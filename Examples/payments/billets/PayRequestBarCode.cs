
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    internal class PayRequestBarCode
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new
            {
                codBarras = ""
            };

            var body = new
            {
                valor = 1,
                dataPagamento = "2022-06-17",
                descricao = "Pagamento de boleto."
            };

            try
            {
                var response = efi.PayRequestBarCode(param, body);
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