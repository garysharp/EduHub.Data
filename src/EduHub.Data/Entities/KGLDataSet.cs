using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Languages Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGLDataSet : SetBase<KGL>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGL"; } }

        internal KGLDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KGLKEY = new Lazy<Dictionary<string, KGL>>(() => this.ToDictionary(i => i.KGLKEY));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<KGL>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGL" /> fields for each CSV column header</returns>
        protected override Action<KGL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGLKEY":
                        mapper[i] = (e, v) => e.KGLKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "NOTICES_AVAILABLE":
                        mapper[i] = (e, v) => e.NOTICES_AVAILABLE = v;
                        break;
                    case "ASCL":
                        mapper[i] = (e, v) => e.ASCL = v;
                        break;
                    case "CASESKEY":
                        mapper[i] = (e, v) => e.CASESKEY = v;
                        break;
                    case "CASES_CASES21_CONV":
                        mapper[i] = (e, v) => e.CASES_CASES21_CONV = v;
                        break;
                    case "OBSOLETE":
                        mapper[i] = (e, v) => e.OBSOLETE = v;
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

        private Lazy<Dictionary<string, KGL>> Index_KGLKEY;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<KGL>>> Index_LW_DATE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGL by KGLKEY field
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find KGL</param>
        /// <returns>Related KGL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGL FindByKGLKEY(string KGLKEY)
        {
            return Index_KGLKEY.Value[KGLKEY];
        }

        /// <summary>
        /// Attempt to find KGL by KGLKEY field
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find KGL</param>
        /// <param name="Value">Related KGL entity</param>
        /// <returns>True if the related KGL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKGLKEY(string KGLKEY, out KGL Value)
        {
            return Index_KGLKEY.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KGL by KGLKEY field
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find KGL</param>
        /// <returns>Related KGL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGL TryFindByKGLKEY(string KGLKEY)
        {
            KGL value;
            if (Index_KGLKEY.Value.TryGetValue(KGLKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KGL by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KGL</param>
        /// <returns>List of related KGL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGL> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find KGL by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KGL</param>
        /// <param name="Value">List of related KGL entities</param>
        /// <returns>True if the list of related KGL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<KGL> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find KGL by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KGL</param>
        /// <returns>List of related KGL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGL> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<KGL> value;
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
