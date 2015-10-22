using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject Prerequisites
    /// </summary>
    public partial class SUPR : EntityBase
    {
#region Navigation Property Cache
        private SU _SUPRKEY_SU;
        private SU _PREREQUISITE_SU;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Subject code of this subject
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUPRKEY { get; internal set; }
        /// <summary>
        /// Subject code of this subject's prerequisite
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string PREREQUISITE { get; internal set; }
        /// <summary>
        /// Result as prerequisite (not implemented)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string RESULT { get; internal set; }
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
        /// SU (Subjects) related entity by [SUPR.SUPRKEY]-&gt;[SU.SUKEY]
        /// Subject code of this subject
        /// </summary>
        public SU SUPRKEY_SU
        {
            get
            {
                if (SUPRKEY != null)
                {
                    if (_SUPRKEY_SU == null)
                    {
                        _SUPRKEY_SU = Context.SU.FindBySUKEY(SUPRKEY);
                    }
                    return _SUPRKEY_SU;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SUPR.PREREQUISITE]-&gt;[SU.SUKEY]
        /// Subject code of this subject's prerequisite
        /// </summary>
        public SU PREREQUISITE_SU
        {
            get
            {
                if (PREREQUISITE != null)
                {
                    if (_PREREQUISITE_SU == null)
                    {
                        _PREREQUISITE_SU = Context.SU.FindBySUKEY(PREREQUISITE);
                    }
                    return _PREREQUISITE_SU;
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
