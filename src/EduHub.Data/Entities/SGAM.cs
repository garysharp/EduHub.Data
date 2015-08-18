using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Adult Group Members
    /// </summary>
    public class SGAM : EntityBase
    {
#region Navigation Property Cache
        private SG _SGAMKEY_SG;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Code of Group/Excursion/Position to which this person belongs
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string SGAMKEY { get; internal set; }
        /// <summary>
        /// Is this person a staff member or a parent/guardian? SF=Staff Member, DF=Parent/guardian
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string ADULT_PERSON_TYPE { get; internal set; }
        /// <summary>
        /// Code of this person in table SF or DF
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PERSON_LINK { get; internal set; }
        /// <summary>
        /// (If this person is a parent/guardian) Identifies which of the two adults in the family this person is
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DF_PARTICIPATION { get; internal set; }
        /// <summary>
        /// This person is in charge of this group? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string RESPONSIBLE { get; internal set; }
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
        /// Role of this person in this group: may later be related to a K table
        /// [Alphanumeric (30)]
        /// </summary>
        public string GROUP_ROLE { get; internal set; }
        /// <summary>
        /// Group type: S=Special Group, E=Excursion Group << What exactly is this field for?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SG_TYPE { get; internal set; }
        /// <summary>
        /// House or home group of staff member
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string HOUSE_HG { get; internal set; }
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
        /// Navigation property for [SGAMKEY] => [SG].[SGKEY]
        /// Code of Group/Excursion/Position to which this person belongs
        /// </summary>
        public SG SGAMKEY_SG {
            get
            {
                if (SGAMKEY != null)
                {
                    if (_SGAMKEY_SG == null)
                    {
                        _SGAMKEY_SG = Context.SG.FindBySGKEY(SGAMKEY);
                    }
                    return _SGAMKEY_SG;
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
