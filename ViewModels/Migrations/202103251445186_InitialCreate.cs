namespace ViewModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nguois",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ten = c.String(),
                        sdt = c.String(),
                        cmnd = c.String(),
                        ngaysinh = c.DateTime(nullable: false),
                        diachi = c.String(),
                        Phong_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Phongs", t => t.Phong_id)
                .Index(t => t.Phong_id);
            
            CreateTable(
                "dbo.Phongs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        sophong = c.String(),
                        status = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Tiens",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tienphong = c.Single(nullable: false),
                        tiendien = c.Single(nullable: false),
                        tiennuoc = c.Single(nullable: false),
                        Phong_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Phongs", t => t.Phong_id)
                .Index(t => t.Phong_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tiens", "Phong_id", "dbo.Phongs");
            DropForeignKey("dbo.Nguois", "Phong_id", "dbo.Phongs");
            DropIndex("dbo.Tiens", new[] { "Phong_id" });
            DropIndex("dbo.Nguois", new[] { "Phong_id" });
            DropTable("dbo.Tiens");
            DropTable("dbo.Phongs");
            DropTable("dbo.Nguois");
        }
    }
}
