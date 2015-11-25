using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accident Involvement Injuries Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SAIIDataSet : SetBase<SAII>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SAII"; } }

        internal SAIIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_INVOLVEMENTID = new Lazy<Dictionary<int, IReadOnlyList<SAII>>>(() => this.ToGroupedDictionary(i => i.INVOLVEMENTID));
            Index_TID = new Lazy<Dictionary<int, SAII>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SAII" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SAII" /> fields for each CSV column header</returns>
        protected override Action<SAII, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SAII, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "INVOLVEMENTID":
                        mapper[i] = (e, v) => e.INVOLVEMENTID = int.Parse(v);
                        break;
                    case "SEVERITY":
                        mapper[i] = (e, v) => e.SEVERITY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SRI_TYPE":
                        mapper[i] = (e, v) => e.SRI_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NATURE":
                        mapper[i] = (e, v) => e.NATURE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OTHER_INFO":
                        mapper[i] = (e, v) => e.OTHER_INFO = v;
                        break;
                    case "LOCATION":
                        mapper[i] = (e, v) => e.LOCATION = v == null ? (short?)null : short.Parse(v);
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

        /// <summary>
        /// Merges <see cref="SAII" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SAII" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SAII" /> items to added or update the base <see cref="SAII" /> items</param>
        /// <returns>A merged list of <see cref="SAII" /> items</returns>
        protected override List<SAII> ApplyDeltaItems(List<SAII> Items, List<SAII> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SAII deltaItem in DeltaItems)
            {
                int index;

                if (Index_TID.TryGetValue(deltaItem.TID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.INVOLVEMENTID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, IReadOnlyList<SAII>>> Index_INVOLVEMENTID;
        private Lazy<Dictionary<int, SAII>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SAII by INVOLVEMENTID field
        /// </summary>
        /// <param name="INVOLVEMENTID">INVOLVEMENTID value used to find SAII</param>
        /// <returns>List of related SAII entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAII> FindByINVOLVEMENTID(int INVOLVEMENTID)
        {
            return Index_INVOLVEMENTID.Value[INVOLVEMENTID];
        }

        /// <summary>
        /// Attempt to find SAII by INVOLVEMENTID field
        /// </summary>
        /// <param name="INVOLVEMENTID">INVOLVEMENTID value used to find SAII</param>
        /// <param name="Value">List of related SAII entities</param>
        /// <returns>True if the list of related SAII entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINVOLVEMENTID(int INVOLVEMENTID, out IReadOnlyList<SAII> Value)
        {
            return Index_INVOLVEMENTID.Value.TryGetValue(INVOLVEMENTID, out Value);
        }

        /// <summary>
        /// Attempt to find SAII by INVOLVEMENTID field
        /// </summary>
        /// <param name="INVOLVEMENTID">INVOLVEMENTID value used to find SAII</param>
        /// <returns>List of related SAII entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAII> TryFindByINVOLVEMENTID(int INVOLVEMENTID)
        {
            IReadOnlyList<SAII> value;
            if (Index_INVOLVEMENTID.Value.TryGetValue(INVOLVEMENTID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAII by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SAII</param>
        /// <returns>Related SAII entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAII FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SAII by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SAII</param>
        /// <param name="Value">Related SAII entity</param>
        /// <returns>True if the related SAII entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SAII Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SAII by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SAII</param>
        /// <returns>Related SAII entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAII TryFindByTID(int TID)
        {
            SAII value;
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
