
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    internal class CreateReport
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var body = new
            {
                dataMovimento = "2022-04-24",
                tipoRegistros = new
                {
                    pixRecebido = true,
                    pixDevolucaoEnviada = false,
                    tarifaPixRecebido = true,
                    pixEnviadoChave = true,
                    pixEnviadoDadosBancarios = false,
                    pixDevolucaoRecebida = true
                }
            };

            try
            {
                var response = efi.CreateReport(null, body);
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