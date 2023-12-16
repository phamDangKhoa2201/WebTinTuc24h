namespace DOAN_TINTUC24H.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chuthichhinh : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TinTucs", "cthinh1", c => c.String());
            AddColumn("dbo.TinTucs", "cthinh2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TinTucs", "cthinh2");
            DropColumn("dbo.TinTucs", "cthinh1");
        }
    }
}
