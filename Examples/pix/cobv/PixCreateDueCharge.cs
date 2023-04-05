
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    internal class PixCreateDueCharge
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new
            {
                txid = "",
            };

            var body = new
            {
                calendario = new
                {
                    dataDeVencimento = "2022-12-01",
                    validadeAposVencimento = 30
                },
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
                    original = "123.45",
                    multa = new
                    {
                        modalidade = 2,
                        valorPerc = "15.00"
                    },
                    juros = new
                    {
                        modalidade = 2,
                        valorPerc = "2.00"
                    },
                    desconto = new
                    {
                        modalidade = 1,
                        descontoDataFixa = new[]{
                        new {
                            data = "2022-11-30",
                            valorPerc = "30.00"
                            }
                        }
                    }
                },
                chave = "",
                solicitacaoPagador = "Cobrança dos serviços prestados."
            };

            try
            {
                var response = efi.PixCreateDueCharge(param, body);
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