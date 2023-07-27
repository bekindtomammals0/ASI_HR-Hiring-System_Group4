using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basecode.Data.ViewModels
{
    public class DeleteUserViewModel
    {
        [Required]
        public string Id { get; set; }
    }
}
