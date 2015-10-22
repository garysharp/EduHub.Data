using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Reports for emailing
    /// </summary>
    public partial class KREPORT : EntityBase
    {
#region Navigation Property Cache
        private KROLE _ROLE_CODE_KROLE;
#endregion

#region Field Properties
        /// <summary>
        /// Report name
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KREPORTKEY { get; internal set; }
        /// <summary>
        /// Description
        /// [Alphanumeric (50)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Role for the code
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string ROLE_CODE { get; internal set; }
        /// <summary>
        /// 
        /// [Alphanumeric (80)]
        /// </summary>
        public string REPORT_NAME { get; internal set; }
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
        /// KROLE (Role Codes) related entity by [KREPORT.ROLE_CODE]-&gt;[KROLE.KROLEKEY]
        /// Role for the code
        /// </summary>
        public KROLE ROLE_CODE_KROLE
        {
            get
            {
                if (ROLE_CODE != null)
                {
                    if (_ROLE_CODE_KROLE == null)
                    {
                        _ROLE_CODE_KROLE = Context.KROLE.FindByKROLEKEY(ROLE_CODE);
                    }
                    return _ROLE_CODE_KROLE;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// SPEMAIL (Report email templates) related entities by [SPEMAIL.REPORT]-&gt;[KREPORT.KREPORTKEY]
        /// </summary>
        public IReadOnlyList<SPEMAIL> SPEMAIL_REPORT
        {
            get
            {
                return Context.KREPORT.FindSPEMAILByREPORT(KREPORTKEY);
            }
        }
#endregion
    }
}
