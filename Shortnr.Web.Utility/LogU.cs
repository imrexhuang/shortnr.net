using System;
using System.Collections.Generic;
using System.Text;
using log4net;
using log4net.Config;

// https://www.c-sharpcorner.com/article/use-log4net-in-asp-net-mvc-application/

namespace Shortnr.Web.Utility
{
    public class LogU
    {
        protected ILog monitoringLogger;
        protected static ILog debugLogger;

        public LogU(Type type)
        {
            monitoringLogger = LogManager.GetLogger(type);
            debugLogger = LogManager.GetLogger(type);
        }


        /// <summary>  
        /// Used to log Debug messages in an explicit Debug Logger  
        /// </summary>  
        /// <param name="message">The object message to log</param>  
        public void Debug(string message)
        {
            debugLogger.Debug(message);
        }


        /// <summary>  
        ///  
        /// </summary>  
        /// <param name="message">The object message to log</param>  
        /// <param name="exception">The exception to log, including its stack trace </param>  
        public void Debug(string message, System.Exception exception)
        {
            debugLogger.Debug(message, exception);
        }


        /// <summary>  
        ///  
        /// </summary>  
        /// <param name="message">The object message to log</param>  
        public void Info(string message)
        {
            monitoringLogger.Info(message);
        }


        /// <summary>  
        ///  
        /// </summary>  
        /// <param name="message">The object message to log</param>  
        /// <param name="exception">The exception to log, including its stack trace </param>  
        public void Info(string message, System.Exception exception)
        {
            monitoringLogger.Info(message, exception);
        }

        /// <summary>  
        ///  
        /// </summary>  
        /// <param name="message">The object message to log</param>  
        public void Warn(string message)
        {
            monitoringLogger.Warn(message);
        }

        /// <summary>  
        ///  
        /// </summary>  
        /// <param name="message">The object message to log</param>  
        /// <param name="exception">The exception to log, including its stack trace </param>  
        public void Warn(string message, System.Exception exception)
        {
            monitoringLogger.Warn(message, exception);
        }

        /// <summary>  
        ///  
        /// </summary>  
        /// <param name="message">The object message to log</param>  
        public void Error(string message)
        {
            monitoringLogger.Error(message);
        }

        /// <summary>  
        ///  
        /// </summary>  
        /// <param name="message">The object message to log</param>  
        /// <param name="exception">The exception to log, including its stack trace </param>  
        public void Error(string message, System.Exception exception)
        {
            monitoringLogger.Error(message, exception);
        }


        /// <summary>  
        ///  
        /// </summary>  
        /// <param name="message">The object message to log</param>  
        public void Fatal(string message)
        {
            monitoringLogger.Fatal(message);
        }

        /// <summary>  
        ///  
        /// </summary>  
        /// <param name="message">The object message to log</param>  
        /// <param name="exception">The exception to log, including its stack trace </param>  
        public void Fatal(string message, System.Exception exception)
        {
            monitoringLogger.Fatal(message, exception);
        }

    }
}
