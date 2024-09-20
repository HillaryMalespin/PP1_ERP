using System.ComponentModel.DataAnnotations;

namespace PP2_ERP.Modelos
{
    public class MovimientoInventario
    {
        [Key]
        public int IdMovimiento { get; set; }

        [Required]
        public int Codigo_Articulo { get; set; }

        [Required]
        public int Bodega_Origen { get; set; }

        [Required]
        public int Bodega_Destino { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        public DateTime Hora { get; set; }

        [Required]
        public string Usuario { get; set; }
    }
}
