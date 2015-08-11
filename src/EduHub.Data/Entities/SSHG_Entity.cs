using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Specialist Subjects per Home Group
    /// </summary>
    public class SSHG_Entity : EntityBase
    {
        /// <summary>
        /// Record identifier [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Home group ID [Uppercase Alphanumeric: u3]
        /// </summary>
        public string HOMEGROUP { get; internal set; }
        /// <summary>
        /// Navigation property for [HOMEGROUP] => [KGC_Entity].[KGCKEY]
        /// Home group ID
        /// </summary>
        public KGC_Entity HOMEGROUP_KGC { get { return HOMEGROUP == null ? null : Context.KGC.FindByKGCKEY(HOMEGROUP); } }
        /// <summary>
        /// Subject ID [Uppercase Alphanumeric: u10]
        /// </summary>
        public string SUBJECT { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJECT] => [SS_Entity].[SSKEY]
        /// Subject ID
        /// </summary>
        public SS_Entity SUBJECT_SS { get { return SUBJECT == null ? null : Context.SS.FindBySSKEY(SUBJECT); } }
        /// <summary>
        /// Teacher ID [Uppercase Alphanumeric: u4]
        /// </summary>
        public string TEACHER { get; internal set; }
        /// <summary>
        /// Navigation property for [TEACHER] => [SF_Entity].[SFKEY]
        /// Teacher ID
        /// </summary>
        public SF_Entity TEACHER_SF { get { return TEACHER == null ? null : Context.SF.FindBySFKEY(TEACHER); } }
        /// <summary>
        /// Student ID [Uppercase Alphanumeric: u10]
        /// </summary>
        public string STUDENT { get; internal set; }
        /// <summary>
        /// Navigation property for [STUDENT] => [ST_Entity].[STKEY]
        /// Student ID
        /// </summary>
        public ST_Entity STUDENT_ST { get { return STUDENT == null ? null : Context.ST.FindBySTKEY(STUDENT); } }
        /// <summary>
        /// IN or OUT [Uppercase Alphanumeric: u3]
        /// </summary>
        public string VARIATION { get; internal set; }
        /// <summary>
        /// ID of home group with which an IN variation will be taken. ZZZ otherwise. [Uppercase Alphanumeric: u3]
        /// </summary>
        public string TEACHING_HG { get; internal set; }
        /// <summary>
        /// Navigation property for [TEACHING_HG] => [KGC_Entity].[KGCKEY]
        /// ID of home group with which an IN variation will be taken. ZZZ otherwise.
        /// </summary>
        public KGC_Entity TEACHING_HG_KGC { get { return TEACHING_HG == null ? null : Context.KGC.FindByKGCKEY(TEACHING_HG); } }
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
