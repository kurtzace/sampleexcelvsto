// Author:Gokuldas Chandgadkar
// Last Update: 15/12/2013

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DemoCustomActionPaneAndRibbon.Utilities
{
    /// <summary>
    /// LogLevel
    /// </summary>
    public enum LogLevel
    { 
        DEBUG =1,
        INFORMATION,
        WARNING,
        ERROR,
        FATAL
       
    }

    /// <summary>
    /// Class which Implements llght weight logging functionality.
    /// Aim is to demonstrate Singleton design pattern.
    /// </summary>
    public class Logger
    {
        private static readonly Logger _instance = new Logger();
        private string _logFilePath = string.Empty;
        private const long MAX_FILESIZE = 5000 * 1000;
        private const string CATEGORY = "DemoCustomActionPaneAndRibbon";
        private Logger() {

            InitLogFilePath();
            this.CurrentLogLevel = LogLevel.DEBUG;
            this.IsEnabled = true;
        }

        public LogLevel CurrentLogLevel { get; set; }
        public bool IsEnabled { get; set; }
        private void InitLogFilePath()
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+ @"\NorthWind\Logs\";
            filePath += string.Format("NorthWind_log_{0}_{1}_{2}_{3}_{4}.csv", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year, DateTime.Now.Hour, DateTime.Now.Minute);
            _logFilePath = filePath;
        }

        public static Logger Log
        {
            get {
                return _instance;
            }

        }

        public void Debug(string message, string category = CATEGORY) {

            if ((this.CurrentLogLevel <= LogLevel.DEBUG) &&( this.IsEnabled))
            {

                SaveToLogFile(category, message,LogLevel.DEBUG);
            }

        }
        public void Warn(string message, string category = CATEGORY) {

            if ((this.CurrentLogLevel <= LogLevel.WARNING) &&( this.IsEnabled))
            {

                SaveToLogFile(category, message,LogLevel.WARNING);
            }

        }

        public void Information(string message, string category = CATEGORY) {

            if ((this.CurrentLogLevel <= LogLevel.INFORMATION) &&( this.IsEnabled))
            {

                SaveToLogFile(category, message,LogLevel.INFORMATION);
            }

        }

        public void Error(string message, string category = CATEGORY) {

            if ((this.CurrentLogLevel <= LogLevel.ERROR) &&( this.IsEnabled))
            {

                SaveToLogFile(category, message,LogLevel.ERROR);
            }

        }

        public void Fatal(string message, string category = CATEGORY) {

            if ((this.CurrentLogLevel <= LogLevel.FATAL) &&( this.IsEnabled))
            {

                SaveToLogFile(category, message,LogLevel.FATAL);
            }

        }




        /// <summary>
        /// Method: SaveToLogFile
        /// Purpose:Logs message in flat file.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="message"></param>
        /// <param name="curLevel"></param>
        private void SaveToLogFile(string category, string message, LogLevel curLevel)
        {
            try
            {
                if (_logFilePath.Length > MAX_FILESIZE)
                {
                    InitLogFilePath();
                }
                using (StreamWriter sw = new StreamWriter(_logFilePath,true))
                {
                    sw.WriteLine(string.Format("{0}-{1}\t{2}\t{3}\t{4}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(),category, curLevel, message));
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
