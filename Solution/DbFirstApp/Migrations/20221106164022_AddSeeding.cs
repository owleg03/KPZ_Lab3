using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbFirstApp.Migrations
{
    public partial class AddSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "id", "content", "description", "is_marked_debatable", "success_rate" },
                values: new object[] { 1, "Calculate 25*3:", "Math problem", false, 90.019999999999996 });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "id", "content", "description", "is_marked_debatable", "success_rate" },
                values: new object[] { 2, "Which is the biggest ocean on Earth?", "Geography problem", false, 29.309999999999999 });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "id", "content", "description", "is_marked_debatable", "success_rate" },
                values: new object[] { 3, "Which animal type is a dolphin?", "Science problem", true, 77.909999999999997 });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "id", "content", "key", "question_id" },
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

            migrationBuilder.CreateIndex(
                name: "IX_Answer_question_id",
                table: "Answer",
                column: "question_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
