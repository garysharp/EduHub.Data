﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Rooms
    /// </summary>
    public class SM : EntityBase
    {
#region Navigation Property Cache
        private KSF _FACULTY_KSF;
        private SCI _CAMPUS_SCI;
        private SF _STAFF_CODE_SF;
#endregion

#region Field Properties
        /// <summary>
        /// Room code
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string ROOM { get; internal set; }
        /// <summary>
        /// Room name
        /// [Alphanumeric (30)]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// Maximum capacity
        /// </summary>
        public short? SEATING { get; internal set; }
        /// <summary>
        /// Description of room
        /// [Alphanumeric (40)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Is this room available for timetabled activities? R=available, otherwise not
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ROOM_TYPE { get; internal set; }
        /// <summary>
        /// Code of the faculty responsible for this room
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FACULTY { get; internal set; }
        /// <summary>
        /// (V) (NRM) &lt;&lt; What exactly is this field for?
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string AREA_CODE { get; internal set; }
        /// <summary>
        /// ID of the campus on which this room is located
        /// </summary>
        public int? CAMPUS { get; internal set; }
        /// <summary>
        /// Code of the staff member responsible for this room (V) (NRM)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string STAFF_CODE { get; internal set; }
        /// <summary>
        /// 
        /// [Memo]
        /// </summary>
        public string COMMENTA { get; internal set; }
        /// <summary>
        /// Type of board provided (blackboard, whiteboard, etc.)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string BOARD { get; internal set; }
        /// <summary>
        /// Does this room have blackout provision? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string BLACKOUT { get; internal set; }
        /// <summary>
        /// Normal load for this room
        /// </summary>
        public short? NORMAL_ALLOTMENT { get; internal set; }
        /// <summary>
        /// Flag indicating if this is a single room or a group of rooms
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GROUP_INDICATOR { get; internal set; }
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
        /// Navigation property for [FACULTY] => [KSF].[KSFKEY]
        /// Code of the faculty responsible for this room
        /// </summary>
        public KSF FACULTY_KSF {
            get
            {
                if (FACULTY != null)
                {
                    if (_FACULTY_KSF == null)
                    {
                        _FACULTY_KSF = Context.KSF.FindByKSFKEY(FACULTY);
                    }
                    return _FACULTY_KSF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [CAMPUS] => [SCI].[SCIKEY]
        /// ID of the campus on which this room is located
        /// </summary>
        public SCI CAMPUS_SCI {
            get
            {
                if (CAMPUS.HasValue)
                {
                    if (_CAMPUS_SCI == null)
                    {
                        _CAMPUS_SCI = Context.SCI.FindBySCIKEY(CAMPUS.Value);
                    }
                    return _CAMPUS_SCI;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [STAFF_CODE] => [SF].[SFKEY]
        /// Code of the staff member responsible for this room (V) (NRM)
        /// </summary>
        public SF STAFF_CODE_SF {
            get
            {
                if (STAFF_CODE != null)
                {
                    if (_STAFF_CODE_SF == null)
                    {
                        _STAFF_CODE_SF = Context.SF.FindBySFKEY(STAFF_CODE);
                    }
                    return _STAFF_CODE_SF;
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
