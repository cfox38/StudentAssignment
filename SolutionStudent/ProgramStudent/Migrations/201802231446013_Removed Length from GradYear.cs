namespace ProgramStudent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedLengthfromGradYear : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Major", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Students", "College", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "College", c => c.String());
            AlterColumn("dbo.Students", "Major", c => c.String());
            AlterColumn("dbo.Students", "Name", c => c.String());
        }
    }
}
