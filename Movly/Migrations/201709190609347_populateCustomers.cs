namespace Movly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers(Name, IsSubscribedToNewsletter, MembershipTypeId, BirthDate) VALUES('Kem Dragov', 'False', '1', '05/10/1987 00:00:00')");
            Sql("INSERT INTO Customers(Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES('Jim Prash', 'True', '2')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Customers WHERE Name = 'Kem Dragov'");
            Sql("DELETE FROM Customers WHERE Name = 'Jim Prash'");
        }
    }
}
