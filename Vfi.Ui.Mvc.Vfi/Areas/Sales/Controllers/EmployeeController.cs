using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Telerik.Web.Mvc;
using Vfi.Client.Module.Sales.Interfaces;
using Vfi.Server.Core.CrossCutting.UnitOfWork;
using Vfi.Ui.Mvc.Vfi.Areas.Sales.Models;
using Vfi.Ui.Mvc.Vfi.Models;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Sales.Controllers {
    public class EmployeeController : Controller {
        //private readonly IUnitOfWork _unitOfWork;
        //private readonly IEmployeeService _employeeService;
        [InjectionConstructor]
        public EmployeeController(IUnitOfWork unitOfWork
            //, IEmployeeService employeeService
            ) {
            if (unitOfWork == null) throw new ArgumentNullException("unitOfWork");
            //if (employeeService == null) throw new ArgumentNullException("employeeService");

            //_unitOfWork = unitOfWork;
            //_employeeService = employeeService;
        }

        // View
        public ActionResult EmployeeManagement() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            return View();
        }

        // Data
        public List<EmployeeModel> GetEmployeeByModels() {
            using (var vfi = new tammaContext()) {
                var production2 = MyUtilities.UserRole.CheckRole(HttpContext.User.Identity.Name,
                    MyUtilities.UserRole.Production2Management);
                var sale = MyUtilities.UserRole.CheckRole(HttpContext.User.Identity.Name,
                    MyUtilities.UserRole.SaleManagement);
                var employees = vfi.Employees.ToList();
                if (production2 && sale) { }
                else if (production2) {
                    employees = employees.Where(e => e.Production2 || e.Production2B).ToList();
                }
                else if (sale) {
                    employees = employees.Where(e => e.Active).ToList();
                }
                return employees.Select(employee => new EmployeeModel {
                    Active = employee.Active,
                    Production2 = employee.Production2,
                    Production2B = employee.Production2B,
                    EmployeeCode = employee.EmployeeCode,
                    EmployeeName = employee.EmployeeName,
                    ModifiedDate = employee.ModifiedDate,
                    ModifiedUser = employee.ModifiedUser,
                    EmployeeId = employee.EmployeeId,
                    Repair = employee.Repair ?? false,
                    QcLine = employee.QcLine ?? false,
                    GroupName = employee.GroupName,
                })
                                .OrderByDescending(e => e.Active)
                                .ThenByDescending(e => e.Production2)
                                .ThenByDescending(e => e.Production2B)
                                .ThenBy(e => e.EmployeeCode)
                                .ToList();
            }
        }

        #region Employee

        [GridAction]
        public ActionResult SelectEmployee() {
            return View(new GridModel(GetEmployeeByModels()));
        }

        [HttpPost]
        [GridAction]
        public ActionResult InsertEmployee(EmployeeModel insert) {
            try {
                if (!Request.IsAuthenticated) {
                    throw new AggregateException(@"Bạn đã bị mất quyền đăng nhập. \r\n " +
                                                 @"1 trong các nguyên nhân như mất thời gian chờ. \r\n " +
                                                 @"Xin vui lòng đăng nhập lại hệ thống.");
                }
                using (var vfi = new tammaContext()) {

                    var production2 = MyUtilities.UserRole.CheckRole(HttpContext.User.Identity.Name,
                        MyUtilities.UserRole.Production2Management);
                    var sale = MyUtilities.UserRole.CheckRole(HttpContext.User.Identity.Name,
                        MyUtilities.UserRole.SaleManagement);
                    if (production2 && sale) {
                    }
                    else if (sale) {
                        insert.Production2 = false;
                        insert.Production2B = false;
                        insert.Active = true;
                    }
                    else if (production2) {
                        insert.Production2 = true;
                        insert.Production2B = false;
                        insert.Active = false;
                    }
                    insert.EmployeeCode = insert.EmployeeCode.Trim();
                    insert.EmployeeName = insert.EmployeeName.Trim();
                    var entity =
                          vfi.Employees.FirstOrDefault(
                              e =>
                              e.EmployeeCode.Equals(insert.EmployeeCode) &&
                              e.Active == insert.Active &&
                              e.Production2 == insert.Production2 &&
                              e.Production2B == insert.Production2B);
                    if (entity == null) {
                        entity = new Employee {
                            Active = insert.Active,
                            EmployeeCode = insert.EmployeeCode,
                            EmployeeName = insert.EmployeeName,
                            ModifiedDate = DateTime.Now,
                            ModifiedUser = HttpContext.User.Identity.Name,
                            Production2 = insert.Production2,
                            Production2B = insert.Production2B,
                            Repair = insert.Repair,
                            QcLine = insert.QcLine,
                            GroupName = (insert.GroupName + "").Trim(),
                        };

                        vfi.Employees.Add(entity);
                        vfi.SaveChanges();
                    }
                    else {
                        throw new AggregateException("Mã nhân viên đã tồn tại. Xin vui lòng nhập lại. (existed code). ");
                    }
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("InsertEmployee", ex.Message);
            }
            return View(new GridModel(GetEmployeeByModels()));
        }

        [HttpPost]
        [GridAction]
        public ActionResult UpdateEmployee(EmployeeModel update) {
            try {
                if (!Request.IsAuthenticated) {
                    throw new AggregateException(@"Bạn đã bị mất quyền đăng nhập. \r\n " +
                                                 @"1 trong các nguyên nhân như mất thời gian chờ. \r\n " +
                                                 @"Xin vui lòng đăng nhập lại hệ thống.");
                }
                using (var vfi = new tammaContext()) {
                    update.EmployeeCode = update.EmployeeCode.Trim();
                    update.EmployeeName = update.EmployeeName.Trim();
                    var entity =
                           vfi.Employees.FirstOrDefault(
                               e =>
                               e.EmployeeCode.Equals(update.EmployeeCode) &&
                               e.Active == update.Active &&
                               e.Production2 == update.Production2 &&
                               e.Production2B == update.Production2B &&
                               e.EmployeeId != update.EmployeeId);
                    if (entity == null) {
                        entity = vfi.Employees.FirstOrDefault(e => e.EmployeeId == update.EmployeeId);
                        if (entity != null) {
                            entity.Active = update.Active;
                            entity.EmployeeCode = update.EmployeeCode;
                            entity.EmployeeName = update.EmployeeName;
                            entity.ModifiedDate = DateTime.Now;
                            entity.ModifiedUser = HttpContext.User.Identity.Name;
                            entity.Production2 = update.Production2;
                            entity.Production2B = update.Production2B;
                            entity.Repair = update.Repair;
                            entity.QcLine = update.QcLine;
                            entity.GroupName = (update.GroupName + "").Trim();
                            vfi.SaveChanges();
                        }
                        else {
                            throw new AggregateException("Lỗi ! Không tìm thấy nhân viên ! Liên hệ admin");
                        }
                    }
                    else {
                        throw new AggregateException("Mã nhân viên đã tồn tại. Xin vui lòng nhập lại. (existed code). ");
                    }
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("UpdateEmployee", ex.Message);
            }
            return View(new GridModel(GetEmployeeByModels()));
        }

        public ActionResult SelectComboBoxEmployee() {
            return new JsonResult {
                Data = new SelectList(GetEmployeeByModels().Where(f => f.Active), "EmployeeId", "EmployeeCodeName")
            };
        }

        public ActionResult SelectComboBoxSalesEmployee() {

            using (var vfi = new tammaContext()) {
                // var employees = vfi.Employees.Where(e => e.Active).ToList();
                //model =  employees.Select(employee => new EmployeeModel
                // {
                //     Active = employee.Active,
                //     Production2 = employee.Production2,
                //     EmployeeCode = employee.EmployeeCode,
                //     EmployeeName = employee.EmployeeName,
                //     ModifiedDate = employee.ModifiedDate,
                //     ModifiedUser = employee.ModifiedUser,
                //     EmployeeId = employee.EmployeeId,
                // }).OrderBy(e => e.EmployeeCode).ToList();
                return new JsonResult {
                    Data = new SelectList(vfi.Employees.Where(e => e.Active).ToList(), "EmployeeId", "EmployeeName"),
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };
            }
        }

        public ActionResult SelectComboBoxSalesUser() {

            using (var vfi = new tammaContext()) {
                return new JsonResult {
                    Data = new SelectList(
                        vfi.Users.Where(e => e.Active == true).OrderBy(e => e.Username).ToList(),
                        "UserId",
                        "Username"),
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };
            }
        }

        public ActionResult SelectComboBoxEmployeeProduction2() {
            using (var vfi = new tammaContext()) {
                var model = from m in vfi.Employees
                            where m.Production2 || m.Production2B
                            select new {
                                m.EmployeeId,
                                m.EmployeeName,
                                m.EmployeeCode,
                                EmployeeCodeName = m.EmployeeCode + "-" + m.EmployeeName,
                            };
                return new JsonResult {
                    Data = new SelectList(model.ToList(), "EmployeeId", "EmployeeCodeName")
                };
            }
        }

        public ActionResult SelectComboBoxEmployeeRepair() {
            using (var vfi = new tammaContext()) {
                //var model = vfi.Machines.Where(m => m.Active).ToList();
                var model = from m in vfi.Employees
                            where m.Repair == true
                            select new {
                                m.EmployeeId,
                                m.EmployeeName,
                                m.EmployeeCode,
                                EmployeeCodeName = m.EmployeeCode + "." + m.EmployeeName,
                            };
                return new JsonResult {
                    Data = new SelectList(model.ToList(), "EmployeeId", "EmployeeCodeName")
                };
            }
        }

        public ActionResult SelectComboBoxEmployeeQcLine() {
            using (var vfi = new tammaContext()) {
                //var model = vfi.Machines.Where(m => m.Active).ToList();
                var model = from m in vfi.Employees
                            where m.QcLine == true
                            select new {
                                m.EmployeeId,
                                m.EmployeeName,
                                m.EmployeeCode,
                                EmployeeCodeName = m.EmployeeCode + "-" + m.EmployeeName,
                            };
                return new JsonResult {
                    Data = new SelectList(model.ToList(), "EmployeeId", "EmployeeCodeName")
                };
            }
        }
        #endregion
    }
}
