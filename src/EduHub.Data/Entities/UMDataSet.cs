using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Addresses Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class UMDataSet : SetBase<UM>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "UM"; } }

        internal UMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_UMKEY = new Lazy<Dictionary<int, UM>>(() => this.ToDictionary(i => i.UMKEY));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<UM>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_COUNTRY = new Lazy<NullDictionary<string, IReadOnlyList<UM>>>(() => this.ToGroupedNullDictionary(i => i.COUNTRY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="UM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="UM" /> fields for each CSV column header</returns>
        protected override Action<UM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<UM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "UMKEY":
                        mapper[i] = (e, v) => e.UMKEY = int.Parse(v);
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "ADDRESS03":
                        mapper[i] = (e, v) => e.ADDRESS03 = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "SILENT":
                        mapper[i] = (e, v) => e.SILENT = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "KAP_LINK":
                        mapper[i] = (e, v) => e.KAP_LINK = v;
                        break;
                    case "COUNTRY":
                        mapper[i] = (e, v) => e.COUNTRY = v;
                        break;
                    case "DPID":
                        mapper[i] = (e, v) => e.DPID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BARCODE":
                        mapper[i] = (e, v) => e.BARCODE = v;
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

        private Lazy<Dictionary<int, UM>> Index_UMKEY;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<UM>>> Index_LW_DATE;
        private Lazy<NullDictionary<string, IReadOnlyList<UM>>> Index_COUNTRY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find UM by UMKEY field
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find UM</param>
        /// <returns>Related UM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public UM FindByUMKEY(int UMKEY)
        {
            return Index_UMKEY.Value[UMKEY];
        }

        /// <summary>
        /// Attempt to find UM by UMKEY field
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find UM</param>
        /// <param name="Value">Related UM entity</param>
        /// <returns>True if the related UM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByUMKEY(int UMKEY, out UM Value)
        {
            return Index_UMKEY.Value.TryGetValue(UMKEY, out Value);
        }

        /// <summary>
        /// Attempt to find UM by UMKEY field
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find UM</param>
        /// <returns>Related UM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public UM TryFindByUMKEY(int UMKEY)
        {
            UM value;
            if (Index_UMKEY.Value.TryGetValue(UMKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find UM by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find UM</param>
        /// <returns>List of related UM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<UM> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find UM by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find UM</param>
        /// <param name="Value">List of related UM entities</param>
        /// <returns>True if the list of related UM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<UM> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find UM by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find UM</param>
        /// <returns>List of related UM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<UM> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<UM> value;
            if (Index_LW_DATE.Value.TryGetValue(LW_DATE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find UM by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find UM</param>
        /// <returns>List of related UM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<UM> FindByCOUNTRY(string COUNTRY)
        {
            return Index_COUNTRY.Value[COUNTRY];
        }

        /// <summary>
        /// Attempt to find UM by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find UM</param>
        /// <param name="Value">List of related UM entities</param>
        /// <returns>True if the list of related UM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOUNTRY(string COUNTRY, out IReadOnlyList<UM> Value)
        {
            return Index_COUNTRY.Value.TryGetValue(COUNTRY, out Value);
        }

        /// <summary>
        /// Attempt to find UM by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find UM</param>
        /// <returns>List of related UM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<UM> TryFindByCOUNTRY(string COUNTRY)
        {
            IReadOnlyList<UM> value;
            if (Index_COUNTRY.Value.TryGetValue(COUNTRY, out value))
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
