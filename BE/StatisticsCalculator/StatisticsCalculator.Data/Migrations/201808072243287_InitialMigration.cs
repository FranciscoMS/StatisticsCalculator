namespace StatisticsCalculator.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        DocumentID = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                        Content = c.String(nullable: false),
                        User_UserID = c.Guid(),
                    })
                .PrimaryKey(t => t.DocumentID)
                .ForeignKey("dbo.Users", t => t.User_UserID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Guid(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 15),
                        Password = c.String(nullable: false, maxLength: 8),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Documents", "User_UserID", "dbo.Users");
            DropIndex("dbo.Documents", new[] { "User_UserID" });
            DropTable("dbo.Users");
            DropTable("dbo.Documents");
        }
    }
}
