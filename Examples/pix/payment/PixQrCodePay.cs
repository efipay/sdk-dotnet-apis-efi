
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    class PixQrCodePay
    {
        public static void Execute()
        {
            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new
            {
                idEnvio = 12345
            };

            var body = new
            {
                pagador = new {
                    chave = "a1f4102e-a446-4a57-bcce-6fa48899c1d1",
                    infoPagador = "Pagamento de QR Code via API Pix"
                },
                pixCopiaECola = "00020101021226830014BR.GOV.BCB.PIX2561qrcodespix.sejaefi.com.br/v2 41e0badf811a4ce6ad8a80b306821fce5204000053000065802BR5905EFISA6008SAOPAULO60070503***61040000"
            };

            try
            {
                var response = efi.PixQrCodePay(param, body);
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