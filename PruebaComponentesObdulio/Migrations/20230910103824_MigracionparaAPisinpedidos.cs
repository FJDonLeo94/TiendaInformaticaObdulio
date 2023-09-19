using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PruebaComponentesObdulio.Migrations
{
    /// <inheritdoc />
    public partial class MigracionparaAPisinpedidos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PedidoComponentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroPedido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoComponentes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PedidoOrdenadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroPedido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoOrdenadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Componentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Coste = table.Column<double>(type: "float", nullable: false),
                    NumeroSerie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calor = table.Column<int>(type: "int", nullable: false),
                    Cores = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Megas = table.Column<long>(type: "bigint", nullable: false),
                    TipoComponente = table.Column<int>(type: "int", nullable: false),
                    PedidoComponentesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Componentes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Componentes_PedidoComponentes_PedidoComponentesId",
                        column: x => x.PedidoComponentesId,
                        principalTable: "PedidoComponentes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ordenadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipoOrdenador = table.Column<int>(type: "int", nullable: false),
                    PrecioTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PedidoOrdenadoresId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordenadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ordenadores_PedidoOrdenadores_PedidoOrdenadoresId",
                        column: x => x.PedidoOrdenadoresId,
                        principalTable: "PedidoOrdenadores",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Componentes",
                columns: new[] { "Id", "Calor", "Cores", "Coste", "Descripcion", "Megas", "NumeroSerie", "PedidoComponentesId", "TipoComponente" },
                values: new object[,]
                {
                    { 1, 10, 9, 134.0, "Procesador Intel i7", 0L, "789_XCS", null, 0 },
                    { 2, 12, 10, 138.0, "Procesador Intel i7", 0L, "789_XCD", null, 0 },
                    { 3, 22, 11, 138.0, "Procesador Intel i7", 0L, "789_XCT", null, 0 },
                    { 4, 10, 0, 100.0, "Banco de memoria SDRAM", 512L, "879FH", null, 1 },
                    { 5, 15, 0, 125.0, "Banco de memoria SDRAM", 1024L, "879FH_L", null, 1 },
                    { 6, 24, 0, 150.0, "Banco de memoria SDRAM", 2028L, "879FH_T", null, 1 },
                    { 7, 10, 0, 50.0, "Disco Duro Scan Disk", 500000L, "789_XX", null, 2 },
                    { 8, 29, 0, 90.0, "Disco Duro Scan Disk", 1000000L, "789_XX_2", null, 2 },
                    { 9, 39, 0, 128.0, "Disco Duro Scan Disk", 2000000L, "789_XX_3", null, 2 },
                    { 10, 30, 10, 78.0, "Procesador Ryzen AMD", 0L, "797-X", null, 0 },
                    { 11, 30, 29, 178.0, "Procesador Ryzen AMD", 0L, "797-X-2", null, 0 },
                    { 12, 60, 34, 278.0, "Procesador Ryzen AMD", 0L, "797-X-3", null, 0 },
                    { 13, 35, 0, 37.0, "Disco Mecanico Patatin", 250L, "788-fg", null, 2 },
                    { 14, 35, 0, 67.0, "Disco Mecanico Patatin", 250L, "788-fg-2", null, 2 },
                    { 15, 35, 0, 97.0, "Disco Mecanico Patatin", 250L, "788-fg-3", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Ordenadores",
                columns: new[] { "Id", "Descripcion", "PedidoOrdenadoresId", "PrecioTotal", "tipoOrdenador" },
                values: new object[,]
                {
                    { 1, "Almacen de componentes", null, 0m, 0 },
                    { 2, "Ordenador de Maria", null, 284m, 1 },
                    { 3, "Ordenador de Andres", null, 556m, 2 },
                    { 4, "Ordenador de Tiburcio", null, 455m, 3 },
                    { 5, "Ordenador de AndresCF", null, 593m, 4 },
                    { 6, "Ordenador personalizado", null, 0m, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Componentes_PedidoComponentesId",
                table: "Componentes",
                column: "PedidoComponentesId");

            migrationBuilder.CreateIndex(
                name: "IX_Ordenadores_PedidoOrdenadoresId",
                table: "Ordenadores",
                column: "PedidoOrdenadoresId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Componentes");

            migrationBuilder.DropTable(
                name: "Ordenadores");

            migrationBuilder.DropTable(
                name: "PedidoComponentes");

            migrationBuilder.DropTable(
                name: "PedidoOrdenadores");
        }
    }
}
