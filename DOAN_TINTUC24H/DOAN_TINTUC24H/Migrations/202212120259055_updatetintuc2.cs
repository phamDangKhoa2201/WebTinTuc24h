namespace DOAN_TINTUC24H.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetintuc2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TinTucs", "maTL", "dbo.TheLoais");
            DropIndex("dbo.TinTucs", new[] { "maTL" });
            AlterColumn("dbo.TinTucs", "tieuDe", c => c.String(nullable: false));
            AlterColumn("dbo.TinTucs", "hinh1", c => c.String());
            AlterColumn("dbo.TinTucs", "doan1", c => c.String(nullable: false));
            AlterColumn("dbo.TinTucs", "doan2", c => c.String());
            AlterColumn("dbo.TinTucs", "maTL", c => c.Int(nullable: false));
            //AlterColumn("dbo.TinTucs", "cthinh1", c => c.String());
            CreateIndex("dbo.TinTucs", "maTL");
            AddForeignKey("dbo.TinTucs", "maTL", "dbo.TheLoais", "maTL", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TinTucs", "maTL", "dbo.TheLoais");
            DropIndex("dbo.TinTucs", new[] { "maTL" });
            //AlterColumn("dbo.TinTucs", "cthinh1", c => c.String(nullable: false));
            AlterColumn("dbo.TinTucs", "maTL", c => c.Int());
            AlterColumn("dbo.TinTucs", "doan2", c => c.String(nullable: false));
            AlterColumn("dbo.TinTucs", "doan1", c => c.String());
            AlterColumn("dbo.TinTucs", "hinh1", c => c.String(nullable: false));
            AlterColumn("dbo.TinTucs", "tieuDe", c => c.String());
            CreateIndex("dbo.TinTucs", "maTL");
            AddForeignKey("dbo.TinTucs", "maTL", "dbo.TheLoais", "maTL");
        }
    }
}
