namespace Sinaptech.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relationc : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.LabTestPrice", "LabTestPriceId", "dbo.LabTest");
            DropIndex("dbo.LabTestPrice", new[] { "LabTestPriceId" });
            DropPrimaryKey("dbo.LabTestPrice");
            CreateTable(
                "dbo.OrderDetail",
                c => new
                    {
                        OrderDetailId = c.Int(nullable: false, identity: true),
                        Price = c.Int(nullable: false),
                        LabTest_LabTestId = c.Int(),
                        Order_OrderId = c.Int(nullable: false),
                        TestPackage_TestPackageId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderDetailId)
                .ForeignKey("dbo.LabTest", t => t.LabTest_LabTestId)
                .ForeignKey("dbo.Order", t => t.Order_OrderId, cascadeDelete: true)
                .ForeignKey("dbo.TestPackage", t => t.TestPackage_TestPackageId)
                .Index(t => t.LabTest_LabTestId)
                .Index(t => t.Order_OrderId)
                .Index(t => t.TestPackage_TestPackageId);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        OrderDateTime = c.DateTime(nullable: false),
                        IsPaid = c.Boolean(nullable: false),
                        TotalPrice = c.Int(nullable: false),
                        Gateway = c.String(maxLength: 100),
                        Status = c.String(nullable: false, maxLength: 100),
                        Customer_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Users", t => t.Customer_Id)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.TestPackage",
                c => new
                    {
                        TestPackageId = c.Int(nullable: false, identity: true),
                        NameSci = c.String(maxLength: 100),
                        NameGen = c.String(nullable: false, maxLength: 100),
                        Description = c.String(),
                        CurrentPrice = c.Int(),
                        CurrentPriceAfterDiscount = c.Int(),
                    })
                .PrimaryKey(t => t.TestPackageId);
            
            CreateTable(
                "dbo.TestPackagePrice",
                c => new
                    {
                        TestPackagePriceId = c.Int(nullable: false, identity: true),
                        Price = c.Int(nullable: false),
                        PriceAfterDiscount = c.Int(),
                        FromDateTime = c.DateTime(nullable: false),
                        TestPackage_TestPackageId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TestPackagePriceId)
                .ForeignKey("dbo.TestPackage", t => t.TestPackage_TestPackageId, cascadeDelete: true)
                .Index(t => t.TestPackage_TestPackageId);
            
            CreateTable(
                "dbo.TestPackageLabTest",
                c => new
                    {
                        TestPackage_TestPackageId = c.Int(nullable: false),
                        LabTest_LabTestId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TestPackage_TestPackageId, t.LabTest_LabTestId })
                .ForeignKey("dbo.TestPackage", t => t.TestPackage_TestPackageId, cascadeDelete: true)
                .ForeignKey("dbo.LabTest", t => t.LabTest_LabTestId, cascadeDelete: true)
                .Index(t => t.TestPackage_TestPackageId)
                .Index(t => t.LabTest_LabTestId);
            
            CreateTable(
                "dbo.LabTestTestCategory",
                c => new
                    {
                        LabTest_LabTestId = c.Int(nullable: false),
                        TestCategory_TestCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.LabTest_LabTestId, t.TestCategory_TestCategoryId })
                .ForeignKey("dbo.LabTest", t => t.LabTest_LabTestId, cascadeDelete: true)
                .ForeignKey("dbo.TestCategory", t => t.TestCategory_TestCategoryId, cascadeDelete: true)
                .Index(t => t.LabTest_LabTestId)
                .Index(t => t.TestCategory_TestCategoryId);
            
            CreateTable(
                "dbo.DiseaseLabTest",
                c => new
                    {
                        Disease_DiseaseId = c.Int(nullable: false),
                        LabTest_LabTestId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Disease_DiseaseId, t.LabTest_LabTestId })
                .ForeignKey("dbo.Disease", t => t.Disease_DiseaseId, cascadeDelete: true)
                .ForeignKey("dbo.LabTest", t => t.LabTest_LabTestId, cascadeDelete: true)
                .Index(t => t.Disease_DiseaseId)
                .Index(t => t.LabTest_LabTestId);
            
            AddColumn("dbo.LabTestPrice", "LabTest_LabTestId", c => c.Int(nullable: false));
            AddColumn("dbo.LabTest", "CurrentPrice", c => c.Int());
            AddColumn("dbo.LabTest", "CurrentPriceAfterDiscount", c => c.Int());
            AddColumn("dbo.Users", "FirstName", c => c.String());
            AlterColumn("dbo.Disease", "NameSci", c => c.String(maxLength: 100));
            AlterColumn("dbo.Disease", "NameGen", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.LabTestPrice", "LabTestPriceId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.LabTestPrice", "PriceAfterDiscount", c => c.Int());
            AlterColumn("dbo.LabTest", "NameSci", c => c.String(maxLength: 100));
            AlterColumn("dbo.LabTest", "NameGen", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.TestCategory", "CategoryName", c => c.String(nullable: false, maxLength: 100));
            AddPrimaryKey("dbo.LabTestPrice", "LabTestPriceId");
            CreateIndex("dbo.LabTestPrice", "LabTest_LabTestId");
            AddForeignKey("dbo.LabTestPrice", "LabTest_LabTestId", "dbo.LabTest", "LabTestId", cascadeDelete: true);
            DropColumn("dbo.LabTest", "LabTestPriceId");
            DropColumn("dbo.Users", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Name", c => c.String());
            AddColumn("dbo.LabTest", "LabTestPriceId", c => c.Int(nullable: false));
            DropForeignKey("dbo.LabTestPrice", "LabTest_LabTestId", "dbo.LabTest");
            DropForeignKey("dbo.DiseaseLabTest", "LabTest_LabTestId", "dbo.LabTest");
            DropForeignKey("dbo.DiseaseLabTest", "Disease_DiseaseId", "dbo.Disease");
            DropForeignKey("dbo.LabTestTestCategory", "TestCategory_TestCategoryId", "dbo.TestCategory");
            DropForeignKey("dbo.LabTestTestCategory", "LabTest_LabTestId", "dbo.LabTest");
            DropForeignKey("dbo.OrderDetail", "TestPackage_TestPackageId", "dbo.TestPackage");
            DropForeignKey("dbo.TestPackagePrice", "TestPackage_TestPackageId", "dbo.TestPackage");
            DropForeignKey("dbo.TestPackageLabTest", "LabTest_LabTestId", "dbo.LabTest");
            DropForeignKey("dbo.TestPackageLabTest", "TestPackage_TestPackageId", "dbo.TestPackage");
            DropForeignKey("dbo.OrderDetail", "Order_OrderId", "dbo.Order");
            DropForeignKey("dbo.Order", "Customer_Id", "dbo.Users");
            DropForeignKey("dbo.OrderDetail", "LabTest_LabTestId", "dbo.LabTest");
            DropIndex("dbo.DiseaseLabTest", new[] { "LabTest_LabTestId" });
            DropIndex("dbo.DiseaseLabTest", new[] { "Disease_DiseaseId" });
            DropIndex("dbo.LabTestTestCategory", new[] { "TestCategory_TestCategoryId" });
            DropIndex("dbo.LabTestTestCategory", new[] { "LabTest_LabTestId" });
            DropIndex("dbo.TestPackageLabTest", new[] { "LabTest_LabTestId" });
            DropIndex("dbo.TestPackageLabTest", new[] { "TestPackage_TestPackageId" });
            DropIndex("dbo.TestPackagePrice", new[] { "TestPackage_TestPackageId" });
            DropIndex("dbo.Order", new[] { "Customer_Id" });
            DropIndex("dbo.OrderDetail", new[] { "TestPackage_TestPackageId" });
            DropIndex("dbo.OrderDetail", new[] { "Order_OrderId" });
            DropIndex("dbo.OrderDetail", new[] { "LabTest_LabTestId" });
            DropIndex("dbo.LabTestPrice", new[] { "LabTest_LabTestId" });
            DropPrimaryKey("dbo.LabTestPrice");
            AlterColumn("dbo.TestCategory", "CategoryName", c => c.String());
            AlterColumn("dbo.LabTest", "NameGen", c => c.String());
            AlterColumn("dbo.LabTest", "NameSci", c => c.String());
            AlterColumn("dbo.LabTestPrice", "PriceAfterDiscount", c => c.Int(nullable: false));
            AlterColumn("dbo.LabTestPrice", "LabTestPriceId", c => c.Int(nullable: false));
            AlterColumn("dbo.Disease", "NameGen", c => c.String());
            AlterColumn("dbo.Disease", "NameSci", c => c.String());
            DropColumn("dbo.Users", "FirstName");
            DropColumn("dbo.LabTest", "CurrentPriceAfterDiscount");
            DropColumn("dbo.LabTest", "CurrentPrice");
            DropColumn("dbo.LabTestPrice", "LabTest_LabTestId");
            DropTable("dbo.DiseaseLabTest");
            DropTable("dbo.LabTestTestCategory");
            DropTable("dbo.TestPackageLabTest");
            DropTable("dbo.TestPackagePrice");
            DropTable("dbo.TestPackage");
            DropTable("dbo.Order");
            DropTable("dbo.OrderDetail");
            AddPrimaryKey("dbo.LabTestPrice", "LabTestPriceId");
            CreateIndex("dbo.LabTestPrice", "LabTestPriceId");
            AddForeignKey("dbo.LabTestPrice", "LabTestPriceId", "dbo.LabTest", "LabTestId");
        }
    }
}
