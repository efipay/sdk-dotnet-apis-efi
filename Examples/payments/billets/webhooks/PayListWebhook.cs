
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    internal class PayListWebhook
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new {
                dataInicio = "2024-01-22T16:01:35Z",
                dataFim = "2024-09-22T16:01:35Z"
            };

            try
            {
                var response = efi.PayListWebhook(param, null);
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