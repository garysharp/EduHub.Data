using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// PAYG Supplier Details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PPSDataSet : SetBase<PPS>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PPS"; } }

        internal PPSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PPSKEY = new Lazy<Dictionary<string, PPS>>(() => this.ToDictionary(i => i.PPSKEY));
            Index_COUNTRY = new Lazy<NullDictionary<string, IReadOnlyList<PPS>>>(() => this.ToGroupedNullDictionary(i => i.COUNTRY));
            Index_POSTAL_COUNTRY = new Lazy<NullDictionary<string, IReadOnlyList<PPS>>>(() => this.ToGroupedNullDictionary(i => i.POSTAL_COUNTRY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PPS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PPS" /> fields for each CSV column header</returns>
        protected override Action<PPS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PPS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PPSKEY":
                        mapper[i] = (e, v) => e.PPSKEY = v;
                        break;
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
                        break;
                    case "NAME":
                        mapper[i] = (e, v) => e.NAME = v;
                        break;
                    case "CONTACT_NAME":
                        mapper[i] = (e, v) => e.CONTACT_NAME = v;
                        break;
                    case "CONTACT_PHONE":
                        mapper[i] = (e, v) => e.CONTACT_PHONE = v;
                        break;
                    case "FACSIMILE":
                        mapper[i] = (e, v) => e.FACSIMILE = v;
                        break;
                    case "FILE_REFERENCE":
                        mapper[i] = (e, v) => e.FILE_REFERENCE = v;
                        break;
                    case "L1_ADDRESS":
                        mapper[i] = (e, v) => e.L1_ADDRESS = v;
                        break;
                    case "L2_ADDRESS":
                        mapper[i] = (e, v) => e.L2_ADDRESS = v;
                        break;
                    case "SUBURB":
                        mapper[i] = (e, v) => e.SUBURB = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "COUNTRY":
                        mapper[i] = (e, v) => e.COUNTRY = v;
                        break;
                    case "POSTAL_L1_ADD":
                        mapper[i] = (e, v) => e.POSTAL_L1_ADD = v;
                        break;
                    case "POSTAL_L2_ADD":
                        mapper[i] = (e, v) => e.POSTAL_L2_ADD = v;
                        break;
                    case "POSTAL_SUBURB":
                        mapper[i] = (e, v) => e.POSTAL_SUBURB = v;
                        break;
                    case "POSTAL_STATE":
                        mapper[i] = (e, v) => e.POSTAL_STATE = v;
                        break;
                    case "POSTAL_POSTCODE":
                        mapper[i] = (e, v) => e.POSTAL_POSTCODE = v;
                        break;
                    case "POSTAL_COUNTRY":
                        mapper[i] = (e, v) => e.POSTAL_COUNTRY = v;
                        break;
                    case "EMAIL_ADDRESS":
                        mapper[i] = (e, v) => e.EMAIL_ADDRESS = v;
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

        #region Index Fields

        private Lazy<Dictionary<string, PPS>> Index_PPSKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<PPS>>> Index_COUNTRY;
        private Lazy<NullDictionary<string, IReadOnlyList<PPS>>> Index_POSTAL_COUNTRY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PPS by PPSKEY field
        /// </summary>
        /// <param name="PPSKEY">PPSKEY value used to find PPS</param>
        /// <returns>Related PPS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PPS FindByPPSKEY(string PPSKEY)
        {
            return Index_PPSKEY.Value[PPSKEY];
        }

        /// <summary>
        /// Attempt to find PPS by PPSKEY field
        /// </summary>
        /// <param name="PPSKEY">PPSKEY value used to find PPS</param>
        /// <param name="Value">Related PPS entity</param>
        /// <returns>True if the related PPS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPPSKEY(string PPSKEY, out PPS Value)
        {
            return Index_PPSKEY.Value.TryGetValue(PPSKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PPS by PPSKEY field
        /// </summary>
        /// <param name="PPSKEY">PPSKEY value used to find PPS</param>
        /// <returns>Related PPS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PPS TryFindByPPSKEY(string PPSKEY)
        {
            PPS value;
            if (Index_PPSKEY.Value.TryGetValue(PPSKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PPS by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PPS</param>
        /// <returns>List of related PPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PPS> FindByCOUNTRY(string COUNTRY)
        {
            return Index_COUNTRY.Value[COUNTRY];
        }

        /// <summary>
        /// Attempt to find PPS by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PPS</param>
        /// <param name="Value">List of related PPS entities</param>
        /// <returns>True if the list of related PPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOUNTRY(string COUNTRY, out IReadOnlyList<PPS> Value)
        {
            return Index_COUNTRY.Value.TryGetValue(COUNTRY, out Value);
        }

        /// <summary>
        /// Attempt to find PPS by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PPS</param>
        /// <returns>List of related PPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PPS> TryFindByCOUNTRY(string COUNTRY)
        {
            IReadOnlyList<PPS> value;
            if (Index_COUNTRY.Value.TryGetValue(COUNTRY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PPS by POSTAL_COUNTRY field
        /// </summary>
        /// <param name="POSTAL_COUNTRY">POSTAL_COUNTRY value used to find PPS</param>
        /// <returns>List of related PPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PPS> FindByPOSTAL_COUNTRY(string POSTAL_COUNTRY)
        {
            return Index_POSTAL_COUNTRY.Value[POSTAL_COUNTRY];
        }

        /// <summary>
        /// Attempt to find PPS by POSTAL_COUNTRY field
        /// </summary>
        /// <param name="POSTAL_COUNTRY">POSTAL_COUNTRY value used to find PPS</param>
        /// <param name="Value">List of related PPS entities</param>
        /// <returns>True if the list of related PPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPOSTAL_COUNTRY(string POSTAL_COUNTRY, out IReadOnlyList<PPS> Value)
        {
            return Index_POSTAL_COUNTRY.Value.TryGetValue(POSTAL_COUNTRY, out Value);
        }

        /// <summary>
        /// Attempt to find PPS by POSTAL_COUNTRY field
        /// </summary>
        /// <param name="POSTAL_COUNTRY">POSTAL_COUNTRY value used to find PPS</param>
        /// <returns>List of related PPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PPS> TryFindByPOSTAL_COUNTRY(string POSTAL_COUNTRY)
        {
            IReadOnlyList<PPS> value;
            if (Index_POSTAL_COUNTRY.Value.TryGetValue(POSTAL_COUNTRY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        #endregion

    }
}
