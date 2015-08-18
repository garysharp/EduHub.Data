using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Specialist Subjects
    /// </summary>
    public class SS : EntityBase
    {
#region Navigation Property Cache
        private KGC _FROM_HOMEGROUP_KGC;
        private KGC _TO_HOMEGROUP_KGC;
        private SF _DEFAULT_TEACHER_SF;
#endregion

#region Field Properties
        /// <summary>
        /// Subject code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SSKEY { get; internal set; }
        /// <summary>
        /// Subject name
        /// [Titlecase (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Minimum home group taking the subject
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string FROM_HOMEGROUP { get; internal set; }
        /// <summary>
        /// Maximum home group taking the subject
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string TO_HOMEGROUP { get; internal set; }
        /// <summary>
        /// Specialist subject active Y/N
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACTIVE { get; internal set; }
        /// <summary>
        /// Optional default teacher
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string DEFAULT_TEACHER { get; internal set; }
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
        /// Navigation property for [FROM_HOMEGROUP] => [KGC].[KGCKEY]
        /// Minimum home group taking the subject
        /// </summary>
        public KGC FROM_HOMEGROUP_KGC {
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
        /// Navigation property for [TO_HOMEGROUP] => [KGC].[KGCKEY]
        /// Maximum home group taking the subject
        /// </summary>
        public KGC TO_HOMEGROUP_KGC {
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
        /// Navigation property for [DEFAULT_TEACHER] => [SF].[SFKEY]
        /// Optional default teacher
        /// </summary>
        public SF DEFAULT_TEACHER_SF {
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
