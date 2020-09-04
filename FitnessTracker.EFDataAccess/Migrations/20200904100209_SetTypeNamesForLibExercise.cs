using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessTracker.EFDataAccess.Migrations
{
    public partial class SetTypeNamesForLibExercise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Duration",
                table: "LibExercises",
                type: "NUMBER(11)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<long>(
                name: "Calories",
                table: "LibExercises",
                type: "NUMBER(11)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "LibExercises",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "NUMBER(11)",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<int>(
                name: "Calories",
                table: "LibExercises",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "NUMBER(11)",
                oldMaxLength: 4);
        }
    }
}
