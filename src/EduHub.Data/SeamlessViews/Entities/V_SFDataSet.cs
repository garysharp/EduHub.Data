using EduHub.Data.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Staff Data Set
    /// </summary>
    public class V_SFDataSet : SeamlessViewsDataSet<V_SF>
    {
        /// <inheritdoc />
        public override string Name { get { return "V_SF"; } }

        internal V_SFDataSet(SeamlessViewsContext Context)
            : base(Context)
        { }

        /// <inheritdoc />
        public override IEnumerable<IEduHubDataSet> GetRequiredDataSets()
        {
            yield return Context.EduHubContext.SF;
        }

        /// <inheritdoc />
        protected override List<V_SF> Load()
        {
            return Context.EduHubContext
                .SF
                .Select(sf => new V_SF(Context, sf))
                .ToList();
        }

        /// <inheritdoc />
        protected override string GetCreateViewSql(string ParentDatabaseName)
        {
            return $@"
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[V_SF]') AND OBJECTPROPERTY(id, N'IsView') = 1)
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [V_SF]
AS
SELECT
    SF.SFKEY,
    SF.SURNAME,
    SF.FIRST_NAME,
    SF.SECOND_NAME,
    SF.PREF_NAME,
    SF.TITLE,
    SF.FACULTY01,
    SF.FACULTY02,
    SF.FACULTY03,
    SF.FACULTY04,
    SF.SUBJECT01,
    SF.SUBJECT02,
    SF.SUBJECT03,
    SF.SUBJECT04,
    SF.SUBJECT05,
    SF.SUBJECT06,
    SF.SUBJECT07,
    SF.SUBJECT08,
    SF.SUBJECT09,
    SF.SUBJECT10,
    SF.FTE,
    SF.MAJORA,
    SF.MAJORB,
    SF.MAJORC,
    SF.PAYROLL_CLASS,
    SF.PAYROLL_REC_NO
FROM {ParentDatabaseName}..SF SF';";
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
                        writer.WriteLine("SFKEY,SURNAME,FIRST_NAME,SECOND_NAME,PREF_NAME,TITLE,FACULTY01,FACULTY02,FACULTY03,FACULTY04,SUBJECT01,SUBJECT02,SUBJECT03,SUBJECT04,SUBJECT05,SUBJECT06,SUBJECT07,SUBJECT08,SUBJECT09,SUBJECT10,FTE,MAJORA,MAJORB,MAJORC,PAYROLL_CLASS,PAYROLL_REC_NO");
                    }

                    foreach (var entity in this)
                    {
                        writer.Write('"');
                        writer.Write(entity.SFKEY);
                        writer.Write("\",\"");
                        writer.Write(entity.SURNAME);
                        writer.Write("\",\"");
                        writer.Write(entity.FIRST_NAME);
                        writer.Write("\",\"");
                        writer.Write(entity.SECOND_NAME);
                        writer.Write("\",\"");
                        writer.Write(entity.PREF_NAME);
                        writer.Write("\",\"");
                        writer.Write(entity.TITLE);
                        writer.Write("\",\"");
                        writer.Write(entity.FACULTY01);
                        writer.Write("\",\"");
                        writer.Write(entity.FACULTY02);
                        writer.Write("\",\"");
                        writer.Write(entity.FACULTY03);
                        writer.Write("\",\"");
                        writer.Write(entity.FACULTY04);
                        writer.Write("\",\"");
                        writer.Write(entity.SUBJECT01);
                        writer.Write("\",\"");
                        writer.Write(entity.SUBJECT02);
                        writer.Write("\",\"");
                        writer.Write(entity.SUBJECT03);
                        writer.Write("\",\"");
                        writer.Write(entity.SUBJECT04);
                        writer.Write("\",\"");
                        writer.Write(entity.SUBJECT05);
                        writer.Write("\",\"");
                        writer.Write(entity.SUBJECT06);
                        writer.Write("\",\"");
                        writer.Write(entity.SUBJECT07);
                        writer.Write("\",\"");
                        writer.Write(entity.SUBJECT08);
                        writer.Write("\",\"");
                        writer.Write(entity.SUBJECT09);
                        writer.Write("\",\"");
                        writer.Write(entity.SUBJECT10);
                        writer.Write("\",");
                        writer.Write(entity.FTE);
                        writer.Write(",\"");
                        writer.Write(entity.MAJORA);
                        writer.Write("\",\"");
                        writer.Write(entity.MAJORB);
                        writer.Write("\",\"");
                        writer.Write(entity.MAJORC);
                        writer.Write("\",\"");
                        writer.Write(entity.PAYROLL_CLASS);
                        writer.Write("\",\"");
                        writer.Write(entity.PAYROLL_REC_NO);
                        writer.WriteLine('"');
                    }
                }
            }
        }
    }
}
