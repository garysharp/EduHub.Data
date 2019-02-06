using System;

namespace EduHub.Data.WriteBack.Entities
{
    /// <summary>
    /// Half-Day Attendance Writer
    /// </summary>
    public interface IATT_HALF_DAYWriter : IWriteBackWriter<ATT_HALF_DAY>
    {
        /// <summary>
        /// Writes a Half-Day Attendance Entity to the write-back dataset
        /// </summary>
        /// <param name="StudentId">Student ID, must be a valid student Id in CASES21</param>
        /// <param name="AbsenceDate">The date of the absence</param>
        /// <param name="YearLevel">The year level code as defined in CASES21.</param>
        /// <param name="AmCode">The absence/attendance code for the student for AM.</param>
        /// <param name="PmCode">The absence/attendance code for the student for PM.</param>
        void Write(string StudentId, DateTime AbsenceDate, string YearLevel, string AmCode, string PmCode);
    }
}
