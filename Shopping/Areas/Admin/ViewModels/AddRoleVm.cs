using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Areas.Admin.ViewModels
{
    public class AddRoleVm
    {
        public BadamUser User { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}
