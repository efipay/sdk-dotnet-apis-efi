
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    class PixDetailAutomaticCharge
    {
        public static void Execute()
        {
            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new
            {
                txid = "3136957d93134f2184b369e8f1c0729d"
            };

            try
            {
                var response = efi.PixDetailAutomaticCharge(param);
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