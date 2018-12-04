namespace PortfolioRebuild.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Project",
                c => new
                    {
                        ProjectID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Timeline = c.String(),
                        Summary = c.String(),
                        Languages = c.String(),
                        Screenshot = c.String(),
                        GitHub = c.String(),
                    })
                .PrimaryKey(t => t.ProjectID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Project");
        }
    }
}
