using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// VELS Aggregated Dimensions
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SVAG : EduHubEntity
    {

        #region Navigation Property Cache

        private KCOHORT Cache_COHORT_KCOHORT;
        private KDI Cache_VDIMENSION_KDI;

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
        /// Unique identification of record
        /// </summary>
        public int SVAGKEY { get; internal set; }

        /// <summary>
        /// Link to cohort
        /// [Alphanumeric (2)]
        /// </summary>
        public string COHORT { get; internal set; }

        /// <summary>
        /// Year level of cohort
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SCHOOL_YEAR { get; internal set; }

        /// <summary>
        /// Campus number of cohort
        /// </summary>
        public int? CAMPUS { get; internal set; }

        /// <summary>
        /// Year and semester YYYY.S eg 2005.1
        /// [Alphanumeric (6)]
        /// </summary>
        public string YEAR_SEMESTER { get; internal set; }

        /// <summary>
        /// Link to dimension
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string VDIMENSION { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT01 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT02 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT03 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT04 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT05 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT06 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT07 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT08 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT09 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT10 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT11 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT12 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT13 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT14 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT15 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT16 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT17 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT18 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT19 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT20 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT21 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT22 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT23 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT24 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT25 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT26 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT27 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT28 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT29 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT30 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT31 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT32 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT33 { get; internal set; }

        /// <summary>
        /// Number of students with each dimension score
        /// </summary>
        public short? NUMBER_AT34 { get; internal set; }

        /// <summary>
        /// Number of students that have a dimension score of N/A
        /// </summary>
        public short? NO_NA { get; internal set; }

        /// <summary>
        /// Number of students that have a dimension score of NT (Not Taught)
        /// </summary>
        public short? NO_NT { get; internal set; }

        /// <summary>
        /// Number of students that have a score of DNP (Did not participate)
        /// </summary>
        public short? NO_DNP { get; internal set; }

        /// <summary>
        /// Number of students in cohort
        /// </summary>
        public short? TOTAL_NUMBER { get; internal set; }

        /// <summary>
        /// Datetime of when record was extracted into SAB export
        /// </summary>
        public DateTime? SENT_TO_DEET { get; internal set; }

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
        /// KCOHORT (Cohorts for data aggregation) related entity by [SVAG.COHORT]-&gt;[KCOHORT.COHORT]
        /// Link to cohort
        /// </summary>
        public KCOHORT COHORT_KCOHORT
        {
            get
            {
                if (COHORT == null)
                {
                    return null;
                }
                if (Cache_COHORT_KCOHORT == null)
                {
                    Cache_COHORT_KCOHORT = Context.KCOHORT.FindByCOHORT(COHORT);
                }

                return Cache_COHORT_KCOHORT;
            }
        }

        /// <summary>
        /// KDI (Victorian Curriculum Strands) related entity by [SVAG.VDIMENSION]-&gt;[KDI.KDIKEY]
        /// Link to dimension
        /// </summary>
        public KDI VDIMENSION_KDI
        {
            get
            {
                if (VDIMENSION == null)
                {
                    return null;
                }
                if (Cache_VDIMENSION_KDI == null)
                {
                    Cache_VDIMENSION_KDI = Context.KDI.FindByKDIKEY(VDIMENSION);
                }

                return Cache_VDIMENSION_KDI;
            }
        }

        #endregion

    }
}
