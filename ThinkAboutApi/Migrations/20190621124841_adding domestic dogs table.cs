using Microsoft.EntityFrameworkCore.Migrations;

namespace ThinkAboutApi.Migrations
{
    public partial class addingdomesticdogstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Details",
                table: "Details");

            migrationBuilder.RenameTable(
                name: "Details",
                newName: "HomelessDogs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HomelessDogs",
                table: "HomelessDogs",
                column: "code");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HomelessDogs",
                table: "HomelessDogs");

            migrationBuilder.RenameTable(
                name: "HomelessDogs",
                newName: "Details");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Details",
                table: "Details",
                column: "code");
        }
    }
}
