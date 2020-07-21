using Seguridad.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Seguridad.Controllers
{
   
        public class AuthController : Controller
        {
            [HttpGet]
            public ActionResult Logon()
            {
                // Just displays the login view
                return View();
            }
        [HttpPost]
        public ActionResult LogOn(LogonViewModel model, String returnUrl,
        String defaultAction = "Index", String defaultController = "Home")
        {
            var isValidReturnUrl = IsValidReturnUrl(returnUrl);
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "The user name or password provided is incorrect.");
                return View(model);
            }
            // Validate and proceed
            if (Membership.ValidateUser(model.UserName, model.Password))
            {
                FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                if (isValidReturnUrl)
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction(defaultAction, defaultController);
                }
            }
            // If we got this far, something failed; redisplay form.
            return View(model);
        }

        private bool IsValidReturnUrl(string returnUrl)
        {
            return true;
        }

        public ActionResult Logoff(String defaultRoute)
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute(defaultRoute);
        }
        public ActionResult Logoff(String defaultAction = "Index", String defaultController = "Home")
            {
                // Logs out and redirects to the home page
                FormsAuthentication.SignOut();
                return RedirectToAction(defaultAction, defaultController);
            }
        }
    
}