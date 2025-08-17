using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IAppLogger<T>
    {
        /// <summary>
        /// Log an informational message.
        /// </summary>
        /// <param name="message"></param>
        void AddInfo(string message);
        /// <summary>
        /// Log a warning message.
        /// </summary>
        /// <param name="message"></param>
        void AddWarning(string message);
        /// <summary>
        /// Log an error message with an exception.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        void AddError(string message, Exception ex);
        /// <summary>
        /// Log an error message without an exception.
        /// </summary>
        /// <param name="message"></param>
        void AddError(string message);

    }
}
