using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject Classes
    /// </summary>
    public class SCL_Entity : EntityBase
    {
        /// <summary>
        /// Class code [Uppercase Alphanumeric: u17]
        /// </summary>
        public string SCLKEY { get; internal set; }
        /// <summary>
        /// Applicable quilt [Uppercase Alphanumeric: u8]
        /// </summary>
        public string QUILT { get; internal set; }
        /// <summary>
        /// Navigation property for [QUILT] => [TH_Entity].[THKEY]
        /// Applicable quilt
        /// </summary>
        public TH_Entity QUILT_TH { get { return QUILT == null ? null : Context.TH.FindByTHKEY(QUILT); } }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJECT { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJECT] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJECT_SU { get { return SUBJECT == null ? null : Context.SU.FindBySUKEY(SUBJECT); } }
        /// <summary>
        /// Class number [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS { get; internal set; }
        /// <summary>
        /// Teachers [Uppercase Alphanumeric: u4]
        /// </summary>
        public string TEACHER01 { get; internal set; }
        /// <summary>
        /// Navigation property for [TEACHER01] => [SF_Entity].[SFKEY]
        /// Teachers
        /// </summary>
        public SF_Entity TEACHER01_SF { get { return TEACHER01 == null ? null : Context.SF.FindBySFKEY(TEACHER01); } }
        /// <summary>
        /// Teachers [Uppercase Alphanumeric: u4]
        /// </summary>
        public string TEACHER02 { get; internal set; }
        /// <summary>
        /// Navigation property for [TEACHER02] => [SF_Entity].[SFKEY]
        /// Teachers
        /// </summary>
        public SF_Entity TEACHER02_SF { get { return TEACHER02 == null ? null : Context.SF.FindBySFKEY(TEACHER02); } }
        /// <summary>
        /// Rooms [Uppercase Alphanumeric: u4]
        /// </summary>
        public string ROOM01 { get; internal set; }
        /// <summary>
        /// Navigation property for [ROOM01] => [SM_Entity].[ROOM]
        /// Rooms
        /// </summary>
        public SM_Entity ROOM01_SM { get { return ROOM01 == null ? null : Context.SM.FindByROOM(ROOM01); } }
        /// <summary>
        /// Rooms [Uppercase Alphanumeric: u4]
        /// </summary>
        public string ROOM02 { get; internal set; }
        /// <summary>
        /// Navigation property for [ROOM02] => [SM_Entity].[ROOM]
        /// Rooms
        /// </summary>
        public SM_Entity ROOM02_SM { get { return ROOM02 == null ? null : Context.SM.FindByROOM(ROOM02); } }
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
        /// Navigation property for [CAMPUS] => [SCI_Entity].[SCIKEY]
        /// Campus where the class is held
        /// </summary>
        public SCI_Entity CAMPUS_SCI { get { return CAMPUS.HasValue ? Context.SCI.FindBySCIKEY(CAMPUS.Value) : null; } }
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
        
        
    }
}
