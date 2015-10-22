using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Report file audit
    /// </summary>
    public partial class SPEPRINT : EntityBase
    {
#region Navigation Property Cache
        private SPEMAIL _CODE_SPEMAIL;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }
        /// <summary>
        /// Email Key
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// printed Date
        /// </summary>
        public DateTime? PRINT_DATE { get; internal set; }
        /// <summary>
        /// Who printed the report.
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string PRINT_BY { get; internal set; }
        /// <summary>
        /// Send Date
        /// </summary>
        public DateTime? SEND_DATE { get; internal set; }
        /// <summary>
        /// Who printed the report.
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string SEND_BY { get; internal set; }
        /// <summary>
        /// Database table key comes from
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string ENTITY_TABLE { get; internal set; }
        /// <summary>
        /// Sendee Key
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string ENTITY_KEY { get; internal set; }
        /// <summary>
        /// Sendee Email Address
        /// [Alphanumeric (60)]
        /// </summary>
        public string EMAIL_ADDRESS { get; internal set; }
        /// <summary>
        /// Sendee Email Address
        /// [Alphanumeric (60)]
        /// </summary>
        public string COPY_ADDRESS { get; internal set; }
        /// <summary>
        /// Email Subject
        /// [Alphanumeric (100)]
        /// </summary>
        public string EMAIL_SUBJECT { get; internal set; }
        /// <summary>
        /// Email Body
        /// [Memo]
        /// </summary>
        public string EMAIL_MESSAGE { get; internal set; }
        /// <summary>
        /// Path of attachment, includes file name
        /// [Alphanumeric (255)]
        /// </summary>
        public string ATTACHMENT_PATH { get; internal set; }
        /// <summary>
        /// Send Status
        /// [Alphanumeric (30)]
        /// </summary>
        public string STATUS { get; internal set; }
        /// <summary>
        /// Trigger field for displaying report
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DISPLAY { get; internal set; }
        /// <summary>
        /// operator comments
        /// 
        /// [Memo]
        /// </summary>
        public string COMMENTS { get; internal set; }
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
        /// SPEMAIL (Report email templates) related entity by [SPEPRINT.CODE]-&gt;[SPEMAIL.SPEMAILKEY]
        /// Email Key
        /// </summary>
        public SPEMAIL CODE_SPEMAIL
        {
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
