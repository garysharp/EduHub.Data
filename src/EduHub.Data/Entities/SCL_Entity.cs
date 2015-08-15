using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject Classes
    /// </summary>
    public class SCL_Entity : EntityBase
    {
#region Navigation Property Cache
        private TH_Entity _QUILT_TH;
        private SU_Entity _SUBJECT_SU;
        private SF_Entity _TEACHER01_SF;
        private SF_Entity _TEACHER02_SF;
        private SM_Entity _ROOM01_SM;
        private SM_Entity _ROOM02_SM;
        private SCI_Entity _CAMPUS_SCI;
#endregion

#region Field Properties
        /// <summary>
        /// Class code [Uppercase Alphanumeric: u17]
        /// </summary>
        public string SCLKEY { get; internal set; }
        /// <summary>
        /// Applicable quilt [Uppercase Alphanumeric: u8]
        /// </summary>
        public string QUILT { get; internal set; }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJECT { get; internal set; }
        /// <summary>
        /// Class number [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS { get; internal set; }
        /// <summary>
        /// Teachers [Uppercase Alphanumeric: u4]
        /// </summary>
        public string TEACHER01 { get; internal set; }
        /// <summary>
        /// Teachers [Uppercase Alphanumeric: u4]
        /// </summary>
        public string TEACHER02 { get; internal set; }
        /// <summary>
        /// Rooms [Uppercase Alphanumeric: u4]
        /// </summary>
        public string ROOM01 { get; internal set; }
        /// <summary>
        /// Rooms [Uppercase Alphanumeric: u4]
        /// </summary>
        public string ROOM02 { get; internal set; }
        /// <summary>
        /// Number of sessions per timetable cycle [Integer (16bit signed nullable): i]
        /// </summary>
        public short? FREQUENCY { get; internal set; }
        /// <summary>
        /// Report print flags [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PRINT_FLAGS01 { get; internal set; }
        /// <summary>
        /// Report print flags [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PRINT_FLAGS02 { get; internal set; }
        /// <summary>
        /// Report print flags [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PRINT_FLAGS03 { get; internal set; }
        /// <summary>
        /// Will period absences be recorded (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PERIOD_ABSENCES { get; internal set; }
        /// <summary>
        /// Campus where the class is held [Integer (32bit signed nullable): l]
        /// </summary>
        public int? CAMPUS { get; internal set; }
        /// <summary>
        /// Optional alias name eg 7A Eng, 7B Maths [Alphanumeric: a10]
        /// </summary>
        public string ALIAS { get; internal set; }
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
        /// Navigation property for [QUILT] => [TH_Entity].[THKEY]
        /// Applicable quilt
        /// </summary>
        public TH_Entity QUILT_TH {
            get
            {
                if (QUILT != null)
                {
                    if (_QUILT_TH == null)
                    {
                        _QUILT_TH = Context.TH.FindByTHKEY(QUILT);
                    }
                    return _QUILT_TH;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJECT] => [SU_Entity].[SUKEY]
        /// Subject code
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
        /// Navigation property for [TEACHER01] => [SF_Entity].[SFKEY]
        /// Teachers
        /// </summary>
        public SF_Entity TEACHER01_SF {
            get
            {
                if (TEACHER01 != null)
                {
                    if (_TEACHER01_SF == null)
                    {
                        _TEACHER01_SF = Context.SF.FindBySFKEY(TEACHER01);
                    }
                    return _TEACHER01_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [TEACHER02] => [SF_Entity].[SFKEY]
        /// Teachers
        /// </summary>
        public SF_Entity TEACHER02_SF {
            get
            {
                if (TEACHER02 != null)
                {
                    if (_TEACHER02_SF == null)
                    {
                        _TEACHER02_SF = Context.SF.FindBySFKEY(TEACHER02);
                    }
                    return _TEACHER02_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [ROOM01] => [SM_Entity].[ROOM]
        /// Rooms
        /// </summary>
        public SM_Entity ROOM01_SM {
            get
            {
                if (ROOM01 != null)
                {
                    if (_ROOM01_SM == null)
                    {
                        _ROOM01_SM = Context.SM.FindByROOM(ROOM01);
                    }
                    return _ROOM01_SM;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [ROOM02] => [SM_Entity].[ROOM]
        /// Rooms
        /// </summary>
        public SM_Entity ROOM02_SM {
            get
            {
                if (ROOM02 != null)
                {
                    if (_ROOM02_SM == null)
                    {
                        _ROOM02_SM = Context.SM.FindByROOM(ROOM02);
                    }
                    return _ROOM02_SM;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [CAMPUS] => [SCI_Entity].[SCIKEY]
        /// Campus where the class is held
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
#endregion
    }
}
