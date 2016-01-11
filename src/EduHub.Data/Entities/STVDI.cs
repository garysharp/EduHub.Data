using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// VELS Dimension Results
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STVDI : EduHubEntity
    {

        #region Navigation Property Cache

        private ST Cache_SKEY_ST;
        private KCY Cache_SCHOOL_YEAR_KCY;
        private SCI Cache_CAMPUS_SCI;
        private KDO Cache_VDOMAIN_KDO;
        private KDI Cache_VDIMENSION_KDI;

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
        /// Year level at the time of result
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SCHOOL_YEAR { get; internal set; }

        /// <summary>
        /// Campus at the time of the result
        /// </summary>
        public int? CAMPUS { get; internal set; }

        /// <summary>
        /// YYYY.S eg 2005.1
        /// [Alphanumeric (6)]
        /// </summary>
        public string YEAR_SEMESTER { get; internal set; }

        /// <summary>
        /// Link to domain
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string VDOMAIN { get; internal set; }

        /// <summary>
        /// Link to dimension
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string VDIMENSION { get; internal set; }

        /// <summary>
        /// Numerical assessment for the dimension - could be NA
        /// [Alphanumeric (4)]
        /// </summary>
        public string SCORE { get; internal set; }

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
        /// ST (Students) related entity by [STVDI.SKEY]-&gt;[ST.STKEY]
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
        /// KCY (Year Levels) related entity by [STVDI.SCHOOL_YEAR]-&gt;[KCY.KCYKEY]
        /// Year level at the time of result
        /// </summary>
        public KCY SCHOOL_YEAR_KCY
        {
            get
            {
                if (SCHOOL_YEAR == null)
                {
                    return null;
                }
                if (Cache_SCHOOL_YEAR_KCY == null)
                {
                    Cache_SCHOOL_YEAR_KCY = Context.KCY.FindByKCYKEY(SCHOOL_YEAR);
                }

                return Cache_SCHOOL_YEAR_KCY;
            }
        }

        /// <summary>
        /// SCI (School Information) related entity by [STVDI.CAMPUS]-&gt;[SCI.SCIKEY]
        /// Campus at the time of the result
        /// </summary>
        public SCI CAMPUS_SCI
        {
            get
            {
                if (CAMPUS == null)
                {
                    return null;
                }
                if (Cache_CAMPUS_SCI == null)
                {
                    Cache_CAMPUS_SCI = Context.SCI.FindBySCIKEY(CAMPUS.Value);
                }

                return Cache_CAMPUS_SCI;
            }
        }

        /// <summary>
        /// KDO (VELS Domains) related entity by [STVDI.VDOMAIN]-&gt;[KDO.KDOKEY]
        /// Link to domain
        /// </summary>
        public KDO VDOMAIN_KDO
        {
            get
            {
                if (VDOMAIN == null)
                {
                    return null;
                }
                if (Cache_VDOMAIN_KDO == null)
                {
                    Cache_VDOMAIN_KDO = Context.KDO.FindByKDOKEY(VDOMAIN);
                }

                return Cache_VDOMAIN_KDO;
            }
        }

        /// <summary>
        /// KDI (VELS Dimensions) related entity by [STVDI.VDIMENSION]-&gt;[KDI.KDIKEY]
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
