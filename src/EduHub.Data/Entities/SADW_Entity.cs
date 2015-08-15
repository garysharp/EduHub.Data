using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accident Witnesses
    /// </summary>
    public class SADW_Entity : EntityBase
    {
#region Navigation Property Cache
        private SAD_Entity _ACCIDENTID_SAD;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Sequence no of accident [Integer (32bit signed nullable): l]
        /// </summary>
        public int? ACCIDENTID { get; internal set; }
        /// <summary>
        /// Type of person witnessing accident: ST=Student, SF=Staff member, DF=Family member, OT=Other [Uppercase Alphanumeric: u2]
        /// </summary>
        public string WITNESS_TYPE { get; internal set; }
        /// <summary>
        /// Code identifying person witnessing accident (if student, staff member or family member) [Uppercase Alphanumeric: u10]
        /// </summary>
        public string WITNESSKEY { get; internal set; }
        /// <summary>
        /// Code indicating adult A or B (if family member) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string WITNESS_DFAB { get; internal set; }
        /// <summary>
        /// Full name of person witnessing accident (if not student, staff member or family member) [Alphanumeric: a64]
        /// </summary>
        public string FULL_NAME { get; internal set; }
        /// <summary>
        /// Address of person witnessing accident (if not student, staff member or family member) [Alphanumeric: a120]
        /// </summary>
        public string ADDRESS { get; internal set; }
        /// <summary>
        /// Phone number of person witnessing accident (if not student, staff member or family member) [Alphanumeric: a20]
        /// </summary>
        public string TELEPHONE { get; internal set; }
        /// <summary>
        /// Witness statement [Memo: m]
        /// </summary>
        public string STATEMENT { get; internal set; }
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
        /// Navigation property for [ACCIDENTID] => [SAD_Entity].[SADKEY]
        /// Sequence no of accident
        /// </summary>
        public SAD_Entity ACCIDENTID_SAD {
            get
            {
                if (ACCIDENTID.HasValue)
                {
                    if (_ACCIDENTID_SAD == null)
                    {
                        _ACCIDENTID_SAD = Context.SAD.FindBySADKEY(ACCIDENTID.Value);
                    }
                    return _ACCIDENTID_SAD;
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
