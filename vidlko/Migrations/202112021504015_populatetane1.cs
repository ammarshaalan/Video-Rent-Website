namespace vidlko.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatetane1 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT movies ON INSERT INTO movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) Values(2, 'Die Hard', 2, 13-06-2018, 2009-11-4, 8  )");
            Sql("INSERT INTO movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) Values(3, 'The Terminator', 2, 22-07-2005, 2001-11-4, 6  )");
            Sql("INSERT INTO movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) Values(4, 'Toy Story', 6, 2010-8-14, 6-7-1997, 22  )");
            Sql("SET IDENTITY_INSERT movies OFF");
        }
        
        public override void Down()
        {
        }
    }
}
