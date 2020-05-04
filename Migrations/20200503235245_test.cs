using Microsoft.EntityFrameworkCore.Migrations;

namespace CampTiger.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 1,
                column: "Address",
                value: "9090 York Rd ");

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "Address", "City", "DOB", "FirstName", "LastName", "Password", "State" },
                values: new object[] { 7, "9090 York Rd ", "Towson", "10/20/1979", "Mark", "Zuckerberg", "password0007", "MD" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 1,
                column: "Address",
                value: "8000 York Rd ");
        }
    }
}
