namespace _25_01;

public interface ICommand
{
    void Execute();
}

public class SupportRequestCommand : ICommand
{
    private SupportHandler handler;
    private string request;

    public SupportRequestCommand(SupportHandler handler, string request)
    {
        this.handler = handler;
        this.request = request;
    }

    public void Execute()
    {
        handler.HandleRequest(request);
    }
}