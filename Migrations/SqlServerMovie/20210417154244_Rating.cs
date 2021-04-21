using Microsoft.EntityFrameworkCore.Migrations;

namespace PD1_PZ_109602_202103.Migrations.SqlServerMovie
{
    public partial class Rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>("Rating", "Movie", nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("Rating", "Movie");
        }
    }
}
