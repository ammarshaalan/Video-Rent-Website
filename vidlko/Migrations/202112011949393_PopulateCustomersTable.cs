namespace vidlko.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomersTable : DbMigration
    {
        public override void Up()
        {
            Sql(
                "SET IDENTITY_INSERT Customers ON INSERT INTO Customers (Id, Name, IsSubscribedToNewsLetter, MembershipTypeId, Brithdate) VALUES (1, 'Ammarshaalan', 0, 1, 1997-11-23)");
            Sql(
                "SET IDENTITY_INSERT Customers ON INSERT INTO Customers (Id, Name, IsSubscribedToNewsLetter, MembershipTypeId, Brithdate) VALUES (2, 'AhmedFathi', 1, 2, 1991-6-15)");
            Sql(
                "SET IDENTITY_INSERT Customers ON INSERT INTO Customers (Id, Name, IsSubscribedToNewsLetter, MembershipTypeId) VALUES (3, 'ZainKhaled', 1, 3)");
            
           
        }

        public override void Down()
        {
        }
    }
}
