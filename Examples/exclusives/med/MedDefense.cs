
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    class MedDefense
    {
        public static void Execute()
        {
            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new
            {
                idInfracao = "00000000-0000-0000-0000-000000000000",
            };

            var body = new 
            {
                analise = "aceito",
                justificativa = "Justificativa"
            };

            try
            {
                var response = efi.MedDefense(param, body);
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