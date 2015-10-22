using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Association Member Attendances
    /// </summary>
    public partial class SAMA : EntityBase
    {
#region Navigation Property Cache
        private SAM _SAMAKEY_SAM;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// ID of school association member
        /// </summary>
        public int? SAMAKEY { get; internal set; }
        /// <summary>
        /// ID of school association meeting
        /// </summary>
        public int? SCAM_TID { get; internal set; }
        /// <summary>
        /// Attended? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ATTENDED { get; internal set; }
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
        /// SAM (School Association Members) related entity by [SAMA.SAMAKEY]-&gt;[SAM.SAMKEY]
        /// ID of school association member
        /// </summary>
        public SAM SAMAKEY_SAM
        {
            get
            {
                if (SAMAKEY.HasValue)
                {
                    if (_SAMAKEY_SAM == null)
                    {
                        _SAMAKEY_SAM = Context.SAM.FindBySAMKEY(SAMAKEY.Value);
                    }
                    return _SAMAKEY_SAM;
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
