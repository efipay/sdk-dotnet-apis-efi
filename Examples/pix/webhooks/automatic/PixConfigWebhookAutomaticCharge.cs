
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    internal class PixConfigWebhookAutomaticCharge
    {
        public static void Execute()
        {
            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var headers = "{\"x-skip-mtls-checking\": \"true\"}";

            var body = new
            {
                webhookUrl = "https://usuario.recebedor.com/api/webhookrec/"
            };

            try
            {
                var response = efi.PixConfigWebhookAutomaticCharge(body, headers);
                Console.WriteLine(response);
            }
            catch (EfiException e)
            {
                Console.WriteLine(e.ErrorType);
                Console.WriteLine(e.Message);
            }
        }
    }
}