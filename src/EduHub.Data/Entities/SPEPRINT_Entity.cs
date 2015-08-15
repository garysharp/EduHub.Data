using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Report file audit
    /// </summary>
    public class SPEPRINT_Entity : EntityBase
    {
#region Navigation Property Cache
        private SPEMAIL_Entity _CODE_SPEMAIL;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed): l]
        /// </summary>
        public int TID { get; internal set; }
        /// <summary>
        /// Email Key [Uppercase Alphanumeric: u15]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// printed Date [Date Time nullable: d]
        /// </summary>
        public DateTime? PRINT_DATE { get; internal set; }
        /// <summary>
        /// Who printed the report. [Uppercase Alphanumeric: u128]
        /// </summary>
        public string PRINT_BY { get; internal set; }
        /// <summary>
        /// Send Date [Date Time nullable: d]
        /// </summary>
        public DateTime? SEND_DATE { get; internal set; }
        /// <summary>
        /// Who printed the report. [Uppercase Alphanumeric: u128]
        /// </summary>
        public string SEND_BY { get; internal set; }
        /// <summary>
        /// Database table key comes from [Uppercase Alphanumeric: u8]
        /// </summary>
        public string ENTITY_TABLE { get; internal set; }
        /// <summary>
        /// Sendee Key [Uppercase Alphanumeric: u20]
        /// </summary>
        public string ENTITY_KEY { get; internal set; }
        /// <summary>
        /// Sendee Email Address [Alphanumeric: a60]
        /// </summary>
        public string EMAIL_ADDRESS { get; internal set; }
        /// <summary>
        /// Sendee Email Address [Alphanumeric: a60]
        /// </summary>
        public string COPY_ADDRESS { get; internal set; }
        /// <summary>
        /// Email Subject [Alphanumeric: a100]
        /// </summary>
        public string EMAIL_SUBJECT { get; internal set; }
        /// <summary>
        /// Email Body [Memo: m]
        /// </summary>
        public string EMAIL_MESSAGE { get; internal set; }
        /// <summary>
        /// Path of attachment, includes file name [Alphanumeric: a255]
        /// </summary>
        public string ATTACHMENT_PATH { get; internal set; }
        /// <summary>
        /// Send Status [Alphanumeric: a30]
        /// </summary>
        public string STATUS { get; internal set; }
        /// <summary>
        /// Trigger field for displaying report [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DISPLAY { get; internal set; }
        /// <summary>
        /// operator comments
        ///  [Memo: m]
        /// </summary>
        public string COMMENTS { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [CODE] => [SPEMAIL_Entity].[SPEMAILKEY]
        /// Email Key
        /// </summary>
        public SPEMAIL_Entity CODE_SPEMAIL {
            get
            {
                if (CODE != null)
                {
                    if (_CODE_SPEMAIL == null)
                    {
                        _CODE_SPEMAIL = Context.SPEMAIL.FindBySPEMAILKEY(CODE);
                    }
                    return _CODE_SPEMAIL;
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
