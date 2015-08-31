using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MFTWebForm.Models
{
    public class Repository
    {
        private DataContext _db = new DataContext();

        public IList<Event> ListEvents()
        {
            return (from e in _db.Events select e).ToList();
        }

        public IList<ObservableData> ListObservableData()
        {
            return (from o in _db.ObservableData select o).ToList();
        }

        public IList<Group> ListGroups()
        {
            return (from g in _db.Groups select g).ToList();
        }

        public IList<Supervisor> ListSupervisors()
        {
            return (from s in _db.Supervisors select s).ToList();
        }

        public void MFTFormSubmit(MFTFormViewModel model)
        {
            MFTFormSubmission blankForm = new MFTFormSubmission();

            blankForm.Date = model.Date;
            blankForm.StartTime = model.StartTime;
            blankForm.ClockHours = model.ClockHours;

            blankForm.Event = model.Events.ToString();
            blankForm.ObservableData = model.ObservableData.ToString();
            blankForm.GroupLocation = model.Groups.ToString();
            blankForm.Supervisor = model.Supervisors.ToString();
            blankForm.SupervisorInitials = model.SupervisorInitials;

            blankForm.Comments = model.Comments;
        }
    }
}