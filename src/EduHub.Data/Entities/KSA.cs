using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Areas of Teaching
    /// </summary>
    public partial class KSA : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Code to identify Area of Teaching
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string KSAKEY { get; internal set; }
        /// <summary>
        /// Descriptive name
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
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
        /// SF (Staff) related entities by [SF.MAJORA]-&gt;[KSA.KSAKEY]
        /// </summary>
        public IReadOnlyList<SF> SF_MAJORA
        {
            get
            {
                return Context.KSA.FindSFByMAJORA(KSAKEY);
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SF.MAJORB]-&gt;[KSA.KSAKEY]
        /// </summary>
        public IReadOnlyList<SF> SF_MAJORB
        {
            get
            {
                return Context.KSA.FindSFByMAJORB(KSAKEY);
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SF.MAJORC]-&gt;[KSA.KSAKEY]
        /// </summary>
        public IReadOnlyList<SF> SF_MAJORC
        {
            get
            {
                return Context.KSA.FindSFByMAJORC(KSAKEY);
            }
        }
#endregion
    }
}
