
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    internal class UpdateStatementRecurrency
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new {
                identificador = "diario" //"diario", "semanal", "mensal"
            };

            var body = new
            {
                periodicidade = "diario", //"diario", "semanal", "mensal"
                status = "ativo",
                envia_email = true,
                comprimir_arquivos = true
            };

            try
            {
                var response = efi.UpdateStatementRecurrency(param, body);
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