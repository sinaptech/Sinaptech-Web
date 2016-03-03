namespace Sinaptech.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ss2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.LabTest", "LabTestPriceId", "dbo.LabTestPrice");
            DropIndex("dbo.LabTest", new[] { "LabTestPriceId" });
            DropPrimaryKey("dbo.LabTestPrice");
            AlterColumn("dbo.LabTestPrice", "LabTestPriceId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.LabTestPrice", "LabTestPriceId");
            CreateIndex("dbo.LabTestPrice", "LabTestPriceId");
            AddForeignKey("dbo.LabTestPrice", "LabTestPriceId", "dbo.LabTest", "LabTestId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LabTestPrice", "LabTestPriceId", "dbo.LabTest");
            DropIndex("dbo.LabTestPrice", new[] { "LabTestPriceId" });
            DropPrimaryKey("dbo.LabTestPrice");
            AlterColumn("dbo.LabTestPrice", "LabTestPriceId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.LabTestPrice", "LabTestPriceId");
            CreateIndex("dbo.LabTest", "LabTestPriceId");
            AddForeignKey("dbo.LabTest", "LabTestPriceId", "dbo.LabTestPrice", "LabTestPriceId", cascadeDelete: true);
        }
    }
}
