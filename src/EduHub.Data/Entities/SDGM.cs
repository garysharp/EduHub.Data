using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Adult Group Members
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SDGM : EduHubEntity
    {

        #region Navigation Property Cache

        private SDG Cache_SDGMKEY_SDG;
        private DR Cache_PERSON_LINK_DR;

        #endregion

        #region Field Properties

        /// <summary>
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Group Code
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string SDGMKEY { get; internal set; }

        /// <summary>
        /// Code of this person in table SF or DF
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PERSON_LINK { get; internal set; }

        /// <summary>
        /// Date on which this person joined this group
        /// </summary>
        public DateTime? START_DATE { get; internal set; }

        /// <summary>
        /// Date on which this person left or will leave this group
        /// </summary>
        public DateTime? END_DATE { get; internal set; }

        /// <summary>
        /// Any general comments
        /// [Memo]
        /// </summary>
        public string OTHER_COMMENTS { get; internal set; }

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
        /// SDG (Sundry Debtor Fee Groups) related entity by [SDGM.SDGMKEY]-&gt;[SDG.SDGKEY]
        /// Group Code
        /// </summary>
        public SDG SDGMKEY_SDG
        {
            get
            {
                if (Cache_SDGMKEY_SDG == null)
                {
                    Cache_SDGMKEY_SDG = Context.SDG.FindBySDGKEY(SDGMKEY);
                }

                return Cache_SDGMKEY_SDG;
            }
        }

        /// <summary>
        /// DR (Accounts Receivable) related entity by [SDGM.PERSON_LINK]-&gt;[DR.DRKEY]
        /// Code of this person in table SF or DF
        /// </summary>
        public DR PERSON_LINK_DR
        {
            get
            {
                if (PERSON_LINK == null)
                {
                    return null;
                }
                if (Cache_PERSON_LINK_DR == null)
                {
                    Cache_PERSON_LINK_DR = Context.DR.FindByDRKEY(PERSON_LINK);
                }

                return Cache_PERSON_LINK_DR;
            }
        }

        #endregion

    }
}
