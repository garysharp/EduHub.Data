using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Report email templates
    /// </summary>
    public class SPEMAIL : EntityBase
    {
#region Navigation Property Cache
        private KREPORT _REPORT_KREPORT;
#endregion

#region Field Properties
        /// <summary>
        /// Key
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string SPEMAILKEY { get; internal set; }
        /// <summary>
        /// Description
        /// [Alphanumeric (40)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Report file name (without  extension)
        /// 
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string REPORT { get; internal set; }
        /// <summary>
        /// Default path of printout
        /// [Alphanumeric (128)]
        /// </summary>
        public string PRINT_PATH { get; internal set; }
        /// <summary>
        /// message importance (High, Low, Normal)
        /// [Titlecase (6)]
        /// </summary>
        public string IMPORTANCE { get; internal set; }
        /// <summary>
        /// Send options
        /// [Titlecase (15)]
        /// </summary>
        public string SEND_OPTION { get; internal set; }
        /// <summary>
        /// Prefix for email subject
        /// [Alphanumeric (70)]
        /// </summary>
        public string EMAIL_SUBJECT { get; internal set; }
        /// <summary>
        /// Message for email
        /// [Memo]
        /// </summary>
        public string EMAIL_MESSAGE { get; internal set; }
        /// <summary>
        /// Location of an HTML file that that contains the message
        /// [Alphanumeric (128)]
        /// </summary>
        public string EMAIL_HTML { get; internal set; }
        /// <summary>
        /// The message text is full HTML
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string HTML_MESSAGE { get; internal set; }
        /// <summary>
        /// The from address to use when email is sent
        /// 
        /// [Alphanumeric (128)]
        /// </summary>
        public string FROM_ADDRESS { get; internal set; }
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
        /// Navigation property for [REPORT] => [KREPORT].[KREPORTKEY]
        /// Report file name (without  extension)
        /// 
        /// </summary>
        public KREPORT REPORT_KREPORT {
            get
            {
                if (REPORT != null)
                {
                    if (_REPORT_KREPORT == null)
                    {
                        _REPORT_KREPORT = Context.KREPORT.FindByKREPORTKEY(REPORT);
                    }
                    return _REPORT_KREPORT;
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
