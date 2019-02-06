using System;

namespace EduHub.Data.WriteBack.Entities
{
    /// <summary>
    /// Half-Day Attendance
    /// </summary>
    public sealed class ATT_HALF_DAY : WriteBackEntity
    {
        internal ATT_HALF_DAY(WriteBackContext Context, string StudentId, DateTime AbsenceDate, string YearLevel, string AmCode, string PmCode)
            : base(Context)
        {
            this.StudentId = StudentId ?? throw new ArgumentNullException(nameof(StudentId));
            this.AbsenceDate = AbsenceDate;
            this.YearLevel = YearLevel ?? throw new ArgumentNullException(nameof(YearLevel));
            this.AmCode = AmCode ?? throw new ArgumentNullException(nameof(AmCode));
            this.PmCode = PmCode ?? throw new ArgumentNullException(nameof(PmCode));
        }

        /// <summary>
        /// Student ID, must be a valid student Id in CASES21
        /// </summary>
        public string StudentId { get; }

        /// <summary>
        /// The date of the absence
        /// </summary>
        public DateTime AbsenceDate { get; }

        /// <summary>
        /// The year level code as defined in CASES21.
        /// This represents the year level of the student as at the date of the absence.
        /// Valid year levels for a particular school are stored in KCY
        /// </summary>
        public string YearLevel { get; }

        /// <summary>
        /// The absence/attendance code for the student for AM. 
        /// Valid CASES21 absence codes can be found in the table KCT.
        /// </summary>
        public string AmCode { get; }

        /// <summary>
        /// The absence/attendance code for the student for PM. 
        /// Valid CASES21 absence codes can be found in the table KCT.
        /// </summary>
        public string PmCode { get; }

        public override string ToString()
        {
            return $"{StudentId},{AbsenceDate.ToString("yyyyMMdd")},{YearLevel},{AmCode},{PmCode}";
        }
    }
}
