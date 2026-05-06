using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreCampProject.Controllers;

public class NewsletterController : Controller
{
    NewsLetterManager nm = new NewsLetterManager(new EfNewsLetterRepository());
    [HttpGet]
    public PartialViewResult SubsribeMail()
    {
        return PartialView();
    }
    [HttpPost]
    //[ValidateAntiForgeryToken]
    public PartialViewResult SubscribeMail(NewsLetter p)
    {
        p.MailStatus = true;
        nm.AddNewsLetter(p);
        return PartialView();
    }
}
