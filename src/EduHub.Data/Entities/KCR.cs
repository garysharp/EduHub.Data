using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Transport Routes/Stops
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCR : EntityBase
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<STBT> Cache_KCRKEY_STBT_ROUTE;
        private IReadOnlyList<STBT> Cache_KCRKEY_STBT_AM1_ROUTE;
        private IReadOnlyList<STBT> Cache_KCRKEY_STBT_PM1_ROUTE;
        private IReadOnlyList<STBT> Cache_KCRKEY_STBT_AM2_ROUTE;
        private IReadOnlyList<STBT> Cache_KCRKEY_STBT_PM2_ROUTE;
        private IReadOnlyList<STBT> Cache_KCRKEY_STBT_AM3_ROUTE;
        private IReadOnlyList<STBT> Cache_KCRKEY_STBT_PM3_ROUTE;
        private IReadOnlyList<STBT> Cache_KCRKEY_STBT_AM4_ROUTE;
        private IReadOnlyList<STBT> Cache_KCRKEY_STBT_PM4_ROUTE;
        private IReadOnlyList<STBT> Cache_KCRKEY_STBT_AM5_ROUTE;
        private IReadOnlyList<STBT> Cache_KCRKEY_STBT_PM5_ROUTE;

        #endregion

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

        #region Foreign Navigation Properties

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [KCR.KCRKEY]-&gt;[STBT.ROUTE]
        /// Route/Stop code
        /// </summary>
        public IReadOnlyList<STBT> KCRKEY_STBT_ROUTE
        {
            get
            {
                if (Cache_KCRKEY_STBT_ROUTE == null &&
                    !Context.STBT.TryFindByROUTE(KCRKEY, out Cache_KCRKEY_STBT_ROUTE))
                {
                    Cache_KCRKEY_STBT_ROUTE = new List<STBT>().AsReadOnly();
                }

                return Cache_KCRKEY_STBT_ROUTE;
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [KCR.KCRKEY]-&gt;[STBT.AM1_ROUTE]
        /// Route/Stop code
        /// </summary>
        public IReadOnlyList<STBT> KCRKEY_STBT_AM1_ROUTE
        {
            get
            {
                if (Cache_KCRKEY_STBT_AM1_ROUTE == null &&
                    !Context.STBT.TryFindByAM1_ROUTE(KCRKEY, out Cache_KCRKEY_STBT_AM1_ROUTE))
                {
                    Cache_KCRKEY_STBT_AM1_ROUTE = new List<STBT>().AsReadOnly();
                }

                return Cache_KCRKEY_STBT_AM1_ROUTE;
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [KCR.KCRKEY]-&gt;[STBT.PM1_ROUTE]
        /// Route/Stop code
        /// </summary>
        public IReadOnlyList<STBT> KCRKEY_STBT_PM1_ROUTE
        {
            get
            {
                if (Cache_KCRKEY_STBT_PM1_ROUTE == null &&
                    !Context.STBT.TryFindByPM1_ROUTE(KCRKEY, out Cache_KCRKEY_STBT_PM1_ROUTE))
                {
                    Cache_KCRKEY_STBT_PM1_ROUTE = new List<STBT>().AsReadOnly();
                }

                return Cache_KCRKEY_STBT_PM1_ROUTE;
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [KCR.KCRKEY]-&gt;[STBT.AM2_ROUTE]
        /// Route/Stop code
        /// </summary>
        public IReadOnlyList<STBT> KCRKEY_STBT_AM2_ROUTE
        {
            get
            {
                if (Cache_KCRKEY_STBT_AM2_ROUTE == null &&
                    !Context.STBT.TryFindByAM2_ROUTE(KCRKEY, out Cache_KCRKEY_STBT_AM2_ROUTE))
                {
                    Cache_KCRKEY_STBT_AM2_ROUTE = new List<STBT>().AsReadOnly();
                }

                return Cache_KCRKEY_STBT_AM2_ROUTE;
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [KCR.KCRKEY]-&gt;[STBT.PM2_ROUTE]
        /// Route/Stop code
        /// </summary>
        public IReadOnlyList<STBT> KCRKEY_STBT_PM2_ROUTE
        {
            get
            {
                if (Cache_KCRKEY_STBT_PM2_ROUTE == null &&
                    !Context.STBT.TryFindByPM2_ROUTE(KCRKEY, out Cache_KCRKEY_STBT_PM2_ROUTE))
                {
                    Cache_KCRKEY_STBT_PM2_ROUTE = new List<STBT>().AsReadOnly();
                }

                return Cache_KCRKEY_STBT_PM2_ROUTE;
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [KCR.KCRKEY]-&gt;[STBT.AM3_ROUTE]
        /// Route/Stop code
        /// </summary>
        public IReadOnlyList<STBT> KCRKEY_STBT_AM3_ROUTE
        {
            get
            {
                if (Cache_KCRKEY_STBT_AM3_ROUTE == null &&
                    !Context.STBT.TryFindByAM3_ROUTE(KCRKEY, out Cache_KCRKEY_STBT_AM3_ROUTE))
                {
                    Cache_KCRKEY_STBT_AM3_ROUTE = new List<STBT>().AsReadOnly();
                }

                return Cache_KCRKEY_STBT_AM3_ROUTE;
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [KCR.KCRKEY]-&gt;[STBT.PM3_ROUTE]
        /// Route/Stop code
        /// </summary>
        public IReadOnlyList<STBT> KCRKEY_STBT_PM3_ROUTE
        {
            get
            {
                if (Cache_KCRKEY_STBT_PM3_ROUTE == null &&
                    !Context.STBT.TryFindByPM3_ROUTE(KCRKEY, out Cache_KCRKEY_STBT_PM3_ROUTE))
                {
                    Cache_KCRKEY_STBT_PM3_ROUTE = new List<STBT>().AsReadOnly();
                }

                return Cache_KCRKEY_STBT_PM3_ROUTE;
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [KCR.KCRKEY]-&gt;[STBT.AM4_ROUTE]
        /// Route/Stop code
        /// </summary>
        public IReadOnlyList<STBT> KCRKEY_STBT_AM4_ROUTE
        {
            get
            {
                if (Cache_KCRKEY_STBT_AM4_ROUTE == null &&
                    !Context.STBT.TryFindByAM4_ROUTE(KCRKEY, out Cache_KCRKEY_STBT_AM4_ROUTE))
                {
                    Cache_KCRKEY_STBT_AM4_ROUTE = new List<STBT>().AsReadOnly();
                }

                return Cache_KCRKEY_STBT_AM4_ROUTE;
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [KCR.KCRKEY]-&gt;[STBT.PM4_ROUTE]
        /// Route/Stop code
        /// </summary>
        public IReadOnlyList<STBT> KCRKEY_STBT_PM4_ROUTE
        {
            get
            {
                if (Cache_KCRKEY_STBT_PM4_ROUTE == null &&
                    !Context.STBT.TryFindByPM4_ROUTE(KCRKEY, out Cache_KCRKEY_STBT_PM4_ROUTE))
                {
                    Cache_KCRKEY_STBT_PM4_ROUTE = new List<STBT>().AsReadOnly();
                }

                return Cache_KCRKEY_STBT_PM4_ROUTE;
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [KCR.KCRKEY]-&gt;[STBT.AM5_ROUTE]
        /// Route/Stop code
        /// </summary>
        public IReadOnlyList<STBT> KCRKEY_STBT_AM5_ROUTE
        {
            get
            {
                if (Cache_KCRKEY_STBT_AM5_ROUTE == null &&
                    !Context.STBT.TryFindByAM5_ROUTE(KCRKEY, out Cache_KCRKEY_STBT_AM5_ROUTE))
                {
                    Cache_KCRKEY_STBT_AM5_ROUTE = new List<STBT>().AsReadOnly();
                }

                return Cache_KCRKEY_STBT_AM5_ROUTE;
            }
        }

        /// <summary>
        /// STBT (Student Transport Usage) related entities by [KCR.KCRKEY]-&gt;[STBT.PM5_ROUTE]
        /// Route/Stop code
        /// </summary>
        public IReadOnlyList<STBT> KCRKEY_STBT_PM5_ROUTE
        {
            get
            {
                if (Cache_KCRKEY_STBT_PM5_ROUTE == null &&
                    !Context.STBT.TryFindByPM5_ROUTE(KCRKEY, out Cache_KCRKEY_STBT_PM5_ROUTE))
                {
                    Cache_KCRKEY_STBT_PM5_ROUTE = new List<STBT>().AsReadOnly();
                }

                return Cache_KCRKEY_STBT_PM5_ROUTE;
            }
        }

        #endregion

    }
}
