namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Hakkımızda", "Aciklama", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Hakkımızda", "Aciklama", c => c.Int(nullable: false));
        }
    }
}
