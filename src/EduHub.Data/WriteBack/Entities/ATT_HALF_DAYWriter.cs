using System;

namespace EduHub.Data.WriteBack.Entities
{
    internal class ATT_HALF_DAYWriter : WriteBackCsvWriter<ATT_HALF_DAY>, IATT_HALF_DAYWriter
    {
        private readonly string schoolName;
        private readonly DateTime fromDate;
        private readonly DateTime toDate;

        public ATT_HALF_DAYWriter(WriteBackContext Context, WriteBackDataSet<ATT_HALF_DAY> DataSet, string SchoolName, DateTime FromDate, DateTime ToDate)
            : base(Context, DataSet, new string[] {
                SchoolName,
                FromDate.ToString("yyyyMMdd"),
                ToDate.ToString("yyyyMMdd"),
                string.Empty,
                string.Empty,
            })
        {
            schoolName = SchoolName;
            fromDate = FromDate;
            toDate = ToDate;
        }

        public override void Write(ATT_HALF_DAY Entity)
        {
            CsvWriter.Write(Entity.StudentId);
            CsvWriter.Write(Entity.AbsenceDate.ToString("yyyyMMdd"));
            CsvWriter.Write(Entity.YearLevel);
            CsvWriter.Write(Entity.AmCode);
            CsvWriter.Write(Entity.PmCode);
            CsvWriter.WriteEndOfRecord();
        }

        public void Write(string StudentId, DateTime AbsenceDate, string YearLevel, string AmCode, string PmCode)
        {
            Write(new ATT_HALF_DAY(Context, StudentId, AbsenceDate, YearLevel, AmCode, PmCode));
        }
    }
}
