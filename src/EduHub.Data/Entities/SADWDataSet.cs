using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accident Witnesses Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SADWDataSet : SetBase<SADW>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SADW"; } }

        internal SADWDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ACCIDENTID = new Lazy<Dictionary<int, IReadOnlyList<SADW>>>(() => this.ToGroupedDictionary(i => i.ACCIDENTID));
            Index_TID = new Lazy<Dictionary<int, SADW>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SADW" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SADW" /> fields for each CSV column header</returns>
        protected override Action<SADW, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SADW, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ACCIDENTID":
                        mapper[i] = (e, v) => e.ACCIDENTID = int.Parse(v);
                        break;
                    case "WITNESS_TYPE":
                        mapper[i] = (e, v) => e.WITNESS_TYPE = v;
                        break;
                    case "WITNESSKEY":
                        mapper[i] = (e, v) => e.WITNESSKEY = v;
                        break;
                    case "WITNESS_DFAB":
                        mapper[i] = (e, v) => e.WITNESS_DFAB = v;
                        break;
                    case "FULL_NAME":
                        mapper[i] = (e, v) => e.FULL_NAME = v;
                        break;
                    case "ADDRESS":
                        mapper[i] = (e, v) => e.ADDRESS = v;
                        break;
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "STATEMENT":
                        mapper[i] = (e, v) => e.STATEMENT = v;
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
        /// Merges <see cref="SADW" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SADW" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SADW" /> items to added or update the base <see cref="SADW" /> items</param>
        /// <returns>A merged list of <see cref="SADW" /> items</returns>
        protected override List<SADW> ApplyDeltaItems(List<SADW> Items, List<SADW> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SADW deltaItem in DeltaItems)
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
                .OrderBy(i => i.ACCIDENTID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, IReadOnlyList<SADW>>> Index_ACCIDENTID;
        private Lazy<Dictionary<int, SADW>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SADW by ACCIDENTID field
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SADW</param>
        /// <returns>List of related SADW entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SADW> FindByACCIDENTID(int ACCIDENTID)
        {
            return Index_ACCIDENTID.Value[ACCIDENTID];
        }

        /// <summary>
        /// Attempt to find SADW by ACCIDENTID field
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SADW</param>
        /// <param name="Value">List of related SADW entities</param>
        /// <returns>True if the list of related SADW entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByACCIDENTID(int ACCIDENTID, out IReadOnlyList<SADW> Value)
        {
            return Index_ACCIDENTID.Value.TryGetValue(ACCIDENTID, out Value);
        }

        /// <summary>
        /// Attempt to find SADW by ACCIDENTID field
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SADW</param>
        /// <returns>List of related SADW entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SADW> TryFindByACCIDENTID(int ACCIDENTID)
        {
            IReadOnlyList<SADW> value;
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
        /// Find SADW by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SADW</param>
        /// <returns>Related SADW entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SADW FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SADW by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SADW</param>
        /// <param name="Value">Related SADW entity</param>
        /// <returns>True if the related SADW entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SADW Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SADW by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SADW</param>
        /// <returns>Related SADW entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SADW TryFindByTID(int TID)
        {
            SADW value;
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
