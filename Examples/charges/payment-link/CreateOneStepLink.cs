
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;


namespace Examples
{
    internal class CreateOneStepLink
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var body = new
            {
                items = new[] {
                    new {
                        name = "Product 1",
                        value = 590,
                        amount = 2
                    }
                },
                settings = new
                {
                    payment_method = "all",
                    expire_at = "2022-12-15",
                    request_delivery_address = false
                }
            };

            try
            {
                var response = efi.CreateOneStepLink(null, body);
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