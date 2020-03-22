namespace EFStudiiDeCaz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SelfReference : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SelfReferences",
                c => new
                    {
                        SelfReferenceId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ParentSelfReferenceId = c.Int(),
                    })
                .PrimaryKey(t => t.SelfReferenceId)
                .ForeignKey("dbo.SelfReferences", t => t.ParentSelfReferenceId)
                .Index(t => t.ParentSelfReferenceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SelfReferences", "ParentSelfReferenceId", "dbo.SelfReferences");
            DropIndex("dbo.SelfReferences", new[] { "ParentSelfReferenceId" });
            DropTable("dbo.SelfReferences");
        }
    }
}
