
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    internal class CreateSubscription
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var planBody = new
            {
                name = "My first plan",
                repeats = 24,
                interval = 2
            };

            var subscriptionBody = new
            {
                items = new[] {
                    new {
                        name = "Product 1",
                            value = 1000,
                        amount = 2
                    }
                }
            };

            try
            {
                var response = efi.CreatePlan(null, planBody);

                JObject planResponse = JObject.Parse(response);

                var subscriptionParam = new
                {
                    id = planResponse["data"]["plan_id"]
                };
                var subscriptionResponse = efi.CreateSubscription(subscriptionParam, subscriptionBody);
                Console.WriteLine(subscriptionResponse);
            }
            catch (EfiException e)
            {
                Console.WriteLine(e.ErrorType);
                Console.WriteLine(e.Message);
            }
        }
    }
}