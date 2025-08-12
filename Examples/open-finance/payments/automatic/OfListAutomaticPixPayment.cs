
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace Examples
{
    internal class OfListAutomaticPixPayment
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new
            {
                identificadorAdesao = "urn:efi:49315a93-d39c-4564-9edb-9a73678dbdb1",
                endToEndId = "E00038166201907261559y6j6"
            };

            try
            {
                var response = efi.OfListAutomaticPixPayment(param);
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