using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Report email templates
    /// </summary>
    public class SPEMAIL_Entity : EntityBase
    {
        /// <summary>
        /// Key [Uppercase Alphanumeric: u15]
        /// </summary>
        public string SPEMAILKEY { get; internal set; }
        /// <summary>
        /// Description [Alphanumeric: a40]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Report file name (without  extension)
        ///  [Uppercase Alphanumeric: u10]
        /// </summary>
        public string REPORT { get; internal set; }
        /// <summary>
        /// Navigation property for [REPORT] => [KREPORT_Entity].[KREPORTKEY]
        /// Report file name (without  extension)
        /// 
        /// </summary>
        public KREPORT_Entity REPORT_KREPORT { get { return REPORT == null ? null : Context.KREPORT.FindByKREPORTKEY(REPORT); } }
        /// <summary>
        /// Default path of printout [Alphanumeric: a128]
        /// </summary>
        public string PRINT_PATH { get; internal set; }
        /// <summary>
        /// message importance (High, Low, Normal) [Titlecase: t6]
        /// </summary>
        public string IMPORTANCE { get; internal set; }
        /// <summary>
        /// Send options [Titlecase: t15]
        /// </summary>
        public string SEND_OPTION { get; internal set; }
        /// <summary>
        /// Prefix for email subject [Alphanumeric: a70]
        /// </summary>
        public string EMAIL_SUBJECT { get; internal set; }
        /// <summary>
        /// Message for email [Memo: m]
        /// </summary>
        public string EMAIL_MESSAGE { get; internal set; }
        /// <summary>
        /// Location of an HTML file that that contains the message [Alphanumeric: a128]
        /// </summary>
        public string EMAIL_HTML { get; internal set; }
        /// <summary>
        /// The message text is full HTML [Uppercase Alphanumeric: u1]
        /// </summary>
        public string HTML_MESSAGE { get; internal set; }
        /// <summary>
        /// The from address to use when email is sent
        ///  [Alphanumeric: a128]
        /// </summary>
        public string FROM_ADDRESS { get; internal set; }
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
        
        
    }
}
