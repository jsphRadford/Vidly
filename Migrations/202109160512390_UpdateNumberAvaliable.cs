namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNumberAvaliable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET NumberAvaliable = NumberInStock");
        }
        
        public override void Down()
        {
        }
    }
}
