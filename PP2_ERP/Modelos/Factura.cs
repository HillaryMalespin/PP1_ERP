using System.ComponentModel.DataAnnotations;

namespace PP2_ERP.Modelos
{
    public class Factura
    {
        [Key]
        public int Numero_Factura { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public string Estado { get; set; }

        [Required]
        public string Cedula_Cliente { get; set; }

        [Required]
        public string Nombre_Local { get; set; }

        public string Cedula_Local { get; set; }

        public string Vendedor { get; set; }
    }
}

