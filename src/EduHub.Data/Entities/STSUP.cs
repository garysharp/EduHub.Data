using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Support Persons
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STSUP : EduHubEntity
    {

        #region Navigation Property Cache

        private ST Cache_SKEY_ST;
        private KGO Cache_SUPPORT_ROLE_KGO;

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
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Original student key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SKEY { get; internal set; }

        /// <summary>
        /// First name
        /// [Alphanumeric (30)]
        /// </summary>
        public string FIRST_NAME { get; internal set; }

        /// <summary>
        /// Surname
        /// [Alphanumeric (30)]
        /// </summary>
        public string SURNAME { get; internal set; }

        /// <summary>
        /// Role of support person
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SUPPORT_ROLE { get; internal set; }

        /// <summary>
        /// Two business address lines
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS01 { get; internal set; }

        /// <summary>
        /// Two business address lines
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS02 { get; internal set; }

        /// <summary>
        /// Suburb
        /// [Alphanumeric (30)]
        /// </summary>
        public string SUBURB { get; internal set; }

        /// <summary>
        /// State code
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string STATE { get; internal set; }

        /// <summary>
        /// Postcode
        /// [Alphanumeric (4)]
        /// </summary>
        public string POSTCODE { get; internal set; }

        /// <summary>
        /// Link to KAP to allow for access to postcodes when entering an address: NOTE this should NOT be a foreign key to KAP as the user is free to enter different data in ADDRESS03 and POSTCODE
        /// [Alphanumeric (34)]
        /// </summary>
        public string KAP_LINK { get; internal set; }

        /// <summary>
        /// Business telephone number
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string BUS_PHONE { get; internal set; }

        /// <summary>
        /// Business email address
        /// [Alphanumeric (60)]
        /// </summary>
        public string BUS_EMAIL { get; internal set; }

        /// <summary>
        /// User who added the record
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string ADDED_BY { get; internal set; }

        /// <summary>
        /// Student received Student Support Services (SSS) (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SUPPORT_SERVICES { get; internal set; }

        /// <summary>
        /// Student received other school-based or departmental student support (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string STUDENT_SUPPORT { get; internal set; }

        /// <summary>
        /// Student received non-school-based/non-departmental support over the last two years (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string STUDENT_OTHER_SUPPORT { get; internal set; }

        /// <summary>
        /// Is the Department of Health and Human Services currently involved with the child and their family? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CHILD_PROTECTION { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last write user
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// ST (Students) related entity by [STSUP.SKEY]-&gt;[ST.STKEY]
        /// Original student key
        /// </summary>
        public ST SKEY_ST
        {
            get
            {
                if (Cache_SKEY_ST == null)
                {
                    Cache_SKEY_ST = Context.ST.FindBySTKEY(SKEY);
                }

                return Cache_SKEY_ST;
            }
        }

        /// <summary>
        /// KGO (Occupations) related entity by [STSUP.SUPPORT_ROLE]-&gt;[KGO.KGOKEY]
        /// Role of support person
        /// </summary>
        public KGO SUPPORT_ROLE_KGO
        {
            get
            {
                if (SUPPORT_ROLE == null)
                {
                    return null;
                }
                if (Cache_SUPPORT_ROLE_KGO == null)
                {
                    Cache_SUPPORT_ROLE_KGO = Context.KGO.FindByKGOKEY(SUPPORT_ROLE);
                }

                return Cache_SUPPORT_ROLE_KGO;
            }
        }

        #endregion

    }
}
