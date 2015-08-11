using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Transport Usage
    /// </summary>
    public class STBT_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Student ID [Uppercase Alphanumeric: u10]
        /// </summary>
        public string STBTKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [STBTKEY] => [ST_Entity].[STKEY]
        /// Student ID
        /// </summary>
        public ST_Entity STBTKEY_ST { get { return STBTKEY == null ? null : Context.ST.FindBySTKEY(STBTKEY); } }
        /// <summary>
        /// Transport route or stop used [Uppercase Alphanumeric: u6]
        /// </summary>
        public string ROUTE { get; internal set; }
        /// <summary>
        /// Navigation property for [ROUTE] => [KCR_Entity].[KCRKEY]
        /// Transport route or stop used
        /// </summary>
        public KCR_Entity ROUTE_KCR { get { return ROUTE == null ? null : Context.KCR.FindByKCRKEY(ROUTE); } }
        /// <summary>
        /// Mon - Fri << What is actually stored in this field? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DAYS_USED01 { get; internal set; }
        /// <summary>
        /// Mon - Fri << What is actually stored in this field? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DAYS_USED02 { get; internal set; }
        /// <summary>
        /// Mon - Fri << What is actually stored in this field? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DAYS_USED03 { get; internal set; }
        /// <summary>
        /// Mon - Fri << What is actually stored in this field? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DAYS_USED04 { get; internal set; }
        /// <summary>
        /// Mon - Fri << What is actually stored in this field? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DAYS_USED05 { get; internal set; }
        /// <summary>
        /// (Was BUS_NOTES) Any annotation about this student's transport usage [Memo: m]
        /// </summary>
        public string TRANSPORT_NOTES { get; internal set; }
        /// <summary>
        /// First day of use [Date Time nullable: d]
        /// </summary>
        public DateTime? DATE_STARTED { get; internal set; }
        /// <summary>
        /// Date use ceased [Date Time nullable: d]
        /// </summary>
        public DateTime? TERMINATED { get; internal set; }
        /// <summary>
        /// Morning pick-up time on Day 1 [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AM1_PICKUP { get; internal set; }
        /// <summary>
        /// Morning pick-up site on Day 1 (could be map ref) [Uppercase Alphanumeric: u4]
        /// </summary>
        public string AM1_PU_SITE { get; internal set; }
        /// <summary>
        /// Morning arrival time on Day 1 [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AM1_SETDOWN { get; internal set; }
        /// <summary>
        /// Set-down campus on Day 1 [Integer (32bit signed nullable): l]
        /// </summary>
        public int? AM1_SD_SITE { get; internal set; }
        /// <summary>
        /// Navigation property for [AM1_SD_SITE] => [SCI_Entity].[SCIKEY]
        /// Set-down campus on Day 1
        /// </summary>
        public SCI_Entity AM1_SD_SITE_SCI { get { return AM1_SD_SITE.HasValue ? Context.SCI.FindBySCIKEY(AM1_SD_SITE.Value) : null; } }
        /// <summary>
        /// Transport route/stop used in the morning on Day 1 [Uppercase Alphanumeric: u6]
        /// </summary>
        public string AM1_ROUTE { get; internal set; }
        /// <summary>
        /// Navigation property for [AM1_ROUTE] => [KCR_Entity].[KCRKEY]
        /// Transport route/stop used in the morning on Day 1
        /// </summary>
        public KCR_Entity AM1_ROUTE_KCR { get { return AM1_ROUTE == null ? null : Context.KCR.FindByKCRKEY(AM1_ROUTE); } }
        /// <summary>
        /// Afternoon pickup time on Day 1 [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PM1_PICKUP { get; internal set; }
        /// <summary>
        /// Pick-up campus on Day 1 [Integer (32bit signed nullable): l]
        /// </summary>
        public int? PM1_PU_SITE { get; internal set; }
        /// <summary>
        /// Navigation property for [PM1_PU_SITE] => [SCI_Entity].[SCIKEY]
        /// Pick-up campus on Day 1
        /// </summary>
        public SCI_Entity PM1_PU_SITE_SCI { get { return PM1_PU_SITE.HasValue ? Context.SCI.FindBySCIKEY(PM1_PU_SITE.Value) : null; } }
        /// <summary>
        /// Afternoon arrival time on Day 1 [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PM1_SETDOWN { get; internal set; }
        /// <summary>
        /// Afternoon set-down site on Day 1 (could be map ref) [Uppercase Alphanumeric: u4]
        /// </summary>
        public string PM1_SD_SITE { get; internal set; }
        /// <summary>
        /// Transport route/stop used in the afternoon on Day 1 [Uppercase Alphanumeric: u6]
        /// </summary>
        public string PM1_ROUTE { get; internal set; }
        /// <summary>
        /// Navigation property for [PM1_ROUTE] => [KCR_Entity].[KCRKEY]
        /// Transport route/stop used in the afternoon on Day 1
        /// </summary>
        public KCR_Entity PM1_ROUTE_KCR { get { return PM1_ROUTE == null ? null : Context.KCR.FindByKCRKEY(PM1_ROUTE); } }
        /// <summary>
        /// Morning pick-up time on Day 2 [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AM2_PICKUP { get; internal set; }
        /// <summary>
        /// Morning pick-up site on Day 2 (could be map ref) [Uppercase Alphanumeric: u4]
        /// </summary>
        public string AM2_PU_SITE { get; internal set; }
        /// <summary>
        /// Morning arrival time on Day 2 [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AM2_SETDOWN { get; internal set; }
        /// <summary>
        /// Set-down campus on Day 2 [Integer (32bit signed nullable): l]
        /// </summary>
        public int? AM2_SD_SITE { get; internal set; }
        /// <summary>
        /// Navigation property for [AM2_SD_SITE] => [SCI_Entity].[SCIKEY]
        /// Set-down campus on Day 2
        /// </summary>
        public SCI_Entity AM2_SD_SITE_SCI { get { return AM2_SD_SITE.HasValue ? Context.SCI.FindBySCIKEY(AM2_SD_SITE.Value) : null; } }
        /// <summary>
        /// Transport route/stop used in the morning on Day 2 [Uppercase Alphanumeric: u6]
        /// </summary>
        public string AM2_ROUTE { get; internal set; }
        /// <summary>
        /// Navigation property for [AM2_ROUTE] => [KCR_Entity].[KCRKEY]
        /// Transport route/stop used in the morning on Day 2
        /// </summary>
        public KCR_Entity AM2_ROUTE_KCR { get { return AM2_ROUTE == null ? null : Context.KCR.FindByKCRKEY(AM2_ROUTE); } }
        /// <summary>
        /// Afternoon pickup time on Day 2 [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PM2_PICKUP { get; internal set; }
        /// <summary>
        /// Pick-up campus on Day 2 [Integer (32bit signed nullable): l]
        /// </summary>
        public int? PM2_PU_SITE { get; internal set; }
        /// <summary>
        /// Navigation property for [PM2_PU_SITE] => [SCI_Entity].[SCIKEY]
        /// Pick-up campus on Day 2
        /// </summary>
        public SCI_Entity PM2_PU_SITE_SCI { get { return PM2_PU_SITE.HasValue ? Context.SCI.FindBySCIKEY(PM2_PU_SITE.Value) : null; } }
        /// <summary>
        /// Afternoon arrival time on Day 2 [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PM2_SETDOWN { get; internal set; }
        /// <summary>
        /// Afternoon set-down site on Day 2 (could be map ref) [Uppercase Alphanumeric: u4]
        /// </summary>
        public string PM2_SD_SITE { get; internal set; }
        /// <summary>
        /// Transport route/stop used in the afternoon on Day 2 [Uppercase Alphanumeric: u6]
        /// </summary>
        public string PM2_ROUTE { get; internal set; }
        /// <summary>
        /// Navigation property for [PM2_ROUTE] => [KCR_Entity].[KCRKEY]
        /// Transport route/stop used in the afternoon on Day 2
        /// </summary>
        public KCR_Entity PM2_ROUTE_KCR { get { return PM2_ROUTE == null ? null : Context.KCR.FindByKCRKEY(PM2_ROUTE); } }
        /// <summary>
        /// Morning pick-up time on Day 3 [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AM3_PICKUP { get; internal set; }
        /// <summary>
        /// Morning pick-up site on Day 3 (could be map ref) [Uppercase Alphanumeric: u4]
        /// </summary>
        public string AM3_PU_SITE { get; internal set; }
        /// <summary>
        /// Morning arrival time on Day 3 [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AM3_SETDOWN { get; internal set; }
        /// <summary>
        /// Set-down campus on Day 3 [Integer (32bit signed nullable): l]
        /// </summary>
        public int? AM3_SD_SITE { get; internal set; }
        /// <summary>
        /// Navigation property for [AM3_SD_SITE] => [SCI_Entity].[SCIKEY]
        /// Set-down campus on Day 3
        /// </summary>
        public SCI_Entity AM3_SD_SITE_SCI { get { return AM3_SD_SITE.HasValue ? Context.SCI.FindBySCIKEY(AM3_SD_SITE.Value) : null; } }
        /// <summary>
        /// Transport route/stop used in the morning on Day 3 [Uppercase Alphanumeric: u6]
        /// </summary>
        public string AM3_ROUTE { get; internal set; }
        /// <summary>
        /// Navigation property for [AM3_ROUTE] => [KCR_Entity].[KCRKEY]
        /// Transport route/stop used in the morning on Day 3
        /// </summary>
        public KCR_Entity AM3_ROUTE_KCR { get { return AM3_ROUTE == null ? null : Context.KCR.FindByKCRKEY(AM3_ROUTE); } }
        /// <summary>
        /// Afternoon pickup time on Day 3 [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PM3_PICKUP { get; internal set; }
        /// <summary>
        /// Pick-up campus on Day 3 [Integer (32bit signed nullable): l]
        /// </summary>
        public int? PM3_PU_SITE { get; internal set; }
        /// <summary>
        /// Navigation property for [PM3_PU_SITE] => [SCI_Entity].[SCIKEY]
        /// Pick-up campus on Day 3
        /// </summary>
        public SCI_Entity PM3_PU_SITE_SCI { get { return PM3_PU_SITE.HasValue ? Context.SCI.FindBySCIKEY(PM3_PU_SITE.Value) : null; } }
        /// <summary>
        /// Afternoon arrival time on Day 3 [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PM3_SETDOWN { get; internal set; }
        /// <summary>
        /// Afternoon set-down site on Day 3 (could be map ref) [Uppercase Alphanumeric: u4]
        /// </summary>
        public string PM3_SD_SITE { get; internal set; }
        /// <summary>
        /// Transport route/stop used in the afternoon on Day 3 [Uppercase Alphanumeric: u6]
        /// </summary>
        public string PM3_ROUTE { get; internal set; }
        /// <summary>
        /// Navigation property for [PM3_ROUTE] => [KCR_Entity].[KCRKEY]
        /// Transport route/stop used in the afternoon on Day 3
        /// </summary>
        public KCR_Entity PM3_ROUTE_KCR { get { return PM3_ROUTE == null ? null : Context.KCR.FindByKCRKEY(PM3_ROUTE); } }
        /// <summary>
        /// Morning pick-up time on Day 4 [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AM4_PICKUP { get; internal set; }
        /// <summary>
        /// Morning pick-up site on Day 4 (could be map ref) [Uppercase Alphanumeric: u4]
        /// </summary>
        public string AM4_PU_SITE { get; internal set; }
        /// <summary>
        /// Morning arrival time on Day 4 [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AM4_SETDOWN { get; internal set; }
        /// <summary>
        /// Set-down campus on Day 4 [Integer (32bit signed nullable): l]
        /// </summary>
        public int? AM4_SD_SITE { get; internal set; }
        /// <summary>
        /// Navigation property for [AM4_SD_SITE] => [SCI_Entity].[SCIKEY]
        /// Set-down campus on Day 4
        /// </summary>
        public SCI_Entity AM4_SD_SITE_SCI { get { return AM4_SD_SITE.HasValue ? Context.SCI.FindBySCIKEY(AM4_SD_SITE.Value) : null; } }
        /// <summary>
        /// Transport route/stop used in the morning on Day 4 [Uppercase Alphanumeric: u6]
        /// </summary>
        public string AM4_ROUTE { get; internal set; }
        /// <summary>
        /// Navigation property for [AM4_ROUTE] => [KCR_Entity].[KCRKEY]
        /// Transport route/stop used in the morning on Day 4
        /// </summary>
        public KCR_Entity AM4_ROUTE_KCR { get { return AM4_ROUTE == null ? null : Context.KCR.FindByKCRKEY(AM4_ROUTE); } }
        /// <summary>
        /// Afternoon pickup time on Day 4 [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PM4_PICKUP { get; internal set; }
        /// <summary>
        /// Pick-up campus on Day 4 [Integer (32bit signed nullable): l]
        /// </summary>
        public int? PM4_PU_SITE { get; internal set; }
        /// <summary>
        /// Navigation property for [PM4_PU_SITE] => [SCI_Entity].[SCIKEY]
        /// Pick-up campus on Day 4
        /// </summary>
        public SCI_Entity PM4_PU_SITE_SCI { get { return PM4_PU_SITE.HasValue ? Context.SCI.FindBySCIKEY(PM4_PU_SITE.Value) : null; } }
        /// <summary>
        /// Afternoon arrival time on Day 4 [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PM4_SETDOWN { get; internal set; }
        /// <summary>
        /// Afternoon set-down site on Day 4 (could be map ref) [Uppercase Alphanumeric: u4]
        /// </summary>
        public string PM4_SD_SITE { get; internal set; }
        /// <summary>
        /// Transport route/stop used in the afternoon on Day 4 [Uppercase Alphanumeric: u6]
        /// </summary>
        public string PM4_ROUTE { get; internal set; }
        /// <summary>
        /// Navigation property for [PM4_ROUTE] => [KCR_Entity].[KCRKEY]
        /// Transport route/stop used in the afternoon on Day 4
        /// </summary>
        public KCR_Entity PM4_ROUTE_KCR { get { return PM4_ROUTE == null ? null : Context.KCR.FindByKCRKEY(PM4_ROUTE); } }
        /// <summary>
        /// Morning pick-up time on Day 5 [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AM5_PICKUP { get; internal set; }
        /// <summary>
        /// Morning pick-up site on Day 5 (could be map ref) [Uppercase Alphanumeric: u4]
        /// </summary>
        public string AM5_PU_SITE { get; internal set; }
        /// <summary>
        /// Morning arrival time on Day 5 [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AM5_SETDOWN { get; internal set; }
        /// <summary>
        /// Set-down campus on Day 5 [Integer (32bit signed nullable): l]
        /// </summary>
        public int? AM5_SD_SITE { get; internal set; }
        /// <summary>
        /// Navigation property for [AM5_SD_SITE] => [SCI_Entity].[SCIKEY]
        /// Set-down campus on Day 5
        /// </summary>
        public SCI_Entity AM5_SD_SITE_SCI { get { return AM5_SD_SITE.HasValue ? Context.SCI.FindBySCIKEY(AM5_SD_SITE.Value) : null; } }
        /// <summary>
        /// Transport route/stop used in the morning on Day 5 [Uppercase Alphanumeric: u6]
        /// </summary>
        public string AM5_ROUTE { get; internal set; }
        /// <summary>
        /// Navigation property for [AM5_ROUTE] => [KCR_Entity].[KCRKEY]
        /// Transport route/stop used in the morning on Day 5
        /// </summary>
        public KCR_Entity AM5_ROUTE_KCR { get { return AM5_ROUTE == null ? null : Context.KCR.FindByKCRKEY(AM5_ROUTE); } }
        /// <summary>
        /// Afternoon pickup time on Day 5 [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PM5_PICKUP { get; internal set; }
        /// <summary>
        /// Pick-up campus on Day 5 [Integer (32bit signed nullable): l]
        /// </summary>
        public int? PM5_PU_SITE { get; internal set; }
        /// <summary>
        /// Navigation property for [PM5_PU_SITE] => [SCI_Entity].[SCIKEY]
        /// Pick-up campus on Day 5
        /// </summary>
        public SCI_Entity PM5_PU_SITE_SCI { get { return PM5_PU_SITE.HasValue ? Context.SCI.FindBySCIKEY(PM5_PU_SITE.Value) : null; } }
        /// <summary>
        /// Afternoon arrival time on Day 5 [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PM5_SETDOWN { get; internal set; }
        /// <summary>
        /// Afternoon set-down site on Day 5 (could be map ref) [Uppercase Alphanumeric: u4]
        /// </summary>
        public string PM5_SD_SITE { get; internal set; }
        /// <summary>
        /// Transport route/stop used in the afternoon on Day 5 [Uppercase Alphanumeric: u6]
        /// </summary>
        public string PM5_ROUTE { get; internal set; }
        /// <summary>
        /// Navigation property for [PM5_ROUTE] => [KCR_Entity].[KCRKEY]
        /// Transport route/stop used in the afternoon on Day 5
        /// </summary>
        public KCR_Entity PM5_ROUTE_KCR { get { return PM5_ROUTE == null ? null : Context.KCR.FindByKCRKEY(PM5_ROUTE); } }
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
