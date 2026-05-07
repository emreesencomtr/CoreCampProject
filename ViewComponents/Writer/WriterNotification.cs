using Microsoft.AspNetCore.Mvc;

namespace CoreCampProject.ViewComponents.Writer;

public class WriterNotification:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
