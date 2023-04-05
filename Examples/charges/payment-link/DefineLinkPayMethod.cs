
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    internal class DefineLinkPayMethod
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new
            {
                id = 1
            };

            var body = new
            {
                billet_discount = 1,
                card_discount = 1,
                message = "",
                expire_at = DateTime.Now.AddDays(3).ToString("yyyy-MM-dd"),
                request_delivery_address = false,
                payment_method = "all"
            };

            try
            {
                var response = efi.DefineLinkPayMethod(param, body);
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