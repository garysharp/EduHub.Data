using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Transport Routes
    /// </summary>
    public class TRPROUT : EntityBase
    {
#region Navigation Property Cache
        private TRPMODE _TRANSPORT_MODE_ID_TRPMODE;
        private KTRCMP _TRANSPORT_COMPANY_ID_KTRCMP;
#endregion

#region Field Properties
        /// <summary>
        /// Route_ID - System Generated
        /// </summary>
        public int ROUTE_ID { get; internal set; }
        /// <summary>
        /// Route Name
        /// [Alphanumeric (40)]
        /// </summary>
        public string ROUTE_NAME { get; internal set; }
        /// <summary>
        /// Transport Modes
        /// </summary>
        public int? TRANSPORT_MODE_ID { get; internal set; }
        /// <summary>
        /// Company ID
        /// </summary>
        public int? TRANSPORT_COMPANY_ID { get; internal set; }
        /// <summary>
        /// Contract No
        /// [Alphanumeric (20)]
        /// </summary>
        public string ROUTE_CONTRACT_NO { get; internal set; }
        /// <summary>
        /// Contact 1 Given
        /// [Alphanumeric (20)]
        /// </summary>
        public string CONTACT1_FIRST_NAME { get; internal set; }
        /// <summary>
        /// Contact 1 Surname
        /// [Alphanumeric (20)]
        /// </summary>
        public string CONTACT1_LAST_NAME { get; internal set; }
        /// <summary>
        /// Contact 1 Phone
        /// [Alphanumeric (20)]
        /// </summary>
        public string CONTACT1_PHONE { get; internal set; }
        /// <summary>
        /// Contact 2 Given
        /// [Alphanumeric (20)]
        /// </summary>
        public string CONTACT2_FIRST_NAME { get; internal set; }
        /// <summary>
        /// Contact 2 Surname
        /// [Alphanumeric (20)]
        /// </summary>
        public string CONTACT2_LAST_NAME { get; internal set; }
        /// <summary>
        /// Contact 2 Phone
        /// [Alphanumeric (20)]
        /// </summary>
        public string CONTACT2_PHONE { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? AM_SETDOWN_TIME { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? PM_PICKUP_TIME { get; internal set; }
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
        /// Navigation property for [TRANSPORT_MODE_ID] => [TRPMODE].[TRANSPORT_MODE_ID]
        /// Transport Modes
        /// </summary>
        public TRPMODE TRANSPORT_MODE_ID_TRPMODE {
            get
            {
                if (TRANSPORT_MODE_ID.HasValue)
                {
                    if (_TRANSPORT_MODE_ID_TRPMODE == null)
                    {
                        _TRANSPORT_MODE_ID_TRPMODE = Context.TRPMODE.FindByTRANSPORT_MODE_ID(TRANSPORT_MODE_ID.Value);
                    }
                    return _TRANSPORT_MODE_ID_TRPMODE;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [TRANSPORT_COMPANY_ID] => [KTRCMP].[COMPANY_ID]
        /// Company ID
        /// </summary>
        public KTRCMP TRANSPORT_COMPANY_ID_KTRCMP {
            get
            {
                if (TRANSPORT_COMPANY_ID.HasValue)
                {
                    if (_TRANSPORT_COMPANY_ID_KTRCMP == null)
                    {
                        _TRANSPORT_COMPANY_ID_KTRCMP = Context.KTRCMP.FindByCOMPANY_ID(TRANSPORT_COMPANY_ID.Value);
                    }
                    return _TRANSPORT_COMPANY_ID_KTRCMP;
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
