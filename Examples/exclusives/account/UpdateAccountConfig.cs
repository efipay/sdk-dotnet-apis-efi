
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    class UpdateAccountConfig
    {
        public static void Execute()
        {
            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            string body = "{\"pix\": { \"receberSemChave\": true, \"chaves\": {\"InformeAquiSuaChave\": {\"recebimento\": {                    \"txidObrigatorio\": false, \"qrCodeEstatico\": { \"recusarTodos\": false }}}}}}";

            try
            {
                var response = efi.UpdateAccountConfig(null, body);
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