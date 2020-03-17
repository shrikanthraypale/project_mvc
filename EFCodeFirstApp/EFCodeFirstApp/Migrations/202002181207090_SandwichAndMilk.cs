namespace EFCodeFirstApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SandwichAndMilk : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Products values('Sandwich',40)");
            Sql("insert into Products values('Milk',20)");

        }
        
        public override void Down()
        {
        }
    }
}
