using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Merit Behaviour Details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STMBDataSet : SetBase<STMB>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "STMB"; } }

        internal STMBDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SKEY = new Lazy<Dictionary<string, IReadOnlyList<STMB>>>(() => this.ToGroupedDictionary(i => i.SKEY));
            Index_TID = new Lazy<Dictionary<int, STMB>>(() => this.ToDictionary(i => i.TID));
            Index_B_CODE = new Lazy<NullDictionary<string, IReadOnlyList<STMB>>>(() => this.ToGroupedNullDictionary(i => i.B_CODE));
            Index_AWARD = new Lazy<NullDictionary<string, IReadOnlyList<STMB>>>(() => this.ToGroupedNullDictionary(i => i.AWARD));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STMB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STMB" /> fields for each CSV column header</returns>
        protected override Action<STMB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STMB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
                        break;
                    case "B_CODE":
                        mapper[i] = (e, v) => e.B_CODE = v;
                        break;
                    case "DETAIL":
                        mapper[i] = (e, v) => e.DETAIL = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "RECOMMEND_TYPE":
                        mapper[i] = (e, v) => e.RECOMMEND_TYPE = v;
                        break;
                    case "RECOMMEND_KEY":
                        mapper[i] = (e, v) => e.RECOMMEND_KEY = v;
                        break;
                    case "RECOMMEND_DFAB":
                        mapper[i] = (e, v) => e.RECOMMEND_DFAB = v;
                        break;
                    case "RECOMMEND_OTHER":
                        mapper[i] = (e, v) => e.RECOMMEND_OTHER = v;
                        break;
                    case "AWARD":
                        mapper[i] = (e, v) => e.AWARD = v;
                        break;
                    case "STMB_COMMENT":
                        mapper[i] = (e, v) => e.STMB_COMMENT = v;
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

        private Lazy<Dictionary<string, IReadOnlyList<STMB>>> Index_SKEY;
        private Lazy<Dictionary<int, STMB>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<STMB>>> Index_B_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<STMB>>> Index_AWARD;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STMB by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STMB</param>
        /// <returns>List of related STMB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMB> FindBySKEY(string SKEY)
        {
            return Index_SKEY.Value[SKEY];
        }

        /// <summary>
        /// Attempt to find STMB by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STMB</param>
        /// <param name="Value">List of related STMB entities</param>
        /// <returns>True if the list of related STMB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySKEY(string SKEY, out IReadOnlyList<STMB> Value)
        {
            return Index_SKEY.Value.TryGetValue(SKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STMB by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STMB</param>
        /// <returns>List of related STMB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMB> TryFindBySKEY(string SKEY)
        {
            IReadOnlyList<STMB> value;
            if (Index_SKEY.Value.TryGetValue(SKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STMB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STMB</param>
        /// <returns>Related STMB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STMB FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STMB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STMB</param>
        /// <param name="Value">Related STMB entity</param>
        /// <returns>True if the related STMB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STMB Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STMB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STMB</param>
        /// <returns>Related STMB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STMB TryFindByTID(int TID)
        {
            STMB value;
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
        /// Find STMB by B_CODE field
        /// </summary>
        /// <param name="B_CODE">B_CODE value used to find STMB</param>
        /// <returns>List of related STMB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMB> FindByB_CODE(string B_CODE)
        {
            return Index_B_CODE.Value[B_CODE];
        }

        /// <summary>
        /// Attempt to find STMB by B_CODE field
        /// </summary>
        /// <param name="B_CODE">B_CODE value used to find STMB</param>
        /// <param name="Value">List of related STMB entities</param>
        /// <returns>True if the list of related STMB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByB_CODE(string B_CODE, out IReadOnlyList<STMB> Value)
        {
            return Index_B_CODE.Value.TryGetValue(B_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find STMB by B_CODE field
        /// </summary>
        /// <param name="B_CODE">B_CODE value used to find STMB</param>
        /// <returns>List of related STMB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMB> TryFindByB_CODE(string B_CODE)
        {
            IReadOnlyList<STMB> value;
            if (Index_B_CODE.Value.TryGetValue(B_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STMB by AWARD field
        /// </summary>
        /// <param name="AWARD">AWARD value used to find STMB</param>
        /// <returns>List of related STMB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMB> FindByAWARD(string AWARD)
        {
            return Index_AWARD.Value[AWARD];
        }

        /// <summary>
        /// Attempt to find STMB by AWARD field
        /// </summary>
        /// <param name="AWARD">AWARD value used to find STMB</param>
        /// <param name="Value">List of related STMB entities</param>
        /// <returns>True if the list of related STMB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAWARD(string AWARD, out IReadOnlyList<STMB> Value)
        {
            return Index_AWARD.Value.TryGetValue(AWARD, out Value);
        }

        /// <summary>
        /// Attempt to find STMB by AWARD field
        /// </summary>
        /// <param name="AWARD">AWARD value used to find STMB</param>
        /// <returns>List of related STMB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMB> TryFindByAWARD(string AWARD)
        {
            IReadOnlyList<STMB> value;
            if (Index_AWARD.Value.TryGetValue(AWARD, out value))
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
