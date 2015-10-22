using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Countries
    /// </summary>
    public partial class KGT : EntityBase
    {
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

#region Navigation Properties

        /// <summary>
        /// DF (Families) related entities by [DF.BIRTH_COUNTRY_A]-&gt;[KGT.COUNTRY]
        /// </summary>
        public IReadOnlyList<DF> DF_BIRTH_COUNTRY_A
        {
            get
            {
                return Context.KGT.FindDFByBIRTH_COUNTRY_A(COUNTRY);
            }
        }

        /// <summary>
        /// DF (Families) related entities by [DF.BIRTH_COUNTRY_B]-&gt;[KGT.COUNTRY]
        /// </summary>
        public IReadOnlyList<DF> DF_BIRTH_COUNTRY_B
        {
            get
            {
                return Context.KGT.FindDFByBIRTH_COUNTRY_B(COUNTRY);
            }
        }

        /// <summary>
        /// OSCS (CASES Past Students) related entities by [OSCS.ADULT_A_COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        public IReadOnlyList<OSCS> OSCS_ADULT_A_COUNTRY
        {
            get
            {
                return Context.KGT.FindOSCSByADULT_A_COUNTRY(COUNTRY);
            }
        }

        /// <summary>
        /// OSCS (CASES Past Students) related entities by [OSCS.ADULT_B_COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        public IReadOnlyList<OSCS> OSCS_ADULT_B_COUNTRY
        {
            get
            {
                return Context.KGT.FindOSCSByADULT_B_COUNTRY(COUNTRY);
            }
        }

        /// <summary>
        /// OSCS (CASES Past Students) related entities by [OSCS.BIRTH_COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        public IReadOnlyList<OSCS> OSCS_BIRTH_COUNTRY
        {
            get
            {
                return Context.KGT.FindOSCSByBIRTH_COUNTRY(COUNTRY);
            }
        }

        /// <summary>
        /// PE (Employees) related entities by [PE.COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        public IReadOnlyList<PE> PE_COUNTRY
        {
            get
            {
                return Context.KGT.FindPEByCOUNTRY(COUNTRY);
            }
        }

        /// <summary>
        /// PPD (PAYG Payer Details) related entities by [PPD.COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        public IReadOnlyList<PPD> PPD_COUNTRY
        {
            get
            {
                return Context.KGT.FindPPDByCOUNTRY(COUNTRY);
            }
        }

        /// <summary>
        /// PPS (PAYG Supplier Details) related entities by [PPS.COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        public IReadOnlyList<PPS> PPS_COUNTRY
        {
            get
            {
                return Context.KGT.FindPPSByCOUNTRY(COUNTRY);
            }
        }

        /// <summary>
        /// PPS (PAYG Supplier Details) related entities by [PPS.POSTAL_COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        public IReadOnlyList<PPS> PPS_POSTAL_COUNTRY
        {
            get
            {
                return Context.KGT.FindPPSByPOSTAL_COUNTRY(COUNTRY);
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SF.BIRTH_COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        public IReadOnlyList<SF> SF_BIRTH_COUNTRY
        {
            get
            {
                return Context.KGT.FindSFByBIRTH_COUNTRY(COUNTRY);
            }
        }

        /// <summary>
        /// ST (Students) related entities by [ST.BIRTH_COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        public IReadOnlyList<ST> ST_BIRTH_COUNTRY
        {
            get
            {
                return Context.KGT.FindSTByBIRTH_COUNTRY(COUNTRY);
            }
        }

        /// <summary>
        /// UM (Addresses) related entities by [UM.COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        public IReadOnlyList<UM> UM_COUNTRY
        {
            get
            {
                return Context.KGT.FindUMByCOUNTRY(COUNTRY);
            }
        }
#endregion
    }
}
