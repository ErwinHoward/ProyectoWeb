using PruebaGit.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PruebaGit.Web.Controllers
{
    public class RolesController : Controller
    {
        readonly ApplicationDbContext db = new ApplicationDbContext();
        // GET: Roles
        public ActionResult Index()
        {
            var users = db.Users.ToList();
            return View(users);
        }
        //metodo get add
        public ActionResult AddRoles(string id)
        {
            var user = db.Users.Find(id);
            return View(user);
        }
      
    
           //FALTA AJUSTAR EL METODO DE POST NO FUNCIONA
    
        //FALTA AJUSTAR EL METODO DE POST NO FUNCIONA
    }
}