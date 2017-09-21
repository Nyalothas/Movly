namespace Movly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNumberAvailableToMovies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberAvailable", c => c.Byte(nullable: false));
            Sql("UPDATE Movies SET NumberAvailable = NumberInStoc");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberAvailable");
        }
    }
}
