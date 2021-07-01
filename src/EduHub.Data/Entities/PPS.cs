using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// PAYG Supplier Details
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PPS : EduHubEntity
    {

        #region Navigation Property Cache

        private KGT Cache_COUNTRY_KGT;
        private KGT Cache_POSTAL_COUNTRY_KGT;

        #endregion

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
        /// Supplier code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PPSKEY { get; internal set; }

        /// <summary>
        /// ABN Number of the Supplier
        /// [Uppercase Alphanumeric (11)]
        /// </summary>
        public string ABN { get; internal set; }

        /// <summary>
        /// Supplier Name
        /// [Uppercase Alphanumeric (76)]
        /// </summary>
        public string NAME { get; internal set; }

        /// <summary>
        /// Supplier contact name
        /// [Uppercase Alphanumeric (38)]
        /// </summary>
        public string CONTACT_NAME { get; internal set; }

        /// <summary>
        /// Supplier contact telephone or mobile number
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string CONTACT_PHONE { get; internal set; }

        /// <summary>
        /// Supplier facsimile number
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string FACSIMILE { get; internal set; }

        /// <summary>
        /// Supplier file reference
        /// [Uppercase Alphanumeric (16)]
        /// </summary>
        public string FILE_REFERENCE { get; internal set; }

        /// <summary>
        /// Supplier street address line 1
        /// [Uppercase Alphanumeric (38)]
        /// </summary>
        public string L1_ADDRESS { get; internal set; }

        /// <summary>
        /// Supplier street address line 2
        /// [Uppercase Alphanumeric (38)]
        /// </summary>
        public string L2_ADDRESS { get; internal set; }

        /// <summary>
        /// Suburb, town, city
        /// [Uppercase Alphanumeric (27)]
        /// </summary>
        public string SUBURB { get; internal set; }

        /// <summary>
        /// State or territory
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string STATE { get; internal set; }

        /// <summary>
        /// Postcode
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string POSTCODE { get; internal set; }

        /// <summary>
        /// Country
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string COUNTRY { get; internal set; }

        /// <summary>
        /// Supplier postal address line 1
        /// [Uppercase Alphanumeric (38)]
        /// </summary>
        public string POSTAL_L1_ADD { get; internal set; }

        /// <summary>
        /// Supplier postal address line 2
        /// [Uppercase Alphanumeric (38)]
        /// </summary>
        public string POSTAL_L2_ADD { get; internal set; }

        /// <summary>
        /// Supplier postal Suburb, town, city
        /// [Uppercase Alphanumeric (27)]
        /// </summary>
        public string POSTAL_SUBURB { get; internal set; }

        /// <summary>
        /// Supplier postal State or territory
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string POSTAL_STATE { get; internal set; }

        /// <summary>
        /// Supplier postal Postcode
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string POSTAL_POSTCODE { get; internal set; }

        /// <summary>
        /// Supplier postal Country
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string POSTAL_COUNTRY { get; internal set; }

        /// <summary>
        /// Supplier e-mail address
        /// [Alphanumeric (76)]
        /// </summary>
        public string EMAIL_ADDRESS { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// KGT (Countries) related entity by [PPS.COUNTRY]-&gt;[KGT.COUNTRY]
        /// Country
        /// </summary>
        public KGT COUNTRY_KGT
        {
            get
            {
                if (COUNTRY == null)
                {
                    return null;
                }
                if (Cache_COUNTRY_KGT == null)
                {
                    Cache_COUNTRY_KGT = Context.KGT.FindByCOUNTRY(COUNTRY);
                }

                return Cache_COUNTRY_KGT;
            }
        }

        /// <summary>
        /// KGT (Countries) related entity by [PPS.POSTAL_COUNTRY]-&gt;[KGT.COUNTRY]
        /// Supplier postal Country
        /// </summary>
        public KGT POSTAL_COUNTRY_KGT
        {
            get
            {
                if (POSTAL_COUNTRY == null)
                {
                    return null;
                }
                if (Cache_POSTAL_COUNTRY_KGT == null)
                {
                    Cache_POSTAL_COUNTRY_KGT = Context.KGT.FindByCOUNTRY(POSTAL_COUNTRY);
                }

                return Cache_POSTAL_COUNTRY_KGT;
            }
        }

        #endregion

    }
}
