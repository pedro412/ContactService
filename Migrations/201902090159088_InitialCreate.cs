namespace ContactService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InsertionDate = c.DateTime(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false, maxLength: 255),
                        Message = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contacts");
        }
    }
}
