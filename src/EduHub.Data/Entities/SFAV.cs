using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Availability for Calendar Extras
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SFAV : EduHubEntity
    {

        #region Navigation Property Cache

        private SF Cache_TEACH_SF;

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE.Value;
            }
        }

        #region Field Properties

        /// <summary>
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Staff key
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TEACH { get; internal set; }

        /// <summary>
        /// Day of the timetable cycle
        /// </summary>
        public short? DAY_NUMBER { get; internal set; }

        /// <summary>
        /// Start time of availability
        /// </summary>
        public DateTime? START_TIME { get; internal set; }

        /// <summary>
        /// Finish time of availability
        /// </summary>
        public DateTime? END_TIME { get; internal set; }

        /// <summary>
        /// Exception date for emergency teachers
        /// </summary>
        public DateTime? AVAILABLE_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// SF (Staff) related entity by [SFAV.TEACH]-&gt;[SF.SFKEY]
        /// Staff key
        /// </summary>
        public SF TEACH_SF
        {
            get
            {
                if (Cache_TEACH_SF == null)
                {
                    Cache_TEACH_SF = Context.SF.FindBySFKEY(TEACH);
                }

                return Cache_TEACH_SF;
            }
        }

        #endregion

    }
}
