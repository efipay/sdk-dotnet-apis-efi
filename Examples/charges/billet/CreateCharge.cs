
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    internal class CreateCharge
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var body = new
            {
                items = new[] {
                    new {
                        name = "Product 1",
                        value = 10500,
                        amount = 2
                    }
                },
                shippings = new[] {
                    new {
                        name = "Default Shipping Cost",
                        value = 100
                        }
                    }
            };

            try
            {
                var response = efi.CreateCharge(null, body);
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