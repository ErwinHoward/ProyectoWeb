using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PruebaGit.Web.Models
{
    public class Doctor
    {
        //TABLA PRINCIPAL ES DOCTOR ----------TABLA SECUNDARIA O RELACIONADA PACIENTE
        public int Id { get; set; }


        [Required]
        [Display(Name = "Doctor")]
        public string Nombre_Doctor { get; set; }


        public ICollection<Paciente>Pacientes { get; set; }
    }
}