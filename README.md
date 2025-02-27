# sdk-dotnet-apis-efi

> A .NET Core library for integration of your application with the payment services
provided by [Efí](https://sejaefi.com.br/).


## Installation

From Visual Studio package manager: 

```bash
PM> Install-Package EfiPay -Version 2.0.2
```

From .NET Cli:

```bash
> dotnet add package EfiPay --version 2.0.2
```

### Tested with
```
.NET 8.0

```
## Basic usage

```c#
using Efipay;
...
dynamic efi = new EfiPay("client_id", "client_secret", true, "production.p12");
            
var body = new 
{
    calendario = new {
        expiracao = 3600
    },
    devedor = new {
        cpf = "12345678909",
        nome = "Francisco da Silva"
    },
    valor = new {
        original = "1.45"
    },
    chave = "71cdf9ba-c695-4e3c-b010-abb521a3f1be",
    solicitacaoPagador = "Informe o número ou identificador do pedido."
};

var response = efi.PixCreateImmediateCharge(null, body);
Console.WriteLine(response);
```

## Examples

You can run the examples contained in the project `Examples` by uncommenting the lines in `Program.cs` file.

Just remember to set the correct credentials inside `Examples/credentials.json` before running.

## Additional documentation

The full documentation with all available endpoints is in https://dev.efipay.com.br/.


## Contributing

Bug reports and pull requests are welcome on GitHub at https://github.com/efipay/sdk-dotnet-apis-efi. This project is intended to be a safe, welcoming space for collaboration.

## License

The library is available as open source under the terms of the [MIT License](LICENSE).