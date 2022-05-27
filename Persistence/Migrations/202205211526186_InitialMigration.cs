namespace Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Username);
            
            CreateTable(
                "dbo.TaskEmployees",
                c => new
                    {
                        TaskId = c.Int(nullable: false),
                        Username = c.String(nullable: false, maxLength: 128),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TaskId, t.Username })
                .ForeignKey("dbo.Employees", t => t.Username)
                .ForeignKey("dbo.Tasks", t => t.TaskId, cascadeDelete: true)
                .Index(t => t.TaskId)
                .Index(t => t.Username);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        DueDate = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bosses",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Username)
                .ForeignKey("dbo.Users", t => t.Username)
                .Index(t => t.Username);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Department = c.String(),
                        LogInTime = c.DateTime(),
                        Salary = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Username)
                .ForeignKey("dbo.Users", t => t.Username)
                .Index(t => t.Username);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Username", "dbo.Users");
            DropForeignKey("dbo.Bosses", "Username", "dbo.Users");
            DropForeignKey("dbo.TaskEmployees", "TaskId", "dbo.Tasks");
            DropForeignKey("dbo.TaskEmployees", "Username", "dbo.Employees");
            DropIndex("dbo.Employees", new[] { "Username" });
            DropIndex("dbo.Bosses", new[] { "Username" });
            DropIndex("dbo.TaskEmployees", new[] { "Username" });
            DropIndex("dbo.TaskEmployees", new[] { "TaskId" });
            DropTable("dbo.Employees");
            DropTable("dbo.Bosses");
            DropTable("dbo.Tasks");
            DropTable("dbo.TaskEmployees");
            DropTable("dbo.Users");
        }
    }
}
