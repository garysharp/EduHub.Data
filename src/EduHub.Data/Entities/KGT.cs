using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Countries
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGT : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<DF> Cache_COUNTRY_DF_BIRTH_COUNTRY_A;
        private IReadOnlyList<DF> Cache_COUNTRY_DF_BIRTH_COUNTRY_B;
        private IReadOnlyList<OSCS> Cache_COUNTRY_OSCS_ADULT_A_COUNTRY;
        private IReadOnlyList<OSCS> Cache_COUNTRY_OSCS_ADULT_B_COUNTRY;
        private IReadOnlyList<OSCS> Cache_COUNTRY_OSCS_BIRTH_COUNTRY;
        private IReadOnlyList<PE> Cache_COUNTRY_PE_COUNTRY;
        private IReadOnlyList<PPD> Cache_COUNTRY_PPD_COUNTRY;
        private IReadOnlyList<PPS> Cache_COUNTRY_PPS_COUNTRY;
        private IReadOnlyList<PPS> Cache_COUNTRY_PPS_POSTAL_COUNTRY;
        private IReadOnlyList<SF> Cache_COUNTRY_SF_BIRTH_COUNTRY;
        private IReadOnlyList<ST> Cache_COUNTRY_ST_BIRTH_COUNTRY;
        private IReadOnlyList<UM> Cache_COUNTRY_UM_COUNTRY;

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE.Value;
            }
        }

        #region Field Properties

        /// <summary>
        /// Country code
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string COUNTRY { get; internal set; }

        /// <summary>
        /// Country description
        /// [Alphanumeric (40)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Indicates whether English is the country's first language (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ENGLISH_SPEAKING { get; internal set; }

        /// <summary>
        /// Numeric "Standard Australian Classification of Countries" code as defined by Australian Bureau of Statistics
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SACC { get; internal set; }

        /// <summary>
        /// Is this code obsolete (no longer in use)? (Y/blank)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string OBSOLETE { get; internal set; }

        /// <summary>
        /// Identifies if Country is a refugee type for EAL (refer Aegis 7210).
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string REFUGEE { get; internal set; }

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
        /// DF (Families) related entities by [KGT.COUNTRY]-&gt;[DF.BIRTH_COUNTRY_A]
        /// Country code
        /// </summary>
        public IReadOnlyList<DF> COUNTRY_DF_BIRTH_COUNTRY_A
        {
            get
            {
                if (Cache_COUNTRY_DF_BIRTH_COUNTRY_A == null &&
                    !Context.DF.TryFindByBIRTH_COUNTRY_A(COUNTRY, out Cache_COUNTRY_DF_BIRTH_COUNTRY_A))
                {
                    Cache_COUNTRY_DF_BIRTH_COUNTRY_A = new List<DF>().AsReadOnly();
                }

                return Cache_COUNTRY_DF_BIRTH_COUNTRY_A;
            }
        }

        /// <summary>
        /// DF (Families) related entities by [KGT.COUNTRY]-&gt;[DF.BIRTH_COUNTRY_B]
        /// Country code
        /// </summary>
        public IReadOnlyList<DF> COUNTRY_DF_BIRTH_COUNTRY_B
        {
            get
            {
                if (Cache_COUNTRY_DF_BIRTH_COUNTRY_B == null &&
                    !Context.DF.TryFindByBIRTH_COUNTRY_B(COUNTRY, out Cache_COUNTRY_DF_BIRTH_COUNTRY_B))
                {
                    Cache_COUNTRY_DF_BIRTH_COUNTRY_B = new List<DF>().AsReadOnly();
                }

                return Cache_COUNTRY_DF_BIRTH_COUNTRY_B;
            }
        }

        /// <summary>
        /// OSCS (CASES Past Students) related entities by [KGT.COUNTRY]-&gt;[OSCS.ADULT_A_COUNTRY]
        /// Country code
        /// </summary>
        public IReadOnlyList<OSCS> COUNTRY_OSCS_ADULT_A_COUNTRY
        {
            get
            {
                if (Cache_COUNTRY_OSCS_ADULT_A_COUNTRY == null &&
                    !Context.OSCS.TryFindByADULT_A_COUNTRY(COUNTRY, out Cache_COUNTRY_OSCS_ADULT_A_COUNTRY))
                {
                    Cache_COUNTRY_OSCS_ADULT_A_COUNTRY = new List<OSCS>().AsReadOnly();
                }

                return Cache_COUNTRY_OSCS_ADULT_A_COUNTRY;
            }
        }

        /// <summary>
        /// OSCS (CASES Past Students) related entities by [KGT.COUNTRY]-&gt;[OSCS.ADULT_B_COUNTRY]
        /// Country code
        /// </summary>
        public IReadOnlyList<OSCS> COUNTRY_OSCS_ADULT_B_COUNTRY
        {
            get
            {
                if (Cache_COUNTRY_OSCS_ADULT_B_COUNTRY == null &&
                    !Context.OSCS.TryFindByADULT_B_COUNTRY(COUNTRY, out Cache_COUNTRY_OSCS_ADULT_B_COUNTRY))
                {
                    Cache_COUNTRY_OSCS_ADULT_B_COUNTRY = new List<OSCS>().AsReadOnly();
                }

                return Cache_COUNTRY_OSCS_ADULT_B_COUNTRY;
            }
        }

        /// <summary>
        /// OSCS (CASES Past Students) related entities by [KGT.COUNTRY]-&gt;[OSCS.BIRTH_COUNTRY]
        /// Country code
        /// </summary>
        public IReadOnlyList<OSCS> COUNTRY_OSCS_BIRTH_COUNTRY
        {
            get
            {
                if (Cache_COUNTRY_OSCS_BIRTH_COUNTRY == null &&
                    !Context.OSCS.TryFindByBIRTH_COUNTRY(COUNTRY, out Cache_COUNTRY_OSCS_BIRTH_COUNTRY))
                {
                    Cache_COUNTRY_OSCS_BIRTH_COUNTRY = new List<OSCS>().AsReadOnly();
                }

                return Cache_COUNTRY_OSCS_BIRTH_COUNTRY;
            }
        }

        /// <summary>
        /// PE (Employees) related entities by [KGT.COUNTRY]-&gt;[PE.COUNTRY]
        /// Country code
        /// </summary>
        public IReadOnlyList<PE> COUNTRY_PE_COUNTRY
        {
            get
            {
                if (Cache_COUNTRY_PE_COUNTRY == null &&
                    !Context.PE.TryFindByCOUNTRY(COUNTRY, out Cache_COUNTRY_PE_COUNTRY))
                {
                    Cache_COUNTRY_PE_COUNTRY = new List<PE>().AsReadOnly();
                }

                return Cache_COUNTRY_PE_COUNTRY;
            }
        }

        /// <summary>
        /// PPD (PAYG Payer Details) related entities by [KGT.COUNTRY]-&gt;[PPD.COUNTRY]
        /// Country code
        /// </summary>
        public IReadOnlyList<PPD> COUNTRY_PPD_COUNTRY
        {
            get
            {
                if (Cache_COUNTRY_PPD_COUNTRY == null &&
                    !Context.PPD.TryFindByCOUNTRY(COUNTRY, out Cache_COUNTRY_PPD_COUNTRY))
                {
                    Cache_COUNTRY_PPD_COUNTRY = new List<PPD>().AsReadOnly();
                }

                return Cache_COUNTRY_PPD_COUNTRY;
            }
        }

        /// <summary>
        /// PPS (PAYG Supplier Details) related entities by [KGT.COUNTRY]-&gt;[PPS.COUNTRY]
        /// Country code
        /// </summary>
        public IReadOnlyList<PPS> COUNTRY_PPS_COUNTRY
        {
            get
            {
                if (Cache_COUNTRY_PPS_COUNTRY == null &&
                    !Context.PPS.TryFindByCOUNTRY(COUNTRY, out Cache_COUNTRY_PPS_COUNTRY))
                {
                    Cache_COUNTRY_PPS_COUNTRY = new List<PPS>().AsReadOnly();
                }

                return Cache_COUNTRY_PPS_COUNTRY;
            }
        }

        /// <summary>
        /// PPS (PAYG Supplier Details) related entities by [KGT.COUNTRY]-&gt;[PPS.POSTAL_COUNTRY]
        /// Country code
        /// </summary>
        public IReadOnlyList<PPS> COUNTRY_PPS_POSTAL_COUNTRY
        {
            get
            {
                if (Cache_COUNTRY_PPS_POSTAL_COUNTRY == null &&
                    !Context.PPS.TryFindByPOSTAL_COUNTRY(COUNTRY, out Cache_COUNTRY_PPS_POSTAL_COUNTRY))
                {
                    Cache_COUNTRY_PPS_POSTAL_COUNTRY = new List<PPS>().AsReadOnly();
                }

                return Cache_COUNTRY_PPS_POSTAL_COUNTRY;
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [KGT.COUNTRY]-&gt;[SF.BIRTH_COUNTRY]
        /// Country code
        /// </summary>
        public IReadOnlyList<SF> COUNTRY_SF_BIRTH_COUNTRY
        {
            get
            {
                if (Cache_COUNTRY_SF_BIRTH_COUNTRY == null &&
                    !Context.SF.TryFindByBIRTH_COUNTRY(COUNTRY, out Cache_COUNTRY_SF_BIRTH_COUNTRY))
                {
                    Cache_COUNTRY_SF_BIRTH_COUNTRY = new List<SF>().AsReadOnly();
                }

                return Cache_COUNTRY_SF_BIRTH_COUNTRY;
            }
        }

        /// <summary>
        /// ST (Students) related entities by [KGT.COUNTRY]-&gt;[ST.BIRTH_COUNTRY]
        /// Country code
        /// </summary>
        public IReadOnlyList<ST> COUNTRY_ST_BIRTH_COUNTRY
        {
            get
            {
                if (Cache_COUNTRY_ST_BIRTH_COUNTRY == null &&
                    !Context.ST.TryFindByBIRTH_COUNTRY(COUNTRY, out Cache_COUNTRY_ST_BIRTH_COUNTRY))
                {
                    Cache_COUNTRY_ST_BIRTH_COUNTRY = new List<ST>().AsReadOnly();
                }

                return Cache_COUNTRY_ST_BIRTH_COUNTRY;
            }
        }

        /// <summary>
        /// UM (Addresses) related entities by [KGT.COUNTRY]-&gt;[UM.COUNTRY]
        /// Country code
        /// </summary>
        public IReadOnlyList<UM> COUNTRY_UM_COUNTRY
        {
            get
            {
                if (Cache_COUNTRY_UM_COUNTRY == null &&
                    !Context.UM.TryFindByCOUNTRY(COUNTRY, out Cache_COUNTRY_UM_COUNTRY))
                {
                    Cache_COUNTRY_UM_COUNTRY = new List<UM>().AsReadOnly();
                }

                return Cache_COUNTRY_UM_COUNTRY;
            }
        }

        #endregion

    }
}
