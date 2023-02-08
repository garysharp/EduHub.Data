#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Associations
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCA : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<SAM> Cache_SCAKEY_SAM_ASSOC_NAME;
#if !EduHubScoped
        private IReadOnlyList<SCAM> Cache_SCAKEY_SCAM_SCAMKEY;
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

        #region Foreign Navigation Properties

        /// <summary>
        /// SAM (School Association Members) related entities by [SCA.SCAKEY]-&gt;[SAM.ASSOC_NAME]
        /// Short name of association
        /// </summary>
        public IReadOnlyList<SAM> SCAKEY_SAM_ASSOC_NAME
        {
            get
            {
                if (Cache_SCAKEY_SAM_ASSOC_NAME == null &&
                    !Context.SAM.TryFindByASSOC_NAME(SCAKEY, out Cache_SCAKEY_SAM_ASSOC_NAME))
                {
                    Cache_SCAKEY_SAM_ASSOC_NAME = new List<SAM>().AsReadOnly();
                }

                return Cache_SCAKEY_SAM_ASSOC_NAME;
            }
        }

#if !EduHubScoped
        /// <summary>
        /// SCAM (School Association Meetings) related entities by [SCA.SCAKEY]-&gt;[SCAM.SCAMKEY]
        /// Short name of association
        /// </summary>
        public IReadOnlyList<SCAM> SCAKEY_SCAM_SCAMKEY
        {
            get
            {
                if (Cache_SCAKEY_SCAM_SCAMKEY == null &&
                    !Context.SCAM.TryFindBySCAMKEY(SCAKEY, out Cache_SCAKEY_SCAM_SCAMKEY))
                {
                    Cache_SCAKEY_SCAM_SCAMKEY = new List<SCAM>().AsReadOnly();
                }

                return Cache_SCAKEY_SCAM_SCAMKEY;
            }
        }

#endif
        #endregion

    }
}
#endif
