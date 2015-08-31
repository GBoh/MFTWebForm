using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MFTWebForm.Models
{
    public class MFTFormViewModel
    {
        private Repository _repo = new Repository();

        //public Event Event { get; set; }
        //public Group Group { get; set; }
        //public ObservableData ObservableData { get; set; }
        //public Supervisor Supervisor { get; set; }

        public DateTime? Date { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? ClockHours { get; set; }
        public IList<Event> Events { get; set; }
        public IList<Group> Groups { get; set; }
        public IList<ObservableData> ObservableData { get; set; }
        public IList<Supervisor> Supervisors { get; set; }
        public string SupervisorInitials { get; set; }
        public string Comments { get; set; }

    
    }
}