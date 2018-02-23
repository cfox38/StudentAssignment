namespace ProgramStudent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Max30addtoName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false));
        }
    }
}
