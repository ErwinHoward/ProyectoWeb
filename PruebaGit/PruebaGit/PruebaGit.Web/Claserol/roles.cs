using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using PruebaGit.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaGit.Web.Claserol
{
    public class Utility

    {
        readonly static ApplicationDbContext db = new ApplicationDbContext();
        public static void CheckRoles(string rol)
        {
            var role = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            if (!role.RoleExists(rol))
            {
                role.Create(new IdentityRole(rol));
            }
        }

        internal static void CheckSuperUsuario()
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var user = userManager.FindByName("Administrador@administrador.com");
            if (user == null)
            {
                CreaterAdministrador("Administrador@administrador.com", "admin123", null, "Administrador");
            }


        }
        private static void CreaterAdministrador(string email, string password, string phone, string rol)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            //Creamos un objeto
            var user = new ApplicationUser()
            {
                UserName = email,
                Email = email,
                PhoneNumber = phone,
                Rol = rol

            };

            //Creamos un usuario
            userManager.Create(user, password);
            //Agregar un rol
            userManager.AddToRole(user.Id, rol);
        }
        internal static void CheckDoctores()
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var user = userManager.FindByName("carlos@gmail.com");
            if (user == null)
            {
                CreateDoctores("carlos@gmail.com", "holamundo20", null, "Doctores");
            }


        }

        private static void CreateDoctores(string email, string password, string phone, string rol)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            //Creamos un objeto
            var user = new ApplicationUser()
            {
                UserName = email,
                Email = email,
                PhoneNumber = phone,
                Rol = rol

            };

            //Creamos un usuario
            userManager.Create(user, password);
            //Agregar un rol
            userManager.AddToRole(user.Id, rol);
        }

       
      
       
        public void Dispose()
        {
            db.Dispose();
        }
    }
}