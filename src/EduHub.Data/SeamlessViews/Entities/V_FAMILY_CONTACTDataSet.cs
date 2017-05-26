using EduHub.Data.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Family Contact Data Set
    /// </summary>
    public class V_FAMILY_CONTACTDataSet : SeamlessViewsDataSet<V_FAMILY_CONTACT>
    {
        /// <inheritdoc />
        public override string Name { get { return "V_FAMILY_CONTACT"; } }

        internal V_FAMILY_CONTACTDataSet(SeamlessViewsContext Context)
            : base(Context)
        { }

        /// <inheritdoc />
        public override IEnumerable<IEduHubDataSet> GetRequiredDataSets()
        {
            yield return Context.EduHubContext.DF;
            yield return Context.EduHubContext.UM;
        }

        /// <inheritdoc />
        protected override List<V_FAMILY_CONTACT> Load()
        {
            return Context.EduHubContext
                .DF
                .Select(df => new V_FAMILY_CONTACT(Context, df))
                .ToList();
        }

        /// <inheritdoc />
        protected override string GetCreateViewSql(string ParentDatabaseName)
        {
            return $@"
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[V_FAMILY_CONTACT]') AND OBJECTPROPERTY(id, N'IsView') = 1)
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [V_FAMILY_CONTACT]
AS
SELECT
    DF.DFKEY,
    UM.MOBILE,
    UM.TELEPHONE,
    DF.E_MAIL_A,
    DF.NAME_A,
    DF.SURNAME_A,
    DF.NAME_B,
    DF.SURNAME_B
FROM [{ParentDatabaseName}]..DF AS DF
LEFT JOIN [{ParentDatabaseName}]..UM UM ON UM.UMKEY = DF.HOMEKEY';";
        }

        /// <inheritdoc />
        public override void WriteToCsv(string Filename, bool IncludeHeader)
        {
            using (var stream = new FileStream(Filename, FileMode.Create, FileAccess.Write))
            {
                using (var writer = new StreamWriter(stream))
                {
                    if (IncludeHeader)
                    {
                        writer.WriteLine("DFKEY,MOBILE,TELEPHONE,E_MAIL_A,NAME_A,SURNAME_A,NAME_B,SURNAME_B");
                    }

                    foreach (var entity in this)
                    {
                        writer.Write('"');
                        writer.Write(entity.DFKEY);
                        writer.Write("\",\"");
                        writer.Write(entity.MOBILE);
                        writer.Write("\",\"");
                        writer.Write(entity.TELEPHONE);
                        writer.Write("\",\"");
                        writer.Write(entity.E_MAIL_A);
                        writer.Write("\",\"");
                        writer.Write(entity.NAME_A);
                        writer.Write("\",\"");
                        writer.Write(entity.SURNAME_A);
                        writer.Write("\",\"");
                        writer.Write(entity.NAME_B);
                        writer.Write("\",\"");
                        writer.Write(entity.SURNAME_B);
                        writer.WriteLine('"');
                    }
                }
            }
        }
    }
}
