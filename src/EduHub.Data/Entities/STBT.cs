using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Transport Usage
    /// </summary>
    public class STBT : EntityBase
    {
#region Navigation Property Cache
        private ST _STBTKEY_ST;
        private KCR _ROUTE_KCR;
        private SCI _AM1_SD_SITE_SCI;
        private KCR _AM1_ROUTE_KCR;
        private SCI _PM1_PU_SITE_SCI;
        private KCR _PM1_ROUTE_KCR;
        private SCI _AM2_SD_SITE_SCI;
        private KCR _AM2_ROUTE_KCR;
        private SCI _PM2_PU_SITE_SCI;
        private KCR _PM2_ROUTE_KCR;
        private SCI _AM3_SD_SITE_SCI;
        private KCR _AM3_ROUTE_KCR;
        private SCI _PM3_PU_SITE_SCI;
        private KCR _PM3_ROUTE_KCR;
        private SCI _AM4_SD_SITE_SCI;
        private KCR _AM4_ROUTE_KCR;
        private SCI _PM4_PU_SITE_SCI;
        private KCR _PM4_ROUTE_KCR;
        private SCI _AM5_SD_SITE_SCI;
        private KCR _AM5_ROUTE_KCR;
        private SCI _PM5_PU_SITE_SCI;
        private KCR _PM5_ROUTE_KCR;
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
        /// Navigation property for [STBTKEY] => [ST].[STKEY]
        /// Student ID
        /// </summary>
        public ST STBTKEY_ST {
            get
            {
                if (STBTKEY != null)
                {
                    if (_STBTKEY_ST == null)
                    {
                        _STBTKEY_ST = Context.ST.FindBySTKEY(STBTKEY);
                    }
                    return _STBTKEY_ST;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [ROUTE] => [KCR].[KCRKEY]
        /// Transport route or stop used
        /// </summary>
        public KCR ROUTE_KCR {
            get
            {
                if (ROUTE != null)
                {
                    if (_ROUTE_KCR == null)
                    {
                        _ROUTE_KCR = Context.KCR.FindByKCRKEY(ROUTE);
                    }
                    return _ROUTE_KCR;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [AM1_SD_SITE] => [SCI].[SCIKEY]
        /// Set-down campus on Day 1
        /// </summary>
        public SCI AM1_SD_SITE_SCI {
            get
            {
                if (AM1_SD_SITE.HasValue)
                {
                    if (_AM1_SD_SITE_SCI == null)
                    {
                        _AM1_SD_SITE_SCI = Context.SCI.FindBySCIKEY(AM1_SD_SITE.Value);
                    }
                    return _AM1_SD_SITE_SCI;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [AM1_ROUTE] => [KCR].[KCRKEY]
        /// Transport route/stop used in the morning on Day 1
        /// </summary>
        public KCR AM1_ROUTE_KCR {
            get
            {
                if (AM1_ROUTE != null)
                {
                    if (_AM1_ROUTE_KCR == null)
                    {
                        _AM1_ROUTE_KCR = Context.KCR.FindByKCRKEY(AM1_ROUTE);
                    }
                    return _AM1_ROUTE_KCR;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PM1_PU_SITE] => [SCI].[SCIKEY]
        /// Pick-up campus on Day 1
        /// </summary>
        public SCI PM1_PU_SITE_SCI {
            get
            {
                if (PM1_PU_SITE.HasValue)
                {
                    if (_PM1_PU_SITE_SCI == null)
                    {
                        _PM1_PU_SITE_SCI = Context.SCI.FindBySCIKEY(PM1_PU_SITE.Value);
                    }
                    return _PM1_PU_SITE_SCI;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PM1_ROUTE] => [KCR].[KCRKEY]
        /// Transport route/stop used in the afternoon on Day 1
        /// </summary>
        public KCR PM1_ROUTE_KCR {
            get
            {
                if (PM1_ROUTE != null)
                {
                    if (_PM1_ROUTE_KCR == null)
                    {
                        _PM1_ROUTE_KCR = Context.KCR.FindByKCRKEY(PM1_ROUTE);
                    }
                    return _PM1_ROUTE_KCR;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [AM2_SD_SITE] => [SCI].[SCIKEY]
        /// Set-down campus on Day 2
        /// </summary>
        public SCI AM2_SD_SITE_SCI {
            get
            {
                if (AM2_SD_SITE.HasValue)
                {
                    if (_AM2_SD_SITE_SCI == null)
                    {
                        _AM2_SD_SITE_SCI = Context.SCI.FindBySCIKEY(AM2_SD_SITE.Value);
                    }
                    return _AM2_SD_SITE_SCI;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [AM2_ROUTE] => [KCR].[KCRKEY]
        /// Transport route/stop used in the morning on Day 2
        /// </summary>
        public KCR AM2_ROUTE_KCR {
            get
            {
                if (AM2_ROUTE != null)
                {
                    if (_AM2_ROUTE_KCR == null)
                    {
                        _AM2_ROUTE_KCR = Context.KCR.FindByKCRKEY(AM2_ROUTE);
                    }
                    return _AM2_ROUTE_KCR;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PM2_PU_SITE] => [SCI].[SCIKEY]
        /// Pick-up campus on Day 2
        /// </summary>
        public SCI PM2_PU_SITE_SCI {
            get
            {
                if (PM2_PU_SITE.HasValue)
                {
                    if (_PM2_PU_SITE_SCI == null)
                    {
                        _PM2_PU_SITE_SCI = Context.SCI.FindBySCIKEY(PM2_PU_SITE.Value);
                    }
                    return _PM2_PU_SITE_SCI;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PM2_ROUTE] => [KCR].[KCRKEY]
        /// Transport route/stop used in the afternoon on Day 2
        /// </summary>
        public KCR PM2_ROUTE_KCR {
            get
            {
                if (PM2_ROUTE != null)
                {
                    if (_PM2_ROUTE_KCR == null)
                    {
                        _PM2_ROUTE_KCR = Context.KCR.FindByKCRKEY(PM2_ROUTE);
                    }
                    return _PM2_ROUTE_KCR;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [AM3_SD_SITE] => [SCI].[SCIKEY]
        /// Set-down campus on Day 3
        /// </summary>
        public SCI AM3_SD_SITE_SCI {
            get
            {
                if (AM3_SD_SITE.HasValue)
                {
                    if (_AM3_SD_SITE_SCI == null)
                    {
                        _AM3_SD_SITE_SCI = Context.SCI.FindBySCIKEY(AM3_SD_SITE.Value);
                    }
                    return _AM3_SD_SITE_SCI;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [AM3_ROUTE] => [KCR].[KCRKEY]
        /// Transport route/stop used in the morning on Day 3
        /// </summary>
        public KCR AM3_ROUTE_KCR {
            get
            {
                if (AM3_ROUTE != null)
                {
                    if (_AM3_ROUTE_KCR == null)
                    {
                        _AM3_ROUTE_KCR = Context.KCR.FindByKCRKEY(AM3_ROUTE);
                    }
                    return _AM3_ROUTE_KCR;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PM3_PU_SITE] => [SCI].[SCIKEY]
        /// Pick-up campus on Day 3
        /// </summary>
        public SCI PM3_PU_SITE_SCI {
            get
            {
                if (PM3_PU_SITE.HasValue)
                {
                    if (_PM3_PU_SITE_SCI == null)
                    {
                        _PM3_PU_SITE_SCI = Context.SCI.FindBySCIKEY(PM3_PU_SITE.Value);
                    }
                    return _PM3_PU_SITE_SCI;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PM3_ROUTE] => [KCR].[KCRKEY]
        /// Transport route/stop used in the afternoon on Day 3
        /// </summary>
        public KCR PM3_ROUTE_KCR {
            get
            {
                if (PM3_ROUTE != null)
                {
                    if (_PM3_ROUTE_KCR == null)
                    {
                        _PM3_ROUTE_KCR = Context.KCR.FindByKCRKEY(PM3_ROUTE);
                    }
                    return _PM3_ROUTE_KCR;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [AM4_SD_SITE] => [SCI].[SCIKEY]
        /// Set-down campus on Day 4
        /// </summary>
        public SCI AM4_SD_SITE_SCI {
            get
            {
                if (AM4_SD_SITE.HasValue)
                {
                    if (_AM4_SD_SITE_SCI == null)
                    {
                        _AM4_SD_SITE_SCI = Context.SCI.FindBySCIKEY(AM4_SD_SITE.Value);
                    }
                    return _AM4_SD_SITE_SCI;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [AM4_ROUTE] => [KCR].[KCRKEY]
        /// Transport route/stop used in the morning on Day 4
        /// </summary>
        public KCR AM4_ROUTE_KCR {
            get
            {
                if (AM4_ROUTE != null)
                {
                    if (_AM4_ROUTE_KCR == null)
                    {
                        _AM4_ROUTE_KCR = Context.KCR.FindByKCRKEY(AM4_ROUTE);
                    }
                    return _AM4_ROUTE_KCR;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PM4_PU_SITE] => [SCI].[SCIKEY]
        /// Pick-up campus on Day 4
        /// </summary>
        public SCI PM4_PU_SITE_SCI {
            get
            {
                if (PM4_PU_SITE.HasValue)
                {
                    if (_PM4_PU_SITE_SCI == null)
                    {
                        _PM4_PU_SITE_SCI = Context.SCI.FindBySCIKEY(PM4_PU_SITE.Value);
                    }
                    return _PM4_PU_SITE_SCI;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PM4_ROUTE] => [KCR].[KCRKEY]
        /// Transport route/stop used in the afternoon on Day 4
        /// </summary>
        public KCR PM4_ROUTE_KCR {
            get
            {
                if (PM4_ROUTE != null)
                {
                    if (_PM4_ROUTE_KCR == null)
                    {
                        _PM4_ROUTE_KCR = Context.KCR.FindByKCRKEY(PM4_ROUTE);
                    }
                    return _PM4_ROUTE_KCR;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [AM5_SD_SITE] => [SCI].[SCIKEY]
        /// Set-down campus on Day 5
        /// </summary>
        public SCI AM5_SD_SITE_SCI {
            get
            {
                if (AM5_SD_SITE.HasValue)
                {
                    if (_AM5_SD_SITE_SCI == null)
                    {
                        _AM5_SD_SITE_SCI = Context.SCI.FindBySCIKEY(AM5_SD_SITE.Value);
                    }
                    return _AM5_SD_SITE_SCI;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [AM5_ROUTE] => [KCR].[KCRKEY]
        /// Transport route/stop used in the morning on Day 5
        /// </summary>
        public KCR AM5_ROUTE_KCR {
            get
            {
                if (AM5_ROUTE != null)
                {
                    if (_AM5_ROUTE_KCR == null)
                    {
                        _AM5_ROUTE_KCR = Context.KCR.FindByKCRKEY(AM5_ROUTE);
                    }
                    return _AM5_ROUTE_KCR;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PM5_PU_SITE] => [SCI].[SCIKEY]
        /// Pick-up campus on Day 5
        /// </summary>
        public SCI PM5_PU_SITE_SCI {
            get
            {
                if (PM5_PU_SITE.HasValue)
                {
                    if (_PM5_PU_SITE_SCI == null)
                    {
                        _PM5_PU_SITE_SCI = Context.SCI.FindBySCIKEY(PM5_PU_SITE.Value);
                    }
                    return _PM5_PU_SITE_SCI;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PM5_ROUTE] => [KCR].[KCRKEY]
        /// Transport route/stop used in the afternoon on Day 5
        /// </summary>
        public KCR PM5_ROUTE_KCR {
            get
            {
                if (PM5_ROUTE != null)
                {
                    if (_PM5_ROUTE_KCR == null)
                    {
                        _PM5_ROUTE_KCR = Context.KCR.FindByKCRKEY(PM5_ROUTE);
                    }
                    return _PM5_ROUTE_KCR;
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
