namespace Gestion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Table_FormerModules : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ModuleFormers",
                c => new
                    {
                        Module_Id = c.Long(nullable: false),
                        Former_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.Module_Id, t.Former_Id })
                .ForeignKey("dbo.Modules", t => t.Module_Id, cascadeDelete: true)
                .ForeignKey("dbo.Formers", t => t.Former_Id, cascadeDelete: true)
                .Index(t => t.Module_Id)
                .Index(t => t.Former_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ModuleFormers", "Former_Id", "dbo.Formers");
            DropForeignKey("dbo.ModuleFormers", "Module_Id", "dbo.Modules");
            DropIndex("dbo.ModuleFormers", new[] { "Former_Id" });
            DropIndex("dbo.ModuleFormers", new[] { "Module_Id" });
            DropTable("dbo.ModuleFormers");
        }
    }
}
