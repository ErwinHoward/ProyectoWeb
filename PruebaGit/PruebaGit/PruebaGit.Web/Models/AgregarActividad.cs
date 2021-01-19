using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PruebaGit.Web.Models
{
    public class AgregarActividad
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="ID Paciente")]
        public int ID_Paciente { get; set; }

        [Required]
        [Display(Name = "ID Empleado")]
        public int ID_Empleado { get; set; }

        [Required]
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }

        [Required]
        [Display(Name = "Hora")]
        public int Hora { get; set; }

        [Required]
        [MaxLength(300)]
        [Display(Name = "ID Empleado")]
        public string Actividad_Realizar { get; set; }

        //TABLA RELACIONADA CON ACTIVIDAD

        [Display(Name = "Actividad")]
        public int ActividadId { get; set; }

        //IDENTIFICAR LA VARIABLE FORANEA
        [ForeignKey("ActividadId")]
        public Actividad Actividad { get; set; }





    }
}