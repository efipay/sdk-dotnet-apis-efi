
using System; using System.IO; using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    internal class CardPaymentRetry
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
                        customer = new
                        {
                            name = "Gorbadoc Oldbuck",
                            cpf = "94271564656",
                            email = "email_do_cliente@servidor.com.br",
                            birth = "1990-08-29",
                            phone_number = "5144916523"
                        },
                        billing_address = new
                        {
                            street = "Avenida Juscelino Kubitschek",
                            number = "909",
                            neighborhood = "Bauxita",
                            zipcode = "35400000",
                            city = "Ouro Preto",
                            complement = "",
                            state = "MG"
                        },
                        payment_token = "5e8aee6844198f01926534faef91597de8d96c31"
                    }
                }
            };

            try
            {
                var response = efi.CardPaymentRetry(param, body);
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