
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    class PixCreateImmediateCharge
    {
        public static void Execute()
        {
            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

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
                    original = "1.45"
                },
                chave = "",
                solicitacaoPagador = "Informe o número ou identificador do pedido."
            };

            try
            {
                var response = efi.PixCreateImmediateCharge(null, body);
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