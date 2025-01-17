﻿using System;

namespace Basecode.Data.Models
{
    public class Applicant
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int CivilStatusID { get; set; }
        public int? CVId { get; set; }
        public int? JobOpeningID { get; set; }
        public int? CharacterReferenceID { get; set; }
        public int? ProcessStatusID { get; set; }
        public bool CharacterReferenceResponded { get; set; }
        public string ContactNo { get; set; }
        public DateTime? DateApplied { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public User User { get; set; }
        public CivilStatus CivilStatus { get; set; }
        public CV CV { get; set; }
        public JobOpening JobOpening { get; set; }
        public CharacterReference CharacterReference { get; set; }
        public ProcessStatus ProcessStatus { get; set; }
    }
}
