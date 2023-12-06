using Newtonsoft.Json;

namespace Efipay
{
    public class Constants
    {
        public object Const = new
        {
            APIS = new
            {
                CHARGES = new
                {
                    URL = new
                    {
                        production = "https://cobrancas.api.efipay.com.br/v1",
                        sandbox = "https://cobrancas-h.api.efipay.com.br/v1"
                    },
                    ENDPOINTS = new
                    {
                        CreateCharge = new
                        {
                            route = "/charge",
                            method = "POST"
                        },
                        DetailCharge = new
                        {
                            route = "/charge/:id",
                            method = "GET"
                        },
                        UpdateChargeMetadata = new
                        {
                            route = "/charge/:id/metadata",
                            method = "PUT"
                        },
                        UpdateBillet = new
                        {
                            route = "/charge/:id/billet",
                            method = "PUT"
                        },
                        DefinePayMethod = new
                        {
                            route = "/charge/:id/pay",
                            method = "POST"
                        },
                        DefineLinkPayMethod = new
                        {
                            route = "/charge/:id/link",
                            method = "POST"
                        },
                        CancelCharge = new
                        {
                            route = "/charge/:id/cancel",
                            method = "PUT"
                        },
                        CreateCarnet = new
                        {
                            route = "/carnet",
                            method = "POST"
                        },
                        DetailCarnet = new
                        {
                            route = "/carnet/:id",
                            method = "GET"
                        },
                        UpdateCarnetParcel = new
                        {
                            route = "/carnet/:id/parcel/:parcel",
                            method = "PUT"
                        },
                        UpdateCarnetMetadata = new
                        {
                            route = "/carnet/:id/metadata",
                            method = "PUT"
                        },
                        GetNotification = new
                        {
                            route = "/notification/:token",
                            method = "GET"
                        },
                        ListPlans = new
                        {
                            route = "/plans",
                            method = "GET"
                        },
                        CreatePlan = new
                        {
                            route = "/plan",
                            method = "POST"
                        },
                        DeletePlan = new
                        {
                            route = "/plan/:id",
                            method = "DELETE"
                        },
                        CreateSubscription = new
                        {
                            route = "/plan/:id/subscription",
                            method = "POST"
                        },
                        DetailSubscription = new
                        {
                            route = "/subscription/:id",
                            method = "GET"
                        },
                        DefineSubscriptionPayMethod = new
                        {
                            route = "/subscription/:id/pay",
                            method = "POST"
                        },
                        CancelSubscription = new
                        {
                            route = "/subscription/:id/cancel",
                            method = "PUT"
                        },
                        UpdateSubscriptionMetadata = new
                        {
                            route = "/subscription/:id/metadata",
                            method = "PUT"
                        },
                        GetInstallments = new
                        {
                            route = "/installments",
                            method = "GET"
                        },
                        SendBilletEmail = new
                        {
                            route = "/charge/:id/billet/resend",
                            method = "POST"
                        },
                        CreateChargeHistory = new
                        {
                            route = "/charge/:id/history",
                            method = "POST"
                        },
                        SendCarnetEmail = new
                        {
                            route = "/carnet/:id/resend",
                            method = "POST"
                        },
                        SendCarnetParcelEmail = new
                        {
                            route = "/carnet/:id/parcel/:parcel/resend",
                            method = "POST"
                        },
                        CreateCarnetHistory = new
                        {
                            route = "/carnet/:id/history",
                            method = "POST"
                        },
                        CancelCarnet = new
                        {
                            route = "/carnet/:id/cancel",
                            method = "PUT"
                        },
                        CancelCarnetParcel = new
                        {
                            route = "/carnet/:id/parcel/:parcel/cancel",
                            method = "PUT"
                        },
                        CreateOneStepLink = new
                        {
                            route = "/charge/one-step/link",
                            method = "POST"
                        },
                        UpdateChargeLink = new
                        {
                            route = "/charge/:id/link",
                            method = "PUT"
                        },
                        UpdatePlan = new
                        {
                            route = "/plan/:id",
                            method = "PUT"
                        },
                        CreateSubscriptionHistory = new
                        {
                            route = "/subscription/:id/history",
                            method = "POST"
                        },
                        SettleCharge = new
                        {
                            route = "/charge/:id/settle",
                            method = "PUT"
                        },
                        SettleCarnet = new
                        {
                            route = "/carnet/:id/settle",
                            method = "PUT"
                        },
                        SettleCarnetParcel = new
                        {
                            route = "/carnet/:id/parcel/:parcel/settle",
                            method = "PUT"
                        },
                        CreateOneStepCharge = new
                        {
                            route = "/charge/one-step",
                            method = "POST"
                        },
                        DefineBalanceSheetBillet = new
                        {
                            route = "/charge/:id/balance-sheet",
                            method = "POST"
                        },
                        OneStepLink = new
                        {
                            route = "/charge/one-step/link",
                            method = "POST"
                        },
                        SendLinkEmail = new
                        {
                            route = "/charge/:id/link/resend",
                            method = "POST"
                        },
                        CreateOneStepSubscriptionLink = new
                        {
                            route = "/plan/:id/subscription/one-step/link",
                            method = "POST"
                        },
                        CreateOneStepSubscription = new
                        {
                            route = "/plan/:id/subscription/one-step",
                            method = "POST"
                        },
                        SendSubscriptionLinkEmail = new
                        {
                            route = "/charge/:id/subscription/resend",
                            method = "POST"
                        }
                    }
                },
                PIX = new
                {
                    URL = new
                    {
                        production = "https://pix.api.efipay.com.br",
                        sandbox = "https://pix-h.api.efipay.com.br"
                    },
                    ENDPOINTS = new
                    {
                        authorize = new
                        {
                            route = "/oauth/token",
                            method = "POST"
                        },
                        PixConfigWebhook = new
                        {
                            route = "/v2/webhook/:chave",
                            method = "PUT"
                        },
                        PixDetailWebhook = new
                        {
                            route = "/v2/webhook/:chave",
                            method = "GET"
                        },
                        PixListWebhook = new
                        {
                            route = "/v2/webhook",
                            method = "GET"
                        },
                        PixDeleteWebhook = new
                        {
                            route = "/v2/webhook/:chave",
                            method = "DELETE"
                        },
                        PixCreateCharge = new
                        {
                            route = "/v2/cob/:txid",
                            method = "PUT"
                        },
                        PixCreateImmediateCharge = new
                        {
                            route = "/v2/cob",
                            method = "POST"
                        },
                        PixDetailCharge = new
                        {
                            route = "/v2/cob/:txid",
                            method = "GET"
                        },
                        PixUpdateCharge = new
                        {
                            route = "/v2/cob/:txid",
                            method = "PATCH"
                        },
                        PixListCharges = new
                        {
                            route = "/v2/cob",
                            method = "GET"
                        },
                        PixGenerateQRCode = new
                        {
                            route = "/v2/loc/:id/qrcode",
                            method = "GET"
                        },
                        PixDevolution = new
                        {
                            route = "/v2/pix/:e2eId/devolucao/:id",
                            method = "PUT"
                        },
                        PixDetailDevolution = new
                        {
                            route = "/v2/pix/:e2eId/devolucao/:id",
                            method = "GET"
                        },
                        PixSend = new
                        {
                            route = "/v2/gn/pix/:idEnvio",
                            method = "PUT"
                        },
                        PixSendDetail = new
                        {
                            route = "/v2/gn/pix/enviados/:e2eid",
                            method = "GET"
                        },
                        PixSendList = new
                        {
                            route = "/v2/gn/pix/enviados",
                            method = "GET"
                        },
                        PixDetailReceived = new
                        {
                            route = "/v2/pix/:e2eId",
                            method = "GET"
                        },
                        PixReceivedList = new
                        {
                            route = "/v2/pix",
                            method = "GET"
                        },
                        PixCreateDueCharge = new
                        {
                            route = "/v2/cobv/:txid",
                            method = "PUT"
                        },
                        PixUpdateDueCharge = new
                        {
                            route = "/v2/cobv/:txid",
                            method = "PATCH"
                        },
                        PixDetailDueCharge = new
                        {
                            route = "/v2/cobv/:txid",
                            method = "GET"
                        },
                        PixListDueCharges = new
                        {
                            route = "/v2/cobv/",
                            method = "GET"
                        },
                        PixCreateLocation = new
                        {
                            route = "/v2/loc",
                            method = "POST"
                        },
                        PixLocationList = new
                        {
                            route = "/v2/loc",
                            method = "GET"
                        },
                        PixDetailLocation = new
                        {
                            route = "/v2/loc/:id",
                            method = "GET"
                        },
                        PixUnlinkTxidLocation = new
                        {
                            route = "/v2/loc/:id/txid",
                            method = "DELETE"
                        },
                        PixCreateEvp = new
                        {
                            route = "/v2/gn/evp",
                            method = "POST"
                        },
                        PixListEvp = new
                        {
                            route = "/v2/gn/evp",
                            method = "GET"
                        },
                        PixDeleteEvp = new
                        {
                            route = "/v2/gn/evp/:chave",
                            method = "DELETE"
                        },
                        GetAccountBalance = new
                        {
                            route = "/v2/gn/saldo",
                            method = "GET"
                        },
                        UpdateAccountConfig = new
                        {
                            route = "/v2/gn/config",
                            method = "PUT"
                        },
                        ListAccountConfig = new
                        {
                            route = "/v2/gn/config",
                            method = "GET"
                        },
                        CreateReport = new
                        {
                            route = "/v2/gn/relatorios/extrato-conciliacao",
                            method = "POST"
                        },
                        DetailReport = new
                        {
                            route = "/v2/gn/relatorios/:id",
                            method = "GET"
                        },
                        PixSplitDetailCharge = new
                        {
                            route = "/v2/gn/split/cob/:txid",
                            method = "GET"
                        },
                        PixSplitLinkCharge = new
                        {
                            route = "/v2/gn/split/cob/:txid/vinculo/:splitConfigId",
                            method = "PUT"
                        },
                        PixSplitUnlinkCharge = new
                        {
                            route = "/v2/gn/split/cob/:txid/vinculo",
                            method = "DELETE"
                        },
                        PixSplitDetailDueCharge = new
                        {
                            route = "/v2/gn/split/cobv/:txid",
                            method = "GET"
                        },
                        PixSplitLinkDueCharge = new
                        {
                            route = "/v2/gn/split/cobv/:txid/vinculo/:splitConfigId",
                            method = "PUT"
                        },
                        PixSplitUnlinkDueCharge = new
                        {
                            route = "/v2/gn/split/cobv/:txid/vinculo",
                            method = "DELETE"
                        },
                        PixSplitConfig = new
                        {
                            route = "/v2/gn/split/config",
                            method = "POST"
                        },
                        PixSplitConfigId = new
                        {
                            route = "/v2/gn/split/config/:id",
                            method = "PUT"
                        },
                        PixSplitDetailConfig = new
                        {
                            route = "/v2/gn/split/config/:id",
                            method = "GET"
                        },
                        PixSendDetailId = new
                        {
                            route = "/v2/gn/pix/enviados/id-envio/:idEnvio",
                            method = "GET"
                        }
                    }
                },
                OPEN_FINANCE = new
                {
                    URL = new
                    {
                        production = "https://openfinance.api.efipay.com.br/v1",
                        sandbox = "https://openfinance-h.api.efipay.com.br/v1"
                    },
                    ENDPOINTS = new
                    {
                        authorize = new
                        {
                            route = "/oauth/token",
                            method = "POST"
                        },
                        OfConfigUpdate = new
                        {
                            route = "/config",
                            method = "PUT"
                        },
                        OfConfigDetail = new
                        {
                            route = "/config",
                            method = "GET"
                        },
                        OfListParticipants = new
                        {
                            route = "/participantes/",
                            method = "GET"
                        },
                        OfStartPixPayment = new
                        {
                            route = "/pagamentos/pix",
                            method = "POST"
                        },
                        OfListPixPayment = new
                        {
                            route = "/pagamentos/pix",
                            method = "GET"
                        },
                        OfDevolutionPix = new
                        {
                            route = "/pagamentos/pix/:identificadorPagamento/devolver",
                            method = "POST"
                        }
                    }
                },
                PAYMENTS = new
                {
                    URL = new
                    {
                        production = "https://pagarcontas.api.efipay.com.br/v1",
                        sandbox = ""
                    },
                    ENDPOINTS = new
                    {
                        authorize = new
                        {
                            route = "/oauth/token",
                            method = "POST"
                        },
                        PayDetailBarCode = new
                        {
                            route = "/codBarras/:codBarras",
                            method = "GET"
                        },
                        PayRequestBarCode = new
                        {
                            route = "/codBarras/:codBarras",
                            method = "POST"
                        },
                        PayDetailPayment = new
                        {
                            route = "/:idPagamento",
                            method = "GET"
                        },
                        PayListPayments = new
                        {
                            route = "/resumo",
                            method = "GET"
                        }
                    }
                },
                OPENING_ACCOUNTS = new
                {
                    URL = new
                    {
                        production = "https://abrircontas.api.efipay.com.br/v1",
                        sandbox = ""
                    },
                    ENDPOINTS = new
                    {
                        authorize = new
                        {
                            route = "/oauth/token",
                            method = "POST"
                        },
                        CreateAccount = new
                        {
                            route = "/cadastro/conta-simplificada",
                            method = "POST"
                        },
                        GetAccountCredentials = new
                        {
                            route = "/cadastro/conta-simplificada/:idContaSimplificada/credenciais",
                            method = "GET"
                        },
                        CreateAccountCertificate = new
                        {
                            route = "/cadastro/conta-simplificada/:idContaSimplificada/certificado",
                            method = "POST"
                        },
                        AccountConfigWebhook = new
                        {
                            route = "/cadastro/webhook",
                            method = "POST"
                        },
                        AccountListWebhook = new
                        {
                            route = "/cadastro/webhooks",
                            method = "GET"
                        },
                        AccountDetailWebhook = new
                        {
                            route = "/cadastro/webhook/:identificadorWebhook",
                            method = "GET"
                        },
                        AccountDeleteWebhook = new
                        {
                            route = "/cadastro/webhook/:identificadorWebhook",
                            method = "DELETE"
                        }
                    }
                }
            }
        };

        public string getConstant()
        {
            string jsonString = JsonConvert.SerializeObject(Const);
            return jsonString;
        }
    }
}
