using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CareConnection2.Controllers
{
    public class AlertTwilio
    {

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
}