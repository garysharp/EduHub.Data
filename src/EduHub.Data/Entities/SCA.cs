using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Associations
    /// </summary>
    public partial class SCA : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Short name of association
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string SCAKEY { get; internal set; }
        /// <summary>
        /// Long name of association
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Date incorporated
        /// </summary>
        public DateTime? FIRST_DATE { get; internal set; }
        /// <summary>
        /// Date ceased
        /// </summary>
        public DateTime? LAST_DATE { get; internal set; }
        /// <summary>
        /// Comments
        /// [Memo]
        /// </summary>
        public string SCA_MEMO { get; internal set; }
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
        /// SAM (School Association Members) related entities by [SAM.ASSOC_NAME]-&gt;[SCA.SCAKEY]
        /// </summary>
        public IReadOnlyList<SAM> SAM_ASSOC_NAME
        {
            get
            {
                return Context.SCA.FindSAMByASSOC_NAME(SCAKEY);
            }
        }

        /// <summary>
        /// SCAM (School Association Meetings) related entities by [SCAM.SCAMKEY]-&gt;[SCA.SCAKEY]
        /// </summary>
        public IReadOnlyList<SCAM> SCAM_SCAMKEY
        {
            get
            {
                return Context.SCA.FindSCAMBySCAMKEY(SCAKEY);
            }
        }
#endregion
    }
}
