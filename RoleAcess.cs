using System;
using System.Collections.Generic;
using System.Text;

namespace Authentication.Core {
    public partial class RolesAcess {
        //public Guid Id { get; set; }
        public string Controller { get; set; }
        public string ControllerAPI { get; set; }
        public string Action { get; set; }
    }
}