namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DattaAnnotations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentInfo", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.StudentInfo", "Phone");
        }
    }
}
