using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Quiz.Models;
using Quiz.ViewModel;
namespace Quiz.Controllers;

public class StudentController : Controller
{
    public IActionResult Index(string UserId, string Password)
    {
        @ViewBag.UserId = UserId;
        @ViewBag.Password = Password;
        return View();
    }

}
