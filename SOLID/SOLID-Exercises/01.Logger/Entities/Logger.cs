﻿using _01.LoggerProblem.Enums;
using _01.LoggerProblem.Interfaces;
using System;
using System.Text;

namespace _01.LoggerProblem.Entities
{
    public class Logger : ILogger
    {
        private IAppender[] appenders;

        public Logger(params IAppender[] appenders)
        {
            this.appenders = appenders;
        }

        private void Log(string timeStamp, string reportLevel, string message)
        {
            foreach (var appender in this.appenders)
            {
                var currentReportLevel = (ReportLevel)Enum.Parse(typeof(ReportLevel), reportLevel);

                if (appender.ReportLevel <= currentReportLevel)
                {
                    appender.Append(timeStamp, reportLevel, message);
                }            
            }
        }

        public void Error(string timeStamp, string message)
        {
            this.Log(timeStamp, "Error", message);
        }

        public void Info(string timeStamp, string message)
        {
            this.Log(timeStamp, "Info", message);
        }

        public void Fatal(string timeStamp, string message)
        {
            this.Log(timeStamp, "Fatal", message);
        }

        public void Critical(string timeStamp, string message)
        {
            this.Log(timeStamp, "Critical", message);
        }

        public void Warning(string timeStamp, string message)
        {
            this.Log(timeStamp, "Warning", message);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("Logger info");
            foreach (var appender in this.appenders)
            {
                sb.AppendLine(appender.ToString());
            }

            return sb.ToString();
        }
    }
}
