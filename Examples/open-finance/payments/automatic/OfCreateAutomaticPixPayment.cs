
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Examples
{
    internal class OfCreateAutomaticPixPayment
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new {
                identificadorAdesao = "urn:efi:19ba4105-9ae2-4637-89f2-96506d3c8770",
                pagamento = new
                {
                    valor = "9.99",
                    data = "2024-06-08",
                    codigoCidadeIBGE = "5300108",
                    infoPagador = "Parcela 2x20"
                }
            };

            try
            {
                var response = efi.OfCreateAutomaticPixPayment(param);
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