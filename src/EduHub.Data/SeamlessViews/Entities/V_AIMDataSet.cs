using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// AIM Data Set
    /// </summary>
    public class V_AIMDataSet : SeamlessViewsDataSetBase<V_AIM>
    {

        internal V_AIMDataSet(SeamlessViewsContext Context)
            : base(Context)
        { }

        /// <inheritdoc />
        protected override List<V_AIM> Load()
        {
            return Context.EduHubContext
                .ST
                .Where(st => st.STATUS == "ACTV" || st.STATUS == "INAC" || st.STATUS == "LVNG")
                .Select(st => new V_AIM(st))
                .ToList();
        }

        /// <summary>
        /// Writes the AIM Data Set in the format expected by On Demand Testing
        /// </summary>
        /// <param name="Filename">Location to Output File</param>
        public void WriteToOnDemandImport(string Filename)
        {
            using (var stream = new FileStream(Filename, FileMode.Create, FileAccess.Write))
            {
                using (var writer = new StreamWriter(stream))
                {
                    foreach (var entity in this)
                    {
                        writer.Write(entity.student_code);
                        writer.Write(',');
                        writer.Write(entity.first_name);
                        writer.Write(',');
                        writer.Write(entity.middle_name);
                        writer.Write(',');
                        writer.Write(entity.surname);
                        writer.Write(',');
                        writer.Write(entity.gender);
                        writer.Write(',');
                        writer.Write(entity.date_of_birth);
                        writer.Write(',');
                        writer.Write(entity.LBOTE);
                        writer.Write(',');
                        writer.Write(entity.ATSI);
                        writer.Write(',');
                        writer.Write(entity.disability_status);
                        writer.Write(',');
                        writer.Write(entity.EMA);
                        writer.Write(',');
                        writer.Write(entity.ESL);
                        writer.Write(',');
                        writer.Write(entity.home_group);
                        writer.Write(',');
                        writer.WriteLine(entity.year_level);
                    }
                }
            }
        }
    }
}
