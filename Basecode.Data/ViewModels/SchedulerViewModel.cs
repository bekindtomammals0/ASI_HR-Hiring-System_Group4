using Basecode.Data.Models;

namespace Basecode.Data.ViewModels
{
    public class SchedulerViewModel
    {
        public string ApplicantName { get; set; }
        public string JobTitle { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public ProcessStatus ProcessStatuses { get; set; }
    }
}