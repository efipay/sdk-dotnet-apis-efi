
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;


namespace Examples
{
    internal class CreateOneStepCardMarketplace
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
                    credit_card = new
                    {
                        installments = 1,
                        payment_token = "7d0a3fe0f0c9caab4f3b6578317a9d7e8ed6303f",
                        billing_address = new
                        {
                            street = "Av. JK",
                            number = 909,
                            neighborhood = "Bauxita",
                            zipcode = "35400000",
                            city = "Ouro Preto",
                            state = "MG"
                        },
                        customer = new
                        {
                            name = "Gorbadoc Oldbuck",
                            email = "oldbuck@efipay.com.br",
                            cpf = "04267484171",
                            birth = "1977-01-15",
                            phone_number = "5144916523"
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