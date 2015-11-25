using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee Leave Audit Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PELADataSet : SetBase<PELA>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PELA"; } }

        internal PELADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PEKEY = new Lazy<Dictionary<string, IReadOnlyList<PELA>>>(() => this.ToGroupedDictionary(i => i.PEKEY));
            Index_TID = new Lazy<Dictionary<int, PELA>>(() => this.ToDictionary(i => i.TID));
            Index_LEAVE_CODE = new Lazy<NullDictionary<string, IReadOnlyList<PELA>>>(() => this.ToGroupedNullDictionary(i => i.LEAVE_CODE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PELA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PELA" /> fields for each CSV column header</returns>
        protected override Action<PELA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PELA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "PEKEY":
                        mapper[i] = (e, v) => e.PEKEY = v;
                        break;
                    case "LEAVE_CODE":
                        mapper[i] = (e, v) => e.LEAVE_CODE = v;
                        break;
                    case "TRQTY":
                        mapper[i] = (e, v) => e.TRQTY = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "LEAVE_STARTDATE":
                        mapper[i] = (e, v) => e.LEAVE_STARTDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LAST_CALC_DATE":
                        mapper[i] = (e, v) => e.LAST_CALC_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LAST_ANNIV_DATE":
                        mapper[i] = (e, v) => e.LAST_ANNIV_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ANNIVERSARY_DATE":
                        mapper[i] = (e, v) => e.ANNIVERSARY_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LEAVE_ENT_HOURS":
                        mapper[i] = (e, v) => e.LEAVE_ENT_HOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "LEAVE_PRORATA_HOURS":
                        mapper[i] = (e, v) => e.LEAVE_PRORATA_HOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_LENGTH_STEP":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH_STEP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PENALTY_DAYS":
                        mapper[i] = (e, v) => e.PENALTY_DAYS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DATE_START":
                        mapper[i] = (e, v) => e.DATE_START = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DATE_END":
                        mapper[i] = (e, v) => e.DATE_END = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CHANGE_TYPE":
                        mapper[i] = (e, v) => e.CHANGE_TYPE = v;
                        break;
                    case "COMMENTS":
                        mapper[i] = (e, v) => e.COMMENTS = v;
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

        private Lazy<Dictionary<string, IReadOnlyList<PELA>>> Index_PEKEY;
        private Lazy<Dictionary<int, PELA>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<PELA>>> Index_LEAVE_CODE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PELA by PEKEY field
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PELA</param>
        /// <returns>List of related PELA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PELA> FindByPEKEY(string PEKEY)
        {
            return Index_PEKEY.Value[PEKEY];
        }

        /// <summary>
        /// Attempt to find PELA by PEKEY field
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PELA</param>
        /// <param name="Value">List of related PELA entities</param>
        /// <returns>True if the list of related PELA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPEKEY(string PEKEY, out IReadOnlyList<PELA> Value)
        {
            return Index_PEKEY.Value.TryGetValue(PEKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PELA by PEKEY field
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PELA</param>
        /// <returns>List of related PELA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PELA> TryFindByPEKEY(string PEKEY)
        {
            IReadOnlyList<PELA> value;
            if (Index_PEKEY.Value.TryGetValue(PEKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PELA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PELA</param>
        /// <returns>Related PELA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PELA FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PELA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PELA</param>
        /// <param name="Value">Related PELA entity</param>
        /// <returns>True if the related PELA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PELA Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PELA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PELA</param>
        /// <returns>Related PELA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PELA TryFindByTID(int TID)
        {
            PELA value;
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
        /// Find PELA by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PELA</param>
        /// <returns>List of related PELA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PELA> FindByLEAVE_CODE(string LEAVE_CODE)
        {
            return Index_LEAVE_CODE.Value[LEAVE_CODE];
        }

        /// <summary>
        /// Attempt to find PELA by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PELA</param>
        /// <param name="Value">List of related PELA entities</param>
        /// <returns>True if the list of related PELA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLEAVE_CODE(string LEAVE_CODE, out IReadOnlyList<PELA> Value)
        {
            return Index_LEAVE_CODE.Value.TryGetValue(LEAVE_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PELA by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PELA</param>
        /// <returns>List of related PELA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PELA> TryFindByLEAVE_CODE(string LEAVE_CODE)
        {
            IReadOnlyList<PELA> value;
            if (Index_LEAVE_CODE.Value.TryGetValue(LEAVE_CODE, out value))
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
