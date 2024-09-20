using System.ComponentModel.DataAnnotations;

namespace PP2_ERP.Modelos
{
    public class Articulo
    {
        [Key]
        public int Codigo_Articulo { get; set; }

        [Required]
        public string Nombre_Articulo { get; set; }

        [Required]
        public float Precio_Estandar { get; set; }

        public bool Activo { get; set; }

        public float Costo { get; set; }

        public float Peso { get; set; }
    }
}
