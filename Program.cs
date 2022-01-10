using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace LearnTwilio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            var accountSid = Secrets.AccountSID;
            var authToken = Secrets.AuthToken;
            var toNumber = Secrets.ToNumber;
            var fromNumber = Secrets.FromNumber;

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                to: new PhoneNumber(toNumber),
                from: new PhoneNumber(fromNumber),
                body: "Hi there! Thanks for joining LHD Build <3"
            );

            Console.WriteLine(message.Sid);
        }
    }
}