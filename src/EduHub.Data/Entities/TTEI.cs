#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Exam Details
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TTEI : EduHubEntity
    {

        #region Navigation Property Cache

        private TT Cache_GKEY_TT;

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE;
            }
        }

        #region Field Properties

        /// <summary>
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Grid involved in exam
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string GKEY { get; internal set; }

        /// <summary>
        /// Exam start date
        /// </summary>
        public DateTime? START_DATE { get; internal set; }

        /// <summary>
        /// Exam end date
        /// </summary>
        public DateTime? END_DATE { get; internal set; }

        /// <summary>
        /// Maximum exam population
        /// </summary>
        public short? MAX_SIZE { get; internal set; }

        /// <summary>
        /// Maximum number of lines in exam grid
        /// </summary>
        public short? MAX_LINES { get; internal set; }

        /// <summary>
        /// Use fixed exam grid
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string USE_FIXED { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// TT (Timetable Grid Templates) related entity by [TTEI.GKEY]-&gt;[TT.TTKEY]
        /// Grid involved in exam
        /// </summary>
        public TT GKEY_TT
        {
            get
            {
                if (Cache_GKEY_TT == null)
                {
                    Cache_GKEY_TT = Context.TT.FindByTTKEY(GKEY);
                }

                return Cache_GKEY_TT;
            }
        }

        #endregion

    }
}
#endif
