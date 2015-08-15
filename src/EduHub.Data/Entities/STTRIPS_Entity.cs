using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Trips
    /// </summary>
    public class STTRIPS_Entity : EntityBase
    {
#region Navigation Property Cache
        private ST_Entity _STUDENT_ID_ST;
        private TRPROUT_Entity _AM_ROUTE_ID_TRPROUT;
        private TRPMODE_Entity _AM_TRANSPORT_MODE_TRPMODE;
        private UM_Entity _AM_PICKUP_ADDRESS_ID_UM;
        private SCI_Entity _AM_SETDOWN_CAMPUS_SCI;
        private TRPROUT_Entity _PM_ROUTE_ID_TRPROUT;
        private TRPMODE_Entity _PM_TRANSPORT_MODE_TRPMODE;
        private SCI_Entity _PM_PICKUP_CAMPUS_SCI;
        private UM_Entity _PM_SETDOWN_ADDRESS_ID_UM;
#endregion

#region Field Properties
        /// <summary>
        /// Sequence [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Student key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string STUDENT_ID { get; internal set; }
        /// <summary>
        /// Transport route valid from [Date Time nullable: d]
        /// </summary>
        public DateTime? TRANSPORT_START_DATE { get; internal set; }
        /// <summary>
        /// Transport route valid to [Date Time nullable: d]
        /// </summary>
        public DateTime? TRANSPORT_END_DATE { get; internal set; }
        /// <summary>
        /// Does the student travel in a wheelchair [Alphanumeric: a1]
        /// </summary>
        public string TRAVEL_IN_WHEELCHAIR { get; internal set; }
        /// <summary>
        /// Day of travel [Alphanumeric: a2]
        /// </summary>
        public string TRAVEL_DAY { get; internal set; }
        /// <summary>
        /// General notes regarding travel [Memo: m]
        /// </summary>
        public string TRAVEL_NOTES { get; internal set; }
        /// <summary>
        /// AM Route ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? AM_ROUTE_ID { get; internal set; }
        /// <summary>
        /// AM mode of transport [Integer (32bit signed nullable): l]
        /// </summary>
        public int? AM_TRANSPORT_MODE { get; internal set; }
        /// <summary>
        /// Does this student use this am route throught the week [Alphanumeric: a1]
        /// </summary>
        public string AM_ROUTE_EVERY_DAY { get; internal set; }
        /// <summary>
        /// AM pickup time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AM_PICKUP_TIME { get; internal set; }
        /// <summary>
        /// AM pickup address [Integer (32bit signed nullable): l]
        /// </summary>
        public int? AM_PICKUP_ADDRESS_ID { get; internal set; }
        /// <summary>
        /// Is the AM pickup address the home address [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AM_PICKUP_ADD_SAME_AS_HOME { get; internal set; }
        /// <summary>
        /// AM Direction of travel (N,NE,E,SE,S,SW,W,NW) [Alphanumeric: a2]
        /// </summary>
        public string AM_PICKUP_DIRECTIONS { get; internal set; }
        /// <summary>
        ///  [Alphanumeric: a1]
        /// </summary>
        public string AM_PICKUP_ADD_MAP_TYPE { get; internal set; }
        /// <summary>
        ///  [Alphanumeric: a4]
        /// </summary>
        public string AM_PICKUP_ADD_MAP_NO { get; internal set; }
        /// <summary>
        ///  [Alphanumeric: a4]
        /// </summary>
        public string AM_PICKUP_ADD_MAP_X_REF { get; internal set; }
        /// <summary>
        ///  [Memo: m]
        /// </summary>
        public string AM_PICKUP_ADD_DESCP { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AM_SETDOWN_TIME { get; internal set; }
        /// <summary>
        ///  [Integer (32bit signed nullable): l]
        /// </summary>
        public int? AM_SETDOWN_CAMPUS { get; internal set; }
        /// <summary>
        ///  [Integer (32bit signed nullable): l]
        /// </summary>
        public int? PM_ROUTE_ID { get; internal set; }
        /// <summary>
        ///  [Integer (32bit signed nullable): l]
        /// </summary>
        public int? PM_TRANSPORT_MODE { get; internal set; }
        /// <summary>
        ///  [Alphanumeric: a1]
        /// </summary>
        public string PM_ROUTE_EVERY_DAY { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PM_PICKUP_TIME { get; internal set; }
        /// <summary>
        ///  [Integer (32bit signed nullable): l]
        /// </summary>
        public int? PM_PICKUP_CAMPUS { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PM_SETDOWN_TIME { get; internal set; }
        /// <summary>
        ///  [Integer (32bit signed nullable): l]
        /// </summary>
        public int? PM_SETDOWN_ADDRESS_ID { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PM_STDWN_AM_PKUP_ADD_SAME { get; internal set; }
        /// <summary>
        ///  [Alphanumeric: a2]
        /// </summary>
        public string PM_SETDOWN_DIRECTIONS { get; internal set; }
        /// <summary>
        ///  [Alphanumeric: a1]
        /// </summary>
        public string PM_SETDOWN_ADD_MAP_TYPE { get; internal set; }
        /// <summary>
        ///  [Alphanumeric: a4]
        /// </summary>
        public string PM_SETDOWN_ADD_MAP_NO { get; internal set; }
        /// <summary>
        ///  [Alphanumeric: a4]
        /// </summary>
        public string PM_SETDOWN_ADD_MAP_X_REF { get; internal set; }
        /// <summary>
        ///  [Memo: m]
        /// </summary>
        public string PM_SETDOWN_ADD_DESCP { get; internal set; }
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
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [STUDENT_ID] => [ST_Entity].[STKEY]
        /// Student key
        /// </summary>
        public ST_Entity STUDENT_ID_ST {
            get
            {
                if (STUDENT_ID != null)
                {
                    if (_STUDENT_ID_ST == null)
                    {
                        _STUDENT_ID_ST = Context.ST.FindBySTKEY(STUDENT_ID);
                    }
                    return _STUDENT_ID_ST;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [AM_ROUTE_ID] => [TRPROUT_Entity].[ROUTE_ID]
        /// AM Route ID
        /// </summary>
        public TRPROUT_Entity AM_ROUTE_ID_TRPROUT {
            get
            {
                if (AM_ROUTE_ID.HasValue)
                {
                    if (_AM_ROUTE_ID_TRPROUT == null)
                    {
                        _AM_ROUTE_ID_TRPROUT = Context.TRPROUT.FindByROUTE_ID(AM_ROUTE_ID.Value);
                    }
                    return _AM_ROUTE_ID_TRPROUT;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [AM_TRANSPORT_MODE] => [TRPMODE_Entity].[TRANSPORT_MODE_ID]
        /// AM mode of transport
        /// </summary>
        public TRPMODE_Entity AM_TRANSPORT_MODE_TRPMODE {
            get
            {
                if (AM_TRANSPORT_MODE.HasValue)
                {
                    if (_AM_TRANSPORT_MODE_TRPMODE == null)
                    {
                        _AM_TRANSPORT_MODE_TRPMODE = Context.TRPMODE.FindByTRANSPORT_MODE_ID(AM_TRANSPORT_MODE.Value);
                    }
                    return _AM_TRANSPORT_MODE_TRPMODE;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [AM_PICKUP_ADDRESS_ID] => [UM_Entity].[UMKEY]
        /// AM pickup address
        /// </summary>
        public UM_Entity AM_PICKUP_ADDRESS_ID_UM {
            get
            {
                if (AM_PICKUP_ADDRESS_ID.HasValue)
                {
                    if (_AM_PICKUP_ADDRESS_ID_UM == null)
                    {
                        _AM_PICKUP_ADDRESS_ID_UM = Context.UM.FindByUMKEY(AM_PICKUP_ADDRESS_ID.Value);
                    }
                    return _AM_PICKUP_ADDRESS_ID_UM;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [AM_SETDOWN_CAMPUS] => [SCI_Entity].[SCIKEY]
        /// 
        /// </summary>
        public SCI_Entity AM_SETDOWN_CAMPUS_SCI {
            get
            {
                if (AM_SETDOWN_CAMPUS.HasValue)
                {
                    if (_AM_SETDOWN_CAMPUS_SCI == null)
                    {
                        _AM_SETDOWN_CAMPUS_SCI = Context.SCI.FindBySCIKEY(AM_SETDOWN_CAMPUS.Value);
                    }
                    return _AM_SETDOWN_CAMPUS_SCI;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PM_ROUTE_ID] => [TRPROUT_Entity].[ROUTE_ID]
        /// 
        /// </summary>
        public TRPROUT_Entity PM_ROUTE_ID_TRPROUT {
            get
            {
                if (PM_ROUTE_ID.HasValue)
                {
                    if (_PM_ROUTE_ID_TRPROUT == null)
                    {
                        _PM_ROUTE_ID_TRPROUT = Context.TRPROUT.FindByROUTE_ID(PM_ROUTE_ID.Value);
                    }
                    return _PM_ROUTE_ID_TRPROUT;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PM_TRANSPORT_MODE] => [TRPMODE_Entity].[TRANSPORT_MODE_ID]
        /// 
        /// </summary>
        public TRPMODE_Entity PM_TRANSPORT_MODE_TRPMODE {
            get
            {
                if (PM_TRANSPORT_MODE.HasValue)
                {
                    if (_PM_TRANSPORT_MODE_TRPMODE == null)
                    {
                        _PM_TRANSPORT_MODE_TRPMODE = Context.TRPMODE.FindByTRANSPORT_MODE_ID(PM_TRANSPORT_MODE.Value);
                    }
                    return _PM_TRANSPORT_MODE_TRPMODE;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PM_PICKUP_CAMPUS] => [SCI_Entity].[SCIKEY]
        /// 
        /// </summary>
        public SCI_Entity PM_PICKUP_CAMPUS_SCI {
            get
            {
                if (PM_PICKUP_CAMPUS.HasValue)
                {
                    if (_PM_PICKUP_CAMPUS_SCI == null)
                    {
                        _PM_PICKUP_CAMPUS_SCI = Context.SCI.FindBySCIKEY(PM_PICKUP_CAMPUS.Value);
                    }
                    return _PM_PICKUP_CAMPUS_SCI;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PM_SETDOWN_ADDRESS_ID] => [UM_Entity].[UMKEY]
        /// 
        /// </summary>
        public UM_Entity PM_SETDOWN_ADDRESS_ID_UM {
            get
            {
                if (PM_SETDOWN_ADDRESS_ID.HasValue)
                {
                    if (_PM_SETDOWN_ADDRESS_ID_UM == null)
                    {
                        _PM_SETDOWN_ADDRESS_ID_UM = Context.UM.FindByUMKEY(PM_SETDOWN_ADDRESS_ID.Value);
                    }
                    return _PM_SETDOWN_ADDRESS_ID_UM;
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
