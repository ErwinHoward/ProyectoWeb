using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PruebaGit.Web.Models
{
    public class NuevoPostre
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "PostreNuevo")]

        public string Nombre { get; set; }
        public ICollection<Administrador> Administradors { get; set; }

    }
}