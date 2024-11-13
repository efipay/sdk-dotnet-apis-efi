
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    internal class OfStartRecurrencyPixPayment
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var body = new
            {
                pagador = new {
                    idParticipante = "e69c25b5-c63a-4c25-8564-81f57436481c",
                    cpf = "45204392050",
                    cnpj = "90293071000112"
                },
                favorecido = new {
                    contaBanco = new {
                        nome = "Lucas Silva",
                        documento = "17558266300",
                        codigoBanco = "09089356",
                        agencia = "0001",
                        conta = "654984",
                        tipoConta = "CACC"
                    }
                },
                pagamento = new {
                    valor = "9.90",
                    codigoCidadeIBGE = "3540000",
                    infoPagador = "Churrasco",
                    idProprio = "6236574863254",
                    recorrencia = new {
                        tipo = "diaria",
                        dataInicio = "2025-12-31",
                        quantidade = 2,
                        diaDaSemana = "SEGUNDA_FEIRA",
                        diaDoMes = 15,
                        datas = new []{
                            "2024-08-01",
                            "2024-08-08",
                            "2024-08-15"
                        }
                        ,
                        descricao = "Petshop"
                    }
                }
            };

            try
            {
                var response = efi.OfStartRecurrencyPixPayment(null, body);
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