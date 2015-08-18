using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Rooms group
    /// </summary>
    public class SMGROUP : EntityBase
    {
#region Navigation Property Cache
        private SM _GROUPKEY_SM;
        private SM _ROOM_SM;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Group key in SM
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string GROUPKEY { get; internal set; }
        /// <summary>
        /// Room in the group
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string ROOM { get; internal set; }
        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [GROUPKEY] => [SM].[ROOM]
        /// Group key in SM
        /// </summary>
        public SM GROUPKEY_SM {
            get
            {
                if (GROUPKEY != null)
                {
                    if (_GROUPKEY_SM == null)
                    {
                        _GROUPKEY_SM = Context.SM.FindByROOM(GROUPKEY);
                    }
                    return _GROUPKEY_SM;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [ROOM] => [SM].[ROOM]
        /// Room in the group
        /// </summary>
        public SM ROOM_SM {
            get
            {
                if (ROOM != null)
                {
                    if (_ROOM_SM == null)
                    {
                        _ROOM_SM = Context.SM.FindByROOM(ROOM);
                    }
                    return _ROOM_SM;
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
