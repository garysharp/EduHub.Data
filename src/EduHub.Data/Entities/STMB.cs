using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Merit Behaviour Details
    /// </summary>
    public class STMB : EntityBase
    {
#region Navigation Property Cache
        private ST _SKEY_ST;
        private KCB _B_CODE_KCB;
        private KGW _AWARD_KGW;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int? TID { get; internal set; }
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
        /// Navigation property for [SKEY] => [ST].[STKEY]
        /// Student ID
        /// </summary>
        public ST SKEY_ST {
            get
            {
                if (SKEY != null)
                {
                    if (_SKEY_ST == null)
                    {
                        _SKEY_ST = Context.ST.FindBySTKEY(SKEY);
                    }
                    return _SKEY_ST;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [B_CODE] => [KCB].[KCBKEY]
        /// Behaviour code
        /// </summary>
        public KCB B_CODE_KCB {
            get
            {
                if (B_CODE != null)
                {
                    if (_B_CODE_KCB == null)
                    {
                        _B_CODE_KCB = Context.KCB.FindByKCBKEY(B_CODE);
                    }
                    return _B_CODE_KCB;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [AWARD] => [KGW].[AWARD]
        /// Award code
        /// </summary>
        public KGW AWARD_KGW {
            get
            {
                if (AWARD != null)
                {
                    if (_AWARD_KGW == null)
                    {
                        _AWARD_KGW = Context.KGW.FindByAWARD(AWARD);
                    }
                    return _AWARD_KGW;
                }
                else
                {
                    return null;
                }
            }
        }
#endregion
    }
}
