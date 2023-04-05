using System; using System.IO; using Newtonsoft.Json.Linq;

namespace Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* CHARGES - BILLET */
            // CancelBillet.Execute();
            // CreateBilletHistory.Execute();
            // CreateCharge.Execute();
            // CreateOneStepBillet.Execute();
            // DefineBilletPayMethod.Execute();
            // DetailBillet.Execute();
            // SendBilletEmail.Execute();
            // SettleBillet.Execute();
            // UpdateBillet.Execute();
            // UpdateBilletMetadata.Execute();

            /* CHARGES - CARD */
            // CancelCard.Execute();
            // CreateCardHistory.Execute();
            // CreateChargeCard.Execute();
            // CreateOneStepCard.Execute();
            // DefineCardPayMethod.Execute();
            // DetailCard.Execute();
            // GetInstallments.Execute();
            // UpdateCardMetadata.Execute();

            /* CHARGES - CARNETS */
            // CancelCarnet.Execute();
            // CancelCarnetParcel.Execute();
            // CreateCarnet.Execute();
            // CreateCarnetHistory.Execute();
            // DetailCarnet.Execute();
            // SendCarnetEmail.Execute();
            // SendCarnetParcelEmail.Execute();
            // SettleCarnet.Execute();
            // SettleCarnetParcel.Execute();
            // UpdateCarnetMetadata.Execute();
            // UpdateCarnetParcel.Execute();

            /* CHARGES - MARKETPLACE */
            // CreateOneStepBilletMatketplace.Execute();
            // CreateOneStepCardMarketplace.Execute();

            /* CHARGES - NOTIFICATION */
            //GetNotification.Execute();

            /* CHARGES - PAYMENT LINK */
            // CancelLink.Execute();
            // CreateChargeLink.Execute();
            // CreateChargeLinkHistory.Execute();
            // CreateOneStepLink.Execute();
            // DefineLinkPayMethod.Execute();
            // DetailLink.Execute();
            // SendLinkEmail.Execute();
            // UpdateChargeLink.Execute();
            // UpdateLinkMetadata.Execute();

            /* CHARGES - SUBSCRIPTION */
            // CancelSubscription.Execute();
            // CreateSubscription.Execute();
            // CreateOneStepBilletSubscription.Execute();
            // CreateOneStepCardSubscription.Execute();
            // CreateOneStepSubscriptionLink.Execute();
            // CreatePlan.Execute();
            // CreateSubscriptionHistory.Execute();
            // DefineSubscriptionBillet.Execute();
            // DefineSubscriptionCard.Execute();
            // DeletePlan.Execute();
            // DetailSubscription.Execute();
            // ListPlans.Execute();
            // SendSubscriptionLinkEmail.Execute();
            // UpdatePlan.Execute();
            // UpdateSubscriptionMetadata.Execute();

            /* EXCLUSIVES - ACCOUNT */
            // GetAccountBalance.Execute();
            // ListAccountConfig.Execute();
            // UpdateAccountConfig.Execute();
            
            /* EXCLUSIVES - KEY */
            // PixListEvp.Execute();
            // PixCreateEvp.Execute();
            // PixDeleteEvp.Execute();

            /* EXCLUSIVES - REPORT */
            // CreateReport.Execute();
            // DetailReport.Execute();

            
            /* OPEN FINANCE - CONFIG */
            // OfConfigDetail.Execute();
            // OfConfigUpdate.Execute();

            /* OPEN FINANCE - DEVOLUTION */
            // OfDevolutionPix.Execute();

            /* OPEN FINANCE - PARTICIPANTS */
            // OfListParticipants.Execute();

            /* OPEN FINANCE - PAYMENTS */
            // OfListPixPayment.Execute();
            // OfStartPixPayment.Execute();


            /* PAYMENTS - BILLETS */
            // PayDetailBarCode.Execute();
            // PayRequestBarCode.Execute();
            // PayDetailPayment.Execute();
            // PayListPayments.Execute();

            
            /* PIX - COB */
            // PixCreateCharge.Execute();
            // PixCreateImmediateCharge.Execute();
            // PixDetailCharge.Execute();
            // PixListCharges.Execute();
            // PixUpdateCharge.Execute();

            /* PIX - COBV */
            // PixCreateDueCharge.Execute();
            // PixUpdateDueCharge.Execute();
            // PixDetailDueCharge.Execute();
            // PixListDueCharges.Execute();

            /* PIX - LOCATION */
            // PixCreateLocation.Execute();
            // PixDetailLocation.Execute();
            // PixGenerateQRCode.Execute();
            // PixLocationList.Execute();
            // PixUnlinkTxidLocation.Execute();

            /* PIX - PIX */
            // PixDetailDevolution.Execute();
            // PixDetailReceived.Execute();
            // PixDevolution.Execute();
            // PixReceivedList.Execute();


            /* PIX - SEND */
            // PixSend.Execute();
            // PixSendDetail.Execute();
            // PixSendList.Execute();
            

            /* PIX - SPLIT - COB */
            // PixSplitDetailCharge.Execute();
            // PixSplitLinkCharge.Execute();
            // PixSplitUnlinkCharge.Execute();

            /* PIX - SPLIT - COBV */
            // PixSplitDetailDueCharge.Execute();
            // PixSplitLinkDueCharge.Execute();
            // PixSplitUnlinkDueCharge.Execute();

            /* PIX - SPLIT - CONFIG */
            // PixSplitConfig.Execute();
            // PixSplitConfigId.Execute();
            // PixSplitDetailConfig.Execute();

            /* PIX - WEBHOOKS */
            // PixConfigWebhook.Execute();
            // PixDeleteWebhook.Execute();
            // PixDetailWebhook.Execute();
            // PixListWebhook.Execute();
            

        }
    }
}
