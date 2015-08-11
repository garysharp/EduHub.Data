using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Merit Behaviour Details
    /// </summary>
    public class STMB_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Student ID [Uppercase Alphanumeric: u10]
        /// </summary>
        public string SKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [SKEY] => [ST_Entity].[STKEY]
        /// Student ID
        /// </summary>
        public ST_Entity SKEY_ST { get { return SKEY == null ? null : Context.ST.FindBySTKEY(SKEY); } }
        /// <summary>
        /// Behaviour code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string B_CODE { get; internal set; }
        /// <summary>
        /// Navigation property for [B_CODE] => [KCB_Entity].[KCBKEY]
        /// Behaviour code
        /// </summary>
        public KCB_Entity B_CODE_KCB { get { return B_CODE == null ? null : Context.KCB.FindByKCBKEY(B_CODE); } }
        /// <summary>
        /// Behaviour detail [Memo: m]
        /// </summary>
        public string DETAIL { get; internal set; }
        /// <summary>
        /// Start date of positive contribution [Date Time nullable: d]
        /// </summary>
        public DateTime? START_DATE { get; internal set; }
        /// <summary>
        /// End date of positive contribution [Date Time nullable: d]
        /// </summary>
        public DateTime? END_DATE { get; internal set; }
        /// <summary>
        /// Type of person making recommendation: SF=Staff member, DF=Family member, OT=Other [Uppercase Alphanumeric: u2]
        /// </summary>
        public string RECOMMEND_TYPE { get; internal set; }
        /// <summary>
        /// Code identifying person making recommendation (if staff member or family member) [Uppercase Alphanumeric: u10]
        /// </summary>
        public string RECOMMEND_KEY { get; internal set; }
        /// <summary>
        /// Code indicating adult A or B (if family member) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string RECOMMEND_DFAB { get; internal set; }
        /// <summary>
        /// Details of person making recommendation (if not staff member or family member) [Memo: m]
        /// </summary>
        public string RECOMMEND_OTHER { get; internal set; }
        /// <summary>
        /// Award code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string AWARD { get; internal set; }
        /// <summary>
        /// Navigation property for [AWARD] => [KGW_Entity].[AWARD]
        /// Award code
        /// </summary>
        public KGW_Entity AWARD_KGW { get { return AWARD == null ? null : Context.KGW.FindByAWARD(AWARD); } }
        /// <summary>
        /// Any extra details [Memo: m]
        /// </summary>
        public string STMB_COMMENT { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
        
        
    }
}
