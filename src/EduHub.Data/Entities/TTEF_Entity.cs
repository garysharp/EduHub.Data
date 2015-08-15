using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Exam Staff
    /// </summary>
    public class TTEF_Entity : EntityBase
    {
#region Navigation Property Cache
        private TT_Entity _GKEY_TT;
        private SF_Entity _STAFF_SF;
        private SM_Entity _ROOM_SM;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Grid involved in exam [Uppercase Alphanumeric: u8]
        /// </summary>
        public string GKEY { get; internal set; }
        /// <summary>
        /// Exam period to which this staff belongs [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TTEP_TID { get; internal set; }
        /// <summary>
        /// Staff start time [Date Time nullable: d]
        /// </summary>
        public DateTime? TIME_START { get; internal set; }
        /// <summary>
        /// Staff end time [Date Time nullable: d]
        /// </summary>
        public DateTime? TIME_END { get; internal set; }
        /// <summary>
        /// Staff member [Uppercase Alphanumeric: u4]
        /// </summary>
        public string STAFF { get; internal set; }
        /// <summary>
        /// Room where Exam is to be held [Uppercase Alphanumeric: u4]
        /// </summary>
        public string ROOM { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [GKEY] => [TT_Entity].[TTKEY]
        /// Grid involved in exam
        /// </summary>
        public TT_Entity GKEY_TT {
            get
            {
                if (GKEY != null)
                {
                    if (_GKEY_TT == null)
                    {
                        _GKEY_TT = Context.TT.FindByTTKEY(GKEY);
                    }
                    return _GKEY_TT;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [STAFF] => [SF_Entity].[SFKEY]
        /// Staff member
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
        /// <summary>
        /// Navigation property for [ROOM] => [SM_Entity].[ROOM]
        /// Room where Exam is to be held
        /// </summary>
        public SM_Entity ROOM_SM {
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
