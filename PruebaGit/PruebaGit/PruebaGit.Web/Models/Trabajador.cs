using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PruebaGit.Web.Models
{
    public class Trabajador
    {

        //TABLA PRINCIPAL ES ADMINISTRADOR -------TABLA RELACIONADA CON REGISTRAR TRABAJADORES
        public int Id { get; set; }
        [Required]
        [Display(Name ="Trabajador")]

        public string Nombre { get; set; }
        public ICollection<Administrador> Administradors { get; set; }

    }
}