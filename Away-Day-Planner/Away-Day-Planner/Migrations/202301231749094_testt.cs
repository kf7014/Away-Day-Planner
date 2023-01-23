namespace Away_Day_Planner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testt : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 50),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        facilitatorRequired = c.Boolean(nullable: false),
                        isBooked = c.Boolean(nullable: false),
                        FacilitatorTeamFK = c.Int(),
                        EventFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Events", t => t.EventFK, cascadeDelete: true)
                .ForeignKey("dbo.FacilitatorTeams", t => t.FacilitatorTeamFK)
                .Index(t => t.FacilitatorTeamFK)
                .Index(t => t.EventFK);
            
            CreateTable(
                "dbo.FacilitatorTeams",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 50),
                        Activity_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Activities", t => t.Activity_id)
                .Index(t => t.Activity_id);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        EventState = c.Int(nullable: false),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        noOfAttendees = c.Int(nullable: false),
                        isBooked = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ActivityTemplates",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 50),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Additions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 50),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ActivityFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Activities", t => t.ActivityFK, cascadeDelete: true)
                .Index(t => t.ActivityFK);
            
            CreateTable(
                "dbo.AdditionTemplates",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 50),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.BookedFacilitatorTeamDates",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        dateTime = c.DateTime(nullable: false),
                        FacilitatorTeamFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.FacilitatorTeams", t => t.FacilitatorTeamFK, cascadeDelete: true)
                .Index(t => t.FacilitatorTeamFK);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        hasClientDispute = c.Boolean(nullable: false),
                        noOfHoursAway = c.Int(nullable: false),
                        name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Dates",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        dateTime = c.DateTime(nullable: false),
                        EventFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Events", t => t.EventFK, cascadeDelete: true)
                .Index(t => t.EventFK);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 50),
                        ClientFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Clients", t => t.ClientFK, cascadeDelete: true)
                .Index(t => t.ClientFK);
            
            CreateTable(
                "dbo.Facilitators",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        firstName = c.String(nullable: false, maxLength: 50),
                        lastName = c.String(nullable: false, maxLength: 50),
                        emailAddress = c.String(nullable: false, maxLength: 50),
                        FacilitatorTeamFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.FacilitatorTeams", t => t.FacilitatorTeamFK, cascadeDelete: true)
                .Index(t => t.FacilitatorTeamFK);
            
            CreateTable(
                "dbo.Rewards",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 50),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ActivityFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Activities", t => t.ActivityFK, cascadeDelete: true)
                .Index(t => t.ActivityFK);
            
            CreateTable(
                "dbo.RewardTemplates",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 50),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        userID = c.Int(nullable: false, identity: true),
                        firstName = c.String(maxLength: 50),
                        lastName = c.String(maxLength: 50),
                        username = c.String(maxLength: 20),
                        userEmail = c.String(maxLength: 50),
                        userPassword = c.String(maxLength: 50),
                        userSalt = c.Binary(maxLength: 50),
                    })
                .PrimaryKey(t => t.userID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rewards", "ActivityFK", "dbo.Activities");
            DropForeignKey("dbo.Facilitators", "FacilitatorTeamFK", "dbo.FacilitatorTeams");
            DropForeignKey("dbo.Departments", "ClientFK", "dbo.Clients");
            DropForeignKey("dbo.Dates", "EventFK", "dbo.Events");
            DropForeignKey("dbo.BookedFacilitatorTeamDates", "FacilitatorTeamFK", "dbo.FacilitatorTeams");
            DropForeignKey("dbo.Additions", "ActivityFK", "dbo.Activities");
            DropForeignKey("dbo.Activities", "FacilitatorTeamFK", "dbo.FacilitatorTeams");
            DropForeignKey("dbo.Activities", "EventFK", "dbo.Events");
            DropForeignKey("dbo.FacilitatorTeams", "Activity_id", "dbo.Activities");
            DropIndex("dbo.Rewards", new[] { "ActivityFK" });
            DropIndex("dbo.Facilitators", new[] { "FacilitatorTeamFK" });
            DropIndex("dbo.Departments", new[] { "ClientFK" });
            DropIndex("dbo.Dates", new[] { "EventFK" });
            DropIndex("dbo.BookedFacilitatorTeamDates", new[] { "FacilitatorTeamFK" });
            DropIndex("dbo.Additions", new[] { "ActivityFK" });
            DropIndex("dbo.FacilitatorTeams", new[] { "Activity_id" });
            DropIndex("dbo.Activities", new[] { "EventFK" });
            DropIndex("dbo.Activities", new[] { "FacilitatorTeamFK" });
            DropTable("dbo.Users");
            DropTable("dbo.RewardTemplates");
            DropTable("dbo.Rewards");
            DropTable("dbo.Facilitators");
            DropTable("dbo.Departments");
            DropTable("dbo.Dates");
            DropTable("dbo.Clients");
            DropTable("dbo.BookedFacilitatorTeamDates");
            DropTable("dbo.AdditionTemplates");
            DropTable("dbo.Additions");
            DropTable("dbo.ActivityTemplates");
            DropTable("dbo.Events");
            DropTable("dbo.FacilitatorTeams");
            DropTable("dbo.Activities");
        }
    }
}
