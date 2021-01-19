using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PruebaGit.Web.Models
{
    public class Hospital
    {

        ///SOLO TENDRA UN ID PARA IDENTIFICARLO
        public int Id { get; set; }

        [Required]
        [Display(Name = "Hospital")]
        public int Numero_Hospital { get; set; }


        public ICollection<Registrar_Hospital> Registrar_Hospitals { get; set; }
    }
}