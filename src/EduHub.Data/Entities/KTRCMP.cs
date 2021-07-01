using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Transport Company
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KTRCMP : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<TRPROUT> Cache_COMPANY_ID_TRPROUT_TRANSPORT_COMPANY_ID;

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
        /// Company ID
        /// </summary>
        public int COMPANY_ID { get; internal set; }

        /// <summary>
        /// Company Short Name
        /// [Alphanumeric (20)]
        /// </summary>
        public string COMPANY_CODE { get; internal set; }

        /// <summary>
        /// Company Name
        /// [Alphanumeric (60)]
        /// </summary>
        public string COMPANY_NAME { get; internal set; }

        /// <summary>
        /// Contact Name
        /// [Alphanumeric (30)]
        /// </summary>
        public string CONTACT { get; internal set; }

        /// <summary>
        /// Address * 3
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS01 { get; internal set; }

        /// <summary>
        /// Address * 3
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS02 { get; internal set; }

        /// <summary>
        /// Address * 3
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS03 { get; internal set; }

        /// <summary>
        /// State
        /// [Alphanumeric (3)]
        /// </summary>
        public string STATE { get; internal set; }

        /// <summary>
        /// Postcode
        /// [Alphanumeric (4)]
        /// </summary>
        public string POSTCODE { get; internal set; }

        /// <summary>
        /// Company Phone No
        /// [Alphanumeric (20)]
        /// </summary>
        public string PHONE { get; internal set; }

        /// <summary>
        /// Company Mobile No
        /// [Alphanumeric (20)]
        /// </summary>
        public string MOBILE { get; internal set; }

        /// <summary>
        /// Company Fax No
        /// [Alphanumeric (20)]
        /// </summary>
        public string FAX { get; internal set; }

        /// <summary>
        /// Company Email
        /// [Alphanumeric (60)]
        /// </summary>
        public string EMAIL { get; internal set; }

        /// <summary>
        /// Company Notes
        /// [Alphanumeric (200)]
        /// </summary>
        public string NOTES { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// TRPROUT (Student Transport Routes) related entities by [KTRCMP.COMPANY_ID]-&gt;[TRPROUT.TRANSPORT_COMPANY_ID]
        /// Company ID
        /// </summary>
        public IReadOnlyList<TRPROUT> COMPANY_ID_TRPROUT_TRANSPORT_COMPANY_ID
        {
            get
            {
                if (Cache_COMPANY_ID_TRPROUT_TRANSPORT_COMPANY_ID == null &&
                    !Context.TRPROUT.TryFindByTRANSPORT_COMPANY_ID(COMPANY_ID, out Cache_COMPANY_ID_TRPROUT_TRANSPORT_COMPANY_ID))
                {
                    Cache_COMPANY_ID_TRPROUT_TRANSPORT_COMPANY_ID = new List<TRPROUT>().AsReadOnly();
                }

                return Cache_COMPANY_ID_TRPROUT_TRANSPORT_COMPANY_ID;
            }
        }

        #endregion

    }
}
