using _01.LoggerProblem.Entities;
using _01.LoggerProblem.Entities.Appenders.Factory;
using _01.LoggerProblem.Entities.Layout.Factory;
using _01.LoggerProblem.Enums;
using _01.LoggerProblem.Interfaces;
using System;
using System.Globalization;

namespace _01.LoggerProblem.Core
{
    public class Controller
    {
        private LayoutFactory layoutFactory;
        private AppenderFactory appenderFactory;
        private ILogger logger;

        public Controller(LayoutFactory layoutFactory, AppenderFactory appenderFactory)
        {
            this.layoutFactory = layoutFactory;
            this.appenderFactory = appenderFactory;
        }

        private IAppender[] ReadAllAppenders(IReader reader)
        {
            var appenderCount = int.Parse(reader.ReadLine());
            var appenders = new IAppender[appenderCount];

            for (int i = 0; i < appenderCount; i++)
            {
                var appenderTokens = reader.ReadLine().Split();
                var appenderType = appenderTokens[0];
                var layoutType = appenderTokens[1];

                var layout = this.layoutFactory.CreateLayout(layoutType);
                var appender = this.appenderFactory.CreateAppender(appenderType, layout);

                if (appenderTokens.Length > 2)
                {
                    var reportLevelName = ConvertToTitleCase(appenderTokens[2]);
                    var reportLevel = (ReportLevel)Enum.Parse(typeof(ReportLevel), reportLevelName);
                    appender.ReportLevel = reportLevel;
                }

                appenders[i] = appender;
            }

            return appenders;
        }

        private string ConvertToTitleCase(string text)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
        }

        public void InitilizeLogger(IReader reader)
        {
            var appenders = this.ReadAllAppenders(reader);
            this.logger = new Logger(appenders);
        }

        public void SendMessageToLogger(string message)
        {
            var tokens = message.Split('|');
            var methodName = this.ConvertToTitleCase(tokens[0]);
            var currentMethod = typeof(Logger).GetMethod(methodName);
            currentMethod.Invoke(this.logger, new object[] { tokens[1], tokens[2] });
        }

        public string GetLoggerInfo()
        {
            return this.logger.ToString();
        }
    }
}
