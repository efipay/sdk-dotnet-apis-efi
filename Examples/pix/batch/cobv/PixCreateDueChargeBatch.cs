
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    internal class PixCreateDueChargeBatch
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new
            {
                id = 1
            };

            var body = new 
            {
                descricao = "Cobranças dos alunos do turno vespertino",
                cobsv = new []{
                    new {
                        calendario = new {
                            dataDeVencimento = "2024-11-28",
                            validadeAposVencimento = 30
                        },
                        txid = "fb2761260e55ood593c7926bjb5cb650",
                        devedor = new {
                            cpf = "01234567890",
                            nome = "João Souza"
                        },
                        valor = new {
                            original = "100.50"
                        },
                        chave = "a572c113-7d13-49ba-9988-0yy7e061a356",
                        solicitacaoPagador = "Informar matrícula"
                    },
                    new {
                        calendario = new {
                            dataDeVencimento = "2020-12-31",
                            validadeAposVencimento = 30
                        },
                        txid = "7978c0c97ea84ppe78e8849634473c9f1",
                        devedor = new {
                            cpf = "15311295449",
                            nome = "Manoel Silva"
                        },
                        valor = new {
                            original = "100.50"
                        },
                        chave = "a572c113-7d13-49ba-9988-0yy7e061a356",
                        solicitacaoPagador = "Informar matrícula"
                    }
                }
            };

            try
            {
                var response = efi.PixCreateDueChargeBatch(param, body);
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