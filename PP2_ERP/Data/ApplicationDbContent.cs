using Microsoft.EntityFrameworkCore;
using PP2_ERP.Modelos;

namespace PP2_ERP.Data
{
    public class ApplicationDbContent: DbContext
    {
        public ApplicationDbContent(DbContextOptions<ApplicationDbContent>option): base(option)
        {
        }
        //Por aqui pasan las entidades modelos
        public DbSet<Usuario> Usuario {  get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Inventario> Inventario { get; set; }
        public DbSet<MovimientoInventario> MovimientoInventario { get; set; }
        public DbSet<Articulo> Articulo { get; set; }
        public DbSet<Bodega> Bodega { get; set; }
        public DbSet<Planilla> Planilla { get; set; }
        public DbSet<HistoricoPuesto> HistoricoPuesto { get; set; }
        public DbSet<HistoricoSalario> HistoricoSalario { get; set; }
        public DbSet<Cotizacion> Cotizacion { get; set; }
        public DbSet<Caso> Caso { get; set; }
        public DbSet<Familia> Familia { get; set; }

    }
}
