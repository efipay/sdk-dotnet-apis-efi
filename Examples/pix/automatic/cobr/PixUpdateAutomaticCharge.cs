
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    class PixUpdateAutomaticCharge
    {
        public static void Execute()
        {
            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new
            {
                txid = "517bd858b59d458a841280b0f0a60bfa"
            };

            var body = new
            {
                status = "CANCELADA"
            };

            try
            {
                var response = efi.PixUpdateAutomaticCharge(param, body);
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