using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PruebaGit.Web.Models
{
    public class Postres
    {
        public int Id { get; set; }

        [Display(Name = "Id")]

        public string Nombre { get; set; }

        [Display(Name = "Nombre")]
        public string Ingredientes { get; set; }

        [Display(Name = "Ingredientes")]
        public int Precio { get; set; }

        [Display(Name = "Precio")]
        public int Cantidad { get; set; }

        
    }
}