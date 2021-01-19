
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using PruebaGit.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaGit.Web.Controllers
{
    [Authorize (Roles ="Administrador")]
    public class RolesDelHospitalController : Controller
    {
        readonly static ApplicationDbContext db = new ApplicationDbContext();
        // GET: RolesDelHospital
        public ActionResult Index()
        {
            var users = db.Users.ToList();
            return View(users);
        }
        //Metodo get ADD
        public ActionResult AddRoles(string id)
        {
            var user = db.Users.Find(id);
            return View(user);
        }
        [HttpPost]
        public ActionResult AddRoles(UserViewModels uvm)
        {
            var userManager=new UserManager <ApplicationUser>(new UserStore<ApplicationUser>(db));
            var userRole = userManager.GetRoles(uvm.UserId);
            if (userRole.Count>0)
            {
                userManager.RemoveFromRoles(uvm.UserId, userRole.ToArray());
                userManager.AddToRole(uvm.UserId, uvm.RolName);
            }
            else
            {
                userManager.AddToRole(uvm.UserId, uvm.RolName);
            }
            return RedirectToAction("Index");
        }
    }
}