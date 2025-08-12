
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace Examples
{
    internal class OfCancelAutomaticPixPayment
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var body = new
            {
                identificadorAdesao = "urn:efi:19ba4105-9ae2-4637-89f2-96506d3c8770",
                endToEndId = "E00038166201907261559y6j5"
            };

            try
            {
                var response = efi.OfCancelAutomaticPixPayment(body);
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