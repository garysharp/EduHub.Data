using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Adult Group Members
    /// </summary>
    public class SDGM_Entity : EntityBase
    {
#region Navigation Property Cache
        private SDG_Entity _SDGMKEY_SDG;
        private DR_Entity _PERSON_LINK_DR;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Group Code [Uppercase Alphanumeric: u12]
        /// </summary>
        public string SDGMKEY { get; internal set; }
        /// <summary>
        /// Code of this person in table SF or DF [Uppercase Alphanumeric: u10]
        /// </summary>
        public string PERSON_LINK { get; internal set; }
        /// <summary>
        /// Date on which this person joined this group [Date Time nullable: d]
        /// </summary>
        public DateTime? START_DATE { get; internal set; }
        /// <summary>
        /// Date on which this person left or will leave this group [Date Time nullable: d]
        /// </summary>
        public DateTime? END_DATE { get; internal set; }
        /// <summary>
        /// Any general comments [Memo: m]
        /// </summary>
        public string OTHER_COMMENTS { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [SDGMKEY] => [SDG_Entity].[SDGKEY]
        /// Group Code
        /// </summary>
        public SDG_Entity SDGMKEY_SDG {
            get
            {
                if (SDGMKEY != null)
                {
                    if (_SDGMKEY_SDG == null)
                    {
                        _SDGMKEY_SDG = Context.SDG.FindBySDGKEY(SDGMKEY);
                    }
                    return _SDGMKEY_SDG;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PERSON_LINK] => [DR_Entity].[DRKEY]
        /// Code of this person in table SF or DF
        /// </summary>
        public DR_Entity PERSON_LINK_DR {
            get
            {
                if (PERSON_LINK != null)
                {
                    if (_PERSON_LINK_DR == null)
                    {
                        _PERSON_LINK_DR = Context.DR.FindByDRKEY(PERSON_LINK);
                    }
                    return _PERSON_LINK_DR;
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
