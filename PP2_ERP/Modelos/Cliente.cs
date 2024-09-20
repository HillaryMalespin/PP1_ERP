using System.ComponentModel.DataAnnotations;

namespace PP2_ERP.Modelos
{
    public class Cliente
    {
        [Key]
        public int Cedula { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Correo { get; set; }

        [Required]
        public string Sector { get; set; }

        [Required]
        public string Celular { get; set; }

        public string Fax { get; set; }
    }
}
