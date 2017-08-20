using _01.LoggerProblem.Interfaces;
using System.Text;

namespace _01.LoggerProblem.Entities.Layout
{
    public class XmlLayout : ILayout
    {
        public string FormatMessage(string timeStamp, string reportLevel, string message)
        {
            var msg = new StringBuilder();

            msg.AppendLine($"<log>");
            msg.AppendLine($"   <date>{timeStamp}</date>");
            msg.AppendLine($"   <level>{reportLevel}</level>");
            msg.AppendLine($"   <message{message}</message>");
            msg.Append($"</log>");

            return msg.ToString();
        }
    }
}
