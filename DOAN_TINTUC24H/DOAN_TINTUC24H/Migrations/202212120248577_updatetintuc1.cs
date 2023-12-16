namespace DOAN_TINTUC24H.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetintuc1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TinTucs", "maTG", "dbo.TacGias");
            DropIndex("dbo.TinTucs", new[] { "maTG" });
            AlterColumn("dbo.TinTucs", "doan2", c => c.String(nullable: false));
            AlterColumn("dbo.TinTucs", "maTG", c => c.Int(nullable: false));
            //AlterColumn("dbo.TinTucs", "cthinh1", c => c.String(nullable: false));
            CreateIndex("dbo.TinTucs", "maTG");
            AddForeignKey("dbo.TinTucs", "maTG", "dbo.TacGias", "maTG", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TinTucs", "maTG", "dbo.TacGias");
            DropIndex("dbo.TinTucs", new[] { "maTG" });
            //AlterColumn("dbo.TinTucs", "cthinh1", c => c.String());
            AlterColumn("dbo.TinTucs", "maTG", c => c.Int());
            AlterColumn("dbo.TinTucs", "doan2", c => c.String());
            CreateIndex("dbo.TinTucs", "maTG");
            AddForeignKey("dbo.TinTucs", "maTG", "dbo.TacGias", "maTG");
        }
    }
}
