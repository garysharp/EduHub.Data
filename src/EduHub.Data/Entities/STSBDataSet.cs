using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Family Invoice Allocations Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STSBDataSet : SetBase<STSB>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "STSB"; } }

        internal STSBDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SKEY = new Lazy<Dictionary<string, IReadOnlyList<STSB>>>(() => this.ToGroupedDictionary(i => i.SKEY));
            Index_TID = new Lazy<Dictionary<int, STSB>>(() => this.ToDictionary(i => i.TID));
            Index_FAMILY = new Lazy<NullDictionary<string, IReadOnlyList<STSB>>>(() => this.ToGroupedNullDictionary(i => i.FAMILY));
            Index_SPLIT_ITEM = new Lazy<NullDictionary<string, IReadOnlyList<STSB>>>(() => this.ToGroupedNullDictionary(i => i.SPLIT_ITEM));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STSB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STSB" /> fields for each CSV column header</returns>
        protected override Action<STSB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STSB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
                        break;
                    case "FAMILY":
                        mapper[i] = (e, v) => e.FAMILY = v;
                        break;
                    case "PERCENTAGE":
                        mapper[i] = (e, v) => e.PERCENTAGE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SPLIT_ITEM":
                        mapper[i] = (e, v) => e.SPLIT_ITEM = v;
                        break;
                    case "ITEM_TYPE":
                        mapper[i] = (e, v) => e.ITEM_TYPE = v;
                        break;
                    case "SPLIT_ITEM_SU":
                        mapper[i] = (e, v) => e.SPLIT_ITEM_SU = v;
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

        private Lazy<Dictionary<string, IReadOnlyList<STSB>>> Index_SKEY;
        private Lazy<Dictionary<int, STSB>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<STSB>>> Index_FAMILY;
        private Lazy<NullDictionary<string, IReadOnlyList<STSB>>> Index_SPLIT_ITEM;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STSB by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STSB</param>
        /// <returns>List of related STSB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSB> FindBySKEY(string SKEY)
        {
            return Index_SKEY.Value[SKEY];
        }

        /// <summary>
        /// Attempt to find STSB by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STSB</param>
        /// <param name="Value">List of related STSB entities</param>
        /// <returns>True if the list of related STSB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySKEY(string SKEY, out IReadOnlyList<STSB> Value)
        {
            return Index_SKEY.Value.TryGetValue(SKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STSB by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STSB</param>
        /// <returns>List of related STSB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSB> TryFindBySKEY(string SKEY)
        {
            IReadOnlyList<STSB> value;
            if (Index_SKEY.Value.TryGetValue(SKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STSB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STSB</param>
        /// <returns>Related STSB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STSB FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STSB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STSB</param>
        /// <param name="Value">Related STSB entity</param>
        /// <returns>True if the related STSB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STSB Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STSB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STSB</param>
        /// <returns>Related STSB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STSB TryFindByTID(int TID)
        {
            STSB value;
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
        /// Find STSB by FAMILY field
        /// </summary>
        /// <param name="FAMILY">FAMILY value used to find STSB</param>
        /// <returns>List of related STSB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSB> FindByFAMILY(string FAMILY)
        {
            return Index_FAMILY.Value[FAMILY];
        }

        /// <summary>
        /// Attempt to find STSB by FAMILY field
        /// </summary>
        /// <param name="FAMILY">FAMILY value used to find STSB</param>
        /// <param name="Value">List of related STSB entities</param>
        /// <returns>True if the list of related STSB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFAMILY(string FAMILY, out IReadOnlyList<STSB> Value)
        {
            return Index_FAMILY.Value.TryGetValue(FAMILY, out Value);
        }

        /// <summary>
        /// Attempt to find STSB by FAMILY field
        /// </summary>
        /// <param name="FAMILY">FAMILY value used to find STSB</param>
        /// <returns>List of related STSB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSB> TryFindByFAMILY(string FAMILY)
        {
            IReadOnlyList<STSB> value;
            if (Index_FAMILY.Value.TryGetValue(FAMILY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STSB by SPLIT_ITEM field
        /// </summary>
        /// <param name="SPLIT_ITEM">SPLIT_ITEM value used to find STSB</param>
        /// <returns>List of related STSB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSB> FindBySPLIT_ITEM(string SPLIT_ITEM)
        {
            return Index_SPLIT_ITEM.Value[SPLIT_ITEM];
        }

        /// <summary>
        /// Attempt to find STSB by SPLIT_ITEM field
        /// </summary>
        /// <param name="SPLIT_ITEM">SPLIT_ITEM value used to find STSB</param>
        /// <param name="Value">List of related STSB entities</param>
        /// <returns>True if the list of related STSB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySPLIT_ITEM(string SPLIT_ITEM, out IReadOnlyList<STSB> Value)
        {
            return Index_SPLIT_ITEM.Value.TryGetValue(SPLIT_ITEM, out Value);
        }

        /// <summary>
        /// Attempt to find STSB by SPLIT_ITEM field
        /// </summary>
        /// <param name="SPLIT_ITEM">SPLIT_ITEM value used to find STSB</param>
        /// <returns>List of related STSB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSB> TryFindBySPLIT_ITEM(string SPLIT_ITEM)
        {
            IReadOnlyList<STSB> value;
            if (Index_SPLIT_ITEM.Value.TryGetValue(SPLIT_ITEM, out value))
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
