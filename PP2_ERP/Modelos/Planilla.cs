using System.ComponentModel.DataAnnotations;

namespace PP2_ERP.Modelos
{
    public class Planilla
    {
        [Key]
        public int Cedula_Usuario { get; set; }

        [Required]
        public int Mes { get; set; }

        [Required]
        public int Horas_Trabajadas { get; set; }

        public int Horas_Extras { get; set; }

        [Required]
        public float Salario_Pagado { get; set; }
    }
}
