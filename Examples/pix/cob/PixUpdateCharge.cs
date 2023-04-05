
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    class PixUpdateCharge
    {
        public static void Execute()
        {
            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new
            {
                txid = "e4caf2374a684d40b6e7a152bebdac67"
            };

            var body = new
            {
                calendario = new
                {
                    expiracao = 3600
                },
                devedor = new
                {
                    cpf = "12345678909",
                    nome = "Francisco da Silva"
                },
                valor = new
                {
                    original = "123.45"
                },
                chave = "",
                solicitacaoPagador = "Informe o número ou identificador do pedido."
            };

            try
            {
                var response = efi.PixUpdateCharge(param, body);
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