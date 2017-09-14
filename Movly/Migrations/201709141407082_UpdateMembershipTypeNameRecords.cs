namespace Movly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypeNameRecords : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes Set Name = 'Pay as You Go' WHERE DurationInMonths = '0'");
            Sql("UPDATE MembershipTypes Set Name = 'Monthly' WHERE DurationInMonths = '1'");
            Sql("UPDATE MembershipTypes Set Name = 'Quarterly' WHERE DurationInMonths = '3'");
            Sql("UPDATE MembershipTypes Set Name = 'Yearly' WHERE DurationInMonths = '12'");
        }

        public override void Down()
        {
        }
    }
}
