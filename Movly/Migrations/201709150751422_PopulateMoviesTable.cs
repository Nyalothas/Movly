namespace Movly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "GenreId");
            Sql("INSERT INTO MOVIES(Name,ReleaseDate,DateAdded,NumberInStoc,Genre_Id) VALUES('Hangover','06/02/2009','01/01/2017',5,5)");
            Sql("INSERT INTO MOVIES(Name,ReleaseDate,DateAdded,NumberInStoc,Genre_Id) VALUES('Die Hard','06/04/1988','01/01/2017',3,6)");
            Sql("INSERT INTO MOVIES(Name,ReleaseDate,DateAdded,NumberInStoc,Genre_Id) VALUES('The Terminator','10/26/1984','01/01/2017',6,6)");
            Sql("INSERT INTO MOVIES(Name,ReleaseDate,DateAdded,NumberInStoc,Genre_Id) VALUES('Toy Story','11/19/1995','01/01/2017',9,7)");
            Sql("INSERT INTO MOVIES(Name,ReleaseDate,DateAdded,NumberInStoc,Genre_Id) VALUES('Titanic','11/18/1997','01/01/2017',8,8)");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
        }
    }
}
