using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// VELS Dimension Results
    /// </summary>
    public class STVDI_Entity : EntityBase
    {
#region Navigation Property Cache
        private ST_Entity _SKEY_ST;
        private KCY_Entity _SCHOOL_YEAR_KCY;
        private SCI_Entity _CAMPUS_SCI;
        private KDO_Entity _VDOMAIN_KDO;
        private KDI_Entity _VDIMENSION_KDI;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Student ID [Uppercase Alphanumeric: u10]
        /// </summary>
        public string SKEY { get; internal set; }
        /// <summary>
        /// Year level at the time of result [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SCHOOL_YEAR { get; internal set; }
        /// <summary>
        /// Campus at the time of the result [Integer (32bit signed nullable): l]
        /// </summary>
        public int? CAMPUS { get; internal set; }
        /// <summary>
        /// YYYY.S eg 2005.1 [Alphanumeric: a6]
        /// </summary>
        public string YEAR_SEMESTER { get; internal set; }
        /// <summary>
        /// Link to domain [Uppercase Alphanumeric: u5]
        /// </summary>
        public string VDOMAIN { get; internal set; }
        /// <summary>
        /// Link to dimension [Uppercase Alphanumeric: u10]
        /// </summary>
        public string VDIMENSION { get; internal set; }
        /// <summary>
        /// Numerical assessment for the dimension - could be NA [Alphanumeric: a4]
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
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [SKEY] => [ST_Entity].[STKEY]
        /// Student ID
        /// </summary>
        public ST_Entity SKEY_ST {
            get
            {
                if (SKEY != null)
                {
                    if (_SKEY_ST == null)
                    {
                        _SKEY_ST = Context.ST.FindBySTKEY(SKEY);
                    }
                    return _SKEY_ST;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SCHOOL_YEAR] => [KCY_Entity].[KCYKEY]
        /// Year level at the time of result
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
        /// Navigation property for [CAMPUS] => [SCI_Entity].[SCIKEY]
        /// Campus at the time of the result
        /// </summary>
        public SCI_Entity CAMPUS_SCI {
            get
            {
                if (CAMPUS.HasValue)
                {
                    if (_CAMPUS_SCI == null)
                    {
                        _CAMPUS_SCI = Context.SCI.FindBySCIKEY(CAMPUS.Value);
                    }
                    return _CAMPUS_SCI;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [VDOMAIN] => [KDO_Entity].[KDOKEY]
        /// Link to domain
        /// </summary>
        public KDO_Entity VDOMAIN_KDO {
            get
            {
                if (VDOMAIN != null)
                {
                    if (_VDOMAIN_KDO == null)
                    {
                        _VDOMAIN_KDO = Context.KDO.FindByKDOKEY(VDOMAIN);
                    }
                    return _VDOMAIN_KDO;
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
