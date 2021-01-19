using System.Web.Mvc;
using System.Net.Mail;
using PruebaGit.Web.Models;
using System.Net;
using System;
using System.Web;

namespace PruebaGit.Web.Controllers
{
    public class SendMailerController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SendMailer
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public void Index( string To, string Subject, string Body, HttpPostedFileBase fichero)
        {
       
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Port = 587;

                //If you need to authenticate
                client.Credentials = new NetworkCredential("paularamos801@gmail.com", "Andreaverdin1");
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("paularamos801@gmail.com", "DulceChocolate");
                mailMessage.To.Add(new MailAddress("paularamos801@gmail.com"));
                mailMessage.Subject = "Hola";
                mailMessage.Body = Body;
            mailMessage.IsBodyHtml = true;

            string ruta = Server.MapPath("~/Upload/");
            fichero.SaveAs(ruta + "\\" + fichero.FileName);

            Attachment adjunto = new Attachment(ruta + "\\" + fichero.FileName);
            mailMessage.Attachments.Add(adjunto);

                client.Send(mailMessage);
                ViewBag.Message = ("Mensaje enviado exitosamente");

          
        }
    }
}