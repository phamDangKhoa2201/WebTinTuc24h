namespace DOAN_TINTUC24H.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TacGias",
                c => new
                    {
                        maTG = c.Int(nullable: false, identity: true),
                        tenTG = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.maTG);
            
            CreateTable(
                "dbo.TheLoais",
                c => new
                    {
                        maTL = c.Int(nullable: false, identity: true),
                        tenTL = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.maTL);
            
            CreateTable(
                "dbo.TinTucs",
                c => new
                    {
                        maTinTuc = c.Int(nullable: false, identity: true),
                        tieuDe = c.String(),
                        ngayDang = c.DateTime(nullable: false),
                        hinh1 = c.String(nullable: false),
                        hinh2 = c.String(),
                        doan1 = c.String(),
                        doan2 = c.String(),
                        doan3 = c.String(),
                        maTL = c.Int(),
                        maTG = c.Int(),
                    })
                .PrimaryKey(t => t.maTinTuc)
                .ForeignKey("dbo.TacGias", t => t.maTG)
                .ForeignKey("dbo.TheLoais", t => t.maTL)
                .Index(t => t.maTL)
                .Index(t => t.maTG);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TinTucs", "maTL", "dbo.TheLoais");
            DropForeignKey("dbo.TinTucs", "maTG", "dbo.TacGias");
            DropIndex("dbo.TinTucs", new[] { "maTG" });
            DropIndex("dbo.TinTucs", new[] { "maTL" });
            DropTable("dbo.TinTucs");
            DropTable("dbo.TheLoais");
            DropTable("dbo.TacGias");
        }
    }
}
