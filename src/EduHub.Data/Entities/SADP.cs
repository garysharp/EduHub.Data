using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accident Prevention Measures
    /// </summary>
    public partial class SADP : EntityBase
    {
#region Navigation Property Cache
        private SAD _ACCIDENTID_SAD;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Sequence no of accident
        /// </summary>
        public int? ACCIDENTID { get; internal set; }
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
                if (ACCIDENTID.HasValue)
                {
                    if (_ACCIDENTID_SAD == null)
                    {
                        _ACCIDENTID_SAD = Context.SAD.FindBySADKEY(ACCIDENTID.Value);
                    }
                    return _ACCIDENTID_SAD;
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
