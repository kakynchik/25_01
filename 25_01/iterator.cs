using System.Collections;

namespace _25_01;

public class RequestCollection : IEnumerable
{
    private string[] requests;

    public RequestCollection(string[] requests)
    {
        this.requests = requests;
    }
    
    public IEnumerator GetEnumerator()
    {
        return new RequestIterator(requests);
    }
}

public class RequestIterator : IEnumerator
{
    private readonly string[] requests;
    private int position = -1;

    public RequestIterator(string[] requests)
    {
        this.requests = requests;
    }
    
    public bool MoveNext()
    {
        position++;
        return (position < requests.Length);
    }
    
    public void Reset()
    {
        position = -1;
    }
    
    public object Current => requests[position];
}