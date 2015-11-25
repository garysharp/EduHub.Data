using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Transport Usage
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STBT : EntityBase
    {

        #region Navigation Property Cache

        private ST Cache_STBTKEY_ST;
        private KCR Cache_ROUTE_KCR;
        private SCI Cache_AM1_SD_SITE_SCI;
        private KCR Cache_AM1_ROUTE_KCR;
        private SCI Cache_PM1_PU_SITE_SCI;
        private KCR Cache_PM1_ROUTE_KCR;
        private SCI Cache_AM2_SD_SITE_SCI;
        private KCR Cache_AM2_ROUTE_KCR;
        private SCI Cache_PM2_PU_SITE_SCI;
        private KCR Cache_PM2_ROUTE_KCR;
        private SCI Cache_AM3_SD_SITE_SCI;
        private KCR Cache_AM3_ROUTE_KCR;
        private SCI Cache_PM3_PU_SITE_SCI;
        private KCR Cache_PM3_ROUTE_KCR;
        private SCI Cache_AM4_SD_SITE_SCI;
        private KCR Cache_AM4_ROUTE_KCR;
        private SCI Cache_PM4_PU_SITE_SCI;
        private KCR Cache_PM4_ROUTE_KCR;
        private SCI Cache_AM5_SD_SITE_SCI;
        private KCR Cache_AM5_ROUTE_KCR;
        private SCI Cache_PM5_PU_SITE_SCI;
        private KCR Cache_PM5_ROUTE_KCR;

        #endregion

        #region Field Properties

        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Student ID
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string STBTKEY { get; internal set; }

        /// <summary>
        /// Transport route or stop used
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string ROUTE { get; internal set; }

        /// <summary>
        /// Mon - Fri &lt;&lt; What is actually stored in this field?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DAYS_USED01 { get; internal set; }

        /// <summary>
        /// Mon - Fri &lt;&lt; What is actually stored in this field?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DAYS_USED02 { get; internal set; }

        /// <summary>
        /// Mon - Fri &lt;&lt; What is actually stored in this field?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DAYS_USED03 { get; internal set; }

        /// <summary>
        /// Mon - Fri &lt;&lt; What is actually stored in this field?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DAYS_USED04 { get; internal set; }

        /// <summary>
        /// Mon - Fri &lt;&lt; What is actually stored in this field?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DAYS_USED05 { get; internal set; }

        /// <summary>
        /// (Was BUS_NOTES) Any annotation about this student's transport usage
        /// [Memo]
        /// </summary>
        public string TRANSPORT_NOTES { get; internal set; }

        /// <summary>
        /// First day of use
        /// </summary>
        public DateTime? DATE_STARTED { get; internal set; }

        /// <summary>
        /// Date use ceased
        /// </summary>
        public DateTime? TERMINATED { get; internal set; }

        /// <summary>
        /// Morning pick-up time on Day 1
        /// </summary>
        public short? AM1_PICKUP { get; internal set; }

        /// <summary>
        /// Morning pick-up site on Day 1 (could be map ref)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string AM1_PU_SITE { get; internal set; }

        /// <summary>
        /// Morning arrival time on Day 1
        /// </summary>
        public short? AM1_SETDOWN { get; internal set; }

        /// <summary>
        /// Set-down campus on Day 1
        /// </summary>
        public int? AM1_SD_SITE { get; internal set; }

        /// <summary>
        /// Transport route/stop used in the morning on Day 1
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string AM1_ROUTE { get; internal set; }

        /// <summary>
        /// Afternoon pickup time on Day 1
        /// </summary>
        public short? PM1_PICKUP { get; internal set; }

        /// <summary>
        /// Pick-up campus on Day 1
        /// </summary>
        public int? PM1_PU_SITE { get; internal set; }

        /// <summary>
        /// Afternoon arrival time on Day 1
        /// </summary>
        public short? PM1_SETDOWN { get; internal set; }

        /// <summary>
        /// Afternoon set-down site on Day 1 (could be map ref)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string PM1_SD_SITE { get; internal set; }

        /// <summary>
        /// Transport route/stop used in the afternoon on Day 1
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string PM1_ROUTE { get; internal set; }

        /// <summary>
        /// Morning pick-up time on Day 2
        /// </summary>
        public short? AM2_PICKUP { get; internal set; }

        /// <summary>
        /// Morning pick-up site on Day 2 (could be map ref)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string AM2_PU_SITE { get; internal set; }

        /// <summary>
        /// Morning arrival time on Day 2
        /// </summary>
        public short? AM2_SETDOWN { get; internal set; }

        /// <summary>
        /// Set-down campus on Day 2
        /// </summary>
        public int? AM2_SD_SITE { get; internal set; }

        /// <summary>
        /// Transport route/stop used in the morning on Day 2
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string AM2_ROUTE { get; internal set; }

        /// <summary>
        /// Afternoon pickup time on Day 2
        /// </summary>
        public short? PM2_PICKUP { get; internal set; }

        /// <summary>
        /// Pick-up campus on Day 2
        /// </summary>
        public int? PM2_PU_SITE { get; internal set; }

        /// <summary>
        /// Afternoon arrival time on Day 2
        /// </summary>
        public short? PM2_SETDOWN { get; internal set; }

        /// <summary>
        /// Afternoon set-down site on Day 2 (could be map ref)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string PM2_SD_SITE { get; internal set; }

        /// <summary>
        /// Transport route/stop used in the afternoon on Day 2
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string PM2_ROUTE { get; internal set; }

        /// <summary>
        /// Morning pick-up time on Day 3
        /// </summary>
        public short? AM3_PICKUP { get; internal set; }

        /// <summary>
        /// Morning pick-up site on Day 3 (could be map ref)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string AM3_PU_SITE { get; internal set; }

        /// <summary>
        /// Morning arrival time on Day 3
        /// </summary>
        public short? AM3_SETDOWN { get; internal set; }

        /// <summary>
        /// Set-down campus on Day 3
        /// </summary>
        public int? AM3_SD_SITE { get; internal set; }

        /// <summary>
        /// Transport route/stop used in the morning on Day 3
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string AM3_ROUTE { get; internal set; }

        /// <summary>
        /// Afternoon pickup time on Day 3
        /// </summary>
        public short? PM3_PICKUP { get; internal set; }

        /// <summary>
        /// Pick-up campus on Day 3
        /// </summary>
        public int? PM3_PU_SITE { get; internal set; }

        /// <summary>
        /// Afternoon arrival time on Day 3
        /// </summary>
        public short? PM3_SETDOWN { get; internal set; }

        /// <summary>
        /// Afternoon set-down site on Day 3 (could be map ref)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string PM3_SD_SITE { get; internal set; }

        /// <summary>
        /// Transport route/stop used in the afternoon on Day 3
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string PM3_ROUTE { get; internal set; }

        /// <summary>
        /// Morning pick-up time on Day 4
        /// </summary>
        public short? AM4_PICKUP { get; internal set; }

        /// <summary>
        /// Morning pick-up site on Day 4 (could be map ref)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string AM4_PU_SITE { get; internal set; }

        /// <summary>
        /// Morning arrival time on Day 4
        /// </summary>
        public short? AM4_SETDOWN { get; internal set; }

        /// <summary>
        /// Set-down campus on Day 4
        /// </summary>
        public int? AM4_SD_SITE { get; internal set; }

        /// <summary>
        /// Transport route/stop used in the morning on Day 4
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string AM4_ROUTE { get; internal set; }

        /// <summary>
        /// Afternoon pickup time on Day 4
        /// </summary>
        public short? PM4_PICKUP { get; internal set; }

        /// <summary>
        /// Pick-up campus on Day 4
        /// </summary>
        public int? PM4_PU_SITE { get; internal set; }

        /// <summary>
        /// Afternoon arrival time on Day 4
        /// </summary>
        public short? PM4_SETDOWN { get; internal set; }

        /// <summary>
        /// Afternoon set-down site on Day 4 (could be map ref)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string PM4_SD_SITE { get; internal set; }

        /// <summary>
        /// Transport route/stop used in the afternoon on Day 4
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string PM4_ROUTE { get; internal set; }

        /// <summary>
        /// Morning pick-up time on Day 5
        /// </summary>
        public short? AM5_PICKUP { get; internal set; }

        /// <summary>
        /// Morning pick-up site on Day 5 (could be map ref)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string AM5_PU_SITE { get; internal set; }

        /// <summary>
        /// Morning arrival time on Day 5
        /// </summary>
        public short? AM5_SETDOWN { get; internal set; }

        /// <summary>
        /// Set-down campus on Day 5
        /// </summary>
        public int? AM5_SD_SITE { get; internal set; }

        /// <summary>
        /// Transport route/stop used in the morning on Day 5
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string AM5_ROUTE { get; internal set; }

        /// <summary>
        /// Afternoon pickup time on Day 5
        /// </summary>
        public short? PM5_PICKUP { get; internal set; }

        /// <summary>
        /// Pick-up campus on Day 5
        /// </summary>
        public int? PM5_PU_SITE { get; internal set; }

        /// <summary>
        /// Afternoon arrival time on Day 5
        /// </summary>
        public short? PM5_SETDOWN { get; internal set; }

        /// <summary>
        /// Afternoon set-down site on Day 5 (could be map ref)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string PM5_SD_SITE { get; internal set; }

        /// <summary>
        /// Transport route/stop used in the afternoon on Day 5
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string PM5_ROUTE { get; internal set; }

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
        /// ST (Students) related entity by [STBT.STBTKEY]-&gt;[ST.STKEY]
        /// Student ID
        /// </summary>
        public ST STBTKEY_ST
        {
            get
            {
                if (Cache_STBTKEY_ST == null)
                {
                    Cache_STBTKEY_ST = Context.ST.FindBySTKEY(STBTKEY);
                }

                return Cache_STBTKEY_ST;
            }
        }

        /// <summary>
        /// KCR (Transport Routes/Stops) related entity by [STBT.ROUTE]-&gt;[KCR.KCRKEY]
        /// Transport route or stop used
        /// </summary>
        public KCR ROUTE_KCR
        {
            get
            {
                if (ROUTE == null)
                {
                    return null;
                }
                if (Cache_ROUTE_KCR == null)
                {
                    Cache_ROUTE_KCR = Context.KCR.FindByKCRKEY(ROUTE);
                }

                return Cache_ROUTE_KCR;
            }
        }

        /// <summary>
        /// SCI (School Information) related entity by [STBT.AM1_SD_SITE]-&gt;[SCI.SCIKEY]
        /// Set-down campus on Day 1
        /// </summary>
        public SCI AM1_SD_SITE_SCI
        {
            get
            {
                if (AM1_SD_SITE == null)
                {
                    return null;
                }
                if (Cache_AM1_SD_SITE_SCI == null)
                {
                    Cache_AM1_SD_SITE_SCI = Context.SCI.FindBySCIKEY(AM1_SD_SITE.Value);
                }

                return Cache_AM1_SD_SITE_SCI;
            }
        }

        /// <summary>
        /// KCR (Transport Routes/Stops) related entity by [STBT.AM1_ROUTE]-&gt;[KCR.KCRKEY]
        /// Transport route/stop used in the morning on Day 1
        /// </summary>
        public KCR AM1_ROUTE_KCR
        {
            get
            {
                if (AM1_ROUTE == null)
                {
                    return null;
                }
                if (Cache_AM1_ROUTE_KCR == null)
                {
                    Cache_AM1_ROUTE_KCR = Context.KCR.FindByKCRKEY(AM1_ROUTE);
                }

                return Cache_AM1_ROUTE_KCR;
            }
        }

        /// <summary>
        /// SCI (School Information) related entity by [STBT.PM1_PU_SITE]-&gt;[SCI.SCIKEY]
        /// Pick-up campus on Day 1
        /// </summary>
        public SCI PM1_PU_SITE_SCI
        {
            get
            {
                if (PM1_PU_SITE == null)
                {
                    return null;
                }
                if (Cache_PM1_PU_SITE_SCI == null)
                {
                    Cache_PM1_PU_SITE_SCI = Context.SCI.FindBySCIKEY(PM1_PU_SITE.Value);
                }

                return Cache_PM1_PU_SITE_SCI;
            }
        }

        /// <summary>
        /// KCR (Transport Routes/Stops) related entity by [STBT.PM1_ROUTE]-&gt;[KCR.KCRKEY]
        /// Transport route/stop used in the afternoon on Day 1
        /// </summary>
        public KCR PM1_ROUTE_KCR
        {
            get
            {
                if (PM1_ROUTE == null)
                {
                    return null;
                }
                if (Cache_PM1_ROUTE_KCR == null)
                {
                    Cache_PM1_ROUTE_KCR = Context.KCR.FindByKCRKEY(PM1_ROUTE);
                }

                return Cache_PM1_ROUTE_KCR;
            }
        }

        /// <summary>
        /// SCI (School Information) related entity by [STBT.AM2_SD_SITE]-&gt;[SCI.SCIKEY]
        /// Set-down campus on Day 2
        /// </summary>
        public SCI AM2_SD_SITE_SCI
        {
            get
            {
                if (AM2_SD_SITE == null)
                {
                    return null;
                }
                if (Cache_AM2_SD_SITE_SCI == null)
                {
                    Cache_AM2_SD_SITE_SCI = Context.SCI.FindBySCIKEY(AM2_SD_SITE.Value);
                }

                return Cache_AM2_SD_SITE_SCI;
            }
        }

        /// <summary>
        /// KCR (Transport Routes/Stops) related entity by [STBT.AM2_ROUTE]-&gt;[KCR.KCRKEY]
        /// Transport route/stop used in the morning on Day 2
        /// </summary>
        public KCR AM2_ROUTE_KCR
        {
            get
            {
                if (AM2_ROUTE == null)
                {
                    return null;
                }
                if (Cache_AM2_ROUTE_KCR == null)
                {
                    Cache_AM2_ROUTE_KCR = Context.KCR.FindByKCRKEY(AM2_ROUTE);
                }

                return Cache_AM2_ROUTE_KCR;
            }
        }

        /// <summary>
        /// SCI (School Information) related entity by [STBT.PM2_PU_SITE]-&gt;[SCI.SCIKEY]
        /// Pick-up campus on Day 2
        /// </summary>
        public SCI PM2_PU_SITE_SCI
        {
            get
            {
                if (PM2_PU_SITE == null)
                {
                    return null;
                }
                if (Cache_PM2_PU_SITE_SCI == null)
                {
                    Cache_PM2_PU_SITE_SCI = Context.SCI.FindBySCIKEY(PM2_PU_SITE.Value);
                }

                return Cache_PM2_PU_SITE_SCI;
            }
        }

        /// <summary>
        /// KCR (Transport Routes/Stops) related entity by [STBT.PM2_ROUTE]-&gt;[KCR.KCRKEY]
        /// Transport route/stop used in the afternoon on Day 2
        /// </summary>
        public KCR PM2_ROUTE_KCR
        {
            get
            {
                if (PM2_ROUTE == null)
                {
                    return null;
                }
                if (Cache_PM2_ROUTE_KCR == null)
                {
                    Cache_PM2_ROUTE_KCR = Context.KCR.FindByKCRKEY(PM2_ROUTE);
                }

                return Cache_PM2_ROUTE_KCR;
            }
        }

        /// <summary>
        /// SCI (School Information) related entity by [STBT.AM3_SD_SITE]-&gt;[SCI.SCIKEY]
        /// Set-down campus on Day 3
        /// </summary>
        public SCI AM3_SD_SITE_SCI
        {
            get
            {
                if (AM3_SD_SITE == null)
                {
                    return null;
                }
                if (Cache_AM3_SD_SITE_SCI == null)
                {
                    Cache_AM3_SD_SITE_SCI = Context.SCI.FindBySCIKEY(AM3_SD_SITE.Value);
                }

                return Cache_AM3_SD_SITE_SCI;
            }
        }

        /// <summary>
        /// KCR (Transport Routes/Stops) related entity by [STBT.AM3_ROUTE]-&gt;[KCR.KCRKEY]
        /// Transport route/stop used in the morning on Day 3
        /// </summary>
        public KCR AM3_ROUTE_KCR
        {
            get
            {
                if (AM3_ROUTE == null)
                {
                    return null;
                }
                if (Cache_AM3_ROUTE_KCR == null)
                {
                    Cache_AM3_ROUTE_KCR = Context.KCR.FindByKCRKEY(AM3_ROUTE);
                }

                return Cache_AM3_ROUTE_KCR;
            }
        }

        /// <summary>
        /// SCI (School Information) related entity by [STBT.PM3_PU_SITE]-&gt;[SCI.SCIKEY]
        /// Pick-up campus on Day 3
        /// </summary>
        public SCI PM3_PU_SITE_SCI
        {
            get
            {
                if (PM3_PU_SITE == null)
                {
                    return null;
                }
                if (Cache_PM3_PU_SITE_SCI == null)
                {
                    Cache_PM3_PU_SITE_SCI = Context.SCI.FindBySCIKEY(PM3_PU_SITE.Value);
                }

                return Cache_PM3_PU_SITE_SCI;
            }
        }

        /// <summary>
        /// KCR (Transport Routes/Stops) related entity by [STBT.PM3_ROUTE]-&gt;[KCR.KCRKEY]
        /// Transport route/stop used in the afternoon on Day 3
        /// </summary>
        public KCR PM3_ROUTE_KCR
        {
            get
            {
                if (PM3_ROUTE == null)
                {
                    return null;
                }
                if (Cache_PM3_ROUTE_KCR == null)
                {
                    Cache_PM3_ROUTE_KCR = Context.KCR.FindByKCRKEY(PM3_ROUTE);
                }

                return Cache_PM3_ROUTE_KCR;
            }
        }

        /// <summary>
        /// SCI (School Information) related entity by [STBT.AM4_SD_SITE]-&gt;[SCI.SCIKEY]
        /// Set-down campus on Day 4
        /// </summary>
        public SCI AM4_SD_SITE_SCI
        {
            get
            {
                if (AM4_SD_SITE == null)
                {
                    return null;
                }
                if (Cache_AM4_SD_SITE_SCI == null)
                {
                    Cache_AM4_SD_SITE_SCI = Context.SCI.FindBySCIKEY(AM4_SD_SITE.Value);
                }

                return Cache_AM4_SD_SITE_SCI;
            }
        }

        /// <summary>
        /// KCR (Transport Routes/Stops) related entity by [STBT.AM4_ROUTE]-&gt;[KCR.KCRKEY]
        /// Transport route/stop used in the morning on Day 4
        /// </summary>
        public KCR AM4_ROUTE_KCR
        {
            get
            {
                if (AM4_ROUTE == null)
                {
                    return null;
                }
                if (Cache_AM4_ROUTE_KCR == null)
                {
                    Cache_AM4_ROUTE_KCR = Context.KCR.FindByKCRKEY(AM4_ROUTE);
                }

                return Cache_AM4_ROUTE_KCR;
            }
        }

        /// <summary>
        /// SCI (School Information) related entity by [STBT.PM4_PU_SITE]-&gt;[SCI.SCIKEY]
        /// Pick-up campus on Day 4
        /// </summary>
        public SCI PM4_PU_SITE_SCI
        {
            get
            {
                if (PM4_PU_SITE == null)
                {
                    return null;
                }
                if (Cache_PM4_PU_SITE_SCI == null)
                {
                    Cache_PM4_PU_SITE_SCI = Context.SCI.FindBySCIKEY(PM4_PU_SITE.Value);
                }

                return Cache_PM4_PU_SITE_SCI;
            }
        }

        /// <summary>
        /// KCR (Transport Routes/Stops) related entity by [STBT.PM4_ROUTE]-&gt;[KCR.KCRKEY]
        /// Transport route/stop used in the afternoon on Day 4
        /// </summary>
        public KCR PM4_ROUTE_KCR
        {
            get
            {
                if (PM4_ROUTE == null)
                {
                    return null;
                }
                if (Cache_PM4_ROUTE_KCR == null)
                {
                    Cache_PM4_ROUTE_KCR = Context.KCR.FindByKCRKEY(PM4_ROUTE);
                }

                return Cache_PM4_ROUTE_KCR;
            }
        }

        /// <summary>
        /// SCI (School Information) related entity by [STBT.AM5_SD_SITE]-&gt;[SCI.SCIKEY]
        /// Set-down campus on Day 5
        /// </summary>
        public SCI AM5_SD_SITE_SCI
        {
            get
            {
                if (AM5_SD_SITE == null)
                {
                    return null;
                }
                if (Cache_AM5_SD_SITE_SCI == null)
                {
                    Cache_AM5_SD_SITE_SCI = Context.SCI.FindBySCIKEY(AM5_SD_SITE.Value);
                }

                return Cache_AM5_SD_SITE_SCI;
            }
        }

        /// <summary>
        /// KCR (Transport Routes/Stops) related entity by [STBT.AM5_ROUTE]-&gt;[KCR.KCRKEY]
        /// Transport route/stop used in the morning on Day 5
        /// </summary>
        public KCR AM5_ROUTE_KCR
        {
            get
            {
                if (AM5_ROUTE == null)
                {
                    return null;
                }
                if (Cache_AM5_ROUTE_KCR == null)
                {
                    Cache_AM5_ROUTE_KCR = Context.KCR.FindByKCRKEY(AM5_ROUTE);
                }

                return Cache_AM5_ROUTE_KCR;
            }
        }

        /// <summary>
        /// SCI (School Information) related entity by [STBT.PM5_PU_SITE]-&gt;[SCI.SCIKEY]
        /// Pick-up campus on Day 5
        /// </summary>
        public SCI PM5_PU_SITE_SCI
        {
            get
            {
                if (PM5_PU_SITE == null)
                {
                    return null;
                }
                if (Cache_PM5_PU_SITE_SCI == null)
                {
                    Cache_PM5_PU_SITE_SCI = Context.SCI.FindBySCIKEY(PM5_PU_SITE.Value);
                }

                return Cache_PM5_PU_SITE_SCI;
            }
        }

        /// <summary>
        /// KCR (Transport Routes/Stops) related entity by [STBT.PM5_ROUTE]-&gt;[KCR.KCRKEY]
        /// Transport route/stop used in the afternoon on Day 5
        /// </summary>
        public KCR PM5_ROUTE_KCR
        {
            get
            {
                if (PM5_ROUTE == null)
                {
                    return null;
                }
                if (Cache_PM5_ROUTE_KCR == null)
                {
                    Cache_PM5_ROUTE_KCR = Context.KCR.FindByKCRKEY(PM5_ROUTE);
                }

                return Cache_PM5_ROUTE_KCR;
            }
        }

        #endregion

    }
}
