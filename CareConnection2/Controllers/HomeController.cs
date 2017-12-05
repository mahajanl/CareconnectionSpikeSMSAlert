using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace CareConnection2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

    static void Main(string[] args)
    {
        SendSms().Wait();
        Console.Write("Press any key to continue.");
        Console.ReadKey();
    }

    static async Task SendSms()
    {
        // Your Account SID from twilio.com/console
        var accountSid = "ACc969090aee1bd200765f9e896c69c78e";
        // Your Auth Token from twilio.com/console
        var authToken = "auth_token";

        TwilioClient.Init(accountSid, authToken);

        var message = await MessageResource.CreateAsync(
            to: new PhoneNumber("+15558675309"),
            from: new PhoneNumber("+15017250604"),
            body: "Hello from C#");

        Console.WriteLine(message.Sid);
    }

}