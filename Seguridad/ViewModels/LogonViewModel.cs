using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seguridad.ViewModels
{
    public class LogonViewModel
    {
        public int id { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}