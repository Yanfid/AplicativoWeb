using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class _ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    CargoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo_Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.CargoId);
                });

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Celular = table.Column<int>(type: "int", maxLength: 9, nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    EstadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEstado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.EstadoId);
                });

            migrationBuilder.CreateTable(
                name: "TipoComprobante",
                columns: table => new
                {
                    TipoComprobanteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoComprobante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroComprobante = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoComprobante", x => x.TipoComprobanteId);
                });

            migrationBuilder.CreateTable(
                name: "TipoUnidad",
                columns: table => new
                {
                    UnidadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreUnidad = table.Column<string>(type: "nvarchar(65)", maxLength: 65, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoUnidad", x => x.UnidadId);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Celular = table.Column<int>(type: "int", nullable: false),
                    CargoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.EmpleadoId);
                    table.ForeignKey(
                        name: "FK_Empleado_Cargo_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargo",
                        principalColumn: "CargoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ubicacion_Pedido",
                columns: table => new
                {
                    DireccionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoPostal = table.Column<int>(type: "int", nullable: false),
                    Latitud = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitud = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicacion_Pedido", x => x.DireccionId);
                    table.ForeignKey(
                        name: "FK_Ubicacion_Pedido_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Insumos",
                columns: table => new
                {
                    InsumoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UnidadId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insumos", x => x.InsumoId);
                    table.ForeignKey(
                        name: "FK_Insumos_TipoUnidad_UnidadId",
                        column: x => x.UnidadId,
                        principalTable: "TipoUnidad",
                        principalColumn: "UnidadId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "usuarioLogin",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarioLogin", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_usuarioLogin_Empleado_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleado",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Adquisiciones",
                columns: table => new
                {
                    AdquisicionesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsumoId = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    FechaAdquisicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaCaducidad = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adquisiciones", x => x.AdquisicionesId);
                    table.ForeignKey(
                        name: "FK_Adquisiciones_Insumos_InsumoId",
                        column: x => x.InsumoId,
                        principalTable: "Insumos",
                        principalColumn: "InsumoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreparacionInsumo",
                columns: table => new
                {
                    PreparacioninsumoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    InsumoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreparacionInsumo", x => x.PreparacioninsumoId);
                    table.ForeignKey(
                        name: "FK_PreparacionInsumo_Insumos_InsumoId",
                        column: x => x.InsumoId,
                        principalTable: "Insumos",
                        principalColumn: "InsumoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Preparacion",
                columns: table => new
                {
                    PreparacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsumoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preparacion", x => x.PreparacionId);
                    table.ForeignKey(
                        name: "FK_Preparacion_PreparacionInsumo_InsumoId",
                        column: x => x.InsumoId,
                        principalTable: "PreparacionInsumo",
                        principalColumn: "PreparacioninsumoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    PreparacionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProductoId);
                    table.ForeignKey(
                        name: "FK_Productos_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_Preparacion_PreparacionId",
                        column: x => x.PreparacionId,
                        principalTable: "Preparacion",
                        principalColumn: "PreparacionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pedido_Producto",
                columns: table => new
                {
                    Pedido_ProductoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido_Producto", x => x.Pedido_ProductoId);
                    table.ForeignKey(
                        name: "FK_Pedido_Producto_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    PedidoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaPedido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    Pedido_ProductoId = table.Column<int>(type: "int", nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.PedidoId);
                    table.ForeignKey(
                        name: "FK_Pedidos_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_Empleado_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleado",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "EstadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_Pedido_Producto_Pedido_ProductoId",
                        column: x => x.Pedido_ProductoId,
                        principalTable: "Pedido_Producto",
                        principalColumn: "Pedido_ProductoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comprobante",
                columns: table => new
                {
                    ComprobanteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    PedidoId = table.Column<int>(type: "int", nullable: false),
                    TipoComprobanteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comprobante", x => x.ComprobanteId);
                    table.ForeignKey(
                        name: "FK_Comprobante_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "PedidoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comprobante_TipoComprobante_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "TipoComprobante",
                        principalColumn: "TipoComprobanteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adquisiciones_InsumoId",
                table: "Adquisiciones",
                column: "InsumoId");

            migrationBuilder.CreateIndex(
                name: "IX_Comprobante_PedidoId",
                table: "Comprobante",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_CargoId",
                table: "Empleado",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Insumos_UnidadId",
                table: "Insumos",
                column: "UnidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_Producto_ProductoId",
                table: "Pedido_Producto",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ClienteId",
                table: "Pedidos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_EmpleadoId",
                table: "Pedidos",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_EstadoId",
                table: "Pedidos",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_Pedido_ProductoId",
                table: "Pedidos",
                column: "Pedido_ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Preparacion_InsumoId",
                table: "Preparacion",
                column: "InsumoId");

            migrationBuilder.CreateIndex(
                name: "IX_PreparacionInsumo_InsumoId",
                table: "PreparacionInsumo",
                column: "InsumoId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CategoriaId",
                table: "Productos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_PreparacionId",
                table: "Productos",
                column: "PreparacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Ubicacion_Pedido_ClienteId",
                table: "Ubicacion_Pedido",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_usuarioLogin_EmpleadoId",
                table: "usuarioLogin",
                column: "EmpleadoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adquisiciones");

            migrationBuilder.DropTable(
                name: "Comprobante");

            migrationBuilder.DropTable(
                name: "Ubicacion_Pedido");

            migrationBuilder.DropTable(
                name: "usuarioLogin");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "TipoComprobante");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropTable(
                name: "Pedido_Producto");

            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Preparacion");

            migrationBuilder.DropTable(
                name: "PreparacionInsumo");

            migrationBuilder.DropTable(
                name: "Insumos");

            migrationBuilder.DropTable(
                name: "TipoUnidad");
        }
    }
}
