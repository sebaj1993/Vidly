namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationToMembershitTypeName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(unicode: false));
        }
    }
}
