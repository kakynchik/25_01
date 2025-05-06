namespace _25_01;

public abstract class SupportHandler
{
    protected SupportHandler nextHandler;

    public void SetNextHandler(SupportHandler handler)
    {
        nextHandler = handler;
    }

    public abstract void HandleRequest(string request);
}

public class TechnicalSupportHandler : SupportHandler
{
    public override void HandleRequest(string request)
    {
        if (request == "Technical")
        {
            Console.WriteLine("Technical support is handling the request.");
        }
        else if (nextHandler != null)
        {
            nextHandler.HandleRequest(request);
        }
    }
}

public class PaymentSupportHandler : SupportHandler
{
    public override void HandleRequest(string request)
    {
        if (request == "Payment")
        {
            Console.WriteLine("Payment support is handling the request.");
        }
        else if (nextHandler != null)
        {
            nextHandler.HandleRequest(request);
        }
    }
}

public class OtherSupportHandler : SupportHandler
{
    public override void HandleRequest(string request)
    {
        if (request == "Other")
        {
            Console.WriteLine("Other support is handling the request.");
        }
        else if (nextHandler != null)
        {
            nextHandler.HandleRequest(request);
        }
    }
}