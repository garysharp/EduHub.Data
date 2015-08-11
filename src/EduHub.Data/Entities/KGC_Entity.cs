using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Groups
    /// </summary>
    public class KGC_Entity : EntityBase
    {
        /// <summary>
        /// (Was FORM) Home Group code [Uppercase Alphanumeric: u3]
        /// </summary>
        public string KGCKEY { get; internal set; }
        /// <summary>
        /// Description [Alphanumeric: a30]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Campus [Integer (32bit signed nullable): l]
        /// </summary>
        public int? CAMPUS { get; internal set; }
        /// <summary>
        /// Navigation property for [CAMPUS] => [SCI_Entity].[SCIKEY]
        /// Campus
        /// </summary>
        public SCI_Entity CAMPUS_SCI { get { return CAMPUS.HasValue ? Context.SCI.FindBySCIKEY(CAMPUS.Value) : null; } }
        /// <summary>
        /// Staff code of first or only home group teacher [Uppercase Alphanumeric: u4]
        /// </summary>
        public string TEACHER { get; internal set; }
        /// <summary>
        /// Navigation property for [TEACHER] => [SF_Entity].[SFKEY]
        /// Staff code of first or only home group teacher
        /// </summary>
        public SF_Entity TEACHER_SF { get { return TEACHER == null ? null : Context.SF.FindBySFKEY(TEACHER); } }
        /// <summary>
        /// Staff code of second home group teacher (if any) [Uppercase Alphanumeric: u4]
        /// </summary>
        public string TEACHER_B { get; internal set; }
        /// <summary>
        /// Navigation property for [TEACHER_B] => [SF_Entity].[SFKEY]
        /// Staff code of second home group teacher (if any)
        /// </summary>
        public SF_Entity TEACHER_B_SF { get { return TEACHER_B == null ? null : Context.SF.FindBySFKEY(TEACHER_B); } }
        /// <summary>
        /// Active Home Group? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ACTIVE { get; internal set; }
        /// <summary>
        /// Home group room [Uppercase Alphanumeric: u4]
        /// </summary>
        public string ROOM { get; internal set; }
        /// <summary>
        /// Navigation property for [ROOM] => [SM_Entity].[ROOM]
        /// Home group room
        /// </summary>
        public SM_Entity ROOM_SM { get { return ROOM == null ? null : Context.SM.FindByROOM(ROOM); } }
        /// <summary>
        /// (Was FORM_SIZE) Home group population [Integer (16bit signed nullable): i]
        /// </summary>
        public short? HG_SIZE { get; internal set; }
        /// <summary>
        /// Number of male students in home group [Integer (16bit signed nullable): i]
        /// </summary>
        public short? MALES { get; internal set; }
        /// <summary>
        /// Number of female students in home group [Integer (16bit signed nullable): i]
        /// </summary>
        public short? FEMALES { get; internal set; }
        /// <summary>
        /// (Was AC_YR) Minimum year level covered by home group [Uppercase Alphanumeric: u4]
        /// </summary>
        public string MIN_AC_YR { get; internal set; }
        /// <summary>
        /// Navigation property for [MIN_AC_YR] => [KCY_Entity].[KCYKEY]
        /// (Was AC_YR) Minimum year level covered by home group
        /// </summary>
        public KCY_Entity MIN_AC_YR_KCY { get { return MIN_AC_YR == null ? null : Context.KCY.FindByKCYKEY(MIN_AC_YR); } }
        /// <summary>
        /// Maximum year level covered by home group [Uppercase Alphanumeric: u4]
        /// </summary>
        public string MAX_AC_YR { get; internal set; }
        /// <summary>
        /// Navigation property for [MAX_AC_YR] => [KCY_Entity].[KCYKEY]
        /// Maximum year level covered by home group
        /// </summary>
        public KCY_Entity MAX_AC_YR_KCY { get { return MAX_AC_YR == null ? null : Context.KCY.FindByKCYKEY(MAX_AC_YR); } }
        /// <summary>
        /// Assumed next home group (eg 8.1 is the group to which 7.1 is promoted) [Uppercase Alphanumeric: u3]
        /// </summary>
        public string NEXT_HG { get; internal set; }
        /// <summary>
        /// Navigation property for [NEXT_HG] => [KGC_Entity].[KGCKEY]
        /// Assumed next home group (eg 8.1 is the group to which 7.1 is promoted)
        /// </summary>
        public KGC_Entity NEXT_HG_KGC { get { return NEXT_HG == null ? null : Context.KGC.FindByKGCKEY(NEXT_HG); } }
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
