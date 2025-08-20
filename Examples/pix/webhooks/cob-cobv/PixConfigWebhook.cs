
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    internal class PixConfigWebhook
    {
        public static void Execute()
        {
            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var headers = "{\"x-skip-mtls-checking\": \"true\"}";

            var param = new
            {
                chave = ""
            };

            var body = new
            {
                webhookUrl = "https://exemplo-pix/webhook"
            };

            try
            {
                var response = efi.PixConfigWebhook(param, body, headers);
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