using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessTracker.EFDataAccess.Migrations
{
    public partial class UpdateTypeNamesForLibExercise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Duration",
                table: "LibExercises",
                type: "NUMBER(4)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "NUMBER(11)",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<byte>(
                name: "Calories",
                table: "LibExercises",
                type: "NUMBER(4)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "NUMBER(11)",
                oldMaxLength: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Duration",
                table: "LibExercises",
                type: "NUMBER(11)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "NUMBER(4)");

            migrationBuilder.AlterColumn<long>(
                name: "Calories",
                table: "LibExercises",
                type: "NUMBER(11)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "NUMBER(4)");
        }
    }
}
