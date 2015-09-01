namespace MFTWebForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MFTFormSubmissions", "ClockHours", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MFTFormSubmissions", "ClockHours", c => c.DateTime());
        }
    }
}
