
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    internal class OfReplaceRecurrencyPixParcel
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new
            {
                identificadorPagamento = "identificadorPagamento",
                endToEndId = "endToEndId"
            };

            var body = new {
                valor = "9.99"
            };

            try
            {
                var response = efi.OfReplaceRecurrencyPixParcel(param, body);
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