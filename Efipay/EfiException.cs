using System;
using Newtonsoft.Json;

namespace Efipay
{
    public class EfiException : Exception
    {
        public EfiException(int code, string error, string message) : base(message)
        {
            Code = code;
            ErrorType = error;
        }

        public int Code { get; }

        public string ErrorType { get; }

        public static EfiException Build(string json, int statusCode)
        {
            try
            {
                object def = new { };
                dynamic jsonObject = JsonConvert.DeserializeAnonymousType(json, def);

                int code = jsonObject.code;
                string error = jsonObject.error.ToString();
                string description = jsonObject.error_description.ToString();
                return new EfiException(code, error, description);
            }
            catch (Exception)
            {
                if (statusCode == 401)
                    throw new EfiException(401, "authorization_error",
                        "Could not authenticate. Please make sure you are using correct credentials and if you are using then in the correct environment.");
                return new EfiException(500, "internal_server_error", "Ocorreu um erro no servidor");
            }
        }
    }

}
