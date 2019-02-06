using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace EduHub.Data.WriteBack.Entities
{
    /// <summary>
    /// Half-Day Attendance
    /// </summary>
    public class ATT_HALF_DAYDataSet : WriteBackDataSet<ATT_HALF_DAY>
    {
        private readonly Lazy<Tuple<string, DateTime, DateTime, List<ATT_HALF_DAY>>> cache;
        private readonly Lazy<string> schoolName;
        private readonly Lazy<DateTime> fromDate;
        private readonly Lazy<DateTime> toDate;

        internal ATT_HALF_DAYDataSet(WriteBackContext Context)
            : base(Context)
        {
            cache = new Lazy<Tuple<string, DateTime, DateTime, List<ATT_HALF_DAY>>>(LoadCache);

            schoolName = new Lazy<string>(() => cache.Value.Item1);
            fromDate = new Lazy<DateTime>(() => cache.Value.Item2);
            toDate = new Lazy<DateTime>(() => cache.Value.Item3);
        }

        /// <inheritdoc />
        public override string Name => "ATT-HALF-DAY";

        /// <inheritdoc />
        public override string Description => "Half-Day Attendance";

        /// <summary>
        /// Creates a Half-Day Attendance Entity
        /// </summary>
        /// <param name="StudentId">Student ID, must be a valid student Id in CASES21</param>
        /// <param name="AbsenceDate">The date of the absence</param>
        /// <param name="YearLevel">The year level code as defined in CASES21.</param>
        /// <param name="AmCode">The absence/attendance code for the student for AM.</param>
        /// <param name="PmCode">The absence/attendance code for the student for PM.</param>
        /// <returns></returns>
        public ATT_HALF_DAY CreateEntity(string StudentId, DateTime AbsenceDate, string YearLevel, string AmCode, string PmCode)
        {
            return new ATT_HALF_DAY(Context, StudentId, AbsenceDate, YearLevel, AmCode, PmCode);
        }

        /// <summary>
        /// Allows creation of a half-day attendance write-back file
        /// </summary>
        /// <param name="FromDate">From date for attendance date range</param>
        /// <param name="ToDate">To date for attendance date range</param>
        /// <returns></returns>
        public IATT_HALF_DAYWriter CreateWriteBack(DateTime FromDate, DateTime ToDate)
        {
            var schoolName = Context.EduHubContext.SCI.ADMIN_SITE.SCHOOL_NAME;
            return new ATT_HALF_DAYWriter(Context, this, schoolName, FromDate, ToDate);
        }

        /// <inheritdoc />
        protected override List<ATT_HALF_DAY> Load() => cache.Value.Item4;

        private Tuple<string, DateTime, DateTime, List<ATT_HALF_DAY>> LoadCache()
        {
            if (!IsPresent)
                throw new EduHubDataSetNotFoundException(Name, Filename);

            // Copy to memory stream (don't directly process eduHub files)
            using (var stream = new MemoryStream())
            {
                using (var fileStream = new FileStream(Filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    fileStream.CopyTo(stream);
                stream.Position = 0;

                // Initialize Csv Reader
                using (var reader = new CsvReader(stream))
                {
                    var items = new List<ATT_HALF_DAY>();

                    foreach (var item in reader.ReadRecords())
                    {
                        items.Add(CreateEntity(
                            StudentId: item[0],
                            AbsenceDate: DateTime.ParseExact(item[1], "yyyyMMdd", CultureInfo.InvariantCulture),
                            YearLevel: item[2],
                            AmCode: item[3],
                            PmCode: item[4]));
                    }

                    return Tuple.Create(
                        reader.Header[0],
                        DateTime.ParseExact(reader.Header[1], "yyyyMMdd", CultureInfo.InvariantCulture),
                        DateTime.ParseExact(reader.Header[1], "yyyyMMdd", CultureInfo.InvariantCulture),
                        items);
                }
            }
        }

    }
}
