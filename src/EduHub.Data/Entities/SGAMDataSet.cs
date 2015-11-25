using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Adult Group Members Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SGAMDataSet : SetBase<SGAM>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SGAM"; } }

        internal SGAMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SGAMKEY = new Lazy<Dictionary<string, IReadOnlyList<SGAM>>>(() => this.ToGroupedDictionary(i => i.SGAMKEY));
            Index_TID = new Lazy<Dictionary<int, SGAM>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SGAM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SGAM" /> fields for each CSV column header</returns>
        protected override Action<SGAM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SGAM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SGAMKEY":
                        mapper[i] = (e, v) => e.SGAMKEY = v;
                        break;
                    case "ADULT_PERSON_TYPE":
                        mapper[i] = (e, v) => e.ADULT_PERSON_TYPE = v;
                        break;
                    case "PERSON_LINK":
                        mapper[i] = (e, v) => e.PERSON_LINK = v;
                        break;
                    case "DF_PARTICIPATION":
                        mapper[i] = (e, v) => e.DF_PARTICIPATION = v;
                        break;
                    case "RESPONSIBLE":
                        mapper[i] = (e, v) => e.RESPONSIBLE = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "OTHER_COMMENTS":
                        mapper[i] = (e, v) => e.OTHER_COMMENTS = v;
                        break;
                    case "GROUP_ROLE":
                        mapper[i] = (e, v) => e.GROUP_ROLE = v;
                        break;
                    case "SG_TYPE":
                        mapper[i] = (e, v) => e.SG_TYPE = v;
                        break;
                    case "HOUSE_HG":
                        mapper[i] = (e, v) => e.HOUSE_HG = v;
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

        private Lazy<Dictionary<string, IReadOnlyList<SGAM>>> Index_SGAMKEY;
        private Lazy<Dictionary<int, SGAM>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SGAM by SGAMKEY field
        /// </summary>
        /// <param name="SGAMKEY">SGAMKEY value used to find SGAM</param>
        /// <returns>List of related SGAM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGAM> FindBySGAMKEY(string SGAMKEY)
        {
            return Index_SGAMKEY.Value[SGAMKEY];
        }

        /// <summary>
        /// Attempt to find SGAM by SGAMKEY field
        /// </summary>
        /// <param name="SGAMKEY">SGAMKEY value used to find SGAM</param>
        /// <param name="Value">List of related SGAM entities</param>
        /// <returns>True if the list of related SGAM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGAMKEY(string SGAMKEY, out IReadOnlyList<SGAM> Value)
        {
            return Index_SGAMKEY.Value.TryGetValue(SGAMKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SGAM by SGAMKEY field
        /// </summary>
        /// <param name="SGAMKEY">SGAMKEY value used to find SGAM</param>
        /// <returns>List of related SGAM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGAM> TryFindBySGAMKEY(string SGAMKEY)
        {
            IReadOnlyList<SGAM> value;
            if (Index_SGAMKEY.Value.TryGetValue(SGAMKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGAM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGAM</param>
        /// <returns>Related SGAM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGAM FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SGAM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGAM</param>
        /// <param name="Value">Related SGAM entity</param>
        /// <returns>True if the related SGAM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SGAM Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SGAM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGAM</param>
        /// <returns>Related SGAM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGAM TryFindByTID(int TID)
        {
            SGAM value;
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
