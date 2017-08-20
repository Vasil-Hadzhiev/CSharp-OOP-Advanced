using _01.LoggerProblem.Interfaces;
using System;
using System.Linq;
using System.Reflection;

namespace _01.LoggerProblem.Entities.Appenders.Factory
{
    public class AppenderFactory
    {
        public IAppender CreateAppender(string appenderName, ILayout layout)
        {
            var appenderType = Assembly.
                GetExecutingAssembly().
                GetTypes().
                FirstOrDefault(t => t.Name == appenderName);

            var appenderInstance = (IAppender)Activator.CreateInstance(appenderType, layout);

            return appenderInstance;
        }
    }
}
