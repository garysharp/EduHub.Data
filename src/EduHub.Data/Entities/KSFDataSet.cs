using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Faculties Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KSFDataSet : SetBase<KSF>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KSF"; } }

        internal KSFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KSFKEY = new Lazy<Dictionary<string, KSF>>(() => this.ToDictionary(i => i.KSFKEY));
            Index_COORDINATOR = new Lazy<NullDictionary<string, IReadOnlyList<KSF>>>(() => this.ToGroupedNullDictionary(i => i.COORDINATOR));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KSF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KSF" /> fields for each CSV column header</returns>
        protected override Action<KSF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KSF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KSFKEY":
                        mapper[i] = (e, v) => e.KSFKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "COORDINATOR":
                        mapper[i] = (e, v) => e.COORDINATOR = v;
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

        private Lazy<Dictionary<string, KSF>> Index_KSFKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<KSF>>> Index_COORDINATOR;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KSF by KSFKEY field
        /// </summary>
        /// <param name="KSFKEY">KSFKEY value used to find KSF</param>
        /// <returns>Related KSF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSF FindByKSFKEY(string KSFKEY)
        {
            return Index_KSFKEY.Value[KSFKEY];
        }

        /// <summary>
        /// Attempt to find KSF by KSFKEY field
        /// </summary>
        /// <param name="KSFKEY">KSFKEY value used to find KSF</param>
        /// <param name="Value">Related KSF entity</param>
        /// <returns>True if the related KSF entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKSFKEY(string KSFKEY, out KSF Value)
        {
            return Index_KSFKEY.Value.TryGetValue(KSFKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KSF by KSFKEY field
        /// </summary>
        /// <param name="KSFKEY">KSFKEY value used to find KSF</param>
        /// <returns>Related KSF entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSF TryFindByKSFKEY(string KSFKEY)
        {
            KSF value;
            if (Index_KSFKEY.Value.TryGetValue(KSFKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KSF by COORDINATOR field
        /// </summary>
        /// <param name="COORDINATOR">COORDINATOR value used to find KSF</param>
        /// <returns>List of related KSF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KSF> FindByCOORDINATOR(string COORDINATOR)
        {
            return Index_COORDINATOR.Value[COORDINATOR];
        }

        /// <summary>
        /// Attempt to find KSF by COORDINATOR field
        /// </summary>
        /// <param name="COORDINATOR">COORDINATOR value used to find KSF</param>
        /// <param name="Value">List of related KSF entities</param>
        /// <returns>True if the list of related KSF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOORDINATOR(string COORDINATOR, out IReadOnlyList<KSF> Value)
        {
            return Index_COORDINATOR.Value.TryGetValue(COORDINATOR, out Value);
        }

        /// <summary>
        /// Attempt to find KSF by COORDINATOR field
        /// </summary>
        /// <param name="COORDINATOR">COORDINATOR value used to find KSF</param>
        /// <returns>List of related KSF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KSF> TryFindByCOORDINATOR(string COORDINATOR)
        {
            IReadOnlyList<KSF> value;
            if (Index_COORDINATOR.Value.TryGetValue(COORDINATOR, out value))
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
