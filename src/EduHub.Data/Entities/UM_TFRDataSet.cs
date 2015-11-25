using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// UM Transfer Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class UM_TFRDataSet : SetBase<UM_TFR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "UM_TFR"; } }

        internal UM_TFRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ORIG_SCHOOL = new Lazy<Dictionary<string, IReadOnlyList<UM_TFR>>>(() => this.ToGroupedDictionary(i => i.ORIG_SCHOOL));
            Index_TID = new Lazy<Dictionary<int, UM_TFR>>(() => this.ToDictionary(i => i.TID));
            Index_UM_TRANS_ID = new Lazy<NullDictionary<string, UM_TFR>>(() => this.ToNullDictionary(i => i.UM_TRANS_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="UM_TFR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="UM_TFR" /> fields for each CSV column header</returns>
        protected override Action<UM_TFR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<UM_TFR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ORIG_SCHOOL":
                        mapper[i] = (e, v) => e.ORIG_SCHOOL = v;
                        break;
                    case "UM_TRANS_ID":
                        mapper[i] = (e, v) => e.UM_TRANS_ID = v;
                        break;
                    case "UMKEY":
                        mapper[i] = (e, v) => e.UMKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "UMKEY_NEW":
                        mapper[i] = (e, v) => e.UMKEY_NEW = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "ADDRESS03":
                        mapper[i] = (e, v) => e.ADDRESS03 = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "SILENT":
                        mapper[i] = (e, v) => e.SILENT = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "KAP_LINK":
                        mapper[i] = (e, v) => e.KAP_LINK = v;
                        break;
                    case "COUNTRY":
                        mapper[i] = (e, v) => e.COUNTRY = v;
                        break;
                    case "DPID":
                        mapper[i] = (e, v) => e.DPID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BARCODE":
                        mapper[i] = (e, v) => e.BARCODE = v;
                        break;
                    case "IMP_STATUS":
                        mapper[i] = (e, v) => e.IMP_STATUS = v;
                        break;
                    case "IMP_DATE":
                        mapper[i] = (e, v) => e.IMP_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="UM_TFR" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="UM_TFR" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="UM_TFR" /> items to added or update the base <see cref="UM_TFR" /> items</param>
        /// <returns>A merged list of <see cref="UM_TFR" /> items</returns>
        protected override List<UM_TFR> ApplyDeltaItems(List<UM_TFR> Items, List<UM_TFR> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            NullDictionary<string, int> Index_UM_TRANS_ID = Items.ToIndexNullDictionary(i => i.UM_TRANS_ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (UM_TFR deltaItem in DeltaItems)
            {
                int index;

                if (Index_TID.TryGetValue(deltaItem.TID, out index))
                {
                    removeIndexes.Add(index);
                }
                if (Index_UM_TRANS_ID.TryGetValue(deltaItem.UM_TRANS_ID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.ORIG_SCHOOL)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<UM_TFR>>> Index_ORIG_SCHOOL;
        private Lazy<Dictionary<int, UM_TFR>> Index_TID;
        private Lazy<NullDictionary<string, UM_TFR>> Index_UM_TRANS_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find UM_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find UM_TFR</param>
        /// <returns>List of related UM_TFR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<UM_TFR> FindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            return Index_ORIG_SCHOOL.Value[ORIG_SCHOOL];
        }

        /// <summary>
        /// Attempt to find UM_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find UM_TFR</param>
        /// <param name="Value">List of related UM_TFR entities</param>
        /// <returns>True if the list of related UM_TFR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByORIG_SCHOOL(string ORIG_SCHOOL, out IReadOnlyList<UM_TFR> Value)
        {
            return Index_ORIG_SCHOOL.Value.TryGetValue(ORIG_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find UM_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find UM_TFR</param>
        /// <returns>List of related UM_TFR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<UM_TFR> TryFindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            IReadOnlyList<UM_TFR> value;
            if (Index_ORIG_SCHOOL.Value.TryGetValue(ORIG_SCHOOL, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find UM_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find UM_TFR</param>
        /// <returns>Related UM_TFR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public UM_TFR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find UM_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find UM_TFR</param>
        /// <param name="Value">Related UM_TFR entity</param>
        /// <returns>True if the related UM_TFR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out UM_TFR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find UM_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find UM_TFR</param>
        /// <returns>Related UM_TFR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public UM_TFR TryFindByTID(int TID)
        {
            UM_TFR value;
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
        /// Find UM_TFR by UM_TRANS_ID field
        /// </summary>
        /// <param name="UM_TRANS_ID">UM_TRANS_ID value used to find UM_TFR</param>
        /// <returns>Related UM_TFR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public UM_TFR FindByUM_TRANS_ID(string UM_TRANS_ID)
        {
            return Index_UM_TRANS_ID.Value[UM_TRANS_ID];
        }

        /// <summary>
        /// Attempt to find UM_TFR by UM_TRANS_ID field
        /// </summary>
        /// <param name="UM_TRANS_ID">UM_TRANS_ID value used to find UM_TFR</param>
        /// <param name="Value">Related UM_TFR entity</param>
        /// <returns>True if the related UM_TFR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByUM_TRANS_ID(string UM_TRANS_ID, out UM_TFR Value)
        {
            return Index_UM_TRANS_ID.Value.TryGetValue(UM_TRANS_ID, out Value);
        }

        /// <summary>
        /// Attempt to find UM_TFR by UM_TRANS_ID field
        /// </summary>
        /// <param name="UM_TRANS_ID">UM_TRANS_ID value used to find UM_TFR</param>
        /// <returns>Related UM_TFR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public UM_TFR TryFindByUM_TRANS_ID(string UM_TRANS_ID)
        {
            UM_TFR value;
            if (Index_UM_TRANS_ID.Value.TryGetValue(UM_TRANS_ID, out value))
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
