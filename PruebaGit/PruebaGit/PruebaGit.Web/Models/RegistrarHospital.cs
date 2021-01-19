using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PruebaGit.Web.Models
{
    public class RegistrarHospital
    {
        public int Id { get; set; }

        
        public int No_Hospital { get; set; }
       

        public string Estado { get; set; }


        public string Ciudad { get; set; }


        public string Colonia { get; set; }


        public string Calle { get; set; }



        
    }
}