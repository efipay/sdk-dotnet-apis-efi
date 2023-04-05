
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    internal class DefineCardPayMethod
    {
        public static void Execute()
        {

            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new
            {
                id = 1
            };

            var body = new
            {
                payment = new
                {
                    credit_card = new
                    {
                        installments = 1,
                        payment_token = "",
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
                var response = efi.DefinePayMethod(param, body);
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