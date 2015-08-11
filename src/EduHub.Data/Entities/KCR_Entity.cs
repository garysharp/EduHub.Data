using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Transport Routes/Stops
    /// </summary>
    public class KCR_Entity : EntityBase
    {
        /// <summary>
        /// Route/Stop code [Uppercase Alphanumeric: u6]
        /// </summary>
        public string KCRKEY { get; internal set; }
        /// <summary>
        /// Type of transport: B=School Bus, P=Public Bus, T=Train, M=Tram [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TRANSPORT_TYPE { get; internal set; }
        /// <summary>
        /// Description of Transport [Alphanumeric: a40]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Transport route code << What exactly is this field for? [Uppercase Alphanumeric: u5]
        /// </summary>
        public string ROUTE_CODE { get; internal set; }
        /// <summary>
        /// Description of stop [Memo: m]
        /// </summary>
        public string STOP_DESCRIP { get; internal set; }
        /// <summary>
        /// Day(s) of week << What exactly are these fields for? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DAYOFWK01 { get; internal set; }
        /// <summary>
        /// Day(s) of week << What exactly are these fields for? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DAYOFWK02 { get; internal set; }
        /// <summary>
        /// Day(s) of week << What exactly are these fields for? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DAYOFWK03 { get; internal set; }
        /// <summary>
        /// Day(s) of week << What exactly are these fields for? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DAYOFWK04 { get; internal set; }
        /// <summary>
        /// Day(s) of week << What exactly are these fields for? [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DAYOFWK05 { get; internal set; }
        /// <summary>
        /// Departure time in the morning [Integer (16bit signed nullable): i]
        /// </summary>
        public short? DEPART_AM { get; internal set; }
        /// <summary>
        /// Departure time in the afternoon [Integer (16bit signed nullable): i]
        /// </summary>
        public short? DEPART_PM { get; internal set; }
        /// <summary>
        /// Arrival time in the morning [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ARRIVE_AM { get; internal set; }
        /// <summary>
        /// Arrival time in the afternoon [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ARRIVE_PM { get; internal set; }
        /// <summary>
        /// Melway, VicRoads, Country Fire Authority, etc [Uppercase Alphanumeric: u1]
        /// </summary>
        public string MAP_TYPE { get; internal set; }
        /// <summary>
        /// (Was MAP_NO) Map no [Uppercase Alphanumeric: u4]
        /// </summary>
        public string MAP_NUM { get; internal set; }
        /// <summary>
        /// Horizontal grid reference [Uppercase Alphanumeric: u2]
        /// </summary>
        public string X_AXIS { get; internal set; }
        /// <summary>
        /// Vertical grid reference [Uppercase Alphanumeric: u2]
        /// </summary>
        public string Y_AXIS { get; internal set; }
        /// <summary>
        /// Number of students [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NO_OF_STUD { get; internal set; }
        /// <summary>
        /// Progressive number of students [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PROG_NO { get; internal set; }
        /// <summary>
        /// Furthest distance PickUp/SetDown [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? DIST_LAST { get; internal set; }
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
