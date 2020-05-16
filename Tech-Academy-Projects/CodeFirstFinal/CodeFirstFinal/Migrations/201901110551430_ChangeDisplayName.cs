namespace CodeFirstFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDisplayName : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Users", name: "DisplayName", newName: "display_area");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Users", name: "display_area", newName: "DisplayName");
        }
    }
}
