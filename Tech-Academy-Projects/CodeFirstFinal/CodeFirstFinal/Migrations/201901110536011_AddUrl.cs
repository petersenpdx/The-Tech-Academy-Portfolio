namespace CodeFirstFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUrl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Errors",
                c => new
                    {
                        ErrorId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ErrorId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Errors", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Errors", new[] { "CategoryId" });
            DropTable("dbo.Errors");
            DropTable("dbo.Categories");
        }
    }
}
