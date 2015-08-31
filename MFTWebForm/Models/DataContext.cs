using MFTWebForm.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MFTWebForm.Models
{
    public class DataContext : DbContext
    {
        static DataContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Configuration>());
        }
        public IDbSet<Event> Events { get; set; }
        public IDbSet<Group> Groups { get; set; }
        public IDbSet<MFTFormSubmission> MFTForms { get; set; }
        public IDbSet<ObservableData> ObservableData { get; set; }
        public IDbSet<Supervisor> Supervisors { get; set; }
        public IDbSet<User> Users { get; set; }
    }
}