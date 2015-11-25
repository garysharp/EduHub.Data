using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Labels Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class THTNDataSet : SetBase<THTN>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "THTN"; } }

        internal THTNDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_QKEY = new Lazy<Dictionary<string, IReadOnlyList<THTN>>>(() => this.ToGroupedDictionary(i => i.QKEY));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<THTN>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_TID = new Lazy<Dictionary<int, THTN>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="THTN" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="THTN" /> fields for each CSV column header</returns>
        protected override Action<THTN, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<THTN, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "QKEY":
                        mapper[i] = (e, v) => e.QKEY = v;
                        break;
                    case "LABEL_NUMBER":
                        mapper[i] = (e, v) => e.LABEL_NUMBER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LABEL_TYPE":
                        mapper[i] = (e, v) => e.LABEL_TYPE = v;
                        break;
                    case "LABEL_NAME":
                        mapper[i] = (e, v) => e.LABEL_NAME = v;
                        break;
                    case "LABEL_COLOUR":
                        mapper[i] = (e, v) => e.LABEL_COLOUR = v == null ? (int?)null : int.Parse(v);
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

        private Lazy<Dictionary<string, IReadOnlyList<THTN>>> Index_QKEY;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<THTN>>> Index_LW_DATE;
        private Lazy<Dictionary<int, THTN>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find THTN by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find THTN</param>
        /// <returns>List of related THTN entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTN> FindByQKEY(string QKEY)
        {
            return Index_QKEY.Value[QKEY];
        }

        /// <summary>
        /// Attempt to find THTN by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find THTN</param>
        /// <param name="Value">List of related THTN entities</param>
        /// <returns>True if the list of related THTN entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByQKEY(string QKEY, out IReadOnlyList<THTN> Value)
        {
            return Index_QKEY.Value.TryGetValue(QKEY, out Value);
        }

        /// <summary>
        /// Attempt to find THTN by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find THTN</param>
        /// <returns>List of related THTN entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTN> TryFindByQKEY(string QKEY)
        {
            IReadOnlyList<THTN> value;
            if (Index_QKEY.Value.TryGetValue(QKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find THTN by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find THTN</param>
        /// <returns>List of related THTN entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTN> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find THTN by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find THTN</param>
        /// <param name="Value">List of related THTN entities</param>
        /// <returns>True if the list of related THTN entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<THTN> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find THTN by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find THTN</param>
        /// <returns>List of related THTN entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTN> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<THTN> value;
            if (Index_LW_DATE.Value.TryGetValue(LW_DATE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find THTN by TID field
        /// </summary>
        /// <param name="TID">TID value used to find THTN</param>
        /// <returns>Related THTN entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public THTN FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find THTN by TID field
        /// </summary>
        /// <param name="TID">TID value used to find THTN</param>
        /// <param name="Value">Related THTN entity</param>
        /// <returns>True if the related THTN entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out THTN Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find THTN by TID field
        /// </summary>
        /// <param name="TID">TID value used to find THTN</param>
        /// <returns>Related THTN entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public THTN TryFindByTID(int TID)
        {
            THTN value;
            if (Index_TID.Value.TryGetValue(TID, out value))
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
