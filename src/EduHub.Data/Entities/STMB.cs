using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Merit Behaviour Details
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STMB : EduHubEntity
    {

        #region Navigation Property Cache

        private ST Cache_SKEY_ST;
        private KCB Cache_B_CODE_KCB;
        private KGW Cache_AWARD_KGW;

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE.Value;
            }
        }

        #region Field Properties

        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Student ID
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SKEY { get; internal set; }

        /// <summary>
        /// Behaviour code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string B_CODE { get; internal set; }

        /// <summary>
        /// Behaviour detail
        /// [Memo]
        /// </summary>
        public string DETAIL { get; internal set; }

        /// <summary>
        /// Start date of positive contribution
        /// </summary>
        public DateTime? START_DATE { get; internal set; }

        /// <summary>
        /// End date of positive contribution
        /// </summary>
        public DateTime? END_DATE { get; internal set; }

        /// <summary>
        /// Type of person making recommendation: SF=Staff member, DF=Family member, OT=Other
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string RECOMMEND_TYPE { get; internal set; }

        /// <summary>
        /// Code identifying person making recommendation (if staff member or family member)
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string RECOMMEND_KEY { get; internal set; }

        /// <summary>
        /// Code indicating adult A or B (if family member)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string RECOMMEND_DFAB { get; internal set; }

        /// <summary>
        /// Details of person making recommendation (if not staff member or family member)
        /// [Memo]
        /// </summary>
        public string RECOMMEND_OTHER { get; internal set; }

        /// <summary>
        /// Award code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string AWARD { get; internal set; }

        /// <summary>
        /// Any extra details
        /// [Memo]
        /// </summary>
        public string STMB_COMMENT { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last write operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// ST (Students) related entity by [STMB.SKEY]-&gt;[ST.STKEY]
        /// Student ID
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
        /// KCB (Behaviour Classifications) related entity by [STMB.B_CODE]-&gt;[KCB.KCBKEY]
        /// Behaviour code
        /// </summary>
        public KCB B_CODE_KCB
        {
            get
            {
                if (B_CODE == null)
                {
                    return null;
                }
                if (Cache_B_CODE_KCB == null)
                {
                    Cache_B_CODE_KCB = Context.KCB.FindByKCBKEY(B_CODE);
                }

                return Cache_B_CODE_KCB;
            }
        }

        /// <summary>
        /// KGW (Awards and Prizes) related entity by [STMB.AWARD]-&gt;[KGW.AWARD]
        /// Award code
        /// </summary>
        public KGW AWARD_KGW
        {
            get
            {
                if (AWARD == null)
                {
                    return null;
                }
                if (Cache_AWARD_KGW == null)
                {
                    Cache_AWARD_KGW = Context.KGW.FindByAWARD(AWARD);
                }

                return Cache_AWARD_KGW;
            }
        }

        #endregion

    }
}
