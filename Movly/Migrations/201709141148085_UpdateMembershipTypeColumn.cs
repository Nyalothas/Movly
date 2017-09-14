namespace Movly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypeColumn : DbMigration
    {
        public override void Up()
        {
            Sql("EXEC sp_RENAME 'MembershipTypes.SingUpFee', 'SignUpFee', 'COLUMN'");
        }

        public override void Down()
        {
        }
    }
}
