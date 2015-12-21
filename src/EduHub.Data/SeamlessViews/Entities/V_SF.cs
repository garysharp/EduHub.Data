using EduHub.Data.Entities;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Staff
    /// </summary>
    public class V_SF : SeamlessViewsEntity
    {
        #region Backing Fields

        private readonly string _SFKEY;
        private readonly string _SURNAME;
        private readonly string _FIRST_NAME;
        private readonly string _SECOND_NAME;
        private readonly string _PREF_NAME;
        private readonly string _TITLE;
        private readonly string _FACULTY01;
        private readonly string _FACULTY02;
        private readonly string _FACULTY03;
        private readonly string _FACULTY04;
        private readonly string _SUBJECT01;
        private readonly string _SUBJECT02;
        private readonly string _SUBJECT03;
        private readonly string _SUBJECT04;
        private readonly string _SUBJECT05;
        private readonly string _SUBJECT06;
        private readonly string _SUBJECT07;
        private readonly string _SUBJECT08;
        private readonly string _SUBJECT09;
        private readonly string _SUBJECT10;
        private readonly double? _FTE;
        private readonly string _MAJORA;
        private readonly string _MAJORB;
        private readonly string _MAJORC;
        private readonly string _PAYROLL_CLASS;
        private readonly string _PAYROLL_REC_NO;

        #endregion

        internal V_SF(SeamlessViewsContext Context, SF SF)
            : base(Context)
        {
            _SFKEY = SF.SFKEY;
            _SURNAME = SF.SURNAME;
            _FIRST_NAME = SF.FIRST_NAME;
            _SECOND_NAME = SF.SECOND_NAME;
            _PREF_NAME = SF.PREF_NAME;
            _TITLE = SF.TITLE;
            _FACULTY01 = SF.FACULTY01;
            _FACULTY02 = SF.FACULTY02;
            _FACULTY03 = SF.FACULTY03;
            _FACULTY04 = SF.FACULTY04;
            _SUBJECT01 = SF.SUBJECT01;
            _SUBJECT02 = SF.SUBJECT02;
            _SUBJECT03 = SF.SUBJECT03;
            _SUBJECT04 = SF.SUBJECT04;
            _SUBJECT05 = SF.SUBJECT05;
            _SUBJECT06 = SF.SUBJECT06;
            _SUBJECT07 = SF.SUBJECT07;
            _SUBJECT08 = SF.SUBJECT08;
            _SUBJECT09 = SF.SUBJECT09;
            _SUBJECT10 = SF.SUBJECT10;
            _FTE = SF.FTE;
            _MAJORA = SF.MAJORA;
            _MAJORB = SF.MAJORB;
            _MAJORC = SF.MAJORC;
            _PAYROLL_CLASS = SF.PAYROLL_CLASS;
            _PAYROLL_REC_NO = SF.PAYROLL_REC_NO;
        }

        /// <summary>
        /// Staff member code
        /// </summary>
        public string SFKEY { get { return _SFKEY; } }
        /// <summary>
        /// Surname
        /// </summary>
        public string SURNAME { get { return _SURNAME; } }
        /// <summary>
        /// First given name
        /// </summary>
        public string FIRST_NAME { get { return _FIRST_NAME; } }
        /// <summary>
        /// Second given name
        /// </summary>
        public string SECOND_NAME { get { return _SECOND_NAME; } }
        /// <summary>
        /// Preferred name
        /// </summary>
        public string PREF_NAME { get { return _PREF_NAME; } }
        /// <summary>
        /// Title: Mr, Ms, etc
        /// </summary>
        public string TITLE { get { return _TITLE; } }
        /// <summary>
        /// Faculty/ies
        /// </summary>
        public string FACULTY01 { get { return _FACULTY01; } }
        /// <summary>
        /// Faculty/ies
        /// </summary>
        public string FACULTY02 { get { return _FACULTY02; } }
        /// <summary>
        /// Faculty/ies
        /// </summary>
        public string FACULTY03 { get { return _FACULTY03; } }
        /// <summary>
        /// Faculty/ies
        /// </summary>
        public string FACULTY04 { get { return _FACULTY04; } }
        /// <summary>
        /// Subjects normally taken in priority sequence
        /// </summary>
        public string SUBJECT01 { get { return _SUBJECT01; } }
        /// <summary>
        /// Subjects normally taken in priority sequence
        /// </summary>
        public string SUBJECT02 { get { return _SUBJECT02; } }
        /// <summary>
        /// Subjects normally taken in priority sequence
        /// </summary>
        public string SUBJECT03 { get { return _SUBJECT03; } }
        /// <summary>
        /// Subjects normally taken in priority sequence
        /// </summary>
        public string SUBJECT04 { get { return _SUBJECT04; } }
        /// <summary>
        /// Subjects normally taken in priority sequence
        /// </summary>
        public string SUBJECT05 { get { return _SUBJECT05; } }
        /// <summary>
        /// Subjects normally taken in priority sequence
        /// </summary>
        public string SUBJECT06 { get { return _SUBJECT06; } }
        /// <summary>
        /// Subjects normally taken in priority sequence
        /// </summary>
        public string SUBJECT07 { get { return _SUBJECT07; } }
        /// <summary>
        /// Subjects normally taken in priority sequence
        /// </summary>
        public string SUBJECT08 { get { return _SUBJECT08; } }
        /// <summary>
        /// Subjects normally taken in priority sequence
        /// </summary>
        public string SUBJECT09 { get { return _SUBJECT09; } }
        /// <summary>
        /// Subjects normally taken in priority sequence
        /// </summary>
        public string SUBJECT10 { get { return _SUBJECT10; } }
        /// <summary>
        /// Full time equivalent
        /// </summary>
        public double? FTE { get { return _FTE; } }
        /// <summary>
        /// Major area of teaching otherwise not available
        /// </summary>
        public string MAJORA { get { return _MAJORA; } }
        /// <summary>
        /// Major area of teaching otherwise not available
        /// </summary>
        public string MAJORB { get { return _MAJORB; } }
        /// <summary>
        /// Major area of teaching otherwise not available
        /// </summary>
        public string MAJORC { get { return _MAJORC; } }
        /// <summary>
        /// Central payroll classification
        /// </summary>
        public string PAYROLL_CLASS { get { return _PAYROLL_CLASS; } }
        /// <summary>
        /// Central payroll record number
        /// </summary>
        public string PAYROLL_REC_NO { get { return _PAYROLL_REC_NO; } }
    }
}
