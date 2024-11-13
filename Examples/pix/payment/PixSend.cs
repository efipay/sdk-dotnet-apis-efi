
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    class PixSend
    {
        public static void Execute()
        {
            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new
            {
                idEnvio = 12345
            };

            var body = new
            {
                valor = "0.01",
                pagador = new
                {
                    chave = "",
                },
                favorecido = new
                {
                    chave = ""
                }
            };

            try
            {
                var response = efi.PixSend(param, body);
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