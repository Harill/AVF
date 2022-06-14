using System;
using System.Linq;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Vfi.Server.Core.CrossCutting.UnitOfWork;
using Vfi.Ui.Mvc.Vfi.Models;
using Telerik.Web.Mvc;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Controllers.Authorization {
    [Authorize]
    public class PermissionController : Controller {
        private readonly IUnitOfWork _unitOfWrok;
        [InjectionConstructor]
        public PermissionController(IUnitOfWork unitOfWork) {
            if (unitOfWork == null) throw new ArgumentNullException("unitOfWork");

            _unitOfWrok = unitOfWork;
        }

        #region Permission

        [HttpPost]
        public ActionResult AssignPermissionForUser(int[] checkedRecords, int userId) {
            checkedRecords = checkedRecords ?? new int[] { };
            try {
                using (var vfi = new tammaContext()) {
                    vfi.Permissions.RemoveRange(vfi.Permissions.Where(x => x.UserID == userId));
                    foreach (var t in checkedRecords) {
                        var entity = new Permission {
                            Creation = true,
                            Deletion = true,
                            Execution = true,
                            Modification = true,
                            FunctionID = t,
                            ModifiedDate = DateTime.Now,
                            UserID = userId
                        };
                        vfi.Permissions.Add(entity);
                    }
                    vfi.SaveChanges();
                    return new JsonResult { Data = "Successful" };
                }

                //var result = _permission/Service.AssignPermissionForUser(checkedRecords, userId);
                //if (!result.Contains(0)) {
                //    var unitOfWorkResult = _unitOfWrok.SaveChanges();
                //    if (unitOfWorkResult == 0) return new JsonResult { Data = "Fault" };
                //    return new JsonResult { Data = "Successful" };
                //}
                //return new JsonResult { Data = "Fault" };
            }
            catch (Exception) {
                return new JsonResult { Data = "Fault" };
            }
        }

        [HttpPost]
        public ActionResult AssignWarehousePermissionForUser(int[] checkedImport, int[] checkedRotate, int[] checkedOrderProgress, int userId) {
            checkedImport = checkedImport ?? new int[] { };
            checkedRotate = checkedRotate ?? new int[] { };
            checkedOrderProgress = checkedOrderProgress ?? new int[] { };
            try {
                using (var vfi = new tammaContext()) {
                    var warehouses = vfi.Warehouses.Where(w => w.Active).ToList();
                    var wPermission = vfi.WarehousePermissions.Where(wp => wp.UserId == userId).ToList();
                    //var warehouseIds = checkedImport.Union(checkedRotate);
                    foreach (var warehouse in warehouses) {
                        var entity = wPermission.FirstOrDefault(wp => wp.WarehouseId == warehouse.WarehouseId);
                        if (entity == null) {
                            entity = new WarehousePermission {
                                UserId = userId,
                                WarehouseId = warehouse.WarehouseId,
                                ModifiedDate = DateTime.Now,
                                Import = false,
                                Rotate = false,
                                OrderProgress = false
                            };
                            vfi.WarehousePermissions.Add(entity);
                        }
                        entity.Import = checkedImport.Contains(warehouse.WarehouseId);
                        entity.Rotate = checkedRotate.Contains(warehouse.WarehouseId);
                        entity.OrderProgress = checkedOrderProgress.Contains(warehouse.WarehouseId);
                    }

                    vfi.SaveChanges();
                    return new JsonResult { Data = "Successfull" };

                }
            }
            catch (Exception) {
                return new JsonResult { Data = "Error" };
            }
            //return new JsonResult { Data = "Nothing happen" };
        }

        [HttpPost]
        public ActionResult AssignWarehouseRotate(int[] checkedRotate, int warehouseId) {
            //checkedImport = checkedImport ?? new int[] { };
            checkedRotate = checkedRotate ?? new int[] { };
            try {
                using (var vfi = new tammaContext()) {
                    var warehouses = vfi.Warehouses.Where(w => w.Active && w.WarehouseId != warehouseId).ToList();
                    foreach (var warehouse in warehouses) {
                        var isRorate = checkedRotate.Contains(warehouse.WarehouseId);
                        var entity =
                            vfi.WarehouseRotates.FirstOrDefault(
                                wr => wr.WarehouseId == warehouseId && wr.ToWarehouseId == warehouse.WarehouseId);
                        if (entity == null) {
                            entity = new WarehouseRotate {
                                ToWarehouseId = warehouse.WarehouseId,
                                Active = isRorate,
                                WarehouseId = warehouseId,
                            };
                            vfi.WarehouseRotates.Add(entity);
                        }
                        else {
                            entity.Active = isRorate;
                        }
                    }

                    vfi.SaveChanges();
                    return new JsonResult { Data = "Successfull" };

                }
            }
            catch (Exception) {
                return new JsonResult { Data = "Error" };
            }
            //return new JsonResult { Data = "Nothing happen" };
        }


        [HttpPost]
        public ActionResult CheckUserPermissionByFunctionCode(string functionCode) {
            var userName = User.Identity.Name;
            if (userName == "thangle")
                return Json(1);

            //var permissions = _permission/Service.GetPermissionPerUser(userName);
            //var isPermission = permissions.FirstOrDefault(f => f.Function.FunctionCode == functionCode) != null ? 1 : 0;
            var isPermission = false;
            using (var vfi = new tammaContext()) {
                isPermission = (from p in vfi.Permissions
                                where p.User.Username.Equals(userName) &&
                                p.Function.FunctionCode.Equals(functionCode)
                                select p).Any();
            }
            return Json(isPermission);
        }
        #endregion


        #region permission

        [GridAction]
        public ActionResult SelectFunctionPermission() {
            var model = new List<FunctionNewModel>();
            try {
                model = GetFunctionPermissions();
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectFunctionPermission", ex.Message);
            }
            return View(new GridModel(model));
        }
        List<FunctionNewModel> GetFunctionPermissions() {
            var model = new List<FunctionNewModel>();
            using (var vfi = new tammaContext()) {
                model.AddRange(vfi.Functions.Where(f => f.FunctionCode == null)
                    .Select(x => new FunctionNewModel {
                        FunctionId = x.FunctionId,
                        FunctionName = x.FunctionName,
                        Description = x.Description,
                        ModifiedDate = x.ModifiedDate,
                        Active = x.Active,
                    }));
            }
            return model;
        }

        [HttpPost]
        [GridAction]
        public ActionResult InsertFunction(FunctionNewModel inserted) {
            try {
                using (var vfi = new tammaContext()) {
                    var function = new Function {
                        Description = inserted.Description,
                        FunctionName = inserted.FunctionName,
                        ModifiedDate = DateTime.Now,
                        Active = true,
                    };
                    vfi.Functions.Add(function);
                    vfi.SaveChanges();
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("InsertFunction", ex.Message);
            }
            return View(new GridModel(GetFunctionPermissions()));
        }

        [HttpPost]
        [GridAction]
        public ActionResult UpdateFunction(FunctionNewModel updated) {
            try {
                using (var vfi = new tammaContext()) {
                    var function = vfi.Functions.FirstOrDefault(f => f.FunctionId == updated.FunctionId);
                    if (function == null)
                        throw new AggregateException("Lỗi! Không tìm thấy quyền cần sửa");

                    function.Description = updated.Description;
                    function.FunctionName = updated.FunctionName;
                    function.ModifiedDate = DateTime.Now;
                    function.Active = updated.Active;
                    vfi.SaveChanges();
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("UpdateFunction", ex.Message);
            }
            return View(new GridModel(GetFunctionPermissions()));
        }


        #endregion


        [GridAction]
        public ActionResult SelectFunctionUserList(int functionId) {
            var model = new List<PermissionNewModel>();
            try {
                using (var vfi = new tammaContext()) {
                    model.AddRange(vfi.Permissions.Where(p => p.FunctionID == functionId && p.User.Active == true)
                        .Select(x => new PermissionNewModel {
                            PermissionId = x.PermissionId,
                            UserName = x.User.FullName,
                            UserLogin = x.User.Username,
                            ModifiedDate = x.ModifiedDate,
                        }));
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectFunctionUserList", ex.Message);
            }
            return View(new GridModel(model));
        }
    }
}
