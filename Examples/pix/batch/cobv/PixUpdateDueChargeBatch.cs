
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    internal class PixUpdateDueChargeBatch
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new
            {
                id = 1
            };

            var body = new {
                cobsv = new [] {
                    new {
                        calendario = new {
                            dataDeVencimento = "2025-01-10"
                        },
                        txid = "fb2761260e554ad593c7226beb5cb650",
                        valor = new {
                            original = "110.00"
                        }
                    },
                    new {
                        calendario = new {
                            dataDeVencimento = "2020-01-10"
                        },
                        txid = "7978c0c97ea847e78e8849634473c1f1",
                        valor = new {
                            original = "110.00"
                        }
                    }
                }
            };
            
            try
            {
                var response = efi.PixUpdateDueChargeBatch(param, body);
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