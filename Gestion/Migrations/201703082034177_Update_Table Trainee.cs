namespace Gestion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_TableTrainee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trainees", "Group_Id", c => c.Long());
            CreateIndex("dbo.Trainees", "Group_Id");
            AddForeignKey("dbo.Trainees", "Group_Id", "dbo.Groups", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trainees", "Group_Id", "dbo.Groups");
            DropIndex("dbo.Trainees", new[] { "Group_Id" });
            DropColumn("dbo.Trainees", "Group_Id");
        }
    }
}
