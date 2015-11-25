using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Room Availability in Quilt Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SMAQDataSet : SetBase<SMAQ>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SMAQ"; } }

        internal SMAQDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SMAQKEY = new Lazy<Dictionary<string, IReadOnlyList<SMAQ>>>(() => this.ToGroupedDictionary(i => i.SMAQKEY));
            Index_TID = new Lazy<Dictionary<int, SMAQ>>(() => this.ToDictionary(i => i.TID));
            Index_QKEY = new Lazy<NullDictionary<string, IReadOnlyList<SMAQ>>>(() => this.ToGroupedNullDictionary(i => i.QKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SMAQ" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SMAQ" /> fields for each CSV column header</returns>
        protected override Action<SMAQ, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SMAQ, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SMAQKEY":
                        mapper[i] = (e, v) => e.SMAQKEY = v;
                        break;
                    case "QKEY":
                        mapper[i] = (e, v) => e.QKEY = v;
                        break;
                    case "DAY_NUMBER":
                        mapper[i] = (e, v) => e.DAY_NUMBER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "START_PERIOD":
                        mapper[i] = (e, v) => e.START_PERIOD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "END_PERIOD":
                        mapper[i] = (e, v) => e.END_PERIOD = v == null ? (short?)null : short.Parse(v);
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

        private Lazy<Dictionary<string, IReadOnlyList<SMAQ>>> Index_SMAQKEY;
        private Lazy<Dictionary<int, SMAQ>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<SMAQ>>> Index_QKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SMAQ by SMAQKEY field
        /// </summary>
        /// <param name="SMAQKEY">SMAQKEY value used to find SMAQ</param>
        /// <returns>List of related SMAQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMAQ> FindBySMAQKEY(string SMAQKEY)
        {
            return Index_SMAQKEY.Value[SMAQKEY];
        }

        /// <summary>
        /// Attempt to find SMAQ by SMAQKEY field
        /// </summary>
        /// <param name="SMAQKEY">SMAQKEY value used to find SMAQ</param>
        /// <param name="Value">List of related SMAQ entities</param>
        /// <returns>True if the list of related SMAQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySMAQKEY(string SMAQKEY, out IReadOnlyList<SMAQ> Value)
        {
            return Index_SMAQKEY.Value.TryGetValue(SMAQKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SMAQ by SMAQKEY field
        /// </summary>
        /// <param name="SMAQKEY">SMAQKEY value used to find SMAQ</param>
        /// <returns>List of related SMAQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMAQ> TryFindBySMAQKEY(string SMAQKEY)
        {
            IReadOnlyList<SMAQ> value;
            if (Index_SMAQKEY.Value.TryGetValue(SMAQKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SMAQ by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMAQ</param>
        /// <returns>Related SMAQ entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMAQ FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SMAQ by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMAQ</param>
        /// <param name="Value">Related SMAQ entity</param>
        /// <returns>True if the related SMAQ entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SMAQ Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SMAQ by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMAQ</param>
        /// <returns>Related SMAQ entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMAQ TryFindByTID(int TID)
        {
            SMAQ value;
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
        /// Find SMAQ by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find SMAQ</param>
        /// <returns>List of related SMAQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMAQ> FindByQKEY(string QKEY)
        {
            return Index_QKEY.Value[QKEY];
        }

        /// <summary>
        /// Attempt to find SMAQ by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find SMAQ</param>
        /// <param name="Value">List of related SMAQ entities</param>
        /// <returns>True if the list of related SMAQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByQKEY(string QKEY, out IReadOnlyList<SMAQ> Value)
        {
            return Index_QKEY.Value.TryGetValue(QKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SMAQ by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find SMAQ</param>
        /// <returns>List of related SMAQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMAQ> TryFindByQKEY(string QKEY)
        {
            IReadOnlyList<SMAQ> value;
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
