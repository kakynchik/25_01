namespace _25_01;

class Program
{
    static void Main(string[] args)
    {
        var technicalHandler = new TechnicalSupportHandler();
        var paymentHandler = new PaymentSupportHandler();
        var otherHandler = new OtherSupportHandler();

        technicalHandler.SetNextHandler(paymentHandler);
        paymentHandler.SetNextHandler(otherHandler);
        
        string[] requests = { "Technical", "Payment", "Other", "Unknown" };

        var requestCollection = new RequestCollection(requests);
        
        foreach (string request in requestCollection)
        {
            var command = new SupportRequestCommand(technicalHandler, request);
            command.Execute();
        }
    }
}