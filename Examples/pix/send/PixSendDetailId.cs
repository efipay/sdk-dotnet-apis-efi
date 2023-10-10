
using System;
using System.IO;
using Newtonsoft.Json.Linq;
using Efipay;

namespace Examples
{
    class PixSendDetailId
    {
        public static void Execute()
        {
            dynamic efi = new EfiPay(JObject.Parse(File.ReadAllText("credentials.json")));

            var param = new
            {
                idEnvio = 12345
            };


            try
            {
                var response = efi.PixSendDetailId(param, null);
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