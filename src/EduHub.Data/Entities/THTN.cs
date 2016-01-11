using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Labels
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class THTN : EduHubEntity
    {

        #region Navigation Property Cache

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
        /// Transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Link to Timetable Quilt Header
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string QKEY { get; internal set; }

        /// <summary>
        /// Number &gt; 0 for quilt label,&lt; 0 extra labels
        /// </summary>
        public short? LABEL_NUMBER { get; internal set; }

        /// <summary>
        /// R for Row, C for Column
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LABEL_TYPE { get; internal set; }

        /// <summary>
        /// Name for the label
        /// [Alphanumeric (20)]
        /// </summary>
        public string LABEL_NAME { get; internal set; }

        /// <summary>
        /// Display colour for the label
        /// </summary>
        public int? LABEL_COLOUR { get; internal set; }

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
        /// TH (Timetable Quilt Headers) related entity by [THTN.QKEY]-&gt;[TH.THKEY]
        /// Link to Timetable Quilt Header
        /// </summary>
        public TH QKEY_TH
        {
            get
            {
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
