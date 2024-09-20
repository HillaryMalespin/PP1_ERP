using System.ComponentModel.DataAnnotations;

namespace PP2_ERP.Modelos
{
    public class Caso
    {
        [Key]
        public int Codigo_Caso { get; set; }

        [Required]
        public string Estado { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Required]
        public string Tipo_Caso { get; set; }

        [Required]
        public DateTime Fecha_Apertura { get; set; }

        public DateTime Fecha_Cierre { get; set; }

        public string Responsable { get; set; }

        [Required]
        public string Prioridad { get; set; }

        public string Cliente_Contacto { get; set; }

        [Required]
        public string Cedula_Cliente { get; set; }
    }
}
