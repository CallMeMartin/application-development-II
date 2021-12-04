using Microsoft.EntityFrameworkCore.Migrations;

namespace NFL.Migrations
{
    public partial class InitialMigaration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HomeClubName = table.Column<string>(type: "TEXT", nullable: false),
                    AwayClubName = table.Column<string>(type: "TEXT", nullable: false),
                    HomeFinalScore = table.Column<int>(type: "INTEGER", nullable: false),
                    AwayFinalScore = table.Column<int>(type: "INTEGER", nullable: false),
                    HomeNumberOfTD = table.Column<int>(type: "INTEGER", nullable: false),
                    AwayNumberOfTD = table.Column<int>(type: "INTEGER", nullable: false),
                    Week = table.Column<int>(type: "INTEGER", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matches");
        }
    }
}
