using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessTracker.EFDataAccess.Migrations
{
    public partial class AddCaloriesPropToFinishedExercise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Calories",
                table: "FinishedExercises",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Calories",
                table: "FinishedExercises");
        }
    }
}
