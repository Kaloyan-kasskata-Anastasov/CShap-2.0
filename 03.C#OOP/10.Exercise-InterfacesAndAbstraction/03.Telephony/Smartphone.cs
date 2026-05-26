namespace Telephony;

public class Smartphone : StationaryPhone, IBrowsable
{
    public string Call(string number)
    {
        return $"Calling... {number}";
    }

    public string Browse(string url)
    {
        return $"Browsing: {url}!";
    }
}