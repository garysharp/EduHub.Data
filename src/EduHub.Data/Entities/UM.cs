using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Addresses
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class UM : EduHubEntity
    {

        #region Navigation Property Cache

        private KGT Cache_COUNTRY_KGT;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<DF> Cache_UMKEY_DF_HOMEKEY;
        private IReadOnlyList<DF> Cache_UMKEY_DF_MAILKEY;
        private IReadOnlyList<DF> Cache_UMKEY_DF_BILLINGKEY;
        private IReadOnlyList<PE> Cache_UMKEY_PE_HOMEKEY;
        private IReadOnlyList<PE> Cache_UMKEY_PE_MAILKEY;
        private IReadOnlyList<PE> Cache_UMKEY_PE_LEAVEKEY;
        private IReadOnlyList<SAM> Cache_UMKEY_SAM_ADDRESSKEY;
        private IReadOnlyList<SAM> Cache_UMKEY_SAM_MAILKEY;
        private IReadOnlyList<SF> Cache_UMKEY_SF_HOMEKEY;
        private IReadOnlyList<SF> Cache_UMKEY_SF_MAILKEY;
        private IReadOnlyList<STTRIPS> Cache_UMKEY_STTRIPS_AM_PICKUP_ADDRESS_ID;
        private IReadOnlyList<STTRIPS> Cache_UMKEY_STTRIPS_PM_SETDOWN_ADDRESS_ID;

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
        /// Address ID
        /// </summary>
        public int UMKEY { get; internal set; }

        /// <summary>
        /// Three address lines (third line used for overseas addresses)
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS01 { get; internal set; }

        /// <summary>
        /// Three address lines (third line used for overseas addresses)
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS02 { get; internal set; }

        /// <summary>
        /// Three address lines (third line used for overseas addresses)
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS03 { get; internal set; }

        /// <summary>
        /// State code (if Australian address)
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string STATE { get; internal set; }

        /// <summary>
        /// Postcode (if Australian address)
        /// [Alphanumeric (4)]
        /// </summary>
        public string POSTCODE { get; internal set; }

        /// <summary>
        /// Phone no
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string TELEPHONE { get; internal set; }

        /// <summary>
        /// Home Mobile no
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string MOBILE { get; internal set; }

        /// <summary>
        /// This phone no is silent? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SILENT { get; internal set; }

        /// <summary>
        /// Fax no
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string FAX { get; internal set; }

        /// <summary>
        /// Link to KAP to allow for access to postcodes when entering an address: NOTE this should NOT be a foreign key to KAP as the user is free to enter different data in ADDRESS03 and POSTCODE
        /// [Alphanumeric (34)]
        /// </summary>
        public string KAP_LINK { get; internal set; }

        /// <summary>
        /// Country (default '1101' code for Australia)
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string COUNTRY { get; internal set; }

        /// <summary>
        /// Australia Post address identifier
        /// </summary>
        public int? DPID { get; internal set; }

        /// <summary>
        /// Australia Post barcode numbers
        /// [Alphanumeric (37)]
        /// </summary>
        public string BARCODE { get; internal set; }

        /// <summary>
        /// Latitude of address for Geospatial referencing
        /// </summary>
        public double? LATITUDE { get; internal set; }

        /// <summary>
        /// Longitude of address for Geospatial referencing
        /// </summary>
        public double? LONGITUDE { get; internal set; }

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
        /// KGT (Countries) related entity by [UM.COUNTRY]-&gt;[KGT.COUNTRY]
        /// Country (default '1101' code for Australia)
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

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// DF (Families) related entities by [UM.UMKEY]-&gt;[DF.HOMEKEY]
        /// Address ID
        /// </summary>
        public IReadOnlyList<DF> UMKEY_DF_HOMEKEY
        {
            get
            {
                if (Cache_UMKEY_DF_HOMEKEY == null &&
                    !Context.DF.TryFindByHOMEKEY(UMKEY, out Cache_UMKEY_DF_HOMEKEY))
                {
                    Cache_UMKEY_DF_HOMEKEY = new List<DF>().AsReadOnly();
                }

                return Cache_UMKEY_DF_HOMEKEY;
            }
        }

        /// <summary>
        /// DF (Families) related entities by [UM.UMKEY]-&gt;[DF.MAILKEY]
        /// Address ID
        /// </summary>
        public IReadOnlyList<DF> UMKEY_DF_MAILKEY
        {
            get
            {
                if (Cache_UMKEY_DF_MAILKEY == null &&
                    !Context.DF.TryFindByMAILKEY(UMKEY, out Cache_UMKEY_DF_MAILKEY))
                {
                    Cache_UMKEY_DF_MAILKEY = new List<DF>().AsReadOnly();
                }

                return Cache_UMKEY_DF_MAILKEY;
            }
        }

        /// <summary>
        /// DF (Families) related entities by [UM.UMKEY]-&gt;[DF.BILLINGKEY]
        /// Address ID
        /// </summary>
        public IReadOnlyList<DF> UMKEY_DF_BILLINGKEY
        {
            get
            {
                if (Cache_UMKEY_DF_BILLINGKEY == null &&
                    !Context.DF.TryFindByBILLINGKEY(UMKEY, out Cache_UMKEY_DF_BILLINGKEY))
                {
                    Cache_UMKEY_DF_BILLINGKEY = new List<DF>().AsReadOnly();
                }

                return Cache_UMKEY_DF_BILLINGKEY;
            }
        }

        /// <summary>
        /// PE (Employees) related entities by [UM.UMKEY]-&gt;[PE.HOMEKEY]
        /// Address ID
        /// </summary>
        public IReadOnlyList<PE> UMKEY_PE_HOMEKEY
        {
            get
            {
                if (Cache_UMKEY_PE_HOMEKEY == null &&
                    !Context.PE.TryFindByHOMEKEY(UMKEY, out Cache_UMKEY_PE_HOMEKEY))
                {
                    Cache_UMKEY_PE_HOMEKEY = new List<PE>().AsReadOnly();
                }

                return Cache_UMKEY_PE_HOMEKEY;
            }
        }

        /// <summary>
        /// PE (Employees) related entities by [UM.UMKEY]-&gt;[PE.MAILKEY]
        /// Address ID
        /// </summary>
        public IReadOnlyList<PE> UMKEY_PE_MAILKEY
        {
            get
            {
                if (Cache_UMKEY_PE_MAILKEY == null &&
                    !Context.PE.TryFindByMAILKEY(UMKEY, out Cache_UMKEY_PE_MAILKEY))
                {
                    Cache_UMKEY_PE_MAILKEY = new List<PE>().AsReadOnly();
                }

                return Cache_UMKEY_PE_MAILKEY;
            }
        }

        /// <summary>
        /// PE (Employees) related entities by [UM.UMKEY]-&gt;[PE.LEAVEKEY]
        /// Address ID
        /// </summary>
        public IReadOnlyList<PE> UMKEY_PE_LEAVEKEY
        {
            get
            {
                if (Cache_UMKEY_PE_LEAVEKEY == null &&
                    !Context.PE.TryFindByLEAVEKEY(UMKEY, out Cache_UMKEY_PE_LEAVEKEY))
                {
                    Cache_UMKEY_PE_LEAVEKEY = new List<PE>().AsReadOnly();
                }

                return Cache_UMKEY_PE_LEAVEKEY;
            }
        }

        /// <summary>
        /// SAM (School Association Members) related entities by [UM.UMKEY]-&gt;[SAM.ADDRESSKEY]
        /// Address ID
        /// </summary>
        public IReadOnlyList<SAM> UMKEY_SAM_ADDRESSKEY
        {
            get
            {
                if (Cache_UMKEY_SAM_ADDRESSKEY == null &&
                    !Context.SAM.TryFindByADDRESSKEY(UMKEY, out Cache_UMKEY_SAM_ADDRESSKEY))
                {
                    Cache_UMKEY_SAM_ADDRESSKEY = new List<SAM>().AsReadOnly();
                }

                return Cache_UMKEY_SAM_ADDRESSKEY;
            }
        }

        /// <summary>
        /// SAM (School Association Members) related entities by [UM.UMKEY]-&gt;[SAM.MAILKEY]
        /// Address ID
        /// </summary>
        public IReadOnlyList<SAM> UMKEY_SAM_MAILKEY
        {
            get
            {
                if (Cache_UMKEY_SAM_MAILKEY == null &&
                    !Context.SAM.TryFindByMAILKEY(UMKEY, out Cache_UMKEY_SAM_MAILKEY))
                {
                    Cache_UMKEY_SAM_MAILKEY = new List<SAM>().AsReadOnly();
                }

                return Cache_UMKEY_SAM_MAILKEY;
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [UM.UMKEY]-&gt;[SF.HOMEKEY]
        /// Address ID
        /// </summary>
        public IReadOnlyList<SF> UMKEY_SF_HOMEKEY
        {
            get
            {
                if (Cache_UMKEY_SF_HOMEKEY == null &&
                    !Context.SF.TryFindByHOMEKEY(UMKEY, out Cache_UMKEY_SF_HOMEKEY))
                {
                    Cache_UMKEY_SF_HOMEKEY = new List<SF>().AsReadOnly();
                }

                return Cache_UMKEY_SF_HOMEKEY;
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [UM.UMKEY]-&gt;[SF.MAILKEY]
        /// Address ID
        /// </summary>
        public IReadOnlyList<SF> UMKEY_SF_MAILKEY
        {
            get
            {
                if (Cache_UMKEY_SF_MAILKEY == null &&
                    !Context.SF.TryFindByMAILKEY(UMKEY, out Cache_UMKEY_SF_MAILKEY))
                {
                    Cache_UMKEY_SF_MAILKEY = new List<SF>().AsReadOnly();
                }

                return Cache_UMKEY_SF_MAILKEY;
            }
        }

        /// <summary>
        /// STTRIPS (Student Trips) related entities by [UM.UMKEY]-&gt;[STTRIPS.AM_PICKUP_ADDRESS_ID]
        /// Address ID
        /// </summary>
        public IReadOnlyList<STTRIPS> UMKEY_STTRIPS_AM_PICKUP_ADDRESS_ID
        {
            get
            {
                if (Cache_UMKEY_STTRIPS_AM_PICKUP_ADDRESS_ID == null &&
                    !Context.STTRIPS.TryFindByAM_PICKUP_ADDRESS_ID(UMKEY, out Cache_UMKEY_STTRIPS_AM_PICKUP_ADDRESS_ID))
                {
                    Cache_UMKEY_STTRIPS_AM_PICKUP_ADDRESS_ID = new List<STTRIPS>().AsReadOnly();
                }

                return Cache_UMKEY_STTRIPS_AM_PICKUP_ADDRESS_ID;
            }
        }

        /// <summary>
        /// STTRIPS (Student Trips) related entities by [UM.UMKEY]-&gt;[STTRIPS.PM_SETDOWN_ADDRESS_ID]
        /// Address ID
        /// </summary>
        public IReadOnlyList<STTRIPS> UMKEY_STTRIPS_PM_SETDOWN_ADDRESS_ID
        {
            get
            {
                if (Cache_UMKEY_STTRIPS_PM_SETDOWN_ADDRESS_ID == null &&
                    !Context.STTRIPS.TryFindByPM_SETDOWN_ADDRESS_ID(UMKEY, out Cache_UMKEY_STTRIPS_PM_SETDOWN_ADDRESS_ID))
                {
                    Cache_UMKEY_STTRIPS_PM_SETDOWN_ADDRESS_ID = new List<STTRIPS>().AsReadOnly();
                }

                return Cache_UMKEY_STTRIPS_PM_SETDOWN_ADDRESS_ID;
            }
        }

        #endregion

    }
}
