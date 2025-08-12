
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    class PixGetReceipt
    {
        public static void Execute()
        {
            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new
            {
                txid = "7978c0c97ea847e78e8849634473c1f1"
            };

            try
            {
                var response = efi.PixGetReceipt(param, null);
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