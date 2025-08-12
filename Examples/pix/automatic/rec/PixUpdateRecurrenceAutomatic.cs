
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    class PixUpdateRecurrenceAutomatic
    {
        public static void Execute()
        {
            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new
            {
                idRec = "RN0908935620250730e2ca345bede"
            };

            var body = new
            {
                loc = 108,
                vinculo = new
                {
                    devedor = new
                    {
                        nome = "Fulano de Tal"
                    }
                },
                calendario = new
                {
                    dataInicial = "2024-04-01"
                },
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
                var response = efi.PixUpdateRecurrenceAutomatic(param, body);
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