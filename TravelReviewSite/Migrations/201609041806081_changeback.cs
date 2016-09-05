namespace TravelReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeback : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "PubDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Reviews", "PublishDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "PublishDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Reviews", "PubDate");
        }
    }
}
