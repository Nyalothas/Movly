namespace Movly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MOVIES(Name,ReleaseDate,DateAdded,NumberInStoc,GenreId) VALUES('Hangover','06/02/2009','01/01/2017',5,1)");
            Sql("INSERT INTO MOVIES(Name,ReleaseDate,DateAdded,NumberInStoc,GenreId) VALUES('Die Hard','06/04/1988','01/01/2017',3,2)");
            Sql("INSERT INTO MOVIES(Name,ReleaseDate,DateAdded,NumberInStoc,GenreId) VALUES('The Terminator','10/26/1984','01/01/2017',6,2)");
            Sql("INSERT INTO MOVIES(Name,ReleaseDate,DateAdded,NumberInStoc,GenreId) VALUES('Toy Story','11/19/1995','01/01/2017',9,3)");
            Sql("INSERT INTO MOVIES(Name,ReleaseDate,DateAdded,NumberInStoc,GenreId) VALUES('Titanic','11/18/1997','01/01/2017',8,4)");

        }

        public override void Down()
        {
            Sql("DELETE FROM MOVIES WHERE Name = 'Hangover'");
            Sql("DELETE FROM MOVIES WHERE Name = 'Die Hard'");
            Sql("DELETE FROM MOVIES WHERE Name = 'The Terminator'");
            Sql("DELETE FROM MOVIES WHERE Name = 'Toy Story'");
            Sql("DELETE FROM MOVIES WHERE Name = 'Titanic'");
        }
    }
}
