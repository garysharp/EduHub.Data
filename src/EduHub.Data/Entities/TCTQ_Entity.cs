using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Class Information
    /// </summary>
    public class TCTQ_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// (was TQTCKEY) Owner relation [Date Time nullable: d]
        /// </summary>
        public DateTime? TCTQKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [TCTQKEY] => [TC_Entity].[TCKEY]
        /// (was TQTCKEY) Owner relation
        /// </summary>
        public TC_Entity TCTQKEY_TC { get { return TCTQKEY.HasValue ? Context.TC.FindByTCKEY(TCTQKEY.Value) : null; } }
        /// <summary>
        /// Associated Quilt [Uppercase Alphanumeric: u8]
        /// </summary>
        public string QKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [QKEY] => [TH_Entity].[THKEY]
        /// Associated Quilt
        /// </summary>
        public TH_Entity QKEY_TH { get { return QKEY == null ? null : Context.TH.FindByTHKEY(QKEY); } }
        /// <summary>
        /// Subject [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJ] => [SU_Entity].[SUKEY]
        /// Subject
        /// </summary>
        public SU_Entity SUBJ_SU { get { return SUBJ == null ? null : Context.SU.FindBySUKEY(SUBJ); } }
        /// <summary>
        /// Class number [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS { get; internal set; }
        /// <summary>
        /// Ident number [Integer (32bit signed nullable): l]
        /// </summary>
        public int? IDENT { get; internal set; }
        /// <summary>
        /// Actual class size [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS_SIZE { get; internal set; }
        /// <summary>
        /// 1st teacher for this period [Uppercase Alphanumeric: u4]
        /// </summary>
        public string T1TEACH { get; internal set; }
        /// <summary>
        /// Navigation property for [T1TEACH] => [SF_Entity].[SFKEY]
        /// 1st teacher for this period
        /// </summary>
        public SF_Entity T1TEACH_SF { get { return T1TEACH == null ? null : Context.SF.FindBySFKEY(T1TEACH); } }
        /// <summary>
        /// 2nd teacher for this period [Uppercase Alphanumeric: u4]
        /// </summary>
        public string T2TEACH { get; internal set; }
        /// <summary>
        /// Navigation property for [T2TEACH] => [SF_Entity].[SFKEY]
        /// 2nd teacher for this period
        /// </summary>
        public SF_Entity T2TEACH_SF { get { return T2TEACH == null ? null : Context.SF.FindBySFKEY(T2TEACH); } }
        /// <summary>
        /// 1st room for this period [Uppercase Alphanumeric: u4]
        /// </summary>
        public string R1ROOM { get; internal set; }
        /// <summary>
        /// Navigation property for [R1ROOM] => [SM_Entity].[ROOM]
        /// 1st room for this period
        /// </summary>
        public SM_Entity R1ROOM_SM { get { return R1ROOM == null ? null : Context.SM.FindByROOM(R1ROOM); } }
        /// <summary>
        /// 2nd room for this period [Uppercase Alphanumeric: u4]
        /// </summary>
        public string R2ROOM { get; internal set; }
        /// <summary>
        /// Navigation property for [R2ROOM] => [SM_Entity].[ROOM]
        /// 2nd room for this period
        /// </summary>
        public SM_Entity R2ROOM_SM { get { return R2ROOM == null ? null : Context.SM.FindByROOM(R2ROOM); } }
        /// <summary>
        /// Resources for this period [Uppercase Alphanumeric: u4]
        /// </summary>
        public string RESOURCES01 { get; internal set; }
        /// <summary>
        /// Resources for this period [Uppercase Alphanumeric: u4]
        /// </summary>
        public string RESOURCES02 { get; internal set; }
        /// <summary>
        /// Resources for this period [Uppercase Alphanumeric: u4]
        /// </summary>
        public string RESOURCES03 { get; internal set; }
        /// <summary>
        /// Resources for this period [Uppercase Alphanumeric: u4]
        /// </summary>
        public string RESOURCES04 { get; internal set; }
        /// <summary>
        /// Resources for this period [Uppercase Alphanumeric: u4]
        /// </summary>
        public string RESOURCES05 { get; internal set; }
        /// <summary>
        /// Resources for this period [Uppercase Alphanumeric: u4]
        /// </summary>
        public string RESOURCES06 { get; internal set; }
        /// <summary>
        /// Resources for this period [Uppercase Alphanumeric: u4]
        /// </summary>
        public string RESOURCES07 { get; internal set; }
        /// <summary>
        /// Resources for this period [Uppercase Alphanumeric: u4]
        /// </summary>
        public string RESOURCES08 { get; internal set; }
        /// <summary>
        /// Resources for this period [Uppercase Alphanumeric: u4]
        /// </summary>
        public string RESOURCES09 { get; internal set; }
        /// <summary>
        /// Teacher replacement [Uppercase Alphanumeric: u4]
        /// </summary>
        public string EXTRA_TEACH { get; internal set; }
        /// <summary>
        /// Navigation property for [EXTRA_TEACH] => [SF_Entity].[SFKEY]
        /// Teacher replacement
        /// </summary>
        public SF_Entity EXTRA_TEACH_SF { get { return EXTRA_TEACH == null ? null : Context.SF.FindBySFKEY(EXTRA_TEACH); } }
        /// <summary>
        /// Room for replacement [Uppercase Alphanumeric: u4]
        /// </summary>
        public string EXTRA_ROOM { get; internal set; }
        /// <summary>
        /// Navigation property for [EXTRA_ROOM] => [SM_Entity].[ROOM]
        /// Room for replacement
        /// </summary>
        public SM_Entity EXTRA_ROOM_SM { get { return EXTRA_ROOM == null ? null : Context.SM.FindByROOM(EXTRA_ROOM); } }
        /// <summary>
        /// Quilt cell row [Integer (16bit signed nullable): i]
        /// </summary>
        public short? QROW { get; internal set; }
        /// <summary>
        /// Quilt cell col [Integer (16bit signed nullable): i]
        /// </summary>
        public short? QCOL { get; internal set; }
        /// <summary>
        /// Flag indicating if this is a composite class [Integer (16bit signed): i]
        /// </summary>
        public short COMPOSITE { get; internal set; }
        /// <summary>
        /// Inserted by Schema Verify for 8.15.1 [Uppercase Alphanumeric: u8]
        /// </summary>
        public string GKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [GKEY] => [TT_Entity].[TTKEY]
        /// Inserted by Schema Verify for 8.15.1
        /// </summary>
        public TT_Entity GKEY_TT { get { return GKEY == null ? null : Context.TT.FindByTTKEY(GKEY); } }
        /// <summary>
        /// Inserted by Schema Verify for 8.15.1 [Integer (16bit signed nullable): i]
        /// </summary>
        public short? GROW { get; internal set; }
        /// <summary>
        /// Inserted by Schema Verify for 8.15.1 [Integer (16bit signed nullable): i]
        /// </summary>
        public short? GCOL { get; internal set; }
        /// <summary>
        /// Inserted by Schema Verify for 8.15.1 [Integer (32bit signed nullable): l]
        /// </summary>
        public int? GCOLOUR { get; internal set; }
        /// <summary>
        /// Inserted by Schema Verify for 8.15.1 [Integer (16bit signed nullable): i]
        /// </summary>
        public short? OCCUR { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
        
        
    }
}
