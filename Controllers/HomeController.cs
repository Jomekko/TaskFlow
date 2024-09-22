using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ASP.NET_Project.Models;

namespace ASP.NET_Project.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Signup()
    {
        return View();
    }
    public IActionResult AdminDashboard()
    {
        return View("~/Views/Home/Admin/AdminDashboard.cshtml");
    }
    public IActionResult AdminProject()
    {
        return View("~/Views/Home/Admin/AdminProject.cshtml");
    }

    public IActionResult AdminTask()
    {
        return View("~/Views/Home/Admin/AdminTask.cshtml");
    }

    public IActionResult AdminUser()
    {
        return View("~/Views/Home/Admin/AdminUser.cshtml");
    }
    public IActionResult AdminCompleted()
    {
        return View("~/Views/Home/Admin/AdminCompleted.cshtml");
    }
    public IActionResult UserDashboard()
    {
        return View("~/Views/Home/User/UserDashboard.cshtml");
    }
    public IActionResult UserProject()
    {
        return View("~/Views/Home/User/UserProject.cshtml");
    }
    public IActionResult UserTask()
    {
        return View("~/Views/Home/User/UserTask.cshtml");
    }
    public IActionResult UserNotification()
    {
        return View("~/Views/Home/User/UserNotification.cshtml");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
