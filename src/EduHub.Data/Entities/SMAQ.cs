using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Room Availability in Quilt
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SMAQ : EduHubEntity
    {

        #region Navigation Property Cache

        private SM Cache_SMAQKEY_SM;
        private TH Cache_QKEY_TH;

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
        /// Room key
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SMAQKEY { get; internal set; }

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
        /// SM (Rooms) related entity by [SMAQ.SMAQKEY]-&gt;[SM.ROOM]
        /// Room key
        /// </summary>
        public SM SMAQKEY_SM
        {
            get
            {
                if (Cache_SMAQKEY_SM == null)
                {
                    Cache_SMAQKEY_SM = Context.SM.FindByROOM(SMAQKEY);
                }

                return Cache_SMAQKEY_SM;
            }
        }

        /// <summary>
        /// TH (Timetable Quilt Headers) related entity by [SMAQ.QKEY]-&gt;[TH.THKEY]
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
