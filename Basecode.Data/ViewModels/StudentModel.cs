using System.ComponentModel.DataAnnotations;

namespace Basecode.Data.ViewModels
{
    public class StudentModel
    {
        [Required]
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }
    }
}
