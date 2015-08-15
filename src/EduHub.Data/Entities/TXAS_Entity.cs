using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Actual Sessions
    /// </summary>
    public class TXAS_Entity : EntityBase
    {
#region Navigation Property Cache
        private SU_Entity _SUBJECT_SU;
        private SF_Entity _TEACHER_SF;
        private SM_Entity _LOCATION_SM;
        private SCL_Entity _SCL_LINK_SCL;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed): l]
        /// </summary>
        public int TID { get; internal set; }
        /// <summary>
        /// TID in corresponding THTQ record [Integer (32bit signed nullable): l]
        /// </summary>
        public int? THTQ_TID { get; internal set; }
        /// <summary>
        /// Actual instance of a class / session [Uppercase Alphanumeric: u9]
        /// </summary>
        public string CLASS_SESSION { get; internal set; }
        /// <summary>
        /// Subject for this session [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJECT { get; internal set; }
        /// <summary>
        /// Class for this session [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS { get; internal set; }
        /// <summary>
        /// Staff code of teacher for this session [Uppercase Alphanumeric: u4]
        /// </summary>
        public string TEACHER { get; internal set; }
        /// <summary>
        /// Room code of room for this session [Uppercase Alphanumeric: u4]
        /// </summary>
        public string LOCATION { get; internal set; }
        /// <summary>
        /// Period number within the day [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PERIOD_NO { get; internal set; }
        /// <summary>
        /// Day number in the current timetable cycle [Integer (16bit signed nullable): i]
        /// </summary>
        public short? DAY_NO { get; internal set; }
        /// <summary>
        /// Date of this session [Date Time nullable: d]
        /// </summary>
        public DateTime? SESSION_DATE { get; internal set; }
        /// <summary>
        /// Actual Period Description from TH [Alphanumeric: a10]
        /// </summary>
        public string PERIOD_DESC { get; internal set; }
        /// <summary>
        /// Session start time (hh:mm) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? START_TIME { get; internal set; }
        /// <summary>
        /// Session finish time (hh:mm) [Integer (16bit signed nullable): i]
        /// </summary>
        public short? FINISH_TIME { get; internal set; }
        /// <summary>
        /// Has this roll been marked? (Y/N) Prompted when form closed [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ROLL_MARKED { get; internal set; }
        /// <summary>
        /// Class code in SCL [Uppercase Alphanumeric: u17]
        /// </summary>
        public string SCL_LINK { get; internal set; }
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
        /// Navigation property for [SUBJECT] => [SU_Entity].[SUKEY]
        /// Subject for this session
        /// </summary>
        public SU_Entity SUBJECT_SU {
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
        /// Navigation property for [TEACHER] => [SF_Entity].[SFKEY]
        /// Staff code of teacher for this session
        /// </summary>
        public SF_Entity TEACHER_SF {
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
        /// Navigation property for [LOCATION] => [SM_Entity].[ROOM]
        /// Room code of room for this session
        /// </summary>
        public SM_Entity LOCATION_SM {
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
        /// Navigation property for [SCL_LINK] => [SCL_Entity].[SCLKEY]
        /// Class code in SCL
        /// </summary>
        public SCL_Entity SCL_LINK_SCL {
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
