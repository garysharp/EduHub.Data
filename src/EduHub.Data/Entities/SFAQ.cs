#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Availability in Quilt
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SFAQ : EduHubEntity
    {

        #region Navigation Property Cache

        private SF Cache_SFAQKEY_SF;
        private TH Cache_QKEY_TH;

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
        /// Staff key
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SFAQKEY { get; internal set; }

        /// <summary>
        /// Quilt
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string QKEY { get; internal set; }

        /// <summary>
        /// Day of the timetable cycle
        /// </summary>
        public short? DAY_NUMBER { get; internal set; }

        /// <summary>
        /// Start available period
        /// </summary>
        public short? START_PERIOD { get; internal set; }

        /// <summary>
        /// End available period
        /// </summary>
        public short? END_PERIOD { get; internal set; }

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
        /// SF (Staff) related entity by [SFAQ.SFAQKEY]-&gt;[SF.SFKEY]
        /// Staff key
        /// </summary>
        public SF SFAQKEY_SF
        {
            get
            {
                if (Cache_SFAQKEY_SF == null)
                {
                    Cache_SFAQKEY_SF = Context.SF.FindBySFKEY(SFAQKEY);
                }

                return Cache_SFAQKEY_SF;
            }
        }

        /// <summary>
        /// TH (Timetable Quilt Headers) related entity by [SFAQ.QKEY]-&gt;[TH.THKEY]
        /// Quilt
        /// </summary>
        public TH QKEY_TH
        {
            get
            {
                if (QKEY == null)
                {
                    return null;
                }
                if (Cache_QKEY_TH == null)
                {
                    Cache_QKEY_TH = Context.TH.FindByTHKEY(QKEY);
                }

                return Cache_QKEY_TH;
            }
        }

        #endregion

    }
}
#endif
