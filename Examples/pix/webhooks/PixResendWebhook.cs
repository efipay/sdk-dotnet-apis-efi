
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    internal class PixResendWebhook
    {
        public static void Execute()
        {
            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var body = new {
                tipo = "PIX_RECEBIDO",
                e2eids = new []{
                    "E09089356202412261300API229e5352",
                    "E09089356202412261300API3149af57"
                    }
            };

            try
            {
                var response = efi.PixResendWebhook(null, body);
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