using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accident Prevention Measures Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SADPDataSet : SetBase<SADP>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SADP"; } }

        internal SADPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ACCIDENTID = new Lazy<Dictionary<int, IReadOnlyList<SADP>>>(() => this.ToGroupedDictionary(i => i.ACCIDENTID));
            Index_TID = new Lazy<Dictionary<int, SADP>>(() => this.ToDictionary(i => i.TID));
            Index_ACCIDENTID_PREVENTION = new Lazy<Dictionary<Tuple<int, short?>, SADP>>(() => this.ToDictionary(i => Tuple.Create(i.ACCIDENTID, i.PREVENTION)));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SADP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SADP" /> fields for each CSV column header</returns>
        protected override Action<SADP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SADP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ACCIDENTID":
                        mapper[i] = (e, v) => e.ACCIDENTID = int.Parse(v);
                        break;
                    case "PREVENTION":
                        mapper[i] = (e, v) => e.PREVENTION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OTHER_PREV_INFO":
                        mapper[i] = (e, v) => e.OTHER_PREV_INFO = v;
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

        private Lazy<Dictionary<int, IReadOnlyList<SADP>>> Index_ACCIDENTID;
        private Lazy<Dictionary<int, SADP>> Index_TID;
        private Lazy<Dictionary<Tuple<int, short?>, SADP>> Index_ACCIDENTID_PREVENTION;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SADP by ACCIDENTID field
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SADP</param>
        /// <returns>List of related SADP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SADP> FindByACCIDENTID(int ACCIDENTID)
        {
            return Index_ACCIDENTID.Value[ACCIDENTID];
        }

        /// <summary>
        /// Attempt to find SADP by ACCIDENTID field
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SADP</param>
        /// <param name="Value">List of related SADP entities</param>
        /// <returns>True if the list of related SADP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByACCIDENTID(int ACCIDENTID, out IReadOnlyList<SADP> Value)
        {
            return Index_ACCIDENTID.Value.TryGetValue(ACCIDENTID, out Value);
        }

        /// <summary>
        /// Attempt to find SADP by ACCIDENTID field
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SADP</param>
        /// <returns>List of related SADP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SADP> TryFindByACCIDENTID(int ACCIDENTID)
        {
            IReadOnlyList<SADP> value;
            if (Index_ACCIDENTID.Value.TryGetValue(ACCIDENTID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SADP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SADP</param>
        /// <returns>Related SADP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SADP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SADP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SADP</param>
        /// <param name="Value">Related SADP entity</param>
        /// <returns>True if the related SADP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SADP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SADP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SADP</param>
        /// <returns>Related SADP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SADP TryFindByTID(int TID)
        {
            SADP value;
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
        /// Find SADP by ACCIDENTID and PREVENTION fields
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SADP</param>
        /// <param name="PREVENTION">PREVENTION value used to find SADP</param>
        /// <returns>Related SADP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SADP FindByACCIDENTID_PREVENTION(int ACCIDENTID, short? PREVENTION)
        {
            return Index_ACCIDENTID_PREVENTION.Value[Tuple.Create(ACCIDENTID, PREVENTION)];
        }

        /// <summary>
        /// Attempt to find SADP by ACCIDENTID and PREVENTION fields
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SADP</param>
        /// <param name="PREVENTION">PREVENTION value used to find SADP</param>
        /// <param name="Value">Related SADP entity</param>
        /// <returns>True if the related SADP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByACCIDENTID_PREVENTION(int ACCIDENTID, short? PREVENTION, out SADP Value)
        {
            return Index_ACCIDENTID_PREVENTION.Value.TryGetValue(Tuple.Create(ACCIDENTID, PREVENTION), out Value);
        }

        /// <summary>
        /// Attempt to find SADP by ACCIDENTID and PREVENTION fields
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SADP</param>
        /// <param name="PREVENTION">PREVENTION value used to find SADP</param>
        /// <returns>Related SADP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SADP TryFindByACCIDENTID_PREVENTION(int ACCIDENTID, short? PREVENTION)
        {
            SADP value;
            if (Index_ACCIDENTID_PREVENTION.Value.TryGetValue(Tuple.Create(ACCIDENTID, PREVENTION), out value))
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
