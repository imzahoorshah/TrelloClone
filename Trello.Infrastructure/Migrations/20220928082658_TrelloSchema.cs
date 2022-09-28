using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Trello.Infrastructure.Migrations
{
    public partial class TrelloSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Board",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsClosed = table.Column<bool>(type: "bit", nullable: true),
                    IsPinned = table.Column<bool>(type: "bit", nullable: true),
                    IsStarred = table.Column<bool>(type: "bit", nullable: true),
                    IsSubscribed = table.Column<bool>(type: "bit", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastActivity = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastViewed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Creation = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Board", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsBusinessClass = table.Column<bool>(type: "bit", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Column",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Creation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BoardName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Column", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Column_Board_BoardName",
                        column: x => x.BoardName,
                        principalTable: "Board",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsArchived = table.Column<bool>(type: "bit", nullable: true),
                    IsComplete = table.Column<bool>(type: "bit", nullable: true),
                    IsSubscribed = table.Column<bool>(type: "bit", nullable: true),
                    LastActivity = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ColumnName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Cards_Column_ColumnName",
                        column: x => x.ColumnName,
                        principalTable: "Column",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cards_User_UserName",
                        column: x => x.UserName,
                        principalTable: "User",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Label",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Label", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Label_Cards_CardName",
                        column: x => x.CardName,
                        principalTable: "Cards",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_ColumnName",
                table: "Cards",
                column: "ColumnName");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_UserName",
                table: "Cards",
                column: "UserName");

            migrationBuilder.CreateIndex(
                name: "IX_Column_BoardName",
                table: "Column",
                column: "BoardName");

            migrationBuilder.CreateIndex(
                name: "IX_Label_CardName",
                table: "Label",
                column: "CardName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Label");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Column");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Board");
        }
    }
}
