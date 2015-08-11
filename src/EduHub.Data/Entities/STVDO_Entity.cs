using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// VELS Domain Results
    /// </summary>
    public class STVDO_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Student ID [Uppercase Alphanumeric: u10]
        /// </summary>
        public string SKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [SKEY] => [ST_Entity].[STKEY]
        /// Student ID
        /// </summary>
        public ST_Entity SKEY_ST { get { return SKEY == null ? null : Context.ST.FindBySTKEY(SKEY); } }
        /// <summary>
        /// Year level at the time of result [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SCHOOL_YEAR { get; internal set; }
        /// <summary>
        /// Navigation property for [SCHOOL_YEAR] => [KCY_Entity].[KCYKEY]
        /// Year level at the time of result
        /// </summary>
        public KCY_Entity SCHOOL_YEAR_KCY { get { return SCHOOL_YEAR == null ? null : Context.KCY.FindByKCYKEY(SCHOOL_YEAR); } }
        /// <summary>
        /// Campus at the time of the result [Integer (32bit signed nullable): l]
        /// </summary>
        public int? CAMPUS { get; internal set; }
        /// <summary>
        /// Navigation property for [CAMPUS] => [SCI_Entity].[SCIKEY]
        /// Campus at the time of the result
        /// </summary>
        public SCI_Entity CAMPUS_SCI { get { return CAMPUS.HasValue ? Context.SCI.FindBySCIKEY(CAMPUS.Value) : null; } }
        /// <summary>
        /// YYYY.S eg 2005.1 [Alphanumeric: a6]
        /// </summary>
        public string YEAR_SEMESTER { get; internal set; }
        /// <summary>
        /// Link to domain [Uppercase Alphanumeric: u5]
        /// </summary>
        public string VDOMAIN { get; internal set; }
        /// <summary>
        /// Navigation property for [VDOMAIN] => [KDO_Entity].[KDOKEY]
        /// Link to domain
        /// </summary>
        public KDO_Entity VDOMAIN_KDO { get { return VDOMAIN == null ? null : Context.KDO.FindByKDOKEY(VDOMAIN); } }
        /// <summary>
        /// Link to dimension [Uppercase Alphanumeric: u10]
        /// </summary>
        public string VDIMENSION { get; internal set; }
        /// <summary>
        /// Navigation property for [VDIMENSION] => [KDI_Entity].[KDIKEY]
        /// Link to dimension
        /// </summary>
        public KDI_Entity VDIMENSION_KDI { get { return VDIMENSION == null ? null : Context.KDI.FindByKDIKEY(VDIMENSION); } }
        /// <summary>
        /// Grade assigned to student A to E [Alphanumeric: a4]
        /// </summary>
        public string SCORE { get; internal set; }
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
