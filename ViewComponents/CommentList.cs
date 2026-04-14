using CoreCampProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreCampProject.ViewComponents;

public class CommentList : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var commentValues = new List<UserComment> 
        {
            new UserComment
            {
                 Id = 1,
                 UserName = "Emre",
            },
            new UserComment
            {
                Id= 2,
                UserName="Esen"
            }
        };
        return View(commentValues);
    }
}
