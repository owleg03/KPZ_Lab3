using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstApp.Migrations
{
    public partial class AddSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "Description", "IsMarkedDebatable", "SuccessRate" },
                values: new object[] { 1, "Calculate 25*3:", "Math problem", false, 90.019999999999996 });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "Description", "IsMarkedDebatable", "SuccessRate" },
                values: new object[] { 2, "Which is the biggest ocean on Earth?", "Geography problem", false, 29.309999999999999 });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "Description", "IsMarkedDebatable", "SuccessRate" },
                values: new object[] { 3, "Which animal type is a dolphin?", "Science problem", true, 77.909999999999997 });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Content", "Key", "QuestionId" },
                values: new object[,]
                {
                    { 1, "100", "A", 1 },
                    { 2, "75", "B", 1 },
                    { 3, "125", "C", 1 },
                    { 4, "Indian", "A", 2 },
                    { 5, "Arctic", "B", 2 },
                    { 6, "Atlantic", "C", 2 },
                    { 7, "Pacific", "D", 2 },
                    { 8, "Rodent", "A", 3 },
                    { 9, "Fish", "B", 3 },
                    { 10, "Mammal", "C", 3 },
                    { 11, "Bird", "D", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
