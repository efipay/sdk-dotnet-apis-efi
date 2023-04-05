
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    internal class PixSplitConfig
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
                descricao = "Waask",
                lancamento = new
                {
                    imediato = true
                },
                split = new
                {
                    divisaoTarifa = "assumir_total",
                    minhaParte = new
                    {
                        tipo = "porcentagem",
                        valor = "85.00"
                    },
                    repasses = new[] {
                        new {
                            tipo = "porcentagem",
                            valor = "15.00",
                            favorecido = new {
                                cpf = "",
                                conta = ""
                            }
                        }
                    }
                }
            };


            try
            {
                var response = efi.PixSplitConfig(null, body);
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