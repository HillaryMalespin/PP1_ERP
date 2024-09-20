using System.ComponentModel.DataAnnotations;

namespace PP2_ERP.Modelos
{
    public class Bodega
    {
        [Key]
        public int Codigo { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Ubicacion { get; set; }

        public float Capacidad_Toneladas { get; set; }
    }
}
