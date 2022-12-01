using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tattoo_Shop.ViewModels
{
    public class GrantRolesViewModel
    {
        public SelectList Users { get; set; }
        public SelectList Roles { get; set; }
        public string UserId { get; set; }
        public string RoleId { get; set; }
    }
}
