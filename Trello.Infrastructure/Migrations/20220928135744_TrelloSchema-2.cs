using Microsoft.EntityFrameworkCore.Migrations;

namespace Trello.Infrastructure.Migrations
{
    public partial class TrelloSchema2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Column_ColumnName",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_User_UserName",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Column_Board_BoardName",
                table: "Column");

            migrationBuilder.DropForeignKey(
                name: "FK_Label_Cards_CardName",
                table: "Label");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Label",
                table: "Label");

            migrationBuilder.DropIndex(
                name: "IX_Label_CardName",
                table: "Label");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Column",
                table: "Column");

            migrationBuilder.DropIndex(
                name: "IX_Column_BoardName",
                table: "Column");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cards",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_ColumnName",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_UserName",
                table: "Cards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Board",
                table: "Board");

            migrationBuilder.DropColumn(
                name: "CardName",
                table: "Label");

            migrationBuilder.DropColumn(
                name: "BoardName",
                table: "Column");

            migrationBuilder.DropColumn(
                name: "ColumnName",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Cards");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "User",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Label",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<long>(
                name: "LabelId",
                table: "Label",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "CardId",
                table: "Label",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Column",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<long>(
                name: "ColumnId",
                table: "Column",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "BoardId",
                table: "Column",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<long>(
                name: "CardId",
                table: "Cards",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "ColumnId",
                table: "Cards",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "Cards",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Board",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<long>(
                name: "BoardId",
                table: "Board",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Label",
                table: "Label",
                column: "LabelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Column",
                table: "Column",
                column: "ColumnId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cards",
                table: "Cards",
                column: "CardId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Board",
                table: "Board",
                column: "BoardId");

            migrationBuilder.CreateIndex(
                name: "IX_Label_CardId",
                table: "Label",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_Column_BoardId",
                table: "Column",
                column: "BoardId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_ColumnId",
                table: "Cards",
                column: "ColumnId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_UserId",
                table: "Cards",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Column_ColumnId",
                table: "Cards",
                column: "ColumnId",
                principalTable: "Column",
                principalColumn: "ColumnId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_User_UserId",
                table: "Cards",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Column_Board_BoardId",
                table: "Column",
                column: "BoardId",
                principalTable: "Board",
                principalColumn: "BoardId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Label_Cards_CardId",
                table: "Label",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "CardId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Column_ColumnId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_User_UserId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Column_Board_BoardId",
                table: "Column");

            migrationBuilder.DropForeignKey(
                name: "FK_Label_Cards_CardId",
                table: "Label");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Label",
                table: "Label");

            migrationBuilder.DropIndex(
                name: "IX_Label_CardId",
                table: "Label");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Column",
                table: "Column");

            migrationBuilder.DropIndex(
                name: "IX_Column_BoardId",
                table: "Column");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cards",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_ColumnId",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_UserId",
                table: "Cards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Board",
                table: "Board");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LabelId",
                table: "Label");

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "Label");

            migrationBuilder.DropColumn(
                name: "ColumnId",
                table: "Column");

            migrationBuilder.DropColumn(
                name: "BoardId",
                table: "Column");

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "ColumnId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "BoardId",
                table: "Board");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "User",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Label",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardName",
                table: "Label",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Column",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BoardName",
                table: "Column",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cards",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ColumnName",
                table: "Cards",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Cards",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Board",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Label",
                table: "Label",
                column: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Column",
                table: "Column",
                column: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cards",
                table: "Cards",
                column: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Board",
                table: "Board",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Label_CardName",
                table: "Label",
                column: "CardName");

            migrationBuilder.CreateIndex(
                name: "IX_Column_BoardName",
                table: "Column",
                column: "BoardName");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_ColumnName",
                table: "Cards",
                column: "ColumnName");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_UserName",
                table: "Cards",
                column: "UserName");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Column_ColumnName",
                table: "Cards",
                column: "ColumnName",
                principalTable: "Column",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_User_UserName",
                table: "Cards",
                column: "UserName",
                principalTable: "User",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Column_Board_BoardName",
                table: "Column",
                column: "BoardName",
                principalTable: "Board",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Label_Cards_CardName",
                table: "Label",
                column: "CardName",
                principalTable: "Cards",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
