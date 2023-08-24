using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddFKPosts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cpmments_users_UserId",
                schema: "Account",
                table: "cpmments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cpmments",
                schema: "Account",
                table: "cpmments");

            migrationBuilder.RenameTable(
                name: "cpmments",
                schema: "Account",
                newName: "comments",
                newSchema: "Account");

            migrationBuilder.RenameIndex(
                name: "IX_cpmments_UserId",
                schema: "Account",
                table: "comments",
                newName: "IX_comments_UserId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                schema: "Account",
                table: "comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                schema: "Account",
                table: "comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_comments",
                schema: "Account",
                table: "comments",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_comments_PostId",
                schema: "Account",
                table: "comments",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_comments_posts_PostId",
                schema: "Account",
                table: "comments",
                column: "PostId",
                principalSchema: "Account",
                principalTable: "posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_comments_users_UserId",
                schema: "Account",
                table: "comments",
                column: "UserId",
                principalSchema: "Account",
                principalTable: "users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_posts_PostId",
                schema: "Account",
                table: "comments");

            migrationBuilder.DropForeignKey(
                name: "FK_comments_users_UserId",
                schema: "Account",
                table: "comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_comments",
                schema: "Account",
                table: "comments");

            migrationBuilder.DropIndex(
                name: "IX_comments_PostId",
                schema: "Account",
                table: "comments");

            migrationBuilder.DropColumn(
                name: "PostId",
                schema: "Account",
                table: "comments");

            migrationBuilder.RenameTable(
                name: "comments",
                schema: "Account",
                newName: "cpmments",
                newSchema: "Account");

            migrationBuilder.RenameIndex(
                name: "IX_comments_UserId",
                schema: "Account",
                table: "cpmments",
                newName: "IX_cpmments_UserId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                schema: "Account",
                table: "cpmments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_cpmments",
                schema: "Account",
                table: "cpmments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_cpmments_users_UserId",
                schema: "Account",
                table: "cpmments",
                column: "UserId",
                principalSchema: "Account",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
