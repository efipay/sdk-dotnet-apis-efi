
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    internal class PixUpdateDueCharge
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new
            {
                txid = "txistxidstxidtxistsgdkjjgkj7",
            };

            var body = new
            {
                devedor = new
                {
                    logradouro = "Alameda Souza, Numero 80, Bairro Braz",
                    cidade = "Recife",
                    uf = "PE",
                    cep = "70011750",
                    cpf = "12345678909",
                    nome = "Francisco da Silva"
                },
                valor = new
                {
                    original = "123.50",
                },
                solicitacaoPagador = "Cobrança dos serviços prestados..."
            };

            try
            {
                var response = efi.PixUpdateDueCharge(param, body);
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