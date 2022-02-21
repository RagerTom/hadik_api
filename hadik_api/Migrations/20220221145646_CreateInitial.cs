using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hadik_api.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HadikSavedData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SavedScore = table.Column<int>(type: "int", nullable: false),
                    SavedSnakeLenght = table.Column<int>(type: "int", nullable: false),
                    SavedSnakePosX = table.Column<int>(type: "int", nullable: false),
                    SavedSnakePosY = table.Column<int>(type: "int", nullable: false),
                    SavedVelocityX = table.Column<int>(type: "int", nullable: false),
                    SavedVelocityY = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HadikSavedData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HadikSavedParts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    X = table.Column<int>(type: "int", nullable: false),
                    Y = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HadikSavedParts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HadikSavedData");

            migrationBuilder.DropTable(
                name: "HadikSavedParts");
        }
    }
}
