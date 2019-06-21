using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThinkAboutApi.Migrations.DomesticDogs
{
    public partial class tableofdomestic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DomesticDogs",
                columns: table => new
                {
                    code = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    status = table.Column<string>(type: "varchar(15)", nullable: false),
                    size = table.Column<string>(type: "varchar(10)", nullable: false),
                    gender = table.Column<bool>(nullable: false),
                    location = table.Column<string>(type: "varchar(100)", nullable: false),
                    breed = table.Column<string>(nullable: false),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomesticDogs", x => x.code);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DomesticDogs");
        }
    }
}
