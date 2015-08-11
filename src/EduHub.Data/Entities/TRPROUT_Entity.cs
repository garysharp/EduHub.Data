using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Transport Routes
    /// </summary>
    public class TRPROUT_Entity : EntityBase
    {
        /// <summary>
        /// Route_ID - System Generated [Integer (32bit signed): l]
        /// </summary>
        public int ROUTE_ID { get; internal set; }
        /// <summary>
        /// Route Name [Alphanumeric: a40]
        /// </summary>
        public string ROUTE_NAME { get; internal set; }
        /// <summary>
        /// Transport Modes [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRANSPORT_MODE_ID { get; internal set; }
        /// <summary>
        /// Navigation property for [TRANSPORT_MODE_ID] => [TRPMODE_Entity].[TRANSPORT_MODE_ID]
        /// Transport Modes
        /// </summary>
        public TRPMODE_Entity TRANSPORT_MODE_ID_TRPMODE { get { return TRANSPORT_MODE_ID.HasValue ? Context.TRPMODE.FindByTRANSPORT_MODE_ID(TRANSPORT_MODE_ID.Value) : null; } }
        /// <summary>
        /// Company ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRANSPORT_COMPANY_ID { get; internal set; }
        /// <summary>
        /// Navigation property for [TRANSPORT_COMPANY_ID] => [KTRCMP_Entity].[COMPANY_ID]
        /// Company ID
        /// </summary>
        public KTRCMP_Entity TRANSPORT_COMPANY_ID_KTRCMP { get { return TRANSPORT_COMPANY_ID.HasValue ? Context.KTRCMP.FindByCOMPANY_ID(TRANSPORT_COMPANY_ID.Value) : null; } }
        /// <summary>
        /// Contract No [Alphanumeric: a20]
        /// </summary>
        public string ROUTE_CONTRACT_NO { get; internal set; }
        /// <summary>
        /// Contact 1 Given [Alphanumeric: a20]
        /// </summary>
        public string CONTACT1_FIRST_NAME { get; internal set; }
        /// <summary>
        /// Contact 1 Surname [Alphanumeric: a20]
        /// </summary>
        public string CONTACT1_LAST_NAME { get; internal set; }
        /// <summary>
        /// Contact 1 Phone [Alphanumeric: a20]
        /// </summary>
        public string CONTACT1_PHONE { get; internal set; }
        /// <summary>
        /// Contact 2 Given [Alphanumeric: a20]
        /// </summary>
        public string CONTACT2_FIRST_NAME { get; internal set; }
        /// <summary>
        /// Contact 2 Surname [Alphanumeric: a20]
        /// </summary>
        public string CONTACT2_LAST_NAME { get; internal set; }
        /// <summary>
        /// Contact 2 Phone [Alphanumeric: a20]
        /// </summary>
        public string CONTACT2_PHONE { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AM_SETDOWN_TIME { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PM_PICKUP_TIME { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
        
        
    }
}
