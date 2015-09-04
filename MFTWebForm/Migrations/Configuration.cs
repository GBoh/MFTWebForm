namespace MFTWebForm.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MFTWebForm.Models.ApplicationDbContext>
    {
        public Configuration() {
            AutomaticMigrationsEnabled = false;
        }

        //protected override void Seed(MFTWebForm.Models.ApplicationDbContext context) {
        //    context.Events.AddOrUpdate(
        //        e => e.EventType,
        //        new Event { EventType = "IT - Individual Thearapy" },
        //        new Event { EventType = "FT - Family Thearapy" },
        //        new Event { EventType = "GT - Group Thearapy" },
        //        new Event { EventType = "ITS - Individual Thearapy with Supervisor" },
        //        new Event { EventType = "FTS - Famil Thearapy with Supervisor" },
        //        new Event { EventType = "GTS - Group Thearapy with Supervisor" },
        //        new Event { EventType = "ITT - Individual Thearapy - Team Member" },
        //        new Event { EventType = "FTT - Family Thearapy - Team Member" },
        //        new Event { EventType = "GTT - Group Thearapy - Team Member" }
        //    );

        //    context.Groups.AddOrUpdate(
        //        g => g.GroupLocation,
        //        new Group { GroupLocation = "Practice" },
        //        new Group { GroupLocation = "Off Campus Intern Site" }
        //    );

        //    context.ObservableData.AddOrUpdate(
        //        o => o.ObservableDataType,
        //        new ObservableData { ObservableDataType = "Supervisor in Room" },
        //        new ObservableData { ObservableDataType = "Used Recording" }
        //    );

        //    context.Supervisors.AddOrUpdate(
        //        s => s.SupervisorType,
        //        new Supervisor { SupervisorType = "AAMFT Approved" },
        //        new Supervisor { SupervisorType = "Stat LMFT Approved" },
        //        new Supervisor { SupervisorType = "Non-Approved" }
        //    );
        //}
    }
}
