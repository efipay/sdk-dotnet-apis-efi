
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace Examples
{
    internal class OfCreateAutomaticEnrollment
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var body = new
            {
                pagador = new
                {
                    cpf = "10134280059",
                    cnpj = "34836879000128",
                    nome  = "Josué Villa Real",
                    idParticipante = "64c189e5-9d4a-4319-aa5e-d02c36e1815d"
                },
                favorecido = new
                {
                    contaBanco = new
                    {
                        nome = "Lucas Silva",
                        documento = "17558266300",
                        codigoBanco = "09089356",
                        agencia = "0001",
                        conta = "654984",
                        tipoConta = "TRAN"
                    }
                },
                assinatura = new
                {
                    expiracao = "2026-08-27",
                    descricao = "Mensalidades do curso XYZ",
                    idProprio = "6236574863254",
                },
                configuracao = new
                {
                    automatico = new
                    {
                        valorFixo = "500.00",
                        valorMinimo = "450.00",
                        valorMaximo = "750.00",
                        intervalo = "SEMANAL",
                        dataInicio = "2025-06-06",
                        permiteRetentativa = false,
                        primeiroPagamento = new
                        {
                            data = "2024-06-08",
                            valor = "9.99",
                            infoPagador = "Parcela 1"
                        }
                    }
                }
            };

            try
            {
                var response = efi.OfCreateAutomaticEnrollment(null, body);
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