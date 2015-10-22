using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Transport Routes/Stops
    /// </summary>
    public partial class KCR : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Route/Stop code
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string KCRKEY { get; internal set; }
        /// <summary>
        /// Type of transport: B=School Bus, P=Public Bus, T=Train, M=Tram
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TRANSPORT_TYPE { get; internal set; }
        /// <summary>
        /// Description of Transport
        /// [Alphanumeric (40)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Transport route code &lt;&lt; What exactly is this field for?
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string ROUTE_CODE { get; internal set; }
        /// <summary>
        /// Description of stop
        /// [Memo]
        /// </summary>
        public string STOP_DESCRIP { get; internal set; }
        /// <summary>
        /// Day(s) of week &lt;&lt; What exactly are these fields for?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DAYOFWK01 { get; internal set; }
        /// <summary>
        /// Day(s) of week &lt;&lt; What exactly are these fields for?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DAYOFWK02 { get; internal set; }
        /// <summary>
        /// Day(s) of week &lt;&lt; What exactly are these fields for?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DAYOFWK03 { get; internal set; }
        /// <summary>
        /// Day(s) of week &lt;&lt; What exactly are these fields for?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DAYOFWK04 { get; internal set; }
        /// <summary>
        /// Day(s) of week &lt;&lt; What exactly are these fields for?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DAYOFWK05 { get; internal set; }
        /// <summary>
        /// Departure time in the morning
        /// </summary>
        public short? DEPART_AM { get; internal set; }
        /// <summary>
        /// Departure time in the afternoon
        /// </summary>
        public short? DEPART_PM { get; internal set; }
        /// <summary>
        /// Arrival time in the morning
        /// </summary>
        public short? ARRIVE_AM { get; internal set; }
        /// <summary>
        /// Arrival time in the afternoon
        /// </summary>
        public short? ARRIVE_PM { get; internal set; }
        /// <summary>
        /// Melway, VicRoads, Country Fire Authority, etc
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string MAP_TYPE { get; internal set; }
        /// <summary>
        /// (Was MAP_NO) Map no
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string MAP_NUM { get; internal set; }
        /// <summary>
        /// Horizontal grid reference
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string X_AXIS { get; internal set; }
        /// <summary>
        /// Vertical grid reference
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string Y_AXIS { get; internal set; }
        /// <summary>
        /// Number of students
        /// </summary>
        public short? NO_OF_STUD { get; internal set; }
        /// <summary>
        /// Progressive number of students
        /// </summary>
        public short? PROG_NO { get; internal set; }
        /// <summary>
        /// Furthest distance PickUp/SetDown
        /// </summary>
        public double? DIST_LAST { get; internal set; }
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
        /// STBT (Student Transport Usage) related entities by [STBT.ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        public IReadOnlyList<STBT> STBT_ROUTE
        {
            get
            {
                return Context.KCR.FindSTBTByROUTE(KCRKEY);
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [STBT.AM1_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        public IReadOnlyList<STBT> STBT_AM1_ROUTE
        {
            get
            {
                return Context.KCR.FindSTBTByAM1_ROUTE(KCRKEY);
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [STBT.PM1_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        public IReadOnlyList<STBT> STBT_PM1_ROUTE
        {
            get
            {
                return Context.KCR.FindSTBTByPM1_ROUTE(KCRKEY);
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [STBT.AM2_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        public IReadOnlyList<STBT> STBT_AM2_ROUTE
        {
            get
            {
                return Context.KCR.FindSTBTByAM2_ROUTE(KCRKEY);
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [STBT.PM2_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        public IReadOnlyList<STBT> STBT_PM2_ROUTE
        {
            get
            {
                return Context.KCR.FindSTBTByPM2_ROUTE(KCRKEY);
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [STBT.AM3_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        public IReadOnlyList<STBT> STBT_AM3_ROUTE
        {
            get
            {
                return Context.KCR.FindSTBTByAM3_ROUTE(KCRKEY);
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [STBT.PM3_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        public IReadOnlyList<STBT> STBT_PM3_ROUTE
        {
            get
            {
                return Context.KCR.FindSTBTByPM3_ROUTE(KCRKEY);
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [STBT.AM4_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        public IReadOnlyList<STBT> STBT_AM4_ROUTE
        {
            get
            {
                return Context.KCR.FindSTBTByAM4_ROUTE(KCRKEY);
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [STBT.PM4_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        public IReadOnlyList<STBT> STBT_PM4_ROUTE
        {
            get
            {
                return Context.KCR.FindSTBTByPM4_ROUTE(KCRKEY);
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [STBT.AM5_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        public IReadOnlyList<STBT> STBT_AM5_ROUTE
        {
            get
            {
                return Context.KCR.FindSTBTByAM5_ROUTE(KCRKEY);
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [STBT.PM5_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        public IReadOnlyList<STBT> STBT_PM5_ROUTE
        {
            get
            {
                return Context.KCR.FindSTBTByPM5_ROUTE(KCRKEY);
            }
        }
#endregion
    }
}
