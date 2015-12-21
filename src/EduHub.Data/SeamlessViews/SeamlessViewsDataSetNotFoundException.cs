namespace EduHub.Data.SeamlessViews
{
    /// <summary>
    /// The exception that is thrown when an attempt to access a Seamless View which depends on an EduHub data set that does not exist in the EduHub Data Directory.
    /// </summary>
    public class SeamlessViewsDataSetNotFoundException : EduHubDataSetNotFoundException
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SeamlessViewsDataSetNotFoundException"/> class
        ///     indicating the missing Data Set and specifying the file name that cannot be found.
        /// </summary>
        /// <param name="SeamlessView">Name of the Seamless View</param>
        /// <param name="DataSet">Name of the Data Set not found</param>
        /// <param name="fileName">Full file name of the expected location of the Data Set</param>
        public SeamlessViewsDataSetNotFoundException(string SeamlessView, string DataSet, string fileName)
            : base($"CSV Data Set not found for [{DataSet}] when loading [{SeamlessView}] Seamless View", fileName)
        {
        }
    }
}
