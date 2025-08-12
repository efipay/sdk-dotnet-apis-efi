
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    internal class OfUpdateAutomaticEnrollment
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new {
                identificador = "urn:efi:19ba4105-9ae2-4637-89f2-96506d3c8770",
                nomeFavorecido = "Marco Antonio de Brito",
                status = "revogado",
                dataExpiracao = "2021-05-21",
                valorMaximo = "500.00"
            };

            try
            {
                var response = efi.OfUpdateAutomaticEnrollment(param);
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