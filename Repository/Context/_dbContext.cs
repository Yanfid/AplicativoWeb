using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Context
{
    public class _dbContext:DbContext
    {
        #region configuration
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationBuilder configurationBuild = new ConfigurationBuilder();
            configurationBuild = configurationBuild.AddJsonFile("appsettings.json");
            IConfiguration configurationFile = configurationBuild.Build();

            string conneccion = configurationFile.GetConnectionString("DliciaConection");
            optionsBuilder.UseSqlServer(connectionString: conneccion);
        }
        #endregion
        public DbSet<TipoUnidadModel> tipoUnidades { get; set; }
        public DbSet<InsumosModel> insumos { get; set; }
        public DbSet<AdquisicionesModel> adquisiciones { get; set; }
        public DbSet<PreparacionInsumoModel> preparacionInsumos { get; set; }
        public DbSet<PreparacionModel> preparaciones { get; set; }
        public DbSet<CategoriaModel> categorias { get; set; }
        public DbSet<ProductosModel> productos { get; set; }
        public DbSet<Pedido_ProductoModel> pedido_Productos { get; set; }
        public DbSet<ClienteModel> clientes { get; set; }
        public DbSet<Ubicacion_PedidoModel> ubicacion_Pedidos { get; set; }
        public DbSet<CargoModel> cargos { get; set; }
        public DbSet<EstadoModel> estados { get; set; }
        public DbSet<EmpleadoModel> empleados { get; set; }
        public DbSet<PedidosModel> pedidos { get; set; }
        public DbSet<TipoComprobanteModel> tipoComprobantes { get; set; }
        public DbSet<ComprobanteModel> comprobantes { get; set; }
        public DbSet<UsuarioLoginModel> usuarioLogin { get; set; }
  
    }
}
