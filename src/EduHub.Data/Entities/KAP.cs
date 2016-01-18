using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Australian Postcodes
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KAP : EduHubEntity
    {

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE;
            }
        }

        #region Field Properties

        /// <summary>
        /// Unique ID: NOTE there are two rows for each postcode/locality combination: in one, KAPKEY=POSTCODE|PLACE_NAME; in the other, KAPKEY=PLACE_NAME|POSTCODE
        /// [Alphanumeric (34)]
        /// </summary>
        public string KAPKEY { get; internal set; }

        /// <summary>
        /// Postcode
        /// [Alphanumeric (4)]
        /// </summary>
        public string POSTCODE { get; internal set; }

        /// <summary>
        /// Name of town, suburb or other locality
        /// [Alphanumeric (30)]
        /// </summary>
        public string PLACE_NAME { get; internal set; }

        /// <summary>
        /// State code
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string STATE { get; internal set; }

        /// <summary>
        /// Distinguishes similar records
        /// [Alphanumeric (30)]
        /// </summary>
        public string DISCRIMINATOR { get; internal set; }

        /// <summary>
        /// Indicates this postcode is for street addresses
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string STREET_ADD { get; internal set; }

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

    }
}
