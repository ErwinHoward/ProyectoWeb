using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PruebaGit.Web.Models
{
    public class Registrar_Hospital
    {

        ///TENDRA TODOS LOS VALORES NECESARIOS PARA DAR DE ALTA UN HOSPITAL
        public int Id { get; set; }

        [Required]
        [Display(Name = "NomHospital")]
        public int NomHospital { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name ="Estado")]
        public string Estado { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name ="Ciudad")]
        public string Ciudad { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Colonia")]
        public string Colonia { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Calle")]
        public string Calle  { get; set; }

        [Required]
        [Display(Name = "Codigo Postal")]
        public int Codigo_Postal { get; set; }


        //HACER REFERENCIA A LA OTRA TABLA RELACIONADA

        [Display(Name = "Hospital")]
        public int HospitalId { get; set; }

        //IDENTIFICAR LA VARIABLE FORANEA
        [ForeignKey("HospitalId")]
        public Hospital Hospital { get; set; }



    }
}