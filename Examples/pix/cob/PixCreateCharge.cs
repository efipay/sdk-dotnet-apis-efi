
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    class PixCreateCharge
    {
        public static void Execute()
        {
            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new
            {
                txid = ""
            };

            var body = new
            {
                calendario = new
                {
                    expiracao = 100000
                },
                devedor = new
                {
                    cpf = "12345678909",
                    nome = "Francisco da Silva"
                },
                valor = new
                {
                    original = "0.01"
                },
                chave = "",
                solicitacaoPagador = "Informe o número ou identificador do pedido."
            };

            try
            {
                var response = efi.PixCreateCharge(param, body);
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