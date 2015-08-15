using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Specialist Subjects
    /// </summary>
    public class SS_Entity : EntityBase
    {
#region Navigation Property Cache
        private KGC_Entity _FROM_HOMEGROUP_KGC;
        private KGC_Entity _TO_HOMEGROUP_KGC;
        private SF_Entity _DEFAULT_TEACHER_SF;
#endregion

#region Field Properties
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string SSKEY { get; internal set; }
        /// <summary>
        /// Subject name [Titlecase: t30]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Minimum home group taking the subject [Uppercase Alphanumeric: u3]
        /// </summary>
        public string FROM_HOMEGROUP { get; internal set; }
        /// <summary>
        /// Maximum home group taking the subject [Uppercase Alphanumeric: u3]
        /// </summary>
        public string TO_HOMEGROUP { get; internal set; }
        /// <summary>
        /// Specialist subject active Y/N [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ACTIVE { get; internal set; }
        /// <summary>
        /// Optional default teacher [Uppercase Alphanumeric: u4]
        /// </summary>
        public string DEFAULT_TEACHER { get; internal set; }
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
        /// Navigation property for [FROM_HOMEGROUP] => [KGC_Entity].[KGCKEY]
        /// Minimum home group taking the subject
        /// </summary>
        public KGC_Entity FROM_HOMEGROUP_KGC {
            get
            {
                if (FROM_HOMEGROUP != null)
                {
                    if (_FROM_HOMEGROUP_KGC == null)
                    {
                        _FROM_HOMEGROUP_KGC = Context.KGC.FindByKGCKEY(FROM_HOMEGROUP);
                    }
                    return _FROM_HOMEGROUP_KGC;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [TO_HOMEGROUP] => [KGC_Entity].[KGCKEY]
        /// Maximum home group taking the subject
        /// </summary>
        public KGC_Entity TO_HOMEGROUP_KGC {
            get
            {
                if (TO_HOMEGROUP != null)
                {
                    if (_TO_HOMEGROUP_KGC == null)
                    {
                        _TO_HOMEGROUP_KGC = Context.KGC.FindByKGCKEY(TO_HOMEGROUP);
                    }
                    return _TO_HOMEGROUP_KGC;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [DEFAULT_TEACHER] => [SF_Entity].[SFKEY]
        /// Optional default teacher
        /// </summary>
        public SF_Entity DEFAULT_TEACHER_SF {
            get
            {
                if (DEFAULT_TEACHER != null)
                {
                    if (_DEFAULT_TEACHER_SF == null)
                    {
                        _DEFAULT_TEACHER_SF = Context.SF.FindBySFKEY(DEFAULT_TEACHER);
                    }
                    return _DEFAULT_TEACHER_SF;
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
