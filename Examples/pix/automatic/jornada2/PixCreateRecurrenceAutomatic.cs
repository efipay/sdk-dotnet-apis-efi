
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    class PixCreateRecurrenceAutomatic
    {
        public static void Execute()
        {
            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var body = new
            {
                vinculo = new
                {
                    contrato = "63100862",
                    devedor = new
                    {
                        cpf = "45164632481",
                        nome = "Fulano de Tal"
                    },
                    objeto = "Serviço de Streamming de Música."
                },
                calendario = new
                {
                    dataFinal = "2025-04-01",
                    dataInicial = "2024-04-01",
                    periodicidade = "MENSAL"
                },
                valor = new
                {
                    valorRec = "35.00"
                },
                politicaRetentativa = "NAO_PERMITE",
                loc = 108,
                ativacao = new
                {
                    dadosJornada = new
                    {
                        txid = "33beb661beda44a8928fef47dbeb2dc5"
                    }
                }
            };

            try
            {
                var response = efi.PixCreateRecurrenceAutomatic(null, body);
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