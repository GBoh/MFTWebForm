using MFTWebForm.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MFTWebForm.Models.Presentation {
    public class MFTFormViewModel {
        [Required]
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime? StartTime { get; set; }

        [Required]
        public string ClockHours { get; set; }

        [Required]
        public IList<Event> Events { get; set; }

        [Required]
        public IList<Group> Groups { get; set; }

        [Required]
        public IList<ObservableData> ObservableData { get; set; }

        [Required]
        public IList<Supervisor> Supervisors { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string SupervisorInitials { get; set; }

        public string Comments { get; set; }
    }
}