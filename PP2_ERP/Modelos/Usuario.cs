using System.ComponentModel.DataAnnotations;

namespace PP2_ERP.Modelos
{
    public class Usuario
    {
        [Key]
        public int Cedula { get; set; }
        [Required]
        public string Nombre {  get; set; }
        [Required]
        public string Rol { get; set; }
        [Required]
        public string  Departamento { get; set; }
        [Required]
        public DateTime Fecha_ingreso { get; set; }
        [Required]
        public float Puesto { get; set; }

    }

    
}
