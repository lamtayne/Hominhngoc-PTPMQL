using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo_Mvc.Migrations
{
    /// <inheritdoc />
    public partial class Create_DaiLy_HeThongPhanPhoi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonID",
                table: "Person",
                newName: "PersonId");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Person",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Person",
                type: "TEXT",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "Person",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HeThongPhanPhois",
                columns: table => new
                {
                    MaHTPP = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TenHTPP = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeThongPhanPhois", x => x.MaHTPP);
                });

            migrationBuilder.CreateTable(
                name: "DaiLys",
                columns: table => new
                {
                    MaDaiLy = table.Column<string>(type: "TEXT", nullable: false),
                    TenDaiLy = table.Column<string>(type: "TEXT", nullable: false),
                    DiaChi = table.Column<string>(type: "TEXT", nullable: false),
                    NguoiDaiDien = table.Column<string>(type: "TEXT", nullable: false),
                    DienThoai = table.Column<string>(type: "TEXT", nullable: false),
                    MaHTPP = table.Column<string>(type: "TEXT", nullable: false),
                    HeThongPhanPhoiMaHTPP = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaiLys", x => x.MaDaiLy);
                    table.ForeignKey(
                        name: "FK_DaiLys_HeThongPhanPhois_HeThongPhanPhoiMaHTPP",
                        column: x => x.HeThongPhanPhoiMaHTPP,
                        principalTable: "HeThongPhanPhois",
                        principalColumn: "MaHTPP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DaiLys_HeThongPhanPhoiMaHTPP",
                table: "DaiLys",
                column: "HeThongPhanPhoiMaHTPP");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DaiLys");

            migrationBuilder.DropTable(
                name: "HeThongPhanPhois");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Person");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Person",
                newName: "PersonID");
        }
    }
}
