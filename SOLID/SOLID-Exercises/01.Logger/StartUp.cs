using _01.LoggerProblem.Core.IO;
using _01.LoggerProblem.Entities.Layout.Factory;
using _01.LoggerProblem.Entities.Appenders.Factory;
using _01.LoggerProblem.Core;

namespace _01.LoggerProblem
{
    public class StartUp
    {
        public static void Main()
        {
            var reader = new Reader();
            var writer = new Writer();

            var layoutFactory = new LayoutFactory();
            var appenderFactory = new AppenderFactory();

            var controller = new Controller(layoutFactory, appenderFactory);
            var engine = new Engine(reader, writer, controller);

            engine.Run();
        }
    }
}
