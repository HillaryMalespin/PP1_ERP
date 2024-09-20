using System.ComponentModel.DataAnnotations;

namespace PP2_ERP.Modelos
{
    public class Inventario
    {
        [Key]
        public int Codigo_Articulo { get; set; }

        [Required]
        public int Codigo_Bodega { get; set; }

        [Required]
        public int Cantidad_Disponible { get; set; }
    }
}
