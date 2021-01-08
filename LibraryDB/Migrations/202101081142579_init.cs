namespace LibraryDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorID = c.Int(nullable: false, identity: true),
                        ListName = c.String(),
                        FirstName = c.String(),
                        Book_ID = c.Int(),
                    })
                .PrimaryKey(t => t.AuthorID)
                .ForeignKey("dbo.Books", t => t.Book_ID)
                .Index(t => t.Book_ID);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Authors", "Book_ID", "dbo.Books");
            DropIndex("dbo.Authors", new[] { "Book_ID" });
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
