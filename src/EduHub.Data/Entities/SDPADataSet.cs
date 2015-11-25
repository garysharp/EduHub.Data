using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Disciplinary Actions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SDPADataSet : SetBase<SDPA>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SDPA"; } }

        internal SDPADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SDP_STUDENT = new Lazy<Dictionary<int, IReadOnlyList<SDPA>>>(() => this.ToGroupedDictionary(i => i.SDP_STUDENT));
            Index_TID = new Lazy<Dictionary<int, SDPA>>(() => this.ToDictionary(i => i.TID));
            Index_TAKEN_BY = new Lazy<NullDictionary<string, IReadOnlyList<SDPA>>>(() => this.ToGroupedNullDictionary(i => i.TAKEN_BY));
            Index_ACTION_TAKEN = new Lazy<NullDictionary<string, IReadOnlyList<SDPA>>>(() => this.ToGroupedNullDictionary(i => i.ACTION_TAKEN));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SDPA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SDPA" /> fields for each CSV column header</returns>
        protected override Action<SDPA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SDPA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SDP_STUDENT":
                        mapper[i] = (e, v) => e.SDP_STUDENT = int.Parse(v);
                        break;
                    case "TAKEN_BY":
                        mapper[i] = (e, v) => e.TAKEN_BY = v;
                        break;
                    case "ACTION_TAKEN":
                        mapper[i] = (e, v) => e.ACTION_TAKEN = v;
                        break;
                    case "OTHER_ACTION":
                        mapper[i] = (e, v) => e.OTHER_ACTION = v;
                        break;
                    case "COMPLIED":
                        mapper[i] = (e, v) => e.COMPLIED = v;
                        break;
                    case "PARENT_INFORMED":
                        mapper[i] = (e, v) => e.PARENT_INFORMED = v;
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

        private Lazy<Dictionary<int, IReadOnlyList<SDPA>>> Index_SDP_STUDENT;
        private Lazy<Dictionary<int, SDPA>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<SDPA>>> Index_TAKEN_BY;
        private Lazy<NullDictionary<string, IReadOnlyList<SDPA>>> Index_ACTION_TAKEN;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SDPA by SDP_STUDENT field
        /// </summary>
        /// <param name="SDP_STUDENT">SDP_STUDENT value used to find SDPA</param>
        /// <returns>List of related SDPA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDPA> FindBySDP_STUDENT(int SDP_STUDENT)
        {
            return Index_SDP_STUDENT.Value[SDP_STUDENT];
        }

        /// <summary>
        /// Attempt to find SDPA by SDP_STUDENT field
        /// </summary>
        /// <param name="SDP_STUDENT">SDP_STUDENT value used to find SDPA</param>
        /// <param name="Value">List of related SDPA entities</param>
        /// <returns>True if the list of related SDPA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySDP_STUDENT(int SDP_STUDENT, out IReadOnlyList<SDPA> Value)
        {
            return Index_SDP_STUDENT.Value.TryGetValue(SDP_STUDENT, out Value);
        }

        /// <summary>
        /// Attempt to find SDPA by SDP_STUDENT field
        /// </summary>
        /// <param name="SDP_STUDENT">SDP_STUDENT value used to find SDPA</param>
        /// <returns>List of related SDPA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDPA> TryFindBySDP_STUDENT(int SDP_STUDENT)
        {
            IReadOnlyList<SDPA> value;
            if (Index_SDP_STUDENT.Value.TryGetValue(SDP_STUDENT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SDPA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SDPA</param>
        /// <returns>Related SDPA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SDPA FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SDPA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SDPA</param>
        /// <param name="Value">Related SDPA entity</param>
        /// <returns>True if the related SDPA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SDPA Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SDPA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SDPA</param>
        /// <returns>Related SDPA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SDPA TryFindByTID(int TID)
        {
            SDPA value;
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
        /// Find SDPA by TAKEN_BY field
        /// </summary>
        /// <param name="TAKEN_BY">TAKEN_BY value used to find SDPA</param>
        /// <returns>List of related SDPA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDPA> FindByTAKEN_BY(string TAKEN_BY)
        {
            return Index_TAKEN_BY.Value[TAKEN_BY];
        }

        /// <summary>
        /// Attempt to find SDPA by TAKEN_BY field
        /// </summary>
        /// <param name="TAKEN_BY">TAKEN_BY value used to find SDPA</param>
        /// <param name="Value">List of related SDPA entities</param>
        /// <returns>True if the list of related SDPA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTAKEN_BY(string TAKEN_BY, out IReadOnlyList<SDPA> Value)
        {
            return Index_TAKEN_BY.Value.TryGetValue(TAKEN_BY, out Value);
        }

        /// <summary>
        /// Attempt to find SDPA by TAKEN_BY field
        /// </summary>
        /// <param name="TAKEN_BY">TAKEN_BY value used to find SDPA</param>
        /// <returns>List of related SDPA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDPA> TryFindByTAKEN_BY(string TAKEN_BY)
        {
            IReadOnlyList<SDPA> value;
            if (Index_TAKEN_BY.Value.TryGetValue(TAKEN_BY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SDPA by ACTION_TAKEN field
        /// </summary>
        /// <param name="ACTION_TAKEN">ACTION_TAKEN value used to find SDPA</param>
        /// <returns>List of related SDPA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDPA> FindByACTION_TAKEN(string ACTION_TAKEN)
        {
            return Index_ACTION_TAKEN.Value[ACTION_TAKEN];
        }

        /// <summary>
        /// Attempt to find SDPA by ACTION_TAKEN field
        /// </summary>
        /// <param name="ACTION_TAKEN">ACTION_TAKEN value used to find SDPA</param>
        /// <param name="Value">List of related SDPA entities</param>
        /// <returns>True if the list of related SDPA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByACTION_TAKEN(string ACTION_TAKEN, out IReadOnlyList<SDPA> Value)
        {
            return Index_ACTION_TAKEN.Value.TryGetValue(ACTION_TAKEN, out Value);
        }

        /// <summary>
        /// Attempt to find SDPA by ACTION_TAKEN field
        /// </summary>
        /// <param name="ACTION_TAKEN">ACTION_TAKEN value used to find SDPA</param>
        /// <returns>List of related SDPA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDPA> TryFindByACTION_TAKEN(string ACTION_TAKEN)
        {
            IReadOnlyList<SDPA> value;
            if (Index_ACTION_TAKEN.Value.TryGetValue(ACTION_TAKEN, out value))
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
