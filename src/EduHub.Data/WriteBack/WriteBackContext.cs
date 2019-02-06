using EduHub.Data.WriteBack.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace EduHub.Data.WriteBack
{
    /// <summary>
    /// Write-Back Context
    /// </summary>
    public class WriteBackContext
    {
        internal WriteBackContext(EduHubContext EduHubContext)
        {
            this.EduHubContext = EduHubContext;
            WriteBackDirectory = Path.Combine(EduHubContext.EduHubDirectory, @"write-back");
            WriteBackResponsesDirectory = Path.Combine(EduHubContext.EduHubDirectory, @"write-back\responses");

            ATT_HALF_DAY = new ATT_HALF_DAYDataSet(this);
        }

        /// <summary>
        /// eduHub Context
        /// </summary>
        public EduHubContext EduHubContext { get; }

        /// <summary>
        /// eduHub Write-back directory
        /// </summary>
        public string WriteBackDirectory { get; }

        /// <summary>
        /// eduHub Write-back responses directory
        /// </summary>
        public string WriteBackResponsesDirectory { get; }

        /// <summary>
        /// Half-Day Attendance Data Set
        /// </summary>
        public ATT_HALF_DAYDataSet ATT_HALF_DAY { get; }

        /// <summary>
        /// All Write-Back Data Sets
        /// </summary>
        public IEnumerable<IWriteBackDataSet> GetDataSets()
        {
            yield return ATT_HALF_DAY;
        }

        /// <summary>
        /// Names of all Write-Back Data Sets
        /// </summary>
        public IEnumerable<string> GetDataSetNames()
        {
            foreach (var dataSet in GetDataSets())
                yield return dataSet.Name;
        }

        /// <summary>
        /// Retrieves a Write-Back Data Set by Name
        /// </summary>
        /// <param name="Name">Name of the Seamless Views Data Set</param>
        public IWriteBackDataSet GetDataSet(string Name)
        {
            foreach (var dataSet in GetDataSets())
                if (dataSet.Name.Equals(Name, StringComparison.OrdinalIgnoreCase))
                    return dataSet;

            throw new ArgumentException($"Unknown Write-Back Data Set [{Name}]", nameof(Name));
        }

        /// <summary>
        /// Present Data Sets
        /// </summary>
        public IEnumerable<IWriteBackDataSet> GetPresentDataSets()
        {
            foreach (var dataSet in GetDataSets())
                if (dataSet.IsPresent)
                    yield return dataSet;
        }

        /// <summary>
        /// Names of Present Data Sets
        /// </summary>
        public IEnumerable<string> GetPresentDataSetNames()
        {
            foreach (var dataSet in GetPresentDataSets())
                yield return dataSet.Name;
        }
    }
}
