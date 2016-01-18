using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accident Prevention Measures
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SADP : EduHubEntity
    {

        #region Navigation Property Cache

        private SAD Cache_ACCIDENTID_SAD;

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
        /// Transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Sequence no of accident
        /// </summary>
        public int ACCIDENTID { get; internal set; }

        /// <summary>
        /// Code identifying preventative action taken
        /// </summary>
        public short? PREVENTION { get; internal set; }

        /// <summary>
        /// Description of any other preventative action taken
        /// [Memo]
        /// </summary>
        public string OTHER_PREV_INFO { get; internal set; }

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
        /// SAD (Accidents) related entity by [SADP.ACCIDENTID]-&gt;[SAD.SADKEY]
        /// Sequence no of accident
        /// </summary>
        public SAD ACCIDENTID_SAD
        {
            get
            {
                if (Cache_ACCIDENTID_SAD == null)
                {
                    Cache_ACCIDENTID_SAD = Context.SAD.FindBySADKEY(ACCIDENTID);
                }

                return Cache_ACCIDENTID_SAD;
            }
        }

        #endregion

    }
}
