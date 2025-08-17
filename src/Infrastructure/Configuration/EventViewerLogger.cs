using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;

namespace Infrastructure.Configuration
{
    public class EventViewerLogger<T> : IAppLogger<T>
    {
        #region Variables

        /// <summary>
        /// Add my implementation here
        /// </summary>
        public const string SOURCE_NAME = "DocumentManagerSource";
        public const string LOG_NAME = "DocumentManagerLog";
        private readonly string _sourceName;
        private readonly string _logName;

        #endregion

        #region Constructor
        public EventViewerLogger()
        {
            _sourceName = SOURCE_NAME;
            _logName = LOG_NAME;

            if (!EventLog.SourceExists(_sourceName))
                EventLog.CreateEventSource(_sourceName, _logName);
        }
        #endregion

        #region Methods
        public void AddInfo(string message)
        {
            EventLog.WriteEntry(_sourceName, message, EventLogEntryType.Information);
        }
        public void AddWarning(string message)
        {
            EventLog.WriteEntry(_sourceName, message, EventLogEntryType.Warning);
        }
        public void AddError(string message, Exception ex)
        {
            var fullMessage = $"{message}\nException: {ex.Message}\nStack Trace: {ex.StackTrace}";
            EventLog.WriteEntry(_sourceName, fullMessage, EventLogEntryType.Error);
        }
        public void AddError(string message)
        {
            EventLog.WriteEntry(_sourceName, message, EventLogEntryType.Error);

        }
        #endregion
    }
}
