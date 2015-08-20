using System.IO;

namespace EduHub.Data
{
    /// <summary>
    /// The exception that is thrown when an attempt to access an EduHub data set that does not exist in the EduHub Data Directory.
    /// </summary>
    public class EduHubDataSetNotFoundException : FileNotFoundException
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="EduHubDataSetNotFoundException"/> class
        ///     indicating the missing Data Set and specifying the file name that cannot be found.
        /// </summary>
        /// <param name="DataSet">Name of the Data Set not found</param>
        /// <param name="fileName">Full file name of the expected location of the Data Set</param>
        public EduHubDataSetNotFoundException(string DataSet, string fileName)
            : base($"CSV Data Set not found for [{DataSet}]", fileName)
        {
        }
    }
}
