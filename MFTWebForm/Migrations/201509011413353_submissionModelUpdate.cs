namespace MFTWebForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class submissionModelUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MFTFormSubmissions", "Events", c => c.String());
            AddColumn("dbo.MFTFormSubmissions", "Groups", c => c.String());
            AddColumn("dbo.MFTFormSubmissions", "Supervisors", c => c.String());
            DropColumn("dbo.MFTFormSubmissions", "Event");
            DropColumn("dbo.MFTFormSubmissions", "GroupLocation");
            DropColumn("dbo.MFTFormSubmissions", "Supervisor");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MFTFormSubmissions", "Supervisor", c => c.String());
            AddColumn("dbo.MFTFormSubmissions", "GroupLocation", c => c.String());
            AddColumn("dbo.MFTFormSubmissions", "Event", c => c.String());
            DropColumn("dbo.MFTFormSubmissions", "Supervisors");
            DropColumn("dbo.MFTFormSubmissions", "Groups");
            DropColumn("dbo.MFTFormSubmissions", "Events");
        }
    }
}
