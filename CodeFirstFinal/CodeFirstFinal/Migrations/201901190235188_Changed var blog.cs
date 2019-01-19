namespace CodeFirstFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changedvarblog : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Errors", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Errors", new[] { "CategoryId" });
            AlterColumn("dbo.Errors", "CategoryId", c => c.Int());
            CreateIndex("dbo.Errors", "CategoryId");
            AddForeignKey("dbo.Errors", "CategoryId", "dbo.Categories", "CategoryId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Errors", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Errors", new[] { "CategoryId" });
            AlterColumn("dbo.Errors", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Errors", "CategoryId");
            AddForeignKey("dbo.Errors", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
        }
    }
}
