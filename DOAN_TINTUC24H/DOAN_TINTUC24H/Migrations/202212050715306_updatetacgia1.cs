namespace DOAN_TINTUC24H.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetacgia1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TacGias", "SDT", c => c.String(nullable: false));
            AlterColumn("dbo.TacGias", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TacGias", "Email", c => c.String());
            AlterColumn("dbo.TacGias", "SDT", c => c.String());
        }
    }
}
