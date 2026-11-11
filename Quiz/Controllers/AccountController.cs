using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Quiz.Models;
using Quiz.ViewModel;
namespace Quiz.Controllers;

public class AccountController : Controller
{
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]

    public IActionResult Login(UserViewModel data)
    {
        string UserId = data.UserId;
        string Password = data.Password;
        return RedirectToAction("Student", "Index", new {UserId = UserId, Password = Password});
    }

    public IActionResult StudentList()
    {
        var list = new List<UserViewModel>
        {
            new UserViewModel { UserId = "A001", Password = "1234" },
            new UserViewModel { UserId = "A002", Password = "1234" },
            new UserViewModel { UserId = "A003", Password = "1234" },
            new UserViewModel { UserId = "A004", Password = "1234" },
            new UserViewModel { UserId = "A005", Password = "1234" },
            new UserViewModel { UserId = "A006", Password = "1234" },
            new UserViewModel { UserId = "A007", Password = "1234" },
            new UserViewModel { UserId = "A008", Password = "1234" }
        };

        return View(list);
    }

    public IActionResult Form()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Form(ScoreViewModel data)
    {
        int score1 = data.Score1;
        int score2 = data.Score2;
        int score3 = data.Score3;
        int score4 = data.Score4;
        int score5 = data.Score5;
        int score6 = data.Score6;
        int score7 = data.Score7;
        int score8 = data.Score8;
        int score9 = data.Score9;
        int score10 = data.Score10;
        int sum = score1 + score2 + score3 + score4 + score5 + score6 + score7 + score8 + score9 + score10;
        return RedirectToAction("Score", "Account", new {sum = sum, score1 = score1, score2 = score2, score3 = score3, score4 = score4, score5 = score5, score6 = score6, score7 = score7, score8 = score8, score9 = score9, score10 = score10});
    }

    public IActionResult Score( int sum , int score1, int score2, int score3, int score4, int score5, int score6, int score7, int score8, int score9, int score10)
    {
        @ViewBag.score1 = score1;
        @ViewBag.score2 = score2;
        @ViewBag.score3 = score3;
        @ViewBag.score4 = score4;
        @ViewBag.score5 = score5;
        @ViewBag.score6 = score6;
        @ViewBag.score7 = score7;
        @ViewBag.score8 = score8;
        @ViewBag.score9 = score9;
        @ViewBag.score10 = score10;
        @ViewBag.sum = score1 + score2 + score3 + score4 + score5 + score6 + score7 + score8 + score9 + score10;
        return View();
    }
}
