using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Grid Subjects
    /// </summary>
    public class TTTG_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
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
        /// The first (lowest) class number for this Subject [Integer (16bit signed nullable): i]
        /// </summary>
        public short? FIRST_CLASS { get; internal set; }
        /// <summary>
        /// Number of sets allocated [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NSET { get; internal set; }
        /// <summary>
        /// Unique subject/class identifier on a particular timetable [Integer (32bit signed): l]
        /// </summary>
        public int IDENT { get; internal set; }
        /// <summary>
        /// Actual set size (TBI) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS_SIZE { get; internal set; }
        /// <summary>
        /// Maximum set size [Integer (16bit signed nullable): i]
        /// </summary>
        public short? MAXIMUM { get; internal set; }
        /// <summary>
        /// Minimum set size [Integer (16bit signed nullable): i]
        /// </summary>
        public short? MINIMUM { get; internal set; }
        /// <summary>
        /// Minimum line range [Integer (16bit signed nullable): i]
        /// </summary>
        public short? MINLINE { get; internal set; }
        /// <summary>
        /// Maximum line range [Integer (16bit signed nullable): i]
        /// </summary>
        public short? MAXLINE { get; internal set; }
        /// <summary>
        /// Mono colour [Integer (16bit signed nullable): i]
        /// </summary>
        public short? MCOLOUR { get; internal set; }
        /// <summary>
        /// Graphics colour [Integer (32bit signed nullable): l]
        /// </summary>
        public int? GCOLOUR { get; internal set; }
        /// <summary>
        /// Number of units (NSW) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? UNITS { get; internal set; }
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
        /// Resources [Uppercase Alphanumeric: u4]
        /// </summary>
        public string RESOURCES01 { get; internal set; }
        /// <summary>
        /// Resources [Uppercase Alphanumeric: u4]
        /// </summary>
        public string RESOURCES02 { get; internal set; }
        /// <summary>
        /// Resources [Uppercase Alphanumeric: u4]
        /// </summary>
        public string RESOURCES03 { get; internal set; }
        /// <summary>
        /// Resources [Uppercase Alphanumeric: u4]
        /// </summary>
        public string RESOURCES04 { get; internal set; }
        /// <summary>
        /// Resources [Uppercase Alphanumeric: u4]
        /// </summary>
        public string RESOURCES05 { get; internal set; }
        /// <summary>
        /// Resources [Uppercase Alphanumeric: u4]
        /// </summary>
        public string RESOURCES06 { get; internal set; }
        /// <summary>
        /// Resources [Uppercase Alphanumeric: u4]
        /// </summary>
        public string RESOURCES07 { get; internal set; }
        /// <summary>
        /// Resources [Uppercase Alphanumeric: u4]
        /// </summary>
        public string RESOURCES08 { get; internal set; }
        /// <summary>
        /// Resources [Uppercase Alphanumeric: u4]
        /// </summary>
        public string RESOURCES09 { get; internal set; }
        /// <summary>
        /// Grid Label [Uppercase Alphanumeric: u5]
        /// </summary>
        public string LAB { get; internal set; }
        /// <summary>
        /// Fixed grid row (line) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? FROW { get; internal set; }
        /// <summary>
        /// Fixed grid column [Integer (16bit signed nullable): i]
        /// </summary>
        public short? FCOL { get; internal set; }
        /// <summary>
        /// Home grid row (line) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? HROW { get; internal set; }
        /// <summary>
        /// Home grid column [Integer (16bit signed nullable): i]
        /// </summary>
        public short? HCOL { get; internal set; }
        /// <summary>
        /// Block control [Uppercase Alphanumeric: u1]
        /// </summary>
        public string BLOCK { get; internal set; }
        /// <summary>
        /// Lock status on grid line: 0=Unlock, 1=Lock subject, 2=Lock line, 3=Lock both line & subject [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LOCK { get; internal set; }
        /// <summary>
        /// Tied chain no [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TCHAIN { get; internal set; }
        /// <summary>
        /// Link chain no [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LCHAIN { get; internal set; }
        /// <summary>
        /// Inserted by Schema Verify [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TIED_COL { get; internal set; }
        /// <summary>
        /// Inserted by Schema Verify [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LINK_COL { get; internal set; }
        /// <summary>
        /// Max # classes that subject can have on any row [Integer (16bit signed nullable): i]
        /// </summary>
        public short? MAX_ROW_CLASSES { get; internal set; }
        /// <summary>
        /// Describe lines on a grid with a block equivalent [Uppercase Alphanumeric: u2]
        /// </summary>
        public string ROW_GROUP { get; internal set; }
        /// <summary>
        /// # Double periods. Applies if Unit value > 1 [Integer (16bit signed nullable): i]
        /// </summary>
        public short? DOUBLE_PERIODS { get; internal set; }
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
