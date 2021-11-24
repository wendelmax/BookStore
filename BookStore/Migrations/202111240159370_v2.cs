namespace BookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "Author_Id", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "Author_Id" });
            CreateTable(
                "dbo.BookAuthor",
                c => new
                    {
                        Author_Id = c.Int(nullable: false),
                        Book_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Author_Id, t.Book_Id })
                .ForeignKey("dbo.Authors", t => t.Author_Id, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_Id, cascadeDelete: true)
                .Index(t => t.Author_Id)
                .Index(t => t.Book_Id);
            
            DropColumn("dbo.Books", "Author_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Author_Id", c => c.Int());
            DropForeignKey("dbo.BookAuthor", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.BookAuthor", "Author_Id", "dbo.Authors");
            DropIndex("dbo.BookAuthor", new[] { "Book_Id" });
            DropIndex("dbo.BookAuthor", new[] { "Author_Id" });
            DropTable("dbo.BookAuthor");
            CreateIndex("dbo.Books", "Author_Id");
            AddForeignKey("dbo.Books", "Author_Id", "dbo.Authors", "Id");
        }
    }
}
