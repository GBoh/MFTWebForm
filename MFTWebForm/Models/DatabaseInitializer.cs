using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MFTWebForm.Models
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            base.Seed(context);
            var Events = new List<Event>
            {
                new Event {EventType="IT - Individual Thearapy" },
                new Event {EventType="FT - Family Thearapy" },
                new Event {EventType="GT - Group Thearapy" },
                new Event {EventType="ITS - Individual Thearapy with Supervisor" },
                new Event {EventType="FTS - Famil Thearapy with Supervisor" },
                new Event {EventType="GTS - Group Thearapy with Supervisor" },
                new Event {EventType="ITT - Individual Thearapy - Team Member" },
                new Event {EventType="FTT - Family Thearapy - Team Member" },
                new Event {EventType="GTT - Group Thearapy - Team Member" }
            };

            var Groups = new List<Group>
            {
                new Group { GroupLocation = "Practice"},
                new Group {GroupLocation = "Off Campus Intern Site" }
            };

            var ObservableData = new List<ObservableData>
            {
                new ObservableData {ObservableDataType="Supervisor in Room" },
                new ObservableData {ObservableDataType="Used Recording" }
            };

            var Supervisors = new List<Supervisor>
            {
                new Supervisor {SupervisorType="AAMFT Approved" },
                new Supervisor {SupervisorType="Stat LMFT Approved" },
                new Supervisor {SupervisorType="Non-Approved" }
            };

            foreach (var e in Events)
            {
                context.Events.Add(e);
            }
            foreach (var g in Groups)
            {
                context.Groups.Add(g);
            }
            foreach (var o in ObservableData)
            {
                context.ObservableData.Add(o);
            }
            foreach (var s in Supervisors)
            {
                context.Supervisors.Add(s);
            }
        }
    }
}