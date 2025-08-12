
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    class PixCreateRequestRecurrenceAutomatic
    {
        public static void Execute()
        {
            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var body = new
            {
                idRec = "RN123456782024011577825445612",
                calendario = new
                {
                    dataExpiracaoSolicitacao = "2023-12-20T12:17:11.926Z"
                },
                destinatario = new
                {
                    agencia = "2569",
                    conta = "550689",
                    cpf = "15231470190",
                    ispbParticipante = "91193552"
                }
            };

            try
            {
                var response = efi.PixCreateRequestRecurrenceAutomatic(null, body);
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