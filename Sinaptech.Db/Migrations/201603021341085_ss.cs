namespace Sinaptech.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ss : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.LabTest", "LabTestPrice_LabTestPriceId", "dbo.LabTestPrice");
            DropIndex("dbo.LabTest", new[] { "LabTestPrice_LabTestPriceId" });
            RenameColumn(table: "dbo.LabTest", name: "LabTestPrice_LabTestPriceId", newName: "LabTestPriceId");
            AlterColumn("dbo.LabTest", "LabTestPriceId", c => c.Int(nullable: false));
            CreateIndex("dbo.LabTest", "LabTestPriceId");
            AddForeignKey("dbo.LabTest", "LabTestPriceId", "dbo.LabTestPrice", "LabTestPriceId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LabTest", "LabTestPriceId", "dbo.LabTestPrice");
            DropIndex("dbo.LabTest", new[] { "LabTestPriceId" });
            AlterColumn("dbo.LabTest", "LabTestPriceId", c => c.Int());
            RenameColumn(table: "dbo.LabTest", name: "LabTestPriceId", newName: "LabTestPrice_LabTestPriceId");
            CreateIndex("dbo.LabTest", "LabTestPrice_LabTestPriceId");
            AddForeignKey("dbo.LabTest", "LabTestPrice_LabTestPriceId", "dbo.LabTestPrice", "LabTestPriceId");
        }
    }
}
