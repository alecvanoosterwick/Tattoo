using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tattoo_Shop.Areas.Identity.data;

namespace Tattoo_Shop.ViewModels
{
    public class UserListViewmodel
    {
        public List<CustomUser> Users { get; set; }

    }
}
