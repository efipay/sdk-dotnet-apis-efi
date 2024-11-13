
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    internal class OfDevolutionRecurrencyPix
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new
            {
                identificadorPagamento = "",
            };

            var body = new []
            {
                new {
                    endToEndId = "",
                    valor = "0.01"
                }
            };

            try
            {
                var response = efi.OfDevolutionRecurrencyPix(param, body);
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