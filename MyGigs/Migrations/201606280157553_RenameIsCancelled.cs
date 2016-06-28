namespace MyGigs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameIsCancelled : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.Gigs", "isCancelled", "IsCancelled");
        }
        
        public override void Down()
        {
            RenameColumn("dbo.Gigs", "IsCancelled", "isCancelled");
        }
    }
}
