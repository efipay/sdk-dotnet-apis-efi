
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    class PixSendSameOwnership
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
                valor = "12.34",
                pagador = new
                {
                    chave = "19974764017",
                    infoPagador = "Segue o pagamento da conta"
                },
                favorecido = new
                {
                    chave = "joão@meuemail.com"
                }
            };

            try
            {
                var response = efi.PixSendSameOwnership(param, body);
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