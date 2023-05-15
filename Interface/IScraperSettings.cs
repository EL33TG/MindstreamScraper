using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindstreamScraper
{
    public interface IScraperSettings
    {
        string FullPath { get; }

        /// <summary>
        /// Removes the specified URL from Exclusion list
        /// </summary>
        /// <param name="exclude">URL to exclude</param>
        void RemoveURLFromList(string exclude);

        /// <summary>
        /// Adds the specified URL to the exclusion list
        /// </summary>
        /// <param name="exclude">URL to add</param>
        void AddURLToList(string exclude);

        /// <summary>
        /// Checks if the specified URL already exists in the exclusion list
        /// </summary>
        /// <param name="exist">URL to check</param>
        /// <returns></returns>
        bool ExclusionListCheck(string exist);

    }
}
