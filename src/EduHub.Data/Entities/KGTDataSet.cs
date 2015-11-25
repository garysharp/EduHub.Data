using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Countries Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGTDataSet : SetBase<KGT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGT"; } }

        internal KGTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_COUNTRY = new Lazy<Dictionary<string, KGT>>(() => this.ToDictionary(i => i.COUNTRY));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<KGT>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
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

        #region Index Fields

        private Lazy<Dictionary<string, KGT>> Index_COUNTRY;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<KGT>>> Index_LW_DATE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGT by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find KGT</param>
        /// <returns>Related KGT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGT FindByCOUNTRY(string COUNTRY)
        {
            return Index_COUNTRY.Value[COUNTRY];
        }

        /// <summary>
        /// Attempt to find KGT by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find KGT</param>
        /// <param name="Value">Related KGT entity</param>
        /// <returns>True if the related KGT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOUNTRY(string COUNTRY, out KGT Value)
        {
            return Index_COUNTRY.Value.TryGetValue(COUNTRY, out Value);
        }

        /// <summary>
        /// Attempt to find KGT by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find KGT</param>
        /// <returns>Related KGT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGT TryFindByCOUNTRY(string COUNTRY)
        {
            KGT value;
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
        /// Find KGT by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KGT</param>
        /// <returns>List of related KGT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGT> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find KGT by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KGT</param>
        /// <param name="Value">List of related KGT entities</param>
        /// <returns>True if the list of related KGT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<KGT> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find KGT by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KGT</param>
        /// <returns>List of related KGT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGT> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<KGT> value;
            if (Index_LW_DATE.Value.TryGetValue(LW_DATE, out value))
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
