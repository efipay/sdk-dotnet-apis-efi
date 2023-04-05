
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    internal class PixDetailDueCharge
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new
            {
                txid = "txistxidstxidtxistsgdkjjgkj7",
            };

            try
            {
                var response = efi.PixDetailDueCharge(param);
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