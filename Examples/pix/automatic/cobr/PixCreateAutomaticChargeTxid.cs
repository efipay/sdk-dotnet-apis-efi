
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;
using System.Runtime.ConstrainedExecution;

namespace Examples
{
    class PixCreateAutomaticChargeTxid
    {
        public static void Execute()
        {
            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new
            {
                txid = "517bd858b59d458a841280b0f0a60bfa"
            };

            var body = new
            {
                idRec = "RR1234567820240115abcdefghijk",
                infoAdicional = "Serviços de Streamming de Música e Filmes.",
                calendario = new
                {
                    dataDeVencimento = "2024-04-15"
                },
                valor = new
                {
                    original = "106.07"
                },
                ajusteDiaUtil = true,
                devedor = new
                {
                    cep = "89256140",
                    cidade = "Uberlândia",
                    email = "sebastiao.tavares@mail.com",
                    logradouro = "Alameda Franco 1056",
                    uf = "MG"
                },
                recebedor = new
                {
                    agencia = "9708",
                    conta = "12682",
                    tipoConta = "CORRENTE"
                }
            };

            try
            {
                var response = efi.PixCreateAutomaticChargeTxid(param, body);
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