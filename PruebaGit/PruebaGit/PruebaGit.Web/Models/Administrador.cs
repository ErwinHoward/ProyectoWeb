using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PruebaGit.Web.Models
{
    public class Administrador
    {
        public int Id { get; set; }

        [Display(Name ="Usuario")]
       
        public string Id_Usuario { get; set; }

        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido Materno")]
        public string APM { get; set; }

        [Display(Name = "Apellido Paterno")]
        public string APP { get; set; }



        //REFERENCIAS A LA TABLA DE TRABAJADOR
        [Display(Name ="Trabajador")]
        public int TrabajadorId { get; set; }


        //IDENTIFICAR LA VARIABLE FORANEA
        [ForeignKey("TrabajadorId")]
        public Trabajador Trabajador { get; set; }

    }
}