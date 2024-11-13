
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    internal class OfStartPixPayment
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var headers = "{\"x-idempotency-key\": \"et sedaute sint officiapariatur amet aute sun\"}";

            var body = new
            {
                pagador = new
                {
                    idParticipante = "ebbed125-5cd7-42e3-965d-2e7af8e3b7ae",
                    cpf = "01234567890",
                },
                favorecido = new
                {
                    contaBanco = new
                    {
                        codigoBanco = "",
                        agencia = "",
                        documento = "",
                        nome = "",
                        conta = "",
                        tipoConta = ""
                    }
                },
                valor = "0.01",
                infoPagador = "Compra dia xx"
            };

            try
            {
                var response = efi.OfStartPixPayment(null, body, headers);
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