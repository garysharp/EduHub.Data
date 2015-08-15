using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// CSF Data Aggregates
    /// </summary>
    public class SCSFAG_Entity : EntityBase
    {
#region Navigation Property Cache
        private SCSF_Entity _SCSFKEY_SCSF;
        private KCY_Entity _ST_YEAR_LEVEL_KCY;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// CSF Outcome Code (identifies KLA and Strand) [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SCSFKEY { get; internal set; }
        /// <summary>
        /// Year and semester during which test administered (eg 2000.1) [Uppercase Alphanumeric: u6]
        /// </summary>
        public string YEAR_SEMESTER { get; internal set; }
        /// <summary>
        /// Campus of assessed students [Integer (32bit signed nullable): l]
        /// </summary>
        public int? ST_CAMPUS { get; internal set; }
        /// <summary>
        /// Year level of assessed students [Uppercase Alphanumeric: u4]
        /// </summary>
        public string ST_YEAR_LEVEL { get; internal set; }
        /// <summary>
        /// Category of this group [Uppercase Alphanumeric: u2]
        /// </summary>
        public string ST_CATEGORY { get; internal set; }
        /// <summary>
        /// Total number of students in this group [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TOTAL_IN_GROUP { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT01 { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT02 { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT03 { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT04 { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT05 { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT06 { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT07 { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT08 { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT09 { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT10 { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT11 { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT12 { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT13 { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT14 { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT15 { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT16 { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT17 { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT18 { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT19 { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT20 { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT21 { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT22 { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT23 { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT24 { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT25 { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT26 { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT27 { get; internal set; }
        /// <summary>
        /// Number of students with a total of n (eg NUMBER_AT20 holds the number of students with a total of 20) (only 7-28 are used) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT28 { get; internal set; }
        /// <summary>
        /// School mean for this group/outcome [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? SCHOOL_MEAN { get; internal set; }
        /// <summary>
        /// School minimum for this group/outcome [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? SCHOOL_MIN { get; internal set; }
        /// <summary>
        /// School maximum for this group/outcome [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? SCHOOL_MAX { get; internal set; }
        /// <summary>
        /// School's 15th percentile for this group/outcome [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? SCHOOL_15TH { get; internal set; }
        /// <summary>
        /// School's 25th percentile for this group/outcome [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? SCHOOL_25TH { get; internal set; }
        /// <summary>
        /// School's 75th percentile for this group/outcome [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? SCHOOL_75TH { get; internal set; }
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
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [SCSFKEY] => [SCSF_Entity].[SCSFKEY]
        /// CSF Outcome Code (identifies KLA and Strand)
        /// </summary>
        public SCSF_Entity SCSFKEY_SCSF {
            get
            {
                if (SCSFKEY != null)
                {
                    if (_SCSFKEY_SCSF == null)
                    {
                        _SCSFKEY_SCSF = Context.SCSF.FindBySCSFKEY(SCSFKEY);
                    }
                    return _SCSFKEY_SCSF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [ST_YEAR_LEVEL] => [KCY_Entity].[KCYKEY]
        /// Year level of assessed students
        /// </summary>
        public KCY_Entity ST_YEAR_LEVEL_KCY {
            get
            {
                if (ST_YEAR_LEVEL != null)
                {
                    if (_ST_YEAR_LEVEL_KCY == null)
                    {
                        _ST_YEAR_LEVEL_KCY = Context.KCY.FindByKCYKEY(ST_YEAR_LEVEL);
                    }
                    return _ST_YEAR_LEVEL_KCY;
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
