using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Reports for emailing
    /// </summary>
    public class KREPORT_Entity : EntityBase
    {
        /// <summary>
        /// Report name [Uppercase Alphanumeric: u10]
        /// </summary>
        public string KREPORTKEY { get; internal set; }
        /// <summary>
        /// Description [Alphanumeric: a50]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Role for the code [Uppercase Alphanumeric: u2]
        /// </summary>
        public string ROLE_CODE { get; internal set; }
        /// <summary>
        /// Navigation property for [ROLE_CODE] => [KROLE_Entity].[KROLEKEY]
        /// Role for the code
        /// </summary>
        public KROLE_Entity ROLE_CODE_KROLE { get { return ROLE_CODE == null ? null : Context.KROLE.FindByKROLEKEY(ROLE_CODE); } }
        /// <summary>
        ///  [Alphanumeric: a80]
        /// </summary>
        public string REPORT_NAME { get; internal set; }
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
