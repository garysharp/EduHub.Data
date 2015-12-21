using EduHub.Data.Entities;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Subjects
    /// </summary>
    public class V_SU : SeamlessViewsEntity
    {
        #region Backing Fields

        private readonly string _SUKEY;
        private readonly string _SHORTNAME;
        private readonly string _FULLNAME;
        private readonly string _OVERVIEW;
        private readonly string _FACULTY;
        private readonly short? _SEMESTER;
        private readonly string _SUBJECT_ACADEMIC_YEAR;
        private readonly string _DESCRIPTION;

        #endregion

        internal V_SU(SeamlessViewsContext Context, SU SU)
            : base(Context)
        {
            var KCY = SU.SUBJECT_ACADEMIC_YEAR_KCY;

            _SUKEY = SU.SUKEY;
            _SHORTNAME = SU.SHORTNAME;
            _FULLNAME = SU.FULLNAME;
            _OVERVIEW = SU.OVERVIEW;
            _FACULTY = SU.FACULTY;
            _SEMESTER = SU.SEMESTER;
            _SUBJECT_ACADEMIC_YEAR = SU.SUBJECT_ACADEMIC_YEAR;
            _DESCRIPTION = KCY.DESCRIPTION;
        }

        /// <summary>
        /// Subject code
        /// </summary>
        public string SUKEY { get { return _SUKEY; } }
        /// <summary>
        /// Subject short name for screen displays and reports
        /// </summary>
        public string SHORTNAME { get { return _SHORTNAME; } }
        /// <summary>
        /// Subject name
        /// </summary>
        public string FULLNAME { get { return _FULLNAME; } }
        /// <summary>
        /// Description of subject for parents
        /// </summary>
        public string OVERVIEW { get { return _OVERVIEW; } }
        /// <summary>
        /// Faculty
        /// </summary>
        public string FACULTY { get { return _FACULTY; } }
        /// <summary>
        /// Semester/term/quarter in which offered: if 0 or matches the value in a TT record, the subject is eligible for that template
        /// </summary>
        public short? SEMESTER { get { return _SEMESTER; } }
        /// <summary>
        /// Offered to students at this year level: if blank or matches one of the values in a TT record, the subject is eligible for that template
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR { get { return _SUBJECT_ACADEMIC_YEAR; } }
        /// <summary>
        /// Year level title
        /// </summary>
        public string DESCRIPTION { get { return _DESCRIPTION; } }
    }
}
