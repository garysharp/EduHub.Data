using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Teacher Absences
    /// </summary>
    public class TCTB : EntityBase
    {
#region Navigation Property Cache
        private TC _TCTBKEY_TC;
        private SU _SUBJ_SU;
        private SF _TEACHER_SF;
        private SM _ROOM_SM;
        private TCAT _ABSENCE_TYPE_TCAT;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Absent date
        /// </summary>
        public DateTime? TCTBKEY { get; internal set; }
        /// <summary>
        /// Subject key
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJ { get; internal set; }
        /// <summary>
        /// Class of subject that is away
        /// </summary>
        public short? CLASS { get; internal set; }
        /// <summary>
        /// Teacher that is absent
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TEACHER { get; internal set; }
        /// <summary>
        /// Room that is not available
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string ROOM { get; internal set; }
        /// <summary>
        /// If subject absence, is teacher available
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TEACHER_AVAILABLE { get; internal set; }
        /// <summary>
        /// If subject absence, is room available
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ROOM_AVAILABLE { get; internal set; }
        /// <summary>
        /// Start time of absence
        /// </summary>
        public DateTime? TIME_FROM { get; internal set; }
        /// <summary>
        /// End time of absence
        /// </summary>
        public DateTime? TIME_TO { get; internal set; }
        /// <summary>
        /// Comments
        /// [Memo]
        /// </summary>
        public string COMMENT_A { get; internal set; }
        /// <summary>
        /// Absence type code. Defaults to "CURRICULUM" if absence created by an Event
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string ABSENCE_TYPE { get; internal set; }
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
        /// Navigation property for [TCTBKEY] => [TC].[TCKEY]
        /// Absent date
        /// </summary>
        public TC TCTBKEY_TC {
            get
            {
                if (TCTBKEY.HasValue)
                {
                    if (_TCTBKEY_TC == null)
                    {
                        _TCTBKEY_TC = Context.TC.FindByTCKEY(TCTBKEY.Value);
                    }
                    return _TCTBKEY_TC;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJ] => [SU].[SUKEY]
        /// Subject key
        /// </summary>
        public SU SUBJ_SU {
            get
            {
                if (SUBJ != null)
                {
                    if (_SUBJ_SU == null)
                    {
                        _SUBJ_SU = Context.SU.FindBySUKEY(SUBJ);
                    }
                    return _SUBJ_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [TEACHER] => [SF].[SFKEY]
        /// Teacher that is absent
        /// </summary>
        public SF TEACHER_SF {
            get
            {
                if (TEACHER != null)
                {
                    if (_TEACHER_SF == null)
                    {
                        _TEACHER_SF = Context.SF.FindBySFKEY(TEACHER);
                    }
                    return _TEACHER_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [ROOM] => [SM].[ROOM]
        /// Room that is not available
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
        /// <summary>
        /// Navigation property for [ABSENCE_TYPE] => [TCAT].[TCATKEY]
        /// Absence type code. Defaults to "CURRICULUM" if absence created by an Event
        /// </summary>
        public TCAT ABSENCE_TYPE_TCAT {
            get
            {
                if (ABSENCE_TYPE != null)
                {
                    if (_ABSENCE_TYPE_TCAT == null)
                    {
                        _ABSENCE_TYPE_TCAT = Context.TCAT.FindByTCATKEY(ABSENCE_TYPE);
                    }
                    return _ABSENCE_TYPE_TCAT;
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
