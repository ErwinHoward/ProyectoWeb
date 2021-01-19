using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PruebaGit.Web.Models
{
    public class Paciente
    {
        public int Id { get; set; }

        [Display(Name = "No Paciente")]
        public int No_Paciente { get; set; }

        [Display(Name = "Nombre")]
        public string Nombre_Paciente { get; set; }

        [Display(Name = "Apellido Materno")]
        public string AM_Paciente { get; set; }

        [Display(Name = "Apellido Paterno")]
        public string AP_Paciente { get; set; }

       [Display(Name = "Fecha de Nacimiento")]
       public DateTime Fecha_Nacimiento_Paciente { get; set; }

        [Display(Name = "Genero")]
        public string Genero_Paciente { get; set; }


        [Display(Name = "Numero de telefono")]
        public int Numero_Paciente { get; set; }

        [Display(Name = "Enfermedad")]
        public string Enfermedad_Paciente { get; set; }



        //REFERENCIAS A LA TABLA DE DOCTOR

        [Display(Name = "Doctor")]
        public int DoctorId { get; set; }

        //IDENTIFICAR LA VARIABLE FORANEA
        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }





    }
}