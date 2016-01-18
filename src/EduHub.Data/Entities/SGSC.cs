using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject/Class Eligibility Criteria
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SGSC : EduHubEntity
    {

        #region Navigation Property Cache

        private SG Cache_SGSCKEY_SG;
        private SU Cache_SULINK_SU;

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
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Code of group for which this is a criterion
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string SGSCKEY { get; internal set; }

        /// <summary>
        /// Code of subject which is a criterion for membership in group SGSGKEY
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SULINK { get; internal set; }

        /// <summary>
        /// Code of class which is a criterion for membership in group SGSGKEY
        /// </summary>
        public short? CLASS { get; internal set; }

        /// <summary>
        /// Timetabling year/semester (eg 1998S1, 1998)
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string TTPERIOD { get; internal set; }

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
        /// SG (Student Groupings) related entity by [SGSC.SGSCKEY]-&gt;[SG.SGKEY]
        /// Code of group for which this is a criterion
        /// </summary>
        public SG SGSCKEY_SG
        {
            get
            {
                if (Cache_SGSCKEY_SG == null)
                {
                    Cache_SGSCKEY_SG = Context.SG.FindBySGKEY(SGSCKEY);
                }

                return Cache_SGSCKEY_SG;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SGSC.SULINK]-&gt;[SU.SUKEY]
        /// Code of subject which is a criterion for membership in group SGSGKEY
        /// </summary>
        public SU SULINK_SU
        {
            get
            {
                if (SULINK == null)
                {
                    return null;
                }
                if (Cache_SULINK_SU == null)
                {
                    Cache_SULINK_SU = Context.SU.FindBySUKEY(SULINK);
                }

                return Cache_SULINK_SU;
            }
        }

        #endregion

    }
}
