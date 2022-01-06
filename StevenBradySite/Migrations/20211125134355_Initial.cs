using Microsoft.EntityFrameworkCore.Migrations;

namespace StevenBradySite.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Subject = table.Column<string>(nullable: false),
                    Message = table.Column<string>(nullable: false),
                    Date = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageId);
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "Date", "FirstName", "LastName", "Message", "Subject" },
                values: new object[] { 1, "11-25-21", "Bob", "Blank", "I'm drawing a blank", "Not Sure" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "Date", "FirstName", "LastName", "Message", "Subject" },
                values: new object[] { 2, "11-25-21", "Kevin", "Klink", "Hogaaaan!", "Hogan" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");
        }
    }
}
