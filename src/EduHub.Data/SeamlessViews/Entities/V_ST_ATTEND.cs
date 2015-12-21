using EduHub.Data.Entities;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Student Attendance
    /// </summary>
    public class V_ST_ATTEND : SeamlessViewsEntity
    {
        #region Backing Fields

        private readonly int _SID;
        private readonly string _STKEY;
        private readonly string _SURNAME;
        private readonly string _FIRST_NAME;
        private readonly string _PREF_NAME;
        private readonly string _HOME_GROUP;
        private readonly string _hgrpdesc;
        private readonly string _SCHOOL_YEAR;
        private readonly string _yrlvldesc;
        private readonly string _HOUSE;
        private readonly string _FAMILY;
        private readonly string _STATUS;
        private readonly string _NOTES;
        private readonly string _OVERSEAS;
        private readonly string _ACCESS_ALERT;
        private readonly string _ATTENDANCE_MEMO;
        private readonly string _TAG;
        private readonly string _FAMB;
        private readonly int? _CAMPUS;
        private readonly string _MEDICAL_ALERT;

        #endregion

        internal V_ST_ATTEND(SeamlessViewsContext Context, ST ST)
            : base(Context)
        {
            _SID = ST.REGISTRATION;
            _STKEY = ST.STKEY;
            _SURNAME = ST.SURNAME;
            _FIRST_NAME = ST.FIRST_NAME;
            _PREF_NAME = ST.PREF_NAME;
            _HOME_GROUP = ST.HOME_GROUP;
            _hgrpdesc = ST.HOME_GROUP_KGC?.DESCRIPTION ?? ST.HOME_GROUP;
            _SCHOOL_YEAR = ST.SCHOOL_YEAR;
            _yrlvldesc = ST.SCHOOL_YEAR_KCY?.SHORT_DESC ?? ST.SCHOOL_YEAR;
            _HOUSE = ST.HOUSE;
            _FAMILY = ST.FAMILY;
            _STATUS = ST.STATUS;
            _NOTES = ST.NOTES;
            _OVERSEAS = ST.OVERSEAS;
            _ACCESS_ALERT = ST.ACCESS_ALERT;
            _ATTENDANCE_MEMO = ST.ATTENDANCE_MEMO;
            _TAG = ST.TAG;
            _FAMB = ST.FAMB;
            _CAMPUS = ST.CAMPUS;
            _MEDICAL_ALERT = ST.MEDICAL_ALERT;
        }

        /// <summary>
        /// Student Registration Identifier
        /// </summary>
        public int SID { get { return _SID; } }
        /// <summary>
        /// Student ID
        /// </summary>
        public string STKEY { get { return _STKEY; } }
        /// <summary>
        /// Surname
        /// </summary>
        public string SURNAME { get { return _SURNAME; } }
        /// <summary>
        /// First given name
        /// </summary>
        public string FIRST_NAME { get { return _FIRST_NAME; } }
        /// <summary>
        /// Preferred name
        /// </summary>
        public string PREF_NAME { get { return _PREF_NAME; } }
        /// <summary>
        /// Student's home group
        /// </summary>
        public string HOME_GROUP { get { return _HOME_GROUP; } }
        /// <summary>
        /// Student's home group description
        /// </summary>
        public string hgrpdesc { get { return _hgrpdesc; } }
        /// <summary>
        /// Year level
        /// </summary>
        public string SCHOOL_YEAR { get { return _SCHOOL_YEAR; } }
        /// <summary>
        /// Year level description
        /// </summary>
        public string yrlvldesc { get { return _yrlvldesc; } }
        /// <summary>
        /// House
        /// </summary>
        public string HOUSE { get { return _HOUSE; } }
        /// <summary>
        /// Student's prime family
        /// </summary>
        public string FAMILY { get { return _FAMILY; } }
        /// <summary>
        /// Student status: Active, Inactive, Future, Left school, Delete
        /// </summary>
        public string STATUS { get { return _STATUS; } }
        /// <summary>
        /// Notes - any general purpose
        /// </summary>
        public string NOTES { get { return _NOTES; } }
        /// <summary>
        /// Born overseas? (Y/N): set to Y if ST.BIRTH_COUNTRY &lt;&gt; "1101": if Y then ARRIVAL is requested
        /// </summary>
        public string OVERSEAS { get { return _OVERSEAS; } }
        /// <summary>
        /// Access alert? (Y/N)
        /// </summary>
        public string ACCESS_ALERT { get { return _ACCESS_ALERT; } }
        /// <summary>
        /// Notes on student attendance/absence
        /// </summary>
        public string ATTENDANCE_MEMO { get { return _ATTENDANCE_MEMO; } }
        /// <summary>
        /// Classifies students into groups for timetabling (use calendar yr of yr 6 or yr 12):if LEFT or *,student not considered a sibling of family for fee determination
        /// </summary>
        public string TAG { get { return _TAG; } }
        /// <summary>
        /// Student's alternative family
        /// </summary>
        public string FAMB { get { return _FAMB; } }
        /// <summary>
        /// Student's home campus
        /// </summary>
        public int? CAMPUS { get { return _CAMPUS; } }
        /// <summary>
        /// Medical alert flag (Y/N)
        /// </summary>
        public string MEDICAL_ALERT { get { return _MEDICAL_ALERT; } }
    }
}
