using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Sickbay Medication Administrations
    /// </summary>
    public class SAIM_Entity : EntityBase
    {
#region Navigation Property Cache
        private SAI_Entity _INVOLVEMENTID_SAI;
        private SF_Entity _STAFF_SF;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Sequence no of accident involvement [Integer (32bit signed nullable): l]
        /// </summary>
        public int? INVOLVEMENTID { get; internal set; }
        /// <summary>
        /// Medication administered [Alphanumeric: a30]
        /// </summary>
        public string MEDICATION { get; internal set; }
        /// <summary>
        /// Staff code of staff member administering medication (if any) [Uppercase Alphanumeric: u4]
        /// </summary>
        public string STAFF { get; internal set; }
        /// <summary>
        /// Name of person administering medication (if not staff member) [Alphanumeric: a30]
        /// </summary>
        public string ADMIN_BY_OTHER { get; internal set; }
        /// <summary>
        /// Time medication administered [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ADMIN_TIME { get; internal set; }
        /// <summary>
        /// Dose administered [Alphanumeric: a30]
        /// </summary>
        public string DOSE { get; internal set; }
        /// <summary>
        /// Ad hoc notes, response to medication [Memo: m]
        /// </summary>
        public string ADMIN_NOTES { get; internal set; }
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
        /// Navigation property for [INVOLVEMENTID] => [SAI_Entity].[SAIKEY]
        /// Sequence no of accident involvement
        /// </summary>
        public SAI_Entity INVOLVEMENTID_SAI {
            get
            {
                if (INVOLVEMENTID.HasValue)
                {
                    if (_INVOLVEMENTID_SAI == null)
                    {
                        _INVOLVEMENTID_SAI = Context.SAI.FindBySAIKEY(INVOLVEMENTID.Value);
                    }
                    return _INVOLVEMENTID_SAI;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [STAFF] => [SF_Entity].[SFKEY]
        /// Staff code of staff member administering medication (if any)
        /// </summary>
        public SF_Entity STAFF_SF {
            get
            {
                if (STAFF != null)
                {
                    if (_STAFF_SF == null)
                    {
                        _STAFF_SF = Context.SF.FindBySFKEY(STAFF);
                    }
                    return _STAFF_SF;
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
