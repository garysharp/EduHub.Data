using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Trips
    /// </summary>
    public partial class STTRIPS : EntityBase
    {
#region Navigation Property Cache
        private ST _STUDENT_ID_ST;
        private TRPROUT _AM_ROUTE_ID_TRPROUT;
        private TRPMODE _AM_TRANSPORT_MODE_TRPMODE;
        private UM _AM_PICKUP_ADDRESS_ID_UM;
        private SCI _AM_SETDOWN_CAMPUS_SCI;
        private TRPROUT _PM_ROUTE_ID_TRPROUT;
        private TRPMODE _PM_TRANSPORT_MODE_TRPMODE;
        private SCI _PM_PICKUP_CAMPUS_SCI;
        private UM _PM_SETDOWN_ADDRESS_ID_UM;
#endregion

#region Field Properties
        /// <summary>
        /// Sequence
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Student key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string STUDENT_ID { get; internal set; }
        /// <summary>
        /// Transport route valid from
        /// </summary>
        public DateTime? TRANSPORT_START_DATE { get; internal set; }
        /// <summary>
        /// Transport route valid to
        /// </summary>
        public DateTime? TRANSPORT_END_DATE { get; internal set; }
        /// <summary>
        /// Does the student travel in a wheelchair
        /// [Alphanumeric (1)]
        /// </summary>
        public string TRAVEL_IN_WHEELCHAIR { get; internal set; }
        /// <summary>
        /// Day of travel
        /// [Alphanumeric (2)]
        /// </summary>
        public string TRAVEL_DAY { get; internal set; }
        /// <summary>
        /// General notes regarding travel
        /// [Memo]
        /// </summary>
        public string TRAVEL_NOTES { get; internal set; }
        /// <summary>
        /// AM Route ID
        /// </summary>
        public int? AM_ROUTE_ID { get; internal set; }
        /// <summary>
        /// AM mode of transport
        /// </summary>
        public int? AM_TRANSPORT_MODE { get; internal set; }
        /// <summary>
        /// Does this student use this am route throught the week
        /// [Alphanumeric (1)]
        /// </summary>
        public string AM_ROUTE_EVERY_DAY { get; internal set; }
        /// <summary>
        /// AM pickup time
        /// </summary>
        public short? AM_PICKUP_TIME { get; internal set; }
        /// <summary>
        /// AM pickup address
        /// </summary>
        public int? AM_PICKUP_ADDRESS_ID { get; internal set; }
        /// <summary>
        /// Is the AM pickup address the home address
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AM_PICKUP_ADD_SAME_AS_HOME { get; internal set; }
        /// <summary>
        /// AM Direction of travel (N,NE,E,SE,S,SW,W,NW)
        /// [Alphanumeric (2)]
        /// </summary>
        public string AM_PICKUP_DIRECTIONS { get; internal set; }
        /// <summary>
        /// 
        /// [Alphanumeric (1)]
        /// </summary>
        public string AM_PICKUP_ADD_MAP_TYPE { get; internal set; }
        /// <summary>
        /// 
        /// [Alphanumeric (4)]
        /// </summary>
        public string AM_PICKUP_ADD_MAP_NO { get; internal set; }
        /// <summary>
        /// 
        /// [Alphanumeric (4)]
        /// </summary>
        public string AM_PICKUP_ADD_MAP_X_REF { get; internal set; }
        /// <summary>
        /// 
        /// [Memo]
        /// </summary>
        public string AM_PICKUP_ADD_DESCP { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? AM_SETDOWN_TIME { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public int? AM_SETDOWN_CAMPUS { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public int? PM_ROUTE_ID { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public int? PM_TRANSPORT_MODE { get; internal set; }
        /// <summary>
        /// 
        /// [Alphanumeric (1)]
        /// </summary>
        public string PM_ROUTE_EVERY_DAY { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? PM_PICKUP_TIME { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public int? PM_PICKUP_CAMPUS { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? PM_SETDOWN_TIME { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public int? PM_SETDOWN_ADDRESS_ID { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PM_STDWN_AM_PKUP_ADD_SAME { get; internal set; }
        /// <summary>
        /// 
        /// [Alphanumeric (2)]
        /// </summary>
        public string PM_SETDOWN_DIRECTIONS { get; internal set; }
        /// <summary>
        /// 
        /// [Alphanumeric (1)]
        /// </summary>
        public string PM_SETDOWN_ADD_MAP_TYPE { get; internal set; }
        /// <summary>
        /// 
        /// [Alphanumeric (4)]
        /// </summary>
        public string PM_SETDOWN_ADD_MAP_NO { get; internal set; }
        /// <summary>
        /// 
        /// [Alphanumeric (4)]
        /// </summary>
        public string PM_SETDOWN_ADD_MAP_X_REF { get; internal set; }
        /// <summary>
        /// 
        /// [Memo]
        /// </summary>
        public string PM_SETDOWN_ADD_DESCP { get; internal set; }
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
        /// ST (Students) related entity by [STTRIPS.STUDENT_ID]-&gt;[ST.STKEY]
        /// Student key
        /// </summary>
        public ST STUDENT_ID_ST
        {
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
        /// TRPROUT (Student Transport Routes) related entity by [STTRIPS.AM_ROUTE_ID]-&gt;[TRPROUT.ROUTE_ID]
        /// AM Route ID
        /// </summary>
        public TRPROUT AM_ROUTE_ID_TRPROUT
        {
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
        /// TRPMODE (Transport Modes) related entity by [STTRIPS.AM_TRANSPORT_MODE]-&gt;[TRPMODE.TRANSPORT_MODE_ID]
        /// AM mode of transport
        /// </summary>
        public TRPMODE AM_TRANSPORT_MODE_TRPMODE
        {
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
        /// UM (Addresses) related entity by [STTRIPS.AM_PICKUP_ADDRESS_ID]-&gt;[UM.UMKEY]
        /// AM pickup address
        /// </summary>
        public UM AM_PICKUP_ADDRESS_ID_UM
        {
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
        /// SCI (School Information) related entity by [STTRIPS.AM_SETDOWN_CAMPUS]-&gt;[SCI.SCIKEY]
        /// 
        /// </summary>
        public SCI AM_SETDOWN_CAMPUS_SCI
        {
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
        /// TRPROUT (Student Transport Routes) related entity by [STTRIPS.PM_ROUTE_ID]-&gt;[TRPROUT.ROUTE_ID]
        /// 
        /// </summary>
        public TRPROUT PM_ROUTE_ID_TRPROUT
        {
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
        /// TRPMODE (Transport Modes) related entity by [STTRIPS.PM_TRANSPORT_MODE]-&gt;[TRPMODE.TRANSPORT_MODE_ID]
        /// 
        /// </summary>
        public TRPMODE PM_TRANSPORT_MODE_TRPMODE
        {
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
        /// SCI (School Information) related entity by [STTRIPS.PM_PICKUP_CAMPUS]-&gt;[SCI.SCIKEY]
        /// 
        /// </summary>
        public SCI PM_PICKUP_CAMPUS_SCI
        {
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
        /// UM (Addresses) related entity by [STTRIPS.PM_SETDOWN_ADDRESS_ID]-&gt;[UM.UMKEY]
        /// 
        /// </summary>
        public UM PM_SETDOWN_ADDRESS_ID_UM
        {
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
