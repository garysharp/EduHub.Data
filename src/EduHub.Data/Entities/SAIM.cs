using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Sickbay Medication Administrations
    /// </summary>
    public partial class SAIM : EntityBase
    {
#region Navigation Property Cache
        private SAI _INVOLVEMENTID_SAI;
        private SF _STAFF_SF;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Sequence no of accident involvement
        /// </summary>
        public int? INVOLVEMENTID { get; internal set; }
        /// <summary>
        /// Medication administered
        /// [Alphanumeric (30)]
        /// </summary>
        public string MEDICATION { get; internal set; }
        /// <summary>
        /// Staff code of staff member administering medication (if any)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string STAFF { get; internal set; }
        /// <summary>
        /// Name of person administering medication (if not staff member)
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADMIN_BY_OTHER { get; internal set; }
        /// <summary>
        /// Time medication administered
        /// </summary>
        public short? ADMIN_TIME { get; internal set; }
        /// <summary>
        /// Dose administered
        /// [Alphanumeric (30)]
        /// </summary>
        public string DOSE { get; internal set; }
        /// <summary>
        /// Ad hoc notes, response to medication
        /// [Memo]
        /// </summary>
        public string ADMIN_NOTES { get; internal set; }
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
        /// SAI (Accident Involvements/Sickbay Visits) related entity by [SAIM.INVOLVEMENTID]-&gt;[SAI.SAIKEY]
        /// Sequence no of accident involvement
        /// </summary>
        public SAI INVOLVEMENTID_SAI
        {
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
        /// SF (Staff) related entity by [SAIM.STAFF]-&gt;[SF.SFKEY]
        /// Staff code of staff member administering medication (if any)
        /// </summary>
        public SF STAFF_SF
        {
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
