using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basecode.Data.ViewModels
{
    /// <summary>
    /// Represents a view model for a Character Reference entity, shown on the razor page.
    /// </summary>
    public class CharacterReferenceViewModel
    {
        /// <summary>
        /// Gets or sets the ID of the Character Reference.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the email of the Character Reference.
        /// </summary>
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the first name of the Character Reference.
        /// </summary>
        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(50, ErrorMessage = "First Name must not exceed 50 characters.")]
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the last name of the Character Reference.
        /// </summary>
        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(50, ErrorMessage = "Last Name must not exceed 50 characters.")]
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets whether the Character Reference has responded or not.
        /// </summary>
        public bool Responded { get; set; }
    }
}
