#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Contacts
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KPC : EduHubEntity
    {

        #region Foreign Navigation Properties

#if !EduHubScoped
        private IReadOnlyList<KPCL> Cache_KPCKEY_KPCL_CONTACT;
#endif

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE;
            }
        }

        #region Field Properties

        /// <summary>
        /// Contact code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KPCKEY { get; internal set; }

        /// <summary>
        /// Contact surname
        /// [Alphanumeric (20)]
        /// </summary>
        public string SURNAME { get; internal set; }

        /// <summary>
        /// First name
        /// [Alphanumeric (15)]
        /// </summary>
        public string FIRST_NAME { get; internal set; }

        /// <summary>
        /// Second name
        /// [Alphanumeric (15)]
        /// </summary>
        public string SECOND_NAME { get; internal set; }

        /// <summary>
        /// Gender
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GENDER { get; internal set; }

        /// <summary>
        /// Address
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS01 { get; internal set; }

        /// <summary>
        /// Address
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS02 { get; internal set; }

        /// <summary>
        /// Address
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS03 { get; internal set; }

        /// <summary>
        /// State
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string STATE { get; internal set; }

        /// <summary>
        /// Post code
        /// [Alphanumeric (4)]
        /// </summary>
        public string POST { get; internal set; }

        /// <summary>
        /// Business phone
        /// [Alphanumeric (20)]
        /// </summary>
        public string BUS_PHONE { get; internal set; }

        /// <summary>
        /// Alternate/ home phone
        /// [Alphanumeric (20)]
        /// </summary>
        public string HOME_PHONE { get; internal set; }

        /// <summary>
        /// Mobile phone
        /// [Alphanumeric (20)]
        /// </summary>
        public string MOBILE { get; internal set; }

        /// <summary>
        /// Email address
        /// [Memo]
        /// </summary>
        public string EMAIL { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Foreign Navigation Properties

#if !EduHubScoped
        /// <summary>
        /// KPCL (Contact Links) related entities by [KPC.KPCKEY]-&gt;[KPCL.CONTACT]
        /// Contact code
        /// </summary>
        public IReadOnlyList<KPCL> KPCKEY_KPCL_CONTACT
        {
            get
            {
                if (Cache_KPCKEY_KPCL_CONTACT == null &&
                    !Context.KPCL.TryFindByCONTACT(KPCKEY, out Cache_KPCKEY_KPCL_CONTACT))
                {
                    Cache_KPCKEY_KPCL_CONTACT = new List<KPCL>().AsReadOnly();
                }

                return Cache_KPCKEY_KPCL_CONTACT;
            }
        }

#endif
        #endregion

    }
}
#endif
