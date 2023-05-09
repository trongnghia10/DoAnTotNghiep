namespace DoAn_LapTrinhWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_product : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "size", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "size");
        }
    }
}
