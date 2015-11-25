using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Medical Conditions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCMDataSet : SetBase<KCM>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCM"; } }

        internal KCMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KCMKEY = new Lazy<Dictionary<string, KCM>>(() => this.ToDictionary(i => i.KCMKEY));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<KCM>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCM" /> fields for each CSV column header</returns>
        protected override Action<KCM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCMKEY":
                        mapper[i] = (e, v) => e.KCMKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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

        private Lazy<Dictionary<string, KCM>> Index_KCMKEY;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<KCM>>> Index_LW_DATE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCM by KCMKEY field
        /// </summary>
        /// <param name="KCMKEY">KCMKEY value used to find KCM</param>
        /// <returns>Related KCM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCM FindByKCMKEY(string KCMKEY)
        {
            return Index_KCMKEY.Value[KCMKEY];
        }

        /// <summary>
        /// Attempt to find KCM by KCMKEY field
        /// </summary>
        /// <param name="KCMKEY">KCMKEY value used to find KCM</param>
        /// <param name="Value">Related KCM entity</param>
        /// <returns>True if the related KCM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKCMKEY(string KCMKEY, out KCM Value)
        {
            return Index_KCMKEY.Value.TryGetValue(KCMKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KCM by KCMKEY field
        /// </summary>
        /// <param name="KCMKEY">KCMKEY value used to find KCM</param>
        /// <returns>Related KCM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCM TryFindByKCMKEY(string KCMKEY)
        {
            KCM value;
            if (Index_KCMKEY.Value.TryGetValue(KCMKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KCM by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KCM</param>
        /// <returns>List of related KCM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCM> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find KCM by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KCM</param>
        /// <param name="Value">List of related KCM entities</param>
        /// <returns>True if the list of related KCM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<KCM> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find KCM by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KCM</param>
        /// <returns>List of related KCM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCM> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<KCM> value;
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
