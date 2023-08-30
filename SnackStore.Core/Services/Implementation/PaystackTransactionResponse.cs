namespace SnackStore.Core.Services.Implementation
{
    public class PaystackTransactionResponse
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public TransactionData Data { get; set; }
        public string Reference { get; set; }
    }
}