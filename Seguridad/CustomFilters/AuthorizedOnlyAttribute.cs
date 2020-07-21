using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seguridad.CustomFilters
{
    public class AuthorizedOnlyAttribute : AuthorizeAttribute
    {
        //this class was created to distinguish between anonymous users and unauthorized users
        public AuthorizedOnlyAttribute()
        {
            View = "error";
            Master = String.Empty;
        }
        public String View { get; set; }
        public String Master { get; set; }
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
            CheckIfUserIsAuthenticated(filterContext);
        }
        private void CheckIfUserIsAuthenticated(AuthorizationContext filterContext)
        {
            // If Result is null, we're OK: the user is authenticated and authorized.
            if (filterContext.Result == null)
                return;
            // If here, you're getting an HTTP 401 status code
            if (filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                if (String.IsNullOrEmpty(View))
                    return;
                var result = new ViewResult { ViewName = View, MasterName = Master };
                filterContext.Result = result;
            }
        }
    }
}