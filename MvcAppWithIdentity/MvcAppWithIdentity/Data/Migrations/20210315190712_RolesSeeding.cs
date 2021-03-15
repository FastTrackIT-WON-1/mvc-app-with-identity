using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcAppWithIdentity.Data.Migrations
{
    public partial class RolesSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddRole("admin");
            migrationBuilder.AddRole("back-office");

            migrationBuilder.AddUserWithRoles(
                email: "admin@fasttrackit.ro",
                password: "Admin123!",
                new[] { "admin" });

            migrationBuilder.AddUserWithRoles(
                email: "backoffice@fasttrackit.ro",
                password: "Back123!",
                new[] { "back-office" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
