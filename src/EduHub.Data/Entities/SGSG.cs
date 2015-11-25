using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Group Membership Eligibility Criteria
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SGSG : EntityBase
    {

        #region Navigation Property Cache

        private SG Cache_SGSGKEY_SG;
        private SG Cache_SGLINK_SG;

        #endregion

        #region Field Properties

        /// <summary>
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Code of group for which this is a criterion
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string SGSGKEY { get; internal set; }

        /// <summary>
        /// Code of group membership of which is a criterion for membership in group SGSGKEY
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string SGLINK { get; internal set; }

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
        /// SG (Student Groupings) related entity by [SGSG.SGSGKEY]-&gt;[SG.SGKEY]
        /// Code of group for which this is a criterion
        /// </summary>
        public SG SGSGKEY_SG
        {
            get
            {
                if (Cache_SGSGKEY_SG == null)
                {
                    Cache_SGSGKEY_SG = Context.SG.FindBySGKEY(SGSGKEY);
                }

                return Cache_SGSGKEY_SG;
            }
        }

        /// <summary>
        /// SG (Student Groupings) related entity by [SGSG.SGLINK]-&gt;[SG.SGKEY]
        /// Code of group membership of which is a criterion for membership in group SGSGKEY
        /// </summary>
        public SG SGLINK_SG
        {
            get
            {
                if (SGLINK == null)
                {
                    return null;
                }
                if (Cache_SGLINK_SG == null)
                {
                    Cache_SGLINK_SG = Context.SG.FindBySGKEY(SGLINK);
                }

                return Cache_SGLINK_SG;
            }
        }

        #endregion

    }
}
