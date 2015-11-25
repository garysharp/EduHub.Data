using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Group Meeting Attendance Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SGMADataSet : SetBase<SGMA>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SGMA"; } }

        internal SGMADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SGMAKEY = new Lazy<Dictionary<string, IReadOnlyList<SGMA>>>(() => this.ToGroupedDictionary(i => i.SGMAKEY));
            Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION = new Lazy<Dictionary<Tuple<string, int?, string, string, string>, SGMA>>(() => this.ToDictionary(i => Tuple.Create(i.SGMAKEY, i.SGM_TID, i.MEMBER_PERSON_TYPE, i.MEMBER_LINK, i.DF_PARTICIPATION)));
            Index_TID = new Lazy<Dictionary<int, SGMA>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SGMA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SGMA" /> fields for each CSV column header</returns>
        protected override Action<SGMA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SGMA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SGMAKEY":
                        mapper[i] = (e, v) => e.SGMAKEY = v;
                        break;
                    case "SGM_TID":
                        mapper[i] = (e, v) => e.SGM_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MEMBER_PERSON_TYPE":
                        mapper[i] = (e, v) => e.MEMBER_PERSON_TYPE = v;
                        break;
                    case "MEMBER_LINK":
                        mapper[i] = (e, v) => e.MEMBER_LINK = v;
                        break;
                    case "DF_PARTICIPATION":
                        mapper[i] = (e, v) => e.DF_PARTICIPATION = v;
                        break;
                    case "ATTENDED":
                        mapper[i] = (e, v) => e.ATTENDED = v;
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
        /// Merges <see cref="SGMA" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SGMA" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SGMA" /> items to added or update the base <see cref="SGMA" /> items</param>
        /// <returns>A merged list of <see cref="SGMA" /> items</returns>
        protected override List<SGMA> ApplyDeltaItems(List<SGMA> Items, List<SGMA> DeltaItems)
        {
            Dictionary<Tuple<string, int?, string, string, string>, int> Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION = Items.ToIndexDictionary(i => Tuple.Create(i.SGMAKEY, i.SGM_TID, i.MEMBER_PERSON_TYPE, i.MEMBER_LINK, i.DF_PARTICIPATION));
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SGMA deltaItem in DeltaItems)
            {
                int index;

                if (Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION.TryGetValue(Tuple.Create(deltaItem.SGMAKEY, deltaItem.SGM_TID, deltaItem.MEMBER_PERSON_TYPE, deltaItem.MEMBER_LINK, deltaItem.DF_PARTICIPATION), out index))
                {
                    removeIndexes.Add(index);
                }
                if (Index_TID.TryGetValue(deltaItem.TID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SGMAKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<SGMA>>> Index_SGMAKEY;
        private Lazy<Dictionary<Tuple<string, int?, string, string, string>, SGMA>> Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION;
        private Lazy<Dictionary<int, SGMA>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SGMA by SGMAKEY field
        /// </summary>
        /// <param name="SGMAKEY">SGMAKEY value used to find SGMA</param>
        /// <returns>List of related SGMA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGMA> FindBySGMAKEY(string SGMAKEY)
        {
            return Index_SGMAKEY.Value[SGMAKEY];
        }

        /// <summary>
        /// Attempt to find SGMA by SGMAKEY field
        /// </summary>
        /// <param name="SGMAKEY">SGMAKEY value used to find SGMA</param>
        /// <param name="Value">List of related SGMA entities</param>
        /// <returns>True if the list of related SGMA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGMAKEY(string SGMAKEY, out IReadOnlyList<SGMA> Value)
        {
            return Index_SGMAKEY.Value.TryGetValue(SGMAKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SGMA by SGMAKEY field
        /// </summary>
        /// <param name="SGMAKEY">SGMAKEY value used to find SGMA</param>
        /// <returns>List of related SGMA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGMA> TryFindBySGMAKEY(string SGMAKEY)
        {
            IReadOnlyList<SGMA> value;
            if (Index_SGMAKEY.Value.TryGetValue(SGMAKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGMA by SGMAKEY, SGM_TID, MEMBER_PERSON_TYPE, MEMBER_LINK and DF_PARTICIPATION fields
        /// </summary>
        /// <param name="SGMAKEY">SGMAKEY value used to find SGMA</param>
        /// <param name="SGM_TID">SGM_TID value used to find SGMA</param>
        /// <param name="MEMBER_PERSON_TYPE">MEMBER_PERSON_TYPE value used to find SGMA</param>
        /// <param name="MEMBER_LINK">MEMBER_LINK value used to find SGMA</param>
        /// <param name="DF_PARTICIPATION">DF_PARTICIPATION value used to find SGMA</param>
        /// <returns>Related SGMA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGMA FindBySGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION(string SGMAKEY, int? SGM_TID, string MEMBER_PERSON_TYPE, string MEMBER_LINK, string DF_PARTICIPATION)
        {
            return Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION.Value[Tuple.Create(SGMAKEY, SGM_TID, MEMBER_PERSON_TYPE, MEMBER_LINK, DF_PARTICIPATION)];
        }

        /// <summary>
        /// Attempt to find SGMA by SGMAKEY, SGM_TID, MEMBER_PERSON_TYPE, MEMBER_LINK and DF_PARTICIPATION fields
        /// </summary>
        /// <param name="SGMAKEY">SGMAKEY value used to find SGMA</param>
        /// <param name="SGM_TID">SGM_TID value used to find SGMA</param>
        /// <param name="MEMBER_PERSON_TYPE">MEMBER_PERSON_TYPE value used to find SGMA</param>
        /// <param name="MEMBER_LINK">MEMBER_LINK value used to find SGMA</param>
        /// <param name="DF_PARTICIPATION">DF_PARTICIPATION value used to find SGMA</param>
        /// <param name="Value">Related SGMA entity</param>
        /// <returns>True if the related SGMA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION(string SGMAKEY, int? SGM_TID, string MEMBER_PERSON_TYPE, string MEMBER_LINK, string DF_PARTICIPATION, out SGMA Value)
        {
            return Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION.Value.TryGetValue(Tuple.Create(SGMAKEY, SGM_TID, MEMBER_PERSON_TYPE, MEMBER_LINK, DF_PARTICIPATION), out Value);
        }

        /// <summary>
        /// Attempt to find SGMA by SGMAKEY, SGM_TID, MEMBER_PERSON_TYPE, MEMBER_LINK and DF_PARTICIPATION fields
        /// </summary>
        /// <param name="SGMAKEY">SGMAKEY value used to find SGMA</param>
        /// <param name="SGM_TID">SGM_TID value used to find SGMA</param>
        /// <param name="MEMBER_PERSON_TYPE">MEMBER_PERSON_TYPE value used to find SGMA</param>
        /// <param name="MEMBER_LINK">MEMBER_LINK value used to find SGMA</param>
        /// <param name="DF_PARTICIPATION">DF_PARTICIPATION value used to find SGMA</param>
        /// <returns>Related SGMA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGMA TryFindBySGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION(string SGMAKEY, int? SGM_TID, string MEMBER_PERSON_TYPE, string MEMBER_LINK, string DF_PARTICIPATION)
        {
            SGMA value;
            if (Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION.Value.TryGetValue(Tuple.Create(SGMAKEY, SGM_TID, MEMBER_PERSON_TYPE, MEMBER_LINK, DF_PARTICIPATION), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGMA</param>
        /// <returns>Related SGMA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGMA FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SGMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGMA</param>
        /// <param name="Value">Related SGMA entity</param>
        /// <returns>True if the related SGMA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SGMA Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SGMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGMA</param>
        /// <returns>Related SGMA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGMA TryFindByTID(int TID)
        {
            SGMA value;
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
