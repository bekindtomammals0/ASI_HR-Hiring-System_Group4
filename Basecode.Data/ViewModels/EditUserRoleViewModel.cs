using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basecode.Data.ViewModels
{
    public class EditUserRoleViewModel
    {
        [Required]
        public string User { get; set; }
        [Required]
        public string Role { get; set; }
        public IEnumerable<string>? UserList { get; set; }
        public IEnumerable<string>? RoleList { get; set; }
    }
}
