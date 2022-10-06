using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/
        // public string Index()
        // {
        //     return "This is my default action...";
        // }

        // GET: /HelloWorld/Welcome/
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string? name, string numTimes = "1")
        {
            /*
             *  使用 C# 選擇性參數功能來指出若未針對 numTimes 參數傳遞任何值時，該參數預設為 1。
             *  使用 HtmlEncoder.Default.Encode 來保護應用程式免于惡意輸入，例如透過 JavaScript。
             *  在 $"Hello {name}, NumTimes is: {numTimes}" 中使用 -> 字串插值。
             */
            // return HtmlEncoder.Default.Encode($"Hello {name}, ID is: {ID}");

            if (name is not null)
            {
                ViewBag.Message = HtmlEncoder.Default.Encode($"Hello, {name.Trim()}");
            }
            else
            {
                ViewBag.Message = "請填寫姓名";
            }
            
            int resNumTimes;
            if (int.TryParse(numTimes, out resNumTimes))
            {
                ViewBag.NumTimes = resNumTimes;
            }
            else
            {
                ViewBag.NumTimes = "請使用數字";
            }

            return View();
        }
    }
}
