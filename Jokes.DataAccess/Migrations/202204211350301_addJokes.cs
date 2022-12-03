namespace Jokes.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addJokes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jokes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SakaSoru = c.String(),
                        SakaCevap = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Jokes");
        }
    }
}
