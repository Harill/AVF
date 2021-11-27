using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Vfi.Client.Module.Authentication.Interfaces;
using Vfi.Server.Core.CrossCutting.UnitOfWork;
using Vfi.Server.Core.DataModel.Models.System;
using Vfi.Ui.Mvc.Vfi.IoC;
using Microsoft.Practices.Unity;

namespace Vfi.Ui.Mvc.Vfi.Utilities
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class AuthenticationAttribute : ActionFilterAttribute
    {
        private readonly IUserService _userService;
        private readonly IUnitOfWork _unitOfWork;
        public AuthenticationAttribute()
            : this(IoCWorker.Resolve<IUnitOfWork>(), IoCWorker.Resolve<IUserService>())
        { }
        [InjectionConstructor]
        private AuthenticationAttribute(IUnitOfWork unitOfWork, IUserService userService)
        {
            if (unitOfWork == null) throw new ArgumentNullException("unitOfWork");    
            if (userService == null) throw  new ArgumentNullException("userService");
            
            _unitOfWork = unitOfWork;    
            _userService = userService;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Request.IsAjaxRequest())
            {
            }

            GetContext(filterContext);

            base.OnActionExecuting(filterContext);
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (filterContext.HttpContext.Request.IsAjaxRequest()
                && !String.IsNullOrWhiteSpace(filterContext.ActionDescriptor.ControllerDescriptor.ControllerName))
            {
                GetContext(filterContext);
            }

            base.OnActionExecuted(filterContext);
        }

        private void GetContext(ActionExecutingContext context)
        {
            if (string.IsNullOrWhiteSpace(context.ActionDescriptor.ActionName)) return;

            var user = _userService.GetUserByUsername(HttpContext.Current.User.Identity.Name);
            var userModel = new UserModel { User = user };

            //if (String.Compare(context.ActionDescriptor.ActionName, "StockOrderMaterial") == 0)
            //{

            //}
            if (!CheckAuthentication(userModel, context.ActionDescriptor.ActionName, false))
            {
                context.Result = NotAuthorization();
            }
        }
        private void GetContext(ActionExecutedContext context)
        {
            try
            {
                var viewResult = context.Result as ViewResultBase;

                if (!String.IsNullOrWhiteSpace(context.ActionDescriptor.ActionName))
                {
                    var user = _userService.GetUserByUsername(HttpContext.Current.User.Identity.Name);
                    var userModel = new UserModel { User = user };

                    #region Menu

                    if (String.Compare(context.ActionDescriptor.ControllerDescriptor.ControllerName, "Menu") == 0)
                    {
                        if (viewResult != null)
                        {
                            var menuModels = viewResult.ViewData.Model as List<MenuModel>;
                            viewResult.ViewData.Model = GetChildren(userModel, menuModels);
                        }
                    }

                    #endregion

                    #region UserAccount

                    // ActionName UserAccount
                    else if (String.Compare(context.ActionDescriptor.ActionName, "UserAccount", StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        if (!CheckAuthentication(userModel, "UserAccount", false))
                        {
                            context.Result = NotAuthorization();
                        }
                    }

                    // ActionName UserFunction
                    else if (String.Compare(context.ActionDescriptor.ActionName, "UserFunction", StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        if (!CheckAuthentication(userModel, "UserFunction", false))
                        {
                            context.Result = NotAuthorization();
                        }
                    }

                    #endregion

                    

                }
            }
            catch (Exception)
            {
                return;
            }
        }

        #region Permission

        private static List<MenuModel> GetChildren(UserModel user, IEnumerable<MenuModel> menuModels)
        {
            var models = new List<MenuModel>();

// ReSharper disable PossibleMultipleEnumeration
            if (menuModels != null && menuModels.Count() > 0)
// ReSharper restore PossibleMultipleEnumeration
            {
// ReSharper disable PossibleMultipleEnumeration
                foreach (var menuModel in menuModels)
// ReSharper restore PossibleMultipleEnumeration
                {
                    if (menuModel.Menu != null
                        && !String.IsNullOrWhiteSpace(menuModel.Menu.ActionName)
                        && CheckAuthentication(user, menuModel.Menu.ActionName, true))
                    {
                        menuModel.HasPermissionExecute = true;
                    }

                    if (menuModel.Children != null && menuModel.Children.Count > 0)
                    {
                        menuModel.HasPermissionExecute = true;
                        menuModel.Children = GetChildren(user, menuModel.Children);
                    }

                    models.Add(menuModel);
                }
            }

            return models;
        }

        private static bool CheckAuthentication(UserModel user, string viewName, bool isAdmin)
        {
            try
            {
                var permissions = GetUserPermissions(user, viewName, isAdmin);

                if (permissions != null)
                {
                    //foreach (var permission in permissions)
                    //{
                    //    if (permission.Execution.Equals(true)) return true;
                    //}
                    return permissions.Any(permission => permission.Execution.Equals(true));
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private static IEnumerable<PermissionModel> GetUserPermissions(UserModel user, string viewName, bool isAdmin)
        {
            var permissions = new List<PermissionModel>();

            // check admin
            if (user == null)
                return null;

            if (!String.IsNullOrWhiteSpace(user.User.Username.ToString()) &&
                String.Compare(user.User.Username.ToString(), "thangle") == 0)
            {
                var permission = new PermissionModel { Creation = true, Deletion = true, Execution = true, Modification = true, User = user.User };

                permissions.Add(permission);
            }

            //if(user !=null && user.Permissions != null && user.Permissions.Count > 0)
            else if (user.User.Permissions != null)
            {
                //var permission = new PermissionModel { Creation = true, Deletion = true, Execution = true, Modification = true, User = user.User };

                //permissions.Add(permission);
                foreach (var permission in user.User.Permissions)
                {
                    if (!string.Equals(viewName, permission.Function.FunctionCode) ||
                        permission.Function.Active != true) continue;

                    var permissionModel = new PermissionModel
                                              {
                                                  Creation = permission.Creation ?? false,
                                                  Execution = permission.Execution ?? false,
                                                  Deletion = permission.Deletion ?? false,
                                                  Modification = permission.Modification ?? false,
                                                  User = permission.User
                                              };
                    permissions.Add(permissionModel);
                }
                //permissions.AddRange(user.Permissions.Where(permission => String.Compare(viewName, permission.Function.FunctionCode) == 0 && permission.Function.Active == true));

                //if (user.UserWorkGroups != null && user.UserWorkGroups.Count > 0)
                //{
                //    foreach (var group in user.UserWorkGroups)
                //    {
                //        if (group.Permissions != null && group.Permissions.Count > 0)
                //        {
                //            //foreach (var permission in group.Permissions)
                //            //{
                //            //    if (String.Compare(viewName, permission.Function.FunctionCode, StringComparison.CurrentCultureIgnoreCase) == 0 && permission.Function.Active == true)
                //            //    {
                //            //        permissions.Add(permission);
                //            //    }
                //            //}
                //            permissions.AddRange(group.Permissions.Where(permission => String.Compare(viewName, permission.Function.FunctionCode, StringComparison.CurrentCultureIgnoreCase) == 0 && permission.Function.Active == true));
                //        }
                //    }
                //}
            }

            return permissions;
        }

        #endregion

        private static RedirectToRouteResult NotAuthorization()
        {
            var redirectTargetDictionary = new RouteValueDictionary { { "action", "NoAccess" }, { "controller", "Home" }, { "area", String.Empty } };

            return new RedirectToRouteResult(redirectTargetDictionary);
        }
    }
}