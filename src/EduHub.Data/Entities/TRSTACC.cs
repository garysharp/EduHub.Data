using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// STACC Holding Table
    /// </summary>
    public class TRSTACC : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Sequence no
        /// </summary>
        public int STACCKEY { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD01 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD02 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD03 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD04 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD05 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD06 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD07 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD08 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD09 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD10 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD11 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD12 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD13 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD14 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD15 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD16 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD17 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD18 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD19 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD20 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD21 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD22 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD23 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD24 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD25 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD26 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD27 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD28 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD29 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD30 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD31 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD32 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD33 { get; internal set; }
        /// <summary>
        /// Error with data row
        /// </summary>
        public short? ERR_FIELD { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public int? AM_UMKEY { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public int? PM_UMKEY { get; internal set; }
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
