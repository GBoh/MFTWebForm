namespace MFTWebForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class moreDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MFTFormSubmissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(),
                        StartTime = c.DateTime(),
                        ClockHours = c.String(),
                        Event = c.String(),
                        Group = c.String(),
                        ObservableData = c.String(),
                        Supervisor = c.String(),
                        SupervisorInitials = c.String(),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ObservableDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Supervisors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "Group_Id", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "Group_Id");
            AddForeignKey("dbo.AspNetUsers", "Group_Id", "dbo.Groups", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "Group_Id", "dbo.Groups");
            DropIndex("dbo.AspNetUsers", new[] { "Group_Id" });
            DropColumn("dbo.AspNetUsers", "Group_Id");
            DropTable("dbo.Supervisors");
            DropTable("dbo.ObservableDatas");
            DropTable("dbo.MFTFormSubmissions");
            DropTable("dbo.Groups");
        }
    }
}
