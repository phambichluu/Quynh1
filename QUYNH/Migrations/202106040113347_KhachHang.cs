namespace QUYNH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KhachHang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        HoTen = c.String(nullable: false, maxLength: 128),
                        NamSinh = c.String(),
                    })
                .PrimaryKey(t => t.HoTen);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KhachHangs");
        }
    }
}
