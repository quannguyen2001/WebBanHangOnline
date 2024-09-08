namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSubscribe123 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.tb_Subcribe", newName: "tb_Subscribe");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.tb_Subscribe", newName: "tb_Subcribe");
        }
    }
}
