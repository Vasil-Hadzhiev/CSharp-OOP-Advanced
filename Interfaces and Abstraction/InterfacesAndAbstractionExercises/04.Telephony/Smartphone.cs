using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Smartphone : ICallable, IBrowsable
{
    public Smartphone(ICollection<string> numbers, ICollection<string> urls)
    {
        this.Numbers = new List<string>(numbers);
        this.Urls = new List<string>(urls);
    }
    public ICollection<string> Numbers { get; }

    public ICollection<string> Urls { get; }

    public string Browse(string url)
    {
        return url.Any(char.IsDigit) ? $"Invalid URL!" : $"Browsing: {url}!";
    }

    public string Call(string number)
    {
        return !number.All(char.IsDigit) ? $"Invalid number!" : $"Calling... {number}";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        foreach (var number in this.Numbers)
        {
            sb.AppendLine(this.Call(number));
        }

        foreach (var url in this.Urls)
        {
            sb.AppendLine(this.Browse(url));
        }

        return sb.ToString();
    }
}

