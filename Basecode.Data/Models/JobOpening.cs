﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basecode.Data.Models
{
    public class JobOpening
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public int EmploymentTypeID { get; set; }
        public int ExperienceLevelID { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
