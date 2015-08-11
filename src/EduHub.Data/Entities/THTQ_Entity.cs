using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Quilt Entries
    /// </summary>
    public class THTQ_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Link to Timetable Quilt Header [Uppercase Alphanumeric: u8]
        /// </summary>
        public string QKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [QKEY] => [TH_Entity].[THKEY]
        /// Link to Timetable Quilt Header
        /// </summary>
        public TH_Entity QKEY_TH { get { return QKEY == null ? null : Context.TH.FindByTHKEY(QKEY); } }
        /// <summary>
        /// Link to Timetable Grid Template [Uppercase Alphanumeric: u8]
        /// </summary>
        public string GKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [GKEY] => [TT_Entity].[TTKEY]
        /// Link to Timetable Grid Template
        /// </summary>
        public TT_Entity GKEY_TT { get { return GKEY == null ? null : Context.TT.FindByTTKEY(GKEY); } }
        /// <summary>
        /// Link to Subject [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJ] => [SU_Entity].[SUKEY]
        /// Link to Subject
        /// </summary>
        public SU_Entity SUBJ_SU { get { return SUBJ == null ? null : Context.SU.FindBySUKEY(SUBJ); } }
        /// <summary>
        /// Set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS { get; internal set; }
        /// <summary>
        /// Occurrence of the subject [Integer (16bit signed nullable): i]
        /// </summary>
        public short? OCCUR { get; internal set; }
        /// <summary>
        /// Max occurrences in the quilt [Integer (16bit signed nullable): i]
        /// </summary>
        public short? FREQ { get; internal set; }
        /// <summary>
        /// Grid line label [Uppercase Alphanumeric: u6]
        /// </summary>
        public string ROW_LABEL { get; internal set; }
        /// <summary>
        /// Allows quilt labels to be "tied" [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TIED { get; internal set; }
        /// <summary>
        /// Unique subject identifier (TTTG.IDENT) [Integer (32bit signed): l]
        /// </summary>
        public int IDENT { get; internal set; }
        /// <summary>
        /// Actual set size (TBI) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS_SIZE { get; internal set; }
        /// <summary>
        /// Staff code of first or only teacher for this period [Uppercase Alphanumeric: u4]
        /// </summary>
        public string T1TEACH { get; internal set; }
        /// <summary>
        /// Navigation property for [T1TEACH] => [SF_Entity].[SFKEY]
        /// Staff code of first or only teacher for this period
        /// </summary>
        public SF_Entity T1TEACH_SF { get { return T1TEACH == null ? null : Context.SF.FindBySFKEY(T1TEACH); } }
        /// <summary>
        /// Staff code of second teacher for this period (if any) [Uppercase Alphanumeric: u4]
        /// </summary>
        public string T2TEACH { get; internal set; }
        /// <summary>
        /// Navigation property for [T2TEACH] => [SF_Entity].[SFKEY]
        /// Staff code of second teacher for this period (if any)
        /// </summary>
        public SF_Entity T2TEACH_SF { get { return T2TEACH == null ? null : Context.SF.FindBySFKEY(T2TEACH); } }
        /// <summary>
        /// Room code of first or only room for this period [Uppercase Alphanumeric: u4]
        /// </summary>
        public string R1ROOM { get; internal set; }
        /// <summary>
        /// Navigation property for [R1ROOM] => [SM_Entity].[ROOM]
        /// Room code of first or only room for this period
        /// </summary>
        public SM_Entity R1ROOM_SM { get { return R1ROOM == null ? null : Context.SM.FindByROOM(R1ROOM); } }
        /// <summary>
        /// Room code of second room for this period (if any) [Uppercase Alphanumeric: u4]
        /// </summary>
        public string R2ROOM { get; internal set; }
        /// <summary>
        /// Navigation property for [R2ROOM] => [SM_Entity].[ROOM]
        /// Room code of second room for this period (if any)
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
        /// Staff code of last replacement teacher [Uppercase Alphanumeric: u4]
        /// </summary>
        public string EXTRA_TEACH { get; internal set; }
        /// <summary>
        /// Navigation property for [EXTRA_TEACH] => [SF_Entity].[SFKEY]
        /// Staff code of last replacement teacher
        /// </summary>
        public SF_Entity EXTRA_TEACH_SF { get { return EXTRA_TEACH == null ? null : Context.SF.FindBySFKEY(EXTRA_TEACH); } }
        /// <summary>
        /// Room code of last replacement room [Uppercase Alphanumeric: u4]
        /// </summary>
        public string EXTRA_ROOM { get; internal set; }
        /// <summary>
        /// Navigation property for [EXTRA_ROOM] => [SM_Entity].[ROOM]
        /// Room code of last replacement room
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
        /// Grid row (TTTG.HROW) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? GROW { get; internal set; }
        /// <summary>
        /// Grid col (TTTG.HCOL) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? GCOL { get; internal set; }
        /// <summary>
        /// Subject link chain no (TTTG.LCHAIN) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LINK { get; internal set; }
        /// <summary>
        /// Inserted by Schema Verify [Integer (16bit signed nullable): i]
        /// </summary>
        public short? COMPOSITE { get; internal set; }
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
