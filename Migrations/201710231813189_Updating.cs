namespace MVCReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updating : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Review_Category",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ReviewID = c.Int(),
                        CategoryID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.CategoryID)
                .ForeignKey("dbo.Reviews", t => t.ReviewID)
                .Index(t => t.ReviewID)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        PublishDate = c.String(),
                        WouldRate = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Review_Category", "ReviewID", "dbo.Reviews");
            DropForeignKey("dbo.Review_Category", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Review_Category", new[] { "CategoryID" });
            DropIndex("dbo.Review_Category", new[] { "ReviewID" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Review_Category");
            DropTable("dbo.Categories");
        }
    }
}
