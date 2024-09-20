using System.ComponentModel.DataAnnotations;

namespace PP2_ERP.Modelos
{
    public class Familia
    {
        [Key]
        public int Codigo_Familia { get; set; }

        [Required]
        public string Nombre_Familia { get; set; }

        [Required]
        public bool Activo { get; set; }

        [Required]
        public string Descripcion { get; set; }
    }
}

