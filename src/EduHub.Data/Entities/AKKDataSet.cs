using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Key Holders Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AKKDataSet : SetBase<AKK>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "AKK"; } }

        internal AKKDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<AKK>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_TID = new Lazy<Dictionary<int, AKK>>(() => this.ToDictionary(i => i.TID));
            Index_STAFF = new Lazy<NullDictionary<string, IReadOnlyList<AKK>>>(() => this.ToGroupedNullDictionary(i => i.STAFF));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AKK" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AKK" /> fields for each CSV column header</returns>
        protected override Action<AKK, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<AKK, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "STAFF":
                        mapper[i] = (e, v) => e.STAFF = v;
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

        private Lazy<Dictionary<string, IReadOnlyList<AKK>>> Index_CODE;
        private Lazy<Dictionary<int, AKK>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<AKK>>> Index_STAFF;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find AKK by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find AKK</param>
        /// <returns>List of related AKK entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKK> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find AKK by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find AKK</param>
        /// <param name="Value">List of related AKK entities</param>
        /// <returns>True if the list of related AKK entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<AKK> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find AKK by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find AKK</param>
        /// <returns>List of related AKK entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKK> TryFindByCODE(string CODE)
        {
            IReadOnlyList<AKK> value;
            if (Index_CODE.Value.TryGetValue(CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find AKK by TID field
        /// </summary>
        /// <param name="TID">TID value used to find AKK</param>
        /// <returns>Related AKK entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKK FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find AKK by TID field
        /// </summary>
        /// <param name="TID">TID value used to find AKK</param>
        /// <param name="Value">Related AKK entity</param>
        /// <returns>True if the related AKK entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out AKK Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find AKK by TID field
        /// </summary>
        /// <param name="TID">TID value used to find AKK</param>
        /// <returns>Related AKK entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKK TryFindByTID(int TID)
        {
            AKK value;
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
        /// Find AKK by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find AKK</param>
        /// <returns>List of related AKK entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKK> FindBySTAFF(string STAFF)
        {
            return Index_STAFF.Value[STAFF];
        }

        /// <summary>
        /// Attempt to find AKK by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find AKK</param>
        /// <param name="Value">List of related AKK entities</param>
        /// <returns>True if the list of related AKK entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTAFF(string STAFF, out IReadOnlyList<AKK> Value)
        {
            return Index_STAFF.Value.TryGetValue(STAFF, out Value);
        }

        /// <summary>
        /// Attempt to find AKK by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find AKK</param>
        /// <returns>List of related AKK entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKK> TryFindBySTAFF(string STAFF)
        {
            IReadOnlyList<AKK> value;
            if (Index_STAFF.Value.TryGetValue(STAFF, out value))
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
