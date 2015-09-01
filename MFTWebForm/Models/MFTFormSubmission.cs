using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFTWebForm.Models
{
    public class MFTFormSubmission
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? StartTime { get; set; }
        public string ClockHours { get; set; }
        public string Events { get; set; }
        public string Groups { get; set; }
        public string ObservableData { get; set; }
        public string Supervisors { get; set; }
        public string SupervisorInitials { get; set; }
        public string Comments { get; set; }
    }
}