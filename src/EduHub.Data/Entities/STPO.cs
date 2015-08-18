using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Position or Group Memberships
    /// </summary>
    public class STPO : EntityBase
    {
#region Navigation Property Cache
        private ST _STPOKEY_ST;
        private SG _SGLINK_SG;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Student ID
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string STPOKEY { get; internal set; }
        /// <summary>
        /// Position or Group code
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string SGLINK { get; internal set; }
        /// <summary>
        /// Date of joining group
        /// </summary>
        public DateTime? START_DATE { get; internal set; }
        /// <summary>
        /// Date of leaving group
        /// </summary>
        public DateTime? END_DATE { get; internal set; }
        /// <summary>
        /// Performance notes
        /// [Memo]
        /// </summary>
        public string PERFORMANCE { get; internal set; }
        /// <summary>
        /// Role of this person in this group
        /// [Alphanumeric (30)]
        /// </summary>
        public string GROUP_ROLE { get; internal set; }
        /// <summary>
        /// Action
        /// [Memo]
        /// </summary>
        public string OTHER { get; internal set; }
        /// <summary>
        /// Group type of Position or Group: S=Special, E=Excursion, P=Position
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SG_TYPE { get; internal set; }
        /// <summary>
        /// House or Home group
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string HOUSE_HG { get; internal set; }
        /// <summary>
        /// Parental permission? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PERMISSION { get; internal set; }
        /// <summary>
        /// School permission? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SCH_PERMISSION { get; internal set; }
        /// <summary>
        /// Payment received in full? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string FULLY_PAID { get; internal set; }
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
        /// Navigation property for [STPOKEY] => [ST].[STKEY]
        /// Student ID
        /// </summary>
        public ST STPOKEY_ST {
            get
            {
                if (STPOKEY != null)
                {
                    if (_STPOKEY_ST == null)
                    {
                        _STPOKEY_ST = Context.ST.FindBySTKEY(STPOKEY);
                    }
                    return _STPOKEY_ST;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SGLINK] => [SG].[SGKEY]
        /// Position or Group code
        /// </summary>
        public SG SGLINK_SG {
            get
            {
                if (SGLINK != null)
                {
                    if (_SGLINK_SG == null)
                    {
                        _SGLINK_SG = Context.SG.FindBySGKEY(SGLINK);
                    }
                    return _SGLINK_SG;
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
