
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;


namespace Examples
{
    internal class CreateOneStepBilletMatketplace
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var body = new
            {
                items = new[] {
                    new {
                        name = "Product 1",
                        value = 1000,
                        amount = 2,
                        marketplace = new {
                            mode = 1,
                            repasses = new [] {
                                new {
                                    payee_code = "Insira_aqui_o_indentificador_da_conta_destino",
                                    percentage = 2500
                                }
                            }
                        }
                    }
                },
                shippings = new[] {
                    new {
                        name = "Default Shipping Cost",
                        value = 100
                    }
                },
                payment = new
                {
                    banking_billet = new
                    {
                        expire_at = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd"),
                        customer = new
                        {
                            name = "Gorbadoc Oldbuck",
                            email = "oldbuck@efipay.com.br",
                            cpf = "94271564656",
                            birth = "1977-01-15",
                            phone_number = "5144976523"
                        }
                    }
                }
            };

            try
            {
                var response = efi.CreateOneStepCharge(null, body);
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