using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Association Member Attendances
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SAMA : EntityBase
    {

        #region Navigation Property Cache

        private SAM Cache_SAMAKEY_SAM;

        #endregion

        #region Field Properties

        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// ID of school association member
        /// </summary>
        public int SAMAKEY { get; internal set; }

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
                if (Cache_SAMAKEY_SAM == null)
                {
                    Cache_SAMAKEY_SAM = Context.SAM.FindBySAMKEY(SAMAKEY);
                }

                return Cache_SAMAKEY_SAM;
            }
        }

        #endregion

    }
}
