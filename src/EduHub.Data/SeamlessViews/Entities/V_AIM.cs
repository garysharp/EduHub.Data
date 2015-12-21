using EduHub.Data.Entities;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// AIM
    /// </summary>
    public class V_AIM : SeamlessViewsEntity
    {
        #region Backing Fields

        private readonly string _student_code;
        private readonly string _first_name;
        private readonly string _middle_name;
        private readonly string _surname;
        private readonly string _gender;
        private readonly string _date_of_birth;
        private readonly int _LBOTE;
        private readonly int _ATSI;
        private readonly int _disability_status;
        private readonly int _EMA;
        private readonly int _ESL;
        private readonly string _home_group;
        private readonly string _year_level;

        #endregion

        internal V_AIM(SeamlessViewsContext Context, ST ST)
            : base(Context)
        {
            _student_code = ST.STKEY;
            _first_name = ST.FIRST_NAME;
            _middle_name = ST.SECOND_NAME;
            _surname = ST.SURNAME;

            _gender = ST.GENDER == "M" ? "MALE" :
                ST.GENDER == "F" ? "FEMAL" : "";

            _date_of_birth = ST.BIRTHDATE.HasValue ? ST.BIRTHDATE.Value.ToString("dd/MM/yyyy") : null;

            _LBOTE = ST.LBOTE == "N" ? 0 : 1;

            _ATSI = ST.KOORIE == "K" || ST.KOORIE == "T" || ST.KOORIE == "B" || ST.KOORIE == "U" ? 1 : 0;

            _disability_status = ST.DISABILITY == "Y" ? 1 : 0;

            _EMA = ST.ED_ALLOW == "Y" ? 1 : 0;

            _ESL = ST.ENG_SPEAK == "N" ? 1 : 0;

            _home_group = ST.HOME_GROUP;
            _year_level = ST.SCHOOL_YEAR == "00" ? "P" : ST.SCHOOL_YEAR;
        }

        /// <summary>
        /// Student Code
        /// </summary>
        public string student_code { get { return _student_code; } }
        /// <summary>
        /// First Name
        /// </summary>
        public string first_name { get { return _first_name; } }
        /// <summary>
        /// Middle Name
        /// </summary>
        public string middle_name { get { return _middle_name; } }
        /// <summary>
        /// Surname
        /// </summary>
        public string surname { get { return _surname; } }
        /// <summary>
        /// Gender
        /// </summary>
        public string gender { get { return _gender; } }
        /// <summary>
        /// Date of Birth
        /// </summary>
        public string date_of_birth { get { return _date_of_birth; } }
        /// <summary>
        /// Language Background Other Than English
        /// </summary>
        public int LBOTE { get { return _LBOTE; } }
        /// <summary>
        /// Aboriginal and Torres Strait Islander
        /// </summary>
        public int ATSI { get { return _ATSI; } }
        /// <summary>
        /// Disability Status
        /// </summary>
        public int disability_status { get { return _disability_status; } }
        /// <summary>
        /// Education Maintenance Allowance
        /// </summary>
        public int EMA { get { return _EMA; } }
        /// <summary>
        /// English as a Second Language
        /// </summary>
        public int ESL { get { return _ESL; } }
        /// <summary>
        /// Home Group
        /// </summary>
        public string home_group { get { return _home_group; } }
        /// <summary>
        /// Year Level
        /// </summary>
        public string year_level { get { return _year_level; } }
    }
}
