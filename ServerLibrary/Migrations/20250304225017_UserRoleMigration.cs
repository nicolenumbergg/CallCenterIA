using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerLibrary.Migrations
{
    /// <inheritdoc />
    public partial class UserRoleMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "SystemRoles");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "SystemRoles");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "UserRoles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "SystemRoles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "SystemRoles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
