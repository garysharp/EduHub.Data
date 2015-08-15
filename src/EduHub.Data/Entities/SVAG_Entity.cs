using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// VELS Aggregated Dimensions
    /// </summary>
    public class SVAG_Entity : EntityBase
    {
#region Navigation Property Cache
        private KCOHORT_Entity _COHORT_KCOHORT;
        private KCY_Entity _SCHOOL_YEAR_KCY;
        private KDI_Entity _VDIMENSION_KDI;
#endregion

#region Field Properties
        /// <summary>
        /// Unique identification of record [Integer (32bit signed): l]
        /// </summary>
        public int SVAGKEY { get; internal set; }
        /// <summary>
        /// Link to cohort [Alphanumeric: a2]
        /// </summary>
        public string COHORT { get; internal set; }
        /// <summary>
        /// Year level of cohort [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SCHOOL_YEAR { get; internal set; }
        /// <summary>
        /// Campus number of cohort [Integer (32bit signed nullable): l]
        /// </summary>
        public int? CAMPUS { get; internal set; }
        /// <summary>
        /// Year and semester YYYY.S eg 2005.1 [Alphanumeric: a6]
        /// </summary>
        public string YEAR_SEMESTER { get; internal set; }
        /// <summary>
        /// Link to dimension [Uppercase Alphanumeric: u10]
        /// </summary>
        public string VDIMENSION { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT01 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT02 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT03 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT04 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT05 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT06 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT07 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT08 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT09 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT10 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT11 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT12 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT13 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT14 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT15 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT16 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT17 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT18 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT19 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT20 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT21 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT22 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT23 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT24 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT25 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT26 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT27 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT28 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT29 { get; internal set; }
        /// <summary>
        /// Number of students with each dimension score [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NUMBER_AT30 { get; internal set; }
        /// <summary>
        /// Number of students that have a dimension score of N/A [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NO_NA { get; internal set; }
        /// <summary>
        /// Number of students in cohort [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TOTAL_NUMBER { get; internal set; }
        /// <summary>
        /// Datetime of when record was extracted into SAB export [Date Time nullable: d]
        /// </summary>
        public DateTime? SENT_TO_DEET { get; internal set; }
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
        /// Navigation property for [COHORT] => [KCOHORT_Entity].[COHORT]
        /// Link to cohort
        /// </summary>
        public KCOHORT_Entity COHORT_KCOHORT {
            get
            {
                if (COHORT != null)
                {
                    if (_COHORT_KCOHORT == null)
                    {
                        _COHORT_KCOHORT = Context.KCOHORT.FindByCOHORT(COHORT);
                    }
                    return _COHORT_KCOHORT;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SCHOOL_YEAR] => [KCY_Entity].[KCYKEY]
        /// Year level of cohort
        /// </summary>
        public KCY_Entity SCHOOL_YEAR_KCY {
            get
            {
                if (SCHOOL_YEAR != null)
                {
                    if (_SCHOOL_YEAR_KCY == null)
                    {
                        _SCHOOL_YEAR_KCY = Context.KCY.FindByKCYKEY(SCHOOL_YEAR);
                    }
                    return _SCHOOL_YEAR_KCY;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [VDIMENSION] => [KDI_Entity].[KDIKEY]
        /// Link to dimension
        /// </summary>
        public KDI_Entity VDIMENSION_KDI {
            get
            {
                if (VDIMENSION != null)
                {
                    if (_VDIMENSION_KDI == null)
                    {
                        _VDIMENSION_KDI = Context.KDI.FindByKDIKEY(VDIMENSION);
                    }
                    return _VDIMENSION_KDI;
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
