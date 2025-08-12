
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Examples
{
    internal class OfCreateBiometricPixPayment
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var body = new {
                identificadorVinculo = "urn:efi:19ba4105-9ae2-4637-89f2-96506d3c8770",
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
                    },
                    chave = "2badfe30-d03b-4da1-9f2f-02b5dcef765c"
                },
                pagamento = new
                {
                    valor = "9.99",
                    codigoCidadeIBGE = "5300108",
                    infoPagador = "Churrasco",
                    idProprio = "6236574863254",
                    qrCode = "00020104141234567890123426660014BR.GOV.BCB.PIX014466756C616E6F32303139406578616D706C652E636F6D27300012BR.COM.OUTRO011001234567895204000053039865406123.455802BR5915NOMEDORECEBEDOR6008BRASILIA61087007490062530515RP12345678-201950300017BR.GOV.BCB.BRCODE01051.0.080450014BR.GOV.BCB.PIX0123PADRAO.URL.PIX/0123ABCD81390012BR.COM.OUTRO01190123.ABCD.3456.WXYZ6304EB76",
                    identificadorTransacao = "E00038166201907261559y6j6"
                }
            };

            try
            {
                var response = efi.OfCreateBiometricPixPayment(null, body);
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