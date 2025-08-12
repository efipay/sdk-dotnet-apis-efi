
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace Examples
{
    internal class OfRevokeBiometricEnrollment
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var body = new
            {
                identificadorVinculo = "urn:efi:ae71713f-875b-4af3-9d85-0bcb43288847",
                motivo = "Encerramento de contrato de vinculo"
            };

            try
            {
                var response = efi.OfRevokeBiometricEnrollment(body);
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