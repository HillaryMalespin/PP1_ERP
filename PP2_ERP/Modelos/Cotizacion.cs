using System.ComponentModel.DataAnnotations;

namespace PP2_ERP.Modelos
{
    public class Cotizacion
    {
        [Key]
        public int Codigo_Cotizacion { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public string Estado { get; set; }

        [Required]
        public string Descripcion { get; set; }

        public string Zona { get; set; }

        public string Sector { get; set; }

        public float Monto_Total { get; set; }

        [Required]
        public DateTime Fecha_Cierre { get; set; }

        public float Probabilidad { get; set; }

        public string Tipo_Cotizacion { get; set; }
    }
}
