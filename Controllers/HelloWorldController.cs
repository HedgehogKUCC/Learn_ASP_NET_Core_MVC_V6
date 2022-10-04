using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public string Index()
        {
            return "This is my default action...";
        }

        // GET: /HelloWorld/Welcome/
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int numTimes = 1)
        {
            /*
             *  使用 C# 選擇性參數功能來指出若未針對 numTimes 參數傳遞任何值時，該參數預設為 1。
             *  使用 HtmlEncoder.Default.Encode 來保護應用程式免于惡意輸入，例如透過 JavaScript。
             *  在 $"Hello {name}, NumTimes is: {numTimes}" 中使用 -> 字串插值。
             */
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}
