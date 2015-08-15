using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accidents
    /// </summary>
    public class SAD_Entity : EntityBase
    {
#region Navigation Property Cache
        private SCI_Entity _CAMPUS_SCI;
        private SM_Entity _ROOM_SM;
        private SF_Entity _AREA_DUTY_TEACHER_SF;
#endregion

#region Field Properties
        /// <summary>
        /// Sequence no [Integer (32bit signed): l]
        /// </summary>
        public int SADKEY { get; internal set; }
        /// <summary>
        /// Detailed description of accident [Memo: m]
        /// </summary>
        public string DETAIL_OUTLINE { get; internal set; }
        /// <summary>
        /// Date of accident [Date Time nullable: d]
        /// </summary>
        public DateTime? ACCIDENT_DATE { get; internal set; }
        /// <summary>
        /// Time of accident [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ACCIDENT_TIME { get; internal set; }
        /// <summary>
        /// Code identifying general activity at time of accident [Integer (16bit signed nullable): i]
        /// </summary>
        public short? GENERAL_ACTIVITY { get; internal set; }
        /// <summary>
        /// Code identifying more specific activity at time of accident [Integer (16bit signed nullable): i]
        /// </summary>
        public short? DETAILED_ACTIVITY { get; internal set; }
        /// <summary>
        /// Further details of activity at time of accident [Memo: m]
        /// </summary>
        public string OTHER_ACTIVITY_INFO { get; internal set; }
        /// <summary>
        /// Code identifying type of accident [Integer (16bit signed nullable): i]
        /// </summary>
        public short? DESCRIPTION { get; internal set; }
        /// <summary>
        /// Further details of type of accident [Memo: m]
        /// </summary>
        public string OTHER_DESC_INFO { get; internal set; }
        /// <summary>
        /// Code identifying area of school in which accident occurred [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ACCIDENT_SITE { get; internal set; }
        /// <summary>
        /// Campus on which accident occured [Integer (32bit signed nullable): l]
        /// </summary>
        public int? CAMPUS { get; internal set; }
        /// <summary>
        /// Location of accident if not on campus [Memo: m]
        /// </summary>
        public string EXTERNAL_ADDRESS { get; internal set; }
        /// <summary>
        /// Room where accident occurred (if any) [Uppercase Alphanumeric: u4]
        /// </summary>
        public string ROOM { get; internal set; }
        /// <summary>
        /// Staff code of senior duty teacher in area of accident at the time [Uppercase Alphanumeric: u4]
        /// </summary>
        public string AREA_DUTY_TEACHER { get; internal set; }
        /// <summary>
        /// Full name of senior duty teacher in area of accident at the time [Alphanumeric: a64]
        /// </summary>
        public string DUTY_TEACHER_FULL_NAME { get; internal set; }
        /// <summary>
        /// Number of teachers on duty in area of accident at the time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TEACHERS_ON_DUTY { get; internal set; }
        /// <summary>
        /// Date on which this record was originally created [Date Time nullable: d]
        /// </summary>
        public DateTime? CREATION_DATE { get; internal set; }
        /// <summary>
        /// Has the report of this accident been mailed to DEECD? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string MAILED { get; internal set; }
        /// <summary>
        /// Full name of first or only person involved [Alphanumeric: a64]
        /// </summary>
        public string FIRST_INJURED_PARTY { get; internal set; }
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
        /// Navigation property for [CAMPUS] => [SCI_Entity].[SCIKEY]
        /// Campus on which accident occured
        /// </summary>
        public SCI_Entity CAMPUS_SCI {
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
        /// Navigation property for [ROOM] => [SM_Entity].[ROOM]
        /// Room where accident occurred (if any)
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
        /// <summary>
        /// Navigation property for [AREA_DUTY_TEACHER] => [SF_Entity].[SFKEY]
        /// Staff code of senior duty teacher in area of accident at the time
        /// </summary>
        public SF_Entity AREA_DUTY_TEACHER_SF {
            get
            {
                if (AREA_DUTY_TEACHER != null)
                {
                    if (_AREA_DUTY_TEACHER_SF == null)
                    {
                        _AREA_DUTY_TEACHER_SF = Context.SF.FindBySFKEY(AREA_DUTY_TEACHER);
                    }
                    return _AREA_DUTY_TEACHER_SF;
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
