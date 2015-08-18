using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// VELS Domain Results
    /// </summary>
    public class STVDO : EntityBase
    {
#region Navigation Property Cache
        private ST _SKEY_ST;
        private KCY _SCHOOL_YEAR_KCY;
        private SCI _CAMPUS_SCI;
        private KDO _VDOMAIN_KDO;
        private KDI _VDIMENSION_KDI;
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
        /// Grade assigned to student A to E
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
        /// Navigation property for [SKEY] => [ST].[STKEY]
        /// Student ID
        /// </summary>
        public ST SKEY_ST {
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
        /// Navigation property for [SCHOOL_YEAR] => [KCY].[KCYKEY]
        /// Year level at the time of result
        /// </summary>
        public KCY SCHOOL_YEAR_KCY {
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
        /// Navigation property for [CAMPUS] => [SCI].[SCIKEY]
        /// Campus at the time of the result
        /// </summary>
        public SCI CAMPUS_SCI {
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
        /// Navigation property for [VDOMAIN] => [KDO].[KDOKEY]
        /// Link to domain
        /// </summary>
        public KDO VDOMAIN_KDO {
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
        /// Navigation property for [VDIMENSION] => [KDI].[KDIKEY]
        /// Link to dimension
        /// </summary>
        public KDI VDIMENSION_KDI {
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
