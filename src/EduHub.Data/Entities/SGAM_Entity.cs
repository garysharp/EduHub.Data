using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Adult Group Members
    /// </summary>
    public class SGAM_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Code of Group/Excursion/Position to which this person belongs [Uppercase Alphanumeric: u12]
        /// </summary>
        public string SGAMKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [SGAMKEY] => [SG_Entity].[SGKEY]
        /// Code of Group/Excursion/Position to which this person belongs
        /// </summary>
        public SG_Entity SGAMKEY_SG { get { return SGAMKEY == null ? null : Context.SG.FindBySGKEY(SGAMKEY); } }
        /// <summary>
        /// Is this person a staff member or a parent/guardian? SF=Staff Member, DF=Parent/guardian [Uppercase Alphanumeric: u2]
        /// </summary>
        public string ADULT_PERSON_TYPE { get; internal set; }
        /// <summary>
        /// Code of this person in table SF or DF [Uppercase Alphanumeric: u10]
        /// </summary>
        public string PERSON_LINK { get; internal set; }
        /// <summary>
        /// (If this person is a parent/guardian) Identifies which of the two adults in the family this person is [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DF_PARTICIPATION { get; internal set; }
        /// <summary>
        /// This person is in charge of this group? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string RESPONSIBLE { get; internal set; }
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
        /// Role of this person in this group: may later be related to a K table [Alphanumeric: a30]
        /// </summary>
        public string GROUP_ROLE { get; internal set; }
        /// <summary>
        /// Group type: S=Special Group, E=Excursion Group << What exactly is this field for? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string SG_TYPE { get; internal set; }
        /// <summary>
        /// House or home group of staff member [Uppercase Alphanumeric: u10]
        /// </summary>
        public string HOUSE_HG { get; internal set; }
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
        
        
    }
}
