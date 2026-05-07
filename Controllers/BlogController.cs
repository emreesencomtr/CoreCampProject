using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreCampProject.Controllers;

[AllowAnonymous]
public class BlogController : Controller
{
    BlogManager bm = new BlogManager(new EfBlogRepository());

    public IActionResult Index()
    {
        var values = bm.GetBlogListWithCategory();
        return View(values);
    }

    public IActionResult BlogReadAll(int id)
    {
        ViewBag.Id = id;
        var values = bm.GetBlogById(id);
        return View(values);
    }

    public IActionResult BlogListByWriter()
    {
        var values = bm.GetBlogListByWriter(3);
        return View(values);
    }

}
