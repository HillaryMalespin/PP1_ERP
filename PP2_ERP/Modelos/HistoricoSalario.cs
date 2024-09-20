﻿using System.ComponentModel.DataAnnotations;

namespace PP2_ERP.Modelos
{
    public class HistoricoSalario
    {
        [Key]
        public int Cedula_Usuario { get; set; }

        [Required]
        public DateTime Fecha_Inicio { get; set; }

        public DateTime Fecha_Fin { get; set; }

        [Required]
        public float Salario { get; set; }

        [Required]
        public string Departamento { get; set; }

        [Required]
        public string Puesto { get; set; }
    }
}

