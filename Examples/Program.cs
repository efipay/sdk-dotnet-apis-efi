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
            // ListBillets.Execute();
            // SendBilletEmail.Execute();
            // SettleBillet.Execute();
            // UpdateBillet.Execute();
            // UpdateBilletMetadata.Execute();

            /* CHARGES - CARD */
            // CancelCard.Execute();
            // CardPaymentRetry.Execute();
            // CreateCardHistory.Execute();
            // CreateChargeCard.Execute();
            // CreateOneStepCard.Execute();
            // DefineCardPayMethod.Execute();
            // DetailCard.Execute();
            // GetInstallments.Execute();
            // ListCards.Execute();
            // RefundCard.Execute();
            // UpdateCardMetadata.Execute();

            /* CHARGES - CARNETS */
            // CancelCarnet.Execute();
            // CancelCarnetParcel.Execute();
            // CreateCarnet.Execute();
            // CreateCarnetHistory.Execute();
            // DetailCarnet.Execute();
            // ListCarnets.Execute();
            // SendCarnetEmail.Execute();
            // SendCarnetParcelEmail.Execute();
            // SettleCarnet.Execute();
            // SettleCarnetParcel.Execute();
            // UpdateCarnetMetadata.Execute();
            // UpdateCarnetParcel.Execute();
            // UpdateCarnetParcels.Execute();

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
            // ListLinks.Execute();
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
            // ListSubscription.Execute();
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

            /* EXCLUSIVES - MED */
            // MedList.Execute();
            // MedDefense.Execute();

            /* EXCLUSIVES - REPORT */
            // CreateReport.Execute();
            // DetailReport.Execute();

            /* EXCLUSIVES - PIX */
            // PixGetReceipt.Execute();


            /* OPEN FINANCE - CONFIG */
            // OfConfigDetail.Execute();
            // OfConfigUpdate.Execute();

            /* OPEN FINANCE - PARTICIPANTS */
            // OfListParticipants.Execute();

            /* OPEN FINANCE - PAYMENTS - IMMEDIATE */
            // OfDevolutionPix.Execute();
            // OfListPixPayment.Execute();
            // OfStartPixPayment.Execute();

            /* OPEN FINANCE - PAYMENTS - RECURRENCY */
            // OfCancelRecurrencyPix.Execute();
            // OfDevolutionRecurrencyPix.Execute();
            // OfListRecurrencyPixPayment.Execute();
            // OfStartRecurrencyPixPayment.Execute();

            /* OPEN FINANCE - PAYMENTS - SCHEDULE */
            // OfCancelSchedulePix.Execute();
            // OfDevolutionSchedulePix.Execute();
            // OfListSchedulePixPayment.Execute();
            // OfStartSchedulePixPayment.Execute();

            /* OPEN FINANCE - PAYMENTS - BIOMETRIC */
            // OfCreateBiometricEnrollment.Execute();
            // OfListBiometricEnrollment.Execute();
            // OfRevokeBiometricEnrollment.Execute();
            // OfCreateBiometricPixPayment.Execute();
            // OfListBiometricPixPayment.Execute();

            /* OPEN FINANCE - PAYMENTS - AUTOMATIC */
            // OfCreateAutomaticEnrollment.Execute();
            // OfListAutomaticEnrollment.Execute();
            // OfUpdateAutomaticEnrollment.Execute();
            // OfCreateAutomaticPixPayment.Execute();
            // OfListAutomaticPixPayment.Execute();
            // OfCancelAutomaticPixPayment.Execute();


            /* PAYMENTS - BILLETS - PAYMENT*/
            // PayDetailBarCode.Execute();
            // PayRequestBarCode.Execute();
            // PayDetailPayment.Execute();
            // PayListPayments.Execute();

            /* PAYMENTS - BILLETS - WEBHOOKS*/
            // PayConfigWebhook.Execute();
            // PayDeleteWebhook.Execute();
            // PayListWebhook.Execute();

            /* PIX - BATCH - COBV */
            // PixCreateDueChargeBatch.Execute();
            // PixDetailDueChargeBatch.Execute();
            // PixListDueChargeBatch.Execute();
            // PixUpdateDueChargeBatch.Execute();


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


            /* PIX AUTOMATIC - REC */
            // PixDetailRecurrenceAutomatic.Execute();
            // PixUpdateRecurrenceAutomatic.Execute();
            // PixListRecurrenceAutomatic.Execute();
            // PixCreateRecurrenceAutomatic.Execute();

            /* PIX AUTOMATIC - SOLICREC */
            // PixCreateRequestRecurrenceAutomatic.Execute();
            // PixDetailRequestRecurrenceAutomatic.Execute();
            // PixUpdateRequestRecurrenceAutomatic.Execute();

            /* PIX AUTOMATIC - COBR */
            // PixCreateAutomaticChargeTxid.Execute();
            // PixUpdateAutomaticCharge.Execute();
            // PixDetailAutomaticCharge.Execute();
            // PixCreateAutomaticCharge.Execute();
            // PixListAutomaticCharge.Execute();
            // PixRetryRequestAutomatic.Execute();


            /* PIX - LOCATION */
            // PixCreateLocation.Execute();
            // PixDetailLocation.Execute();
            // PixGenerateQRCode.Execute();
            // PixLocationList.Execute();
            // PixUnlinkTxidLocation.Execute();

            /* PIX - LOCATION - REC */
            // PixCreateLocationRecurrenceAutomatic.Execute();
            // PixListLocationRecurrenceAutomatic.Execute();
            // PixDetailLocationRecurrenceAutomatic.Execute();
            // PixUnlinkLocationRecurrenceAutomatic.Execute();

            /* PIX - MANAGEMENT */
            // PixDetailDevolution.Execute();
            // PixDetailReceived.Execute();
            // PixDevolution.Execute();
            // PixReceivedList.Execute();

            /* PIX - PAYMENT */
            // PixQrCodeDetail.Execute();
            // PixQrCodePay.Execute();
            // PixSend.Execute();
            // PixSendSameOwnership.Execute();
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
            // PixResendWebhook.Execute();

            /* PIX - WEBHOOKS - AUTOMATIC */
            // PixConfigWebhookRecurrenceAutomatic.Execute();
            // PixListWebhookRecurrenceAutomatic.Execute();
            // PixDeleteWebhookRecurrenceAutomatic.Execute();
            // PixConfigWebhookAutomaticCharge.Execute();
            // PixListWebhookAutomaticCharge.Execute();
            // PixDeleteWebhookAutomaticCharge.Execute();


        }
    }
}
