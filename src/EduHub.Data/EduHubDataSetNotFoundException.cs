using System.IO;

namespace EduHub.Data
{
    public class EduHubDataSetNotFoundException : FileNotFoundException
    {
        public EduHubDataSetNotFoundException(string DataSet, string fileName)
            : base($"CSV Data Set not found for [{DataSet}]", fileName)
        {
        }
    }
}
