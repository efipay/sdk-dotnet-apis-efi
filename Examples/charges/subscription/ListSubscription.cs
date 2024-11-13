using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    internal class ListCharges
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new
            {
                charge_type = "subscription",
                begin_date = "2024-01-01",
                end_date = "2024-09-01"
            };

            try
            {
                var response = efi.ListCharges(param);
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