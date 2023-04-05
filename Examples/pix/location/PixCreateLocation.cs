
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    class PixCreateLocation
    {
        public static void Execute()
        {
            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var body = new
            {
                tipoCob = "cob"
            };

            try
            {
                var response = efi.PixCreateLocation(null, body);
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