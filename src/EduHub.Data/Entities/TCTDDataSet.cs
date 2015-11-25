using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Period Information Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TCTDDataSet : SetBase<TCTD>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TCTD"; } }

        internal TCTDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TCTDKEY = new Lazy<Dictionary<DateTime, IReadOnlyList<TCTD>>>(() => this.ToGroupedDictionary(i => i.TCTDKEY));
            Index_TID = new Lazy<Dictionary<int, TCTD>>(() => this.ToDictionary(i => i.TID));
            Index_QKEY = new Lazy<NullDictionary<string, IReadOnlyList<TCTD>>>(() => this.ToGroupedNullDictionary(i => i.QKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TCTD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TCTD" /> fields for each CSV column header</returns>
        protected override Action<TCTD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TCTD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "TCTDKEY":
                        mapper[i] = (e, v) => e.TCTDKEY = DateTime.Parse(v);
                        break;
                    case "QKEY":
                        mapper[i] = (e, v) => e.QKEY = v;
                        break;
                    case "TIME_INDEX":
                        mapper[i] = (e, v) => e.TIME_INDEX = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TIME_START":
                        mapper[i] = (e, v) => e.TIME_START = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TIME_END":
                        mapper[i] = (e, v) => e.TIME_END = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TIME_TYPE":
                        mapper[i] = (e, v) => e.TIME_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TIME_NAME":
                        mapper[i] = (e, v) => e.TIME_NAME = v;
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

        private Lazy<Dictionary<DateTime, IReadOnlyList<TCTD>>> Index_TCTDKEY;
        private Lazy<Dictionary<int, TCTD>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<TCTD>>> Index_QKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TCTD by TCTDKEY field
        /// </summary>
        /// <param name="TCTDKEY">TCTDKEY value used to find TCTD</param>
        /// <returns>List of related TCTD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTD> FindByTCTDKEY(DateTime TCTDKEY)
        {
            return Index_TCTDKEY.Value[TCTDKEY];
        }

        /// <summary>
        /// Attempt to find TCTD by TCTDKEY field
        /// </summary>
        /// <param name="TCTDKEY">TCTDKEY value used to find TCTD</param>
        /// <param name="Value">List of related TCTD entities</param>
        /// <returns>True if the list of related TCTD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTCTDKEY(DateTime TCTDKEY, out IReadOnlyList<TCTD> Value)
        {
            return Index_TCTDKEY.Value.TryGetValue(TCTDKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TCTD by TCTDKEY field
        /// </summary>
        /// <param name="TCTDKEY">TCTDKEY value used to find TCTD</param>
        /// <returns>List of related TCTD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTD> TryFindByTCTDKEY(DateTime TCTDKEY)
        {
            IReadOnlyList<TCTD> value;
            if (Index_TCTDKEY.Value.TryGetValue(TCTDKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTD by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TCTD</param>
        /// <returns>Related TCTD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TCTD FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TCTD by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TCTD</param>
        /// <param name="Value">Related TCTD entity</param>
        /// <returns>True if the related TCTD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TCTD Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TCTD by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TCTD</param>
        /// <returns>Related TCTD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TCTD TryFindByTID(int TID)
        {
            TCTD value;
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
        /// Find TCTD by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find TCTD</param>
        /// <returns>List of related TCTD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTD> FindByQKEY(string QKEY)
        {
            return Index_QKEY.Value[QKEY];
        }

        /// <summary>
        /// Attempt to find TCTD by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find TCTD</param>
        /// <param name="Value">List of related TCTD entities</param>
        /// <returns>True if the list of related TCTD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByQKEY(string QKEY, out IReadOnlyList<TCTD> Value)
        {
            return Index_QKEY.Value.TryGetValue(QKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TCTD by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find TCTD</param>
        /// <returns>List of related TCTD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTD> TryFindByQKEY(string QKEY)
        {
            IReadOnlyList<TCTD> value;
            if (Index_QKEY.Value.TryGetValue(QKEY, out value))
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
