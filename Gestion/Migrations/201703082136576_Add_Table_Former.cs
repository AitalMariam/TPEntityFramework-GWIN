namespace Gestion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Table_Former : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Formers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Cne = c.String(),
                        Name = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Formers");
        }
    }
}
