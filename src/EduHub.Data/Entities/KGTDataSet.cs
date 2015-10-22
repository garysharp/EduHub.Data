using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Countries Data Set
    /// </summary>
    public sealed partial class KGTDataSet : SetBase<KGT>
    {
        private Lazy<Dictionary<string, KGT>> COUNTRYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<DF>>> DF_BIRTH_COUNTRY_AForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<DF>>> DF_BIRTH_COUNTRY_BForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<OSCS>>> OSCS_ADULT_A_COUNTRYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<OSCS>>> OSCS_ADULT_B_COUNTRYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<OSCS>>> OSCS_BIRTH_COUNTRYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PE>>> PE_COUNTRYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PPD>>> PPD_COUNTRYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PPS>>> PPS_COUNTRYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PPS>>> PPS_POSTAL_COUNTRYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_BIRTH_COUNTRYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ST>>> ST_BIRTH_COUNTRYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<UM>>> UM_COUNTRYForeignIndex;

        internal KGTDataSet(EduHubContext Context)
            : base(Context)
        {
            COUNTRYIndex = new Lazy<Dictionary<string, KGT>>(() => this.ToDictionary(e => e.COUNTRY));

            DF_BIRTH_COUNTRY_AForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DF>>>(() =>
                    Context.DF
                          .Where(e => e.BIRTH_COUNTRY_A != null)
                          .GroupBy(e => e.BIRTH_COUNTRY_A)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DF>)g.ToList()
                          .AsReadOnly()));

            DF_BIRTH_COUNTRY_BForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DF>>>(() =>
                    Context.DF
                          .Where(e => e.BIRTH_COUNTRY_B != null)
                          .GroupBy(e => e.BIRTH_COUNTRY_B)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DF>)g.ToList()
                          .AsReadOnly()));

            OSCS_ADULT_A_COUNTRYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<OSCS>>>(() =>
                    Context.OSCS
                          .Where(e => e.ADULT_A_COUNTRY != null)
                          .GroupBy(e => e.ADULT_A_COUNTRY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<OSCS>)g.ToList()
                          .AsReadOnly()));

            OSCS_ADULT_B_COUNTRYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<OSCS>>>(() =>
                    Context.OSCS
                          .Where(e => e.ADULT_B_COUNTRY != null)
                          .GroupBy(e => e.ADULT_B_COUNTRY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<OSCS>)g.ToList()
                          .AsReadOnly()));

            OSCS_BIRTH_COUNTRYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<OSCS>>>(() =>
                    Context.OSCS
                          .Where(e => e.BIRTH_COUNTRY != null)
                          .GroupBy(e => e.BIRTH_COUNTRY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<OSCS>)g.ToList()
                          .AsReadOnly()));

            PE_COUNTRYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PE>>>(() =>
                    Context.PE
                          .Where(e => e.COUNTRY != null)
                          .GroupBy(e => e.COUNTRY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PE>)g.ToList()
                          .AsReadOnly()));

            PPD_COUNTRYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PPD>>>(() =>
                    Context.PPD
                          .Where(e => e.COUNTRY != null)
                          .GroupBy(e => e.COUNTRY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PPD>)g.ToList()
                          .AsReadOnly()));

            PPS_COUNTRYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PPS>>>(() =>
                    Context.PPS
                          .Where(e => e.COUNTRY != null)
                          .GroupBy(e => e.COUNTRY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PPS>)g.ToList()
                          .AsReadOnly()));

            PPS_POSTAL_COUNTRYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PPS>>>(() =>
                    Context.PPS
                          .Where(e => e.POSTAL_COUNTRY != null)
                          .GroupBy(e => e.POSTAL_COUNTRY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PPS>)g.ToList()
                          .AsReadOnly()));

            SF_BIRTH_COUNTRYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.BIRTH_COUNTRY != null)
                          .GroupBy(e => e.BIRTH_COUNTRY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            ST_BIRTH_COUNTRYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ST>>>(() =>
                    Context.ST
                          .Where(e => e.BIRTH_COUNTRY != null)
                          .GroupBy(e => e.BIRTH_COUNTRY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ST>)g.ToList()
                          .AsReadOnly()));

            UM_COUNTRYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<UM>>>(() =>
                    Context.UM
                          .Where(e => e.COUNTRY != null)
                          .GroupBy(e => e.COUNTRY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<UM>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGT"; } }

        /// <summary>
        /// Find KGT by COUNTRY key field
        /// </summary>
        /// <param name="Key">COUNTRY value used to find KGT</param>
        /// <returns>Related KGT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">COUNTRY value didn't match any KGT entities</exception>
        public KGT FindByCOUNTRY(string Key)
        {
            KGT result;
            if (COUNTRYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KGT by COUNTRY key field
        /// </summary>
        /// <param name="Key">COUNTRY value used to find KGT</param>
        /// <param name="Value">Related KGT entity</param>
        /// <returns>True if the KGT entity is found</returns>
        public bool TryFindByCOUNTRY(string Key, out KGT Value)
        {
            return COUNTRYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KGT by COUNTRY key field
        /// </summary>
        /// <param name="Key">COUNTRY value used to find KGT</param>
        /// <returns>Related KGT entity, or null if not found</returns>
        public KGT TryFindByCOUNTRY(string Key)
        {
            KGT result;
            if (COUNTRYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all DF (Families) entities by [DF.BIRTH_COUNTRY_A]-&gt;[KGT.COUNTRY]
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find DF entities</param>
        /// <returns>A list of related DF entities</returns>
        public IReadOnlyList<DF> FindDFByBIRTH_COUNTRY_A(string COUNTRY)
        {
            IReadOnlyList<DF> result;
            if (DF_BIRTH_COUNTRY_AForeignIndex.Value.TryGetValue(COUNTRY, out result))
            {
                return result;
            }
            else
            {
                return new List<DF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DF entities by [DF.BIRTH_COUNTRY_A]-&gt;[KGT.COUNTRY]
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find DF entities</param>
        /// <param name="Value">A list of related DF entities</param>
        /// <returns>True if any DF entities are found</returns>
        public bool TryFindDFByBIRTH_COUNTRY_A(string COUNTRY, out IReadOnlyList<DF> Value)
        {
            return DF_BIRTH_COUNTRY_AForeignIndex.Value.TryGetValue(COUNTRY, out Value);
        }

        /// <summary>
        /// Find all DF (Families) entities by [DF.BIRTH_COUNTRY_B]-&gt;[KGT.COUNTRY]
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find DF entities</param>
        /// <returns>A list of related DF entities</returns>
        public IReadOnlyList<DF> FindDFByBIRTH_COUNTRY_B(string COUNTRY)
        {
            IReadOnlyList<DF> result;
            if (DF_BIRTH_COUNTRY_BForeignIndex.Value.TryGetValue(COUNTRY, out result))
            {
                return result;
            }
            else
            {
                return new List<DF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DF entities by [DF.BIRTH_COUNTRY_B]-&gt;[KGT.COUNTRY]
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find DF entities</param>
        /// <param name="Value">A list of related DF entities</param>
        /// <returns>True if any DF entities are found</returns>
        public bool TryFindDFByBIRTH_COUNTRY_B(string COUNTRY, out IReadOnlyList<DF> Value)
        {
            return DF_BIRTH_COUNTRY_BForeignIndex.Value.TryGetValue(COUNTRY, out Value);
        }

        /// <summary>
        /// Find all OSCS (CASES Past Students) entities by [OSCS.ADULT_A_COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find OSCS entities</param>
        /// <returns>A list of related OSCS entities</returns>
        public IReadOnlyList<OSCS> FindOSCSByADULT_A_COUNTRY(string COUNTRY)
        {
            IReadOnlyList<OSCS> result;
            if (OSCS_ADULT_A_COUNTRYForeignIndex.Value.TryGetValue(COUNTRY, out result))
            {
                return result;
            }
            else
            {
                return new List<OSCS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all OSCS entities by [OSCS.ADULT_A_COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find OSCS entities</param>
        /// <param name="Value">A list of related OSCS entities</param>
        /// <returns>True if any OSCS entities are found</returns>
        public bool TryFindOSCSByADULT_A_COUNTRY(string COUNTRY, out IReadOnlyList<OSCS> Value)
        {
            return OSCS_ADULT_A_COUNTRYForeignIndex.Value.TryGetValue(COUNTRY, out Value);
        }

        /// <summary>
        /// Find all OSCS (CASES Past Students) entities by [OSCS.ADULT_B_COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find OSCS entities</param>
        /// <returns>A list of related OSCS entities</returns>
        public IReadOnlyList<OSCS> FindOSCSByADULT_B_COUNTRY(string COUNTRY)
        {
            IReadOnlyList<OSCS> result;
            if (OSCS_ADULT_B_COUNTRYForeignIndex.Value.TryGetValue(COUNTRY, out result))
            {
                return result;
            }
            else
            {
                return new List<OSCS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all OSCS entities by [OSCS.ADULT_B_COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find OSCS entities</param>
        /// <param name="Value">A list of related OSCS entities</param>
        /// <returns>True if any OSCS entities are found</returns>
        public bool TryFindOSCSByADULT_B_COUNTRY(string COUNTRY, out IReadOnlyList<OSCS> Value)
        {
            return OSCS_ADULT_B_COUNTRYForeignIndex.Value.TryGetValue(COUNTRY, out Value);
        }

        /// <summary>
        /// Find all OSCS (CASES Past Students) entities by [OSCS.BIRTH_COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find OSCS entities</param>
        /// <returns>A list of related OSCS entities</returns>
        public IReadOnlyList<OSCS> FindOSCSByBIRTH_COUNTRY(string COUNTRY)
        {
            IReadOnlyList<OSCS> result;
            if (OSCS_BIRTH_COUNTRYForeignIndex.Value.TryGetValue(COUNTRY, out result))
            {
                return result;
            }
            else
            {
                return new List<OSCS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all OSCS entities by [OSCS.BIRTH_COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find OSCS entities</param>
        /// <param name="Value">A list of related OSCS entities</param>
        /// <returns>True if any OSCS entities are found</returns>
        public bool TryFindOSCSByBIRTH_COUNTRY(string COUNTRY, out IReadOnlyList<OSCS> Value)
        {
            return OSCS_BIRTH_COUNTRYForeignIndex.Value.TryGetValue(COUNTRY, out Value);
        }

        /// <summary>
        /// Find all PE (Employees) entities by [PE.COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PE entities</param>
        /// <returns>A list of related PE entities</returns>
        public IReadOnlyList<PE> FindPEByCOUNTRY(string COUNTRY)
        {
            IReadOnlyList<PE> result;
            if (PE_COUNTRYForeignIndex.Value.TryGetValue(COUNTRY, out result))
            {
                return result;
            }
            else
            {
                return new List<PE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PE entities by [PE.COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PE entities</param>
        /// <param name="Value">A list of related PE entities</param>
        /// <returns>True if any PE entities are found</returns>
        public bool TryFindPEByCOUNTRY(string COUNTRY, out IReadOnlyList<PE> Value)
        {
            return PE_COUNTRYForeignIndex.Value.TryGetValue(COUNTRY, out Value);
        }

        /// <summary>
        /// Find all PPD (PAYG Payer Details) entities by [PPD.COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PPD entities</param>
        /// <returns>A list of related PPD entities</returns>
        public IReadOnlyList<PPD> FindPPDByCOUNTRY(string COUNTRY)
        {
            IReadOnlyList<PPD> result;
            if (PPD_COUNTRYForeignIndex.Value.TryGetValue(COUNTRY, out result))
            {
                return result;
            }
            else
            {
                return new List<PPD>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PPD entities by [PPD.COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PPD entities</param>
        /// <param name="Value">A list of related PPD entities</param>
        /// <returns>True if any PPD entities are found</returns>
        public bool TryFindPPDByCOUNTRY(string COUNTRY, out IReadOnlyList<PPD> Value)
        {
            return PPD_COUNTRYForeignIndex.Value.TryGetValue(COUNTRY, out Value);
        }

        /// <summary>
        /// Find all PPS (PAYG Supplier Details) entities by [PPS.COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PPS entities</param>
        /// <returns>A list of related PPS entities</returns>
        public IReadOnlyList<PPS> FindPPSByCOUNTRY(string COUNTRY)
        {
            IReadOnlyList<PPS> result;
            if (PPS_COUNTRYForeignIndex.Value.TryGetValue(COUNTRY, out result))
            {
                return result;
            }
            else
            {
                return new List<PPS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PPS entities by [PPS.COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PPS entities</param>
        /// <param name="Value">A list of related PPS entities</param>
        /// <returns>True if any PPS entities are found</returns>
        public bool TryFindPPSByCOUNTRY(string COUNTRY, out IReadOnlyList<PPS> Value)
        {
            return PPS_COUNTRYForeignIndex.Value.TryGetValue(COUNTRY, out Value);
        }

        /// <summary>
        /// Find all PPS (PAYG Supplier Details) entities by [PPS.POSTAL_COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PPS entities</param>
        /// <returns>A list of related PPS entities</returns>
        public IReadOnlyList<PPS> FindPPSByPOSTAL_COUNTRY(string COUNTRY)
        {
            IReadOnlyList<PPS> result;
            if (PPS_POSTAL_COUNTRYForeignIndex.Value.TryGetValue(COUNTRY, out result))
            {
                return result;
            }
            else
            {
                return new List<PPS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PPS entities by [PPS.POSTAL_COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PPS entities</param>
        /// <param name="Value">A list of related PPS entities</param>
        /// <returns>True if any PPS entities are found</returns>
        public bool TryFindPPSByPOSTAL_COUNTRY(string COUNTRY, out IReadOnlyList<PPS> Value)
        {
            return PPS_POSTAL_COUNTRYForeignIndex.Value.TryGetValue(COUNTRY, out Value);
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.BIRTH_COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFByBIRTH_COUNTRY(string COUNTRY)
        {
            IReadOnlyList<SF> result;
            if (SF_BIRTH_COUNTRYForeignIndex.Value.TryGetValue(COUNTRY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.BIRTH_COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFByBIRTH_COUNTRY(string COUNTRY, out IReadOnlyList<SF> Value)
        {
            return SF_BIRTH_COUNTRYForeignIndex.Value.TryGetValue(COUNTRY, out Value);
        }

        /// <summary>
        /// Find all ST (Students) entities by [ST.BIRTH_COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find ST entities</param>
        /// <returns>A list of related ST entities</returns>
        public IReadOnlyList<ST> FindSTByBIRTH_COUNTRY(string COUNTRY)
        {
            IReadOnlyList<ST> result;
            if (ST_BIRTH_COUNTRYForeignIndex.Value.TryGetValue(COUNTRY, out result))
            {
                return result;
            }
            else
            {
                return new List<ST>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ST entities by [ST.BIRTH_COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find ST entities</param>
        /// <param name="Value">A list of related ST entities</param>
        /// <returns>True if any ST entities are found</returns>
        public bool TryFindSTByBIRTH_COUNTRY(string COUNTRY, out IReadOnlyList<ST> Value)
        {
            return ST_BIRTH_COUNTRYForeignIndex.Value.TryGetValue(COUNTRY, out Value);
        }

        /// <summary>
        /// Find all UM (Addresses) entities by [UM.COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find UM entities</param>
        /// <returns>A list of related UM entities</returns>
        public IReadOnlyList<UM> FindUMByCOUNTRY(string COUNTRY)
        {
            IReadOnlyList<UM> result;
            if (UM_COUNTRYForeignIndex.Value.TryGetValue(COUNTRY, out result))
            {
                return result;
            }
            else
            {
                return new List<UM>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all UM entities by [UM.COUNTRY]-&gt;[KGT.COUNTRY]
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find UM entities</param>
        /// <param name="Value">A list of related UM entities</param>
        /// <returns>True if any UM entities are found</returns>
        public bool TryFindUMByCOUNTRY(string COUNTRY, out IReadOnlyList<UM> Value)
        {
            return UM_COUNTRYForeignIndex.Value.TryGetValue(COUNTRY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGT" /> fields for each CSV column header</returns>
        protected override Action<KGT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "COUNTRY":
                        mapper[i] = (e, v) => e.COUNTRY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ENGLISH_SPEAKING":
                        mapper[i] = (e, v) => e.ENGLISH_SPEAKING = v;
                        break;
                    case "SACC":
                        mapper[i] = (e, v) => e.SACC = v;
                        break;
                    case "OBSOLETE":
                        mapper[i] = (e, v) => e.OBSOLETE = v;
                        break;
                    case "REFUGEE":
                        mapper[i] = (e, v) => e.REFUGEE = v;
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_USER":
                        mapper[i] = (e, v) => e.LW_USER = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }
    }
}
