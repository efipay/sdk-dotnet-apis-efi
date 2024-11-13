
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    internal class UpdateCarnetParcels
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new
            {
                id = 1,
            };

            var body = new
            {
               parcels = new [] {
                    new {
                        parcel = 1,
                        expire_at = "2024-11-15"
                    },
                    new {
                        parcel = 2,
                        expire_at = "2024-12-15"
                    }
               }
            };

            try
            {
                var response = efi.UpdateCarnetParcels(param, body);
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