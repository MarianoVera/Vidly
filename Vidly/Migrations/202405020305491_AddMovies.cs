namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Terminator', 1, 12/08/1990, 25/08/1990, 5)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('MadMax', 2, 02/05/1995, 15/01/1990, 1)");
            Sql("INSERT INTO Movies  (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('The Simpsons Movie', 3, 15/11/2000, 17/08/2011, 7)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Love Forever', 4, 06/03/2005, 05/08/1998, 9)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('The Comedy Family', 5, 29/06/1980, 20/01/1981, 10)");
        }
        
        public override void Down()
        {
        }
    }
}
