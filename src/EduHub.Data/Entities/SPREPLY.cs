using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// SMS Recipients
    /// </summary>
    public partial class SPREPLY : EntityBase
    {
#region Navigation Property Cache
        private SPSMS _CODE_SPSMS;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }
        /// <summary>
        /// SMS Key
        /// </summary>
        public int? CODE { get; internal set; }
        /// <summary>
        /// TID From SPRECIP
        /// 
        /// </summary>
        public int? SPRECIP_TID { get; internal set; }
        /// <summary>
        /// 
        /// [Alphanumeric (255)]
        /// </summary>
        public string MESSAGE { get; internal set; }
        /// <summary>
        /// phone number reply came from
        /// [Alphanumeric (15)]
        /// </summary>
        public string PHONE_NUMBER { get; internal set; }
        /// <summary>
        /// date recieved by recipient (if read receipt required)
        /// 
        /// </summary>
        public DateTime? RECEIVED_DATE { get; internal set; }
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
        /// SPSMS (SMS messages) related entity by [SPREPLY.CODE]-&gt;[SPSMS.SPSMSKEY]
        /// SMS Key
        /// </summary>
        public SPSMS CODE_SPSMS
        {
            get
            {
                if (CODE.HasValue)
                {
                    if (_CODE_SPSMS == null)
                    {
                        _CODE_SPSMS = Context.SPSMS.FindBySPSMSKEY(CODE.Value);
                    }
                    return _CODE_SPSMS;
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
