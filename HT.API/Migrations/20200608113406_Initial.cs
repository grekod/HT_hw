using Microsoft.EntityFrameworkCore.Migrations;

namespace HT.API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Memories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    ImgURL = table.Column<string>(nullable: true),
                    PurchasePrice = table.Column<int>(nullable: false),
                    SellingPrice = table.Column<int>(nullable: false),
                    Socket = table.Column<int>(nullable: false),
                    MemorySize = table.Column<int>(nullable: false),
                    Size = table.Column<int>(nullable: false),
                    Latency = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memories", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Memories");
        }
    }
}
