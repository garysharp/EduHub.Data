using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Australian Postcodes
    /// </summary>
    public class KAP_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Unique ID: NOTE there are two rows for each postcode/locality combination: in one, KAPKEY=POSTCODE|PLACE_NAME; in the other, KAPKEY=PLACE_NAME|POSTCODE [Alphanumeric: a34]
        /// </summary>
        public string KAPKEY { get; internal set; }
        /// <summary>
        /// Postcode [Alphanumeric: a4]
        /// </summary>
        public string POSTCODE { get; internal set; }
        /// <summary>
        /// Name of town, suburb or other locality [Alphanumeric: a30]
        /// </summary>
        public string PLACE_NAME { get; internal set; }
        /// <summary>
        /// State code [Uppercase Alphanumeric: u3]
        /// </summary>
        public string STATE { get; internal set; }
        /// <summary>
        /// Distinguishes similar records [Alphanumeric: a30]
        /// </summary>
        public string DISCRIMINATOR { get; internal set; }
        /// <summary>
        /// Indicates this postcode is for street addresses [Uppercase Alphanumeric: u1]
        /// </summary>
        public string STREET_ADD { get; internal set; }
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
#endregion
    }
}
