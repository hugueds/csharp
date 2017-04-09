using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactList.Migrations
{
    public partial class AddBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Contacts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    BookID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AuthorContactId = table.Column<int>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.BookID);
                    table.ForeignKey(
                        name: "FK_Book_Contacts_AuthorContactId",
                        column: x => x.AuthorContactId,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_AuthorContactId",
                table: "Book",
                column: "AuthorContactId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Contacts",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
