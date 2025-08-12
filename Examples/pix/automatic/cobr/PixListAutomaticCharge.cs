
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;
using System.Runtime.ConstrainedExecution;

namespace Examples
{
    class PixListAutomaticCharge
    {
        public static void Execute()
        {
            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new
            {
                inicio = "2024-04-01T00:00:00Z",
                fim = "2024-12-01T23:59:59Z"
            };

            try
            {
                var response = efi.PixListAutomaticCharge(param);
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