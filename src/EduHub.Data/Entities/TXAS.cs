using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Actual Sessions
    /// </summary>
    public class TXAS : EntityBase
    {
#region Navigation Property Cache
        private SU _SUBJECT_SU;
        private SF _TEACHER_SF;
        private SM _LOCATION_SM;
        private SCL _SCL_LINK_SCL;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }
        /// <summary>
        /// TID in corresponding THTQ record
        /// </summary>
        public int? THTQ_TID { get; internal set; }
        /// <summary>
        /// Actual instance of a class / session
        /// [Uppercase Alphanumeric (9)]
        /// </summary>
        public string CLASS_SESSION { get; internal set; }
        /// <summary>
        /// Subject for this session
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJECT { get; internal set; }
        /// <summary>
        /// Class for this session
        /// </summary>
        public short? CLASS { get; internal set; }
        /// <summary>
        /// Staff code of teacher for this session
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TEACHER { get; internal set; }
        /// <summary>
        /// Room code of room for this session
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string LOCATION { get; internal set; }
        /// <summary>
        /// Period number within the day
        /// </summary>
        public short? PERIOD_NO { get; internal set; }
        /// <summary>
        /// Day number in the current timetable cycle
        /// </summary>
        public short? DAY_NO { get; internal set; }
        /// <summary>
        /// Date of this session
        /// </summary>
        public DateTime? SESSION_DATE { get; internal set; }
        /// <summary>
        /// Actual Period Description from TH
        /// [Alphanumeric (10)]
        /// </summary>
        public string PERIOD_DESC { get; internal set; }
        /// <summary>
        /// Session start time (hh:mm)
        /// </summary>
        public short? START_TIME { get; internal set; }
        /// <summary>
        /// Session finish time (hh:mm)
        /// </summary>
        public short? FINISH_TIME { get; internal set; }
        /// <summary>
        /// Has this roll been marked? (Y/N) Prompted when form closed
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ROLL_MARKED { get; internal set; }
        /// <summary>
        /// Class code in SCL
        /// [Uppercase Alphanumeric (17)]
        /// </summary>
        public string SCL_LINK { get; internal set; }
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
        /// Navigation property for [SUBJECT] => [SU].[SUKEY]
        /// Subject for this session
        /// </summary>
        public SU SUBJECT_SU {
            get
            {
                if (SUBJECT != null)
                {
                    if (_SUBJECT_SU == null)
                    {
                        _SUBJECT_SU = Context.SU.FindBySUKEY(SUBJECT);
                    }
                    return _SUBJECT_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [TEACHER] => [SF].[SFKEY]
        /// Staff code of teacher for this session
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
        /// Navigation property for [LOCATION] => [SM].[ROOM]
        /// Room code of room for this session
        /// </summary>
        public SM LOCATION_SM {
            get
            {
                if (LOCATION != null)
                {
                    if (_LOCATION_SM == null)
                    {
                        _LOCATION_SM = Context.SM.FindByROOM(LOCATION);
                    }
                    return _LOCATION_SM;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SCL_LINK] => [SCL].[SCLKEY]
        /// Class code in SCL
        /// </summary>
        public SCL SCL_LINK_SCL {
            get
            {
                if (SCL_LINK != null)
                {
                    if (_SCL_LINK_SCL == null)
                    {
                        _SCL_LINK_SCL = Context.SCL.FindBySCLKEY(SCL_LINK);
                    }
                    return _SCL_LINK_SCL;
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
