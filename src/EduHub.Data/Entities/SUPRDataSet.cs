using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject Prerequisites Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SUPRDataSet : SetBase<SUPR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SUPR"; } }

        internal SUPRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SUPRKEY = new Lazy<Dictionary<string, IReadOnlyList<SUPR>>>(() => this.ToGroupedDictionary(i => i.SUPRKEY));
            Index_TID = new Lazy<Dictionary<int, SUPR>>(() => this.ToDictionary(i => i.TID));
            Index_PREREQUISITE = new Lazy<NullDictionary<string, IReadOnlyList<SUPR>>>(() => this.ToGroupedNullDictionary(i => i.PREREQUISITE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SUPR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SUPR" /> fields for each CSV column header</returns>
        protected override Action<SUPR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SUPR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SUPRKEY":
                        mapper[i] = (e, v) => e.SUPRKEY = v;
                        break;
                    case "PREREQUISITE":
                        mapper[i] = (e, v) => e.PREREQUISITE = v;
                        break;
                    case "RESULT":
                        mapper[i] = (e, v) => e.RESULT = v;
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

        private Lazy<Dictionary<string, IReadOnlyList<SUPR>>> Index_SUPRKEY;
        private Lazy<Dictionary<int, SUPR>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<SUPR>>> Index_PREREQUISITE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SUPR by SUPRKEY field
        /// </summary>
        /// <param name="SUPRKEY">SUPRKEY value used to find SUPR</param>
        /// <returns>List of related SUPR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SUPR> FindBySUPRKEY(string SUPRKEY)
        {
            return Index_SUPRKEY.Value[SUPRKEY];
        }

        /// <summary>
        /// Attempt to find SUPR by SUPRKEY field
        /// </summary>
        /// <param name="SUPRKEY">SUPRKEY value used to find SUPR</param>
        /// <param name="Value">List of related SUPR entities</param>
        /// <returns>True if the list of related SUPR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUPRKEY(string SUPRKEY, out IReadOnlyList<SUPR> Value)
        {
            return Index_SUPRKEY.Value.TryGetValue(SUPRKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SUPR by SUPRKEY field
        /// </summary>
        /// <param name="SUPRKEY">SUPRKEY value used to find SUPR</param>
        /// <returns>List of related SUPR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SUPR> TryFindBySUPRKEY(string SUPRKEY)
        {
            IReadOnlyList<SUPR> value;
            if (Index_SUPRKEY.Value.TryGetValue(SUPRKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SUPR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SUPR</param>
        /// <returns>Related SUPR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SUPR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SUPR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SUPR</param>
        /// <param name="Value">Related SUPR entity</param>
        /// <returns>True if the related SUPR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SUPR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SUPR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SUPR</param>
        /// <returns>Related SUPR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SUPR TryFindByTID(int TID)
        {
            SUPR value;
            if (Index_TID.Value.TryGetValue(TID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SUPR by PREREQUISITE field
        /// </summary>
        /// <param name="PREREQUISITE">PREREQUISITE value used to find SUPR</param>
        /// <returns>List of related SUPR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SUPR> FindByPREREQUISITE(string PREREQUISITE)
        {
            return Index_PREREQUISITE.Value[PREREQUISITE];
        }

        /// <summary>
        /// Attempt to find SUPR by PREREQUISITE field
        /// </summary>
        /// <param name="PREREQUISITE">PREREQUISITE value used to find SUPR</param>
        /// <param name="Value">List of related SUPR entities</param>
        /// <returns>True if the list of related SUPR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPREREQUISITE(string PREREQUISITE, out IReadOnlyList<SUPR> Value)
        {
            return Index_PREREQUISITE.Value.TryGetValue(PREREQUISITE, out Value);
        }

        /// <summary>
        /// Attempt to find SUPR by PREREQUISITE field
        /// </summary>
        /// <param name="PREREQUISITE">PREREQUISITE value used to find SUPR</param>
        /// <returns>List of related SUPR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SUPR> TryFindByPREREQUISITE(string PREREQUISITE)
        {
            IReadOnlyList<SUPR> value;
            if (Index_PREREQUISITE.Value.TryGetValue(PREREQUISITE, out value))
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
