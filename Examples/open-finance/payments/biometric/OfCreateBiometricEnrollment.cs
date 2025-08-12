
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace Examples
{
    internal class OfCreateBiometricEnrollment
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var body = new
            {
                pagador = new
                {
                    idParticipante = "9f4cd202-8f2b-11ec-b909-0242ac120002",
                    cpf = "45204392050",
                    cnpj = "90293071000112"
                }
            };

            try
            {
                var response = efi.OfCreateBiometricEnrollment(null, body);
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