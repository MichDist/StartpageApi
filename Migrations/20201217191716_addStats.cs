using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StartpageApi.Migrations
{
    public partial class addStats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Group_User_user_idid",
                table: "Group");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Group_groupid",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_User_user_idid",
                table: "Links");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Group",
                table: "Group");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Group",
                newName: "Groups");

            migrationBuilder.RenameIndex(
                name: "IX_Group_user_idid",
                table: "Groups",
                newName: "IX_Groups_user_idid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groups",
                table: "Groups",
                column: "id");

            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    linkid = table.Column<int>(type: "int", nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.id);
                    table.ForeignKey(
                        name: "FK_Statistics_Links_linkid",
                        column: x => x.linkid,
                        principalTable: "Links",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_linkid",
                table: "Statistics",
                column: "linkid");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Users_user_idid",
                table: "Groups",
                column: "user_idid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Groups_groupid",
                table: "Links",
                column: "groupid",
                principalTable: "Groups",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Users_user_idid",
                table: "Links",
                column: "user_idid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Users_user_idid",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Groups_groupid",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Users_user_idid",
                table: "Links");

            migrationBuilder.DropTable(
                name: "Statistics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Groups",
                table: "Groups");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Groups",
                newName: "Group");

            migrationBuilder.RenameIndex(
                name: "IX_Groups_user_idid",
                table: "Group",
                newName: "IX_Group_user_idid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Group",
                table: "Group",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Group_User_user_idid",
                table: "Group",
                column: "user_idid",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Group_groupid",
                table: "Links",
                column: "groupid",
                principalTable: "Group",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_User_user_idid",
                table: "Links",
                column: "user_idid",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
