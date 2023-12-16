namespace DOAN_TINTUC24H.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetacgia : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TacGias", "SDT", c => c.String());
            AddColumn("dbo.TacGias", "diaChi", c => c.String());
            AddColumn("dbo.TacGias", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TacGias", "Email");
            DropColumn("dbo.TacGias", "diaChi");
            DropColumn("dbo.TacGias", "SDT");
        }
    }
}
