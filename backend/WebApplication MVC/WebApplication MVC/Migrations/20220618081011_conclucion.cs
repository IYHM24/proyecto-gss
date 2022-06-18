using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication_MVC.Migrations
{
    public partial class conclucion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "id_alquiler",
                table: "Registro",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Registro",
                table: "Registro",
                column: "id_alquiler");

            migrationBuilder.CreateTable(
                name: "Contador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ventas_por_dia = table.Column<int>(type: "int", nullable: false),
                    ventas_por_mes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contador", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contador");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Registro",
                table: "Registro");

            migrationBuilder.AlterColumn<int>(
                name: "id_alquiler",
                table: "Registro",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
