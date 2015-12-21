using EduHub.Data.Entities;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Family Contact
    /// </summary>
    public class V_FAMILY_CONTACT : SeamlessViewsEntity
    {
        #region Backing Fields

        private readonly string _DFKEY;
        private readonly string _MOBILE;
        private readonly string _TELEPHONE;
        private readonly string _E_MAIL_A;
        private readonly string _NAME_A;
        private readonly string _SURNAME_A;
        private readonly string _NAME_B;
        private readonly string _SURNAME_B;

        #endregion

        internal V_FAMILY_CONTACT(SeamlessViewsContext Context, DF DF)
            : base(Context)
        {
            var UM = DF.HOMEKEY_UM;

            _DFKEY = DF.DFKEY;
            _MOBILE = UM?.MOBILE;
            _TELEPHONE = UM?.TELEPHONE;
            _E_MAIL_A = DF.E_MAIL_A;
            _NAME_A = DF.NAME_A;
            _SURNAME_A = DF.SURNAME_A;
            _NAME_B = DF.NAME_B;
            _SURNAME_B = DF.SURNAME_B;
        }

        /// <summary>
        /// Family ID
        /// </summary>
        public string DFKEY { get { return _DFKEY; } }
        /// <summary>
        /// Home Mobile no
        /// </summary>
        public string MOBILE { get { return _MOBILE; } }
        /// <summary>
        /// Phone no
        /// </summary>
        public string TELEPHONE { get { return _TELEPHONE; } }
        /// <summary>
        /// Parent/guardian A e-mail address
        /// </summary>
        public string E_MAIL_A { get { return _E_MAIL_A; } }
        /// <summary>
        /// Parent/guardian A first given name
        /// </summary>
        public string NAME_A { get { return _NAME_A; } }
        /// <summary>
        /// Parent/guardian A surname
        /// </summary>
        public string SURNAME_A { get { return _SURNAME_A; } }
        /// <summary>
        /// Parent/guardian B first given name
        /// </summary>
        public string NAME_B { get { return _NAME_B; } }
        /// <summary>
        /// Parent/guardian B surname
        /// </summary>
        public string SURNAME_B { get { return _SURNAME_B; } }
    }
}
