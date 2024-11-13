
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    internal class OfStartSchedulePixPayment
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var body = new {
                pagador = new {
                    idParticipante = "75db457a-612d-4d62-b557-ba9d32b05216",
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
                    valor = "9.99",
                    codigoCidadeIBGE = "3540000",
                    infoPagador = "Churrasco",
                    idProprio = "6236574863254",
                    dataAgendamento = "2024-08-06"
                }
            };


            try
            {
                var response = efi.OfStartSchedulePixPayment(null, body);
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