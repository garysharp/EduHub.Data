using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Transport Routes/Stops
    /// </summary>
    public class KCR : EntityBase
    {
#region Navigation Property Cache
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
        /// Transport route code << What exactly is this field for?
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string ROUTE_CODE { get; internal set; }
        /// <summary>
        /// Description of stop
        /// [Memo]
        /// </summary>
        public string STOP_DESCRIP { get; internal set; }
        /// <summary>
        /// Day(s) of week << What exactly are these fields for?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DAYOFWK01 { get; internal set; }
        /// <summary>
        /// Day(s) of week << What exactly are these fields for?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DAYOFWK02 { get; internal set; }
        /// <summary>
        /// Day(s) of week << What exactly are these fields for?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DAYOFWK03 { get; internal set; }
        /// <summary>
        /// Day(s) of week << What exactly are these fields for?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DAYOFWK04 { get; internal set; }
        /// <summary>
        /// Day(s) of week << What exactly are these fields for?
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
#endregion
    }
}
