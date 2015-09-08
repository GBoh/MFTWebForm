using MFTWebForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MFTWebForm.Models {
    public class MFTFormInputViewModel {
        [Required]
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime? StartTime { get; set; }

        [Required]
        public string ClockHours { get; set; }

        [Required]
        public IList<EventDTO> Events { get; set; }

        [Required]
        public IList<GroupDTO> Groups { get; set; }

        [Required]
        public IList<ObservableDataDTO> ObservableData { get; set; }

        [Required]
        public IList<SupervisorDTO> Supervisors { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string SupervisorInitials { get; set; }

        public string Comments { get; set; }
    }

    public class TermsViewModel {
        public IList<TermDTO> Terms { get; set; }
    }
}