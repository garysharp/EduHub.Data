#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// STSUP Transfer
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STSUP_TR : EduHubEntity
    {

        #region Navigation Property Cache

        private SKGS Cache_ORIG_SCHOOL_SKGS;

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
        /// Originating School
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string ORIG_SCHOOL { get; internal set; }

        /// <summary>
        /// Unique STSUP Transfer ID
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string STSUP_TRANS_ID { get; internal set; }

        /// <summary>
        /// Original student key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SKEY { get; internal set; }

        /// <summary>
        /// New student key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SKEY_NEW { get; internal set; }

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
        /// New role of support person
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SUPPORT_ROLE_NEW { get; internal set; }

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
        /// Unique ST Transfer ID
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string ST_TRANS_ID { get; internal set; }

        /// <summary>
        /// Unique KGO Transfer ID
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string KGO_TRANS_ID { get; internal set; }

        /// <summary>
        /// Current status of import
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string IMP_STATUS { get; internal set; }

        /// <summary>
        /// Actual date data transferred into live table
        /// </summary>
        public DateTime? IMP_DATE { get; internal set; }

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
        /// SKGS (Schools) related entity by [STSUP_TR.ORIG_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// Originating School
        /// </summary>
        public SKGS ORIG_SCHOOL_SKGS
        {
            get
            {
                if (Cache_ORIG_SCHOOL_SKGS == null)
                {
                    Cache_ORIG_SCHOOL_SKGS = Context.SKGS.FindBySCHOOL(ORIG_SCHOOL);
                }

                return Cache_ORIG_SCHOOL_SKGS;
            }
        }

        #endregion

    }
}
#endif
