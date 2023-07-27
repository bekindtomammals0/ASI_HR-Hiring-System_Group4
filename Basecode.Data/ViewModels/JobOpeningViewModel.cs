using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basecode.Data.ViewModels
{
    /// <summary>
    /// Represents a view model for a Job Opening entity, shown on the razor page.
    /// </summary>
    public class JobOpeningViewModel
    {
        /// <summary>
        /// Gets or sets the ID of the Job Opening.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Employment Type ID associated with the Job Opening.
        /// </summary>
        [Required(ErrorMessage = "Employment Type ID is required.")]
        public int EmploymentTypeID { get; set; }

        /// <summary>
        /// Gets or sets the Experience Level ID associated with the Job Opening.
        /// </summary>
        [Required(ErrorMessage = "Experience Level ID is required.")]
        public int ExperienceLevelID { get; set; }

        /// <summary>
        /// Gets or sets the title of the Job Opening.
        /// </summary>
        [Required(ErrorMessage = "Title is required.")]
        [StringLength(50, ErrorMessage = "Title must not exceed 50 characters.")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the description of the Job Opening (optional).
        /// </summary>
        [StringLength(4000, ErrorMessage = "Description must not exceed 4000 characters.")]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the created time of the Job Opening.
        /// </summary>
        [Required(ErrorMessage = "Created Time is required.")]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// Gets or sets the creator of the Job Opening.
        /// </summary>
        [Required(ErrorMessage = "Created By is required.")]
        [StringLength(50, ErrorMessage = "Created By must not exceed 50 characters.")]
        public string CreatedBy { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the updated time of the Job Opening (optional).
        /// </summary>
        public DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// Gets or sets the last updater of the Job Opening (optional).
        /// </summary>
        [StringLength(50, ErrorMessage = "Updated By must not exceed 50 characters.")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// Validates the JobOpeningViewModel and returns the validation results.
        /// </summary>
        /// <returns>A list of validation results.</returns>
        public List<ValidationResult> Validate()
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(this, serviceProvider: null, items: null);

            // Perform data annotation validation
            Validator.TryValidateObject(this, context, results, true);

            // Additional custom validations can be added here
            // For example, validating foreign key constraints

            return results;
        }
    }
}