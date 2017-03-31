namespace Bot.Messenger.Models
{
    public enum WebhookEventType
    {
        UnIdentifiedCallback,
        MessageReceivedCallback,
        MessageDeliveredCallback,
        MessageReadCallback,
        MessageEchoCallback,
        PostbackRecievedCallback,
        PluginOptinCallback,
        ReferralCallback,
        PaymentCallback,
        CheckoutUpdateCallback,
        PreCheckoutCallback,
        AccountLinkingCallback
    }
}