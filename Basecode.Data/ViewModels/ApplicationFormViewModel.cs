using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Basecode.Data.Models;

namespace Basecode.Data.ViewModels
{
    /// <summary>
    /// Represents a view model for an ApplicationForm entity, shown on the Razor page.
    /// </summary>
    public class ApplicationFormViewModel
    {
        //default constructor
        public ApplicationFormViewModel()
        {
        }
        /// <summary>
        /// Gets or sets the ID of the Applicant for this application.
        /// </summary>
        public int ApplicantId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the Job Opening being applied for.
        /// </summary>
        public int JobOpeningId { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        public string ApplicantFirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        public string ApplicantLastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string ApplicantEmail { get; set; }

        [Required(ErrorMessage = "Contact Number is required.")]
        public string ApplicantContactNumber { get; set; }

        [Required(ErrorMessage = "Civil Status is required.")]
        public string CivilStatus { get; set; }

        /// <summary>
        /// Gets or sets the id of the CV file uploaded by the applicant.
        /// </summary>
        public int CVId { get; set; }

        [Required(ErrorMessage = "CV file is required.")]
        public byte[] CVFile { get; set; }

        /// <summary>
        /// Gets or sets the ID of the applicant's Character Reference.
        /// </summary>
        public int CharacterReferenceId { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        public string CharacterReferenceFirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        public string CharacterReferenceLastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        public string CharacterReferenceEmail { get; set; }
    }
}