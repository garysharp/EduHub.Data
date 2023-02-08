#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accident Involvement Injuries
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SAII : EduHubEntity
    {

        #region Navigation Property Cache

#if !EduHubScoped
        private SAI Cache_INVOLVEMENTID_SAI;
#endif

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE;
            }
        }

        #region Field Properties

        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Sequence no of accident involvement
        /// </summary>
        public int INVOLVEMENTID { get; internal set; }

        /// <summary>
        /// Code identifying Injury Severity
        /// </summary>
        public short? SEVERITY { get; internal set; }

        /// <summary>
        /// Code identifying Serious Reportable Injury
        /// </summary>
        public short? SRI_TYPE { get; internal set; }

        /// <summary>
        /// Code identifying Nature of Injury
        /// </summary>
        public short? NATURE { get; internal set; }

        /// <summary>
        /// Notes if NATURE = Other
        /// [Memo]
        /// </summary>
        public string OTHER_INFO { get; internal set; }

        /// <summary>
        /// Code identifying Body Location of injury
        /// </summary>
        public short? LOCATION { get; internal set; }

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

#if !EduHubScoped
        /// <summary>
        /// SAI (Accident Involvements/Sickbay Visits) related entity by [SAII.INVOLVEMENTID]-&gt;[SAI.SAIKEY]
        /// Sequence no of accident involvement
        /// </summary>
        public SAI INVOLVEMENTID_SAI
        {
            get
            {
                if (Cache_INVOLVEMENTID_SAI == null)
                {
                    Cache_INVOLVEMENTID_SAI = Context.SAI.FindBySAIKEY(INVOLVEMENTID);
                }

                return Cache_INVOLVEMENTID_SAI;
            }
        }

#endif
        #endregion

    }
}
#endif
