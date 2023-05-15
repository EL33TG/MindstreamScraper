using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindstreamScraper
{
    public interface ILogHouseKeeping
    {
        /// <summary>
        /// Automatically diplays Try/Catch Exception generated during runt-time.
        /// </summary>
        /// <param name="e">The value where the mesasge lives</param>
        void ExceptionLog(Exception e);
       
        /// <summary>
        /// Accepts a String input to be displayed in your custom log file.
        /// </summary>
        /// <param name="errorMessage">The String value that represents the error message to write to file.</param>
        void CustomLog(String errorMessage);
    }
}
