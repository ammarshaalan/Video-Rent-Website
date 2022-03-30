namespace vidlko.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenre : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.movies", "GenreId", c => c.Int(nullable: false));
            AddColumn("dbo.movies", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.movies", "NumberInStock", c => c.Byte(nullable: false));
            CreateIndex("dbo.movies", "GenreId");
            AddForeignKey("dbo.movies", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.movies", "GenreId", "dbo.Genres");
            DropIndex("dbo.movies", new[] { "GenreId" });
            DropColumn("dbo.movies", "NumberInStock");
            DropColumn("dbo.movies", "ReleaseDate");
            DropColumn("dbo.movies", "DateAdded");
            DropColumn("dbo.movies", "GenreId");
            DropTable("dbo.Genres");
        }
    }
}
