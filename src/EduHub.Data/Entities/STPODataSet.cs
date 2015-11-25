using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Position or Group Memberships Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STPODataSet : SetBase<STPO>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "STPO"; } }

        internal STPODataSet(EduHubContext Context)
            : base(Context)
        {
            Index_STPOKEY = new Lazy<Dictionary<string, IReadOnlyList<STPO>>>(() => this.ToGroupedDictionary(i => i.STPOKEY));
            Index_TID = new Lazy<Dictionary<int, STPO>>(() => this.ToDictionary(i => i.TID));
            Index_SGLINK = new Lazy<NullDictionary<string, IReadOnlyList<STPO>>>(() => this.ToGroupedNullDictionary(i => i.SGLINK));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STPO" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STPO" /> fields for each CSV column header</returns>
        protected override Action<STPO, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STPO, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "STPOKEY":
                        mapper[i] = (e, v) => e.STPOKEY = v;
                        break;
                    case "SGLINK":
                        mapper[i] = (e, v) => e.SGLINK = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PERFORMANCE":
                        mapper[i] = (e, v) => e.PERFORMANCE = v;
                        break;
                    case "GROUP_ROLE":
                        mapper[i] = (e, v) => e.GROUP_ROLE = v;
                        break;
                    case "OTHER":
                        mapper[i] = (e, v) => e.OTHER = v;
                        break;
                    case "SG_TYPE":
                        mapper[i] = (e, v) => e.SG_TYPE = v;
                        break;
                    case "HOUSE_HG":
                        mapper[i] = (e, v) => e.HOUSE_HG = v;
                        break;
                    case "PERMISSION":
                        mapper[i] = (e, v) => e.PERMISSION = v;
                        break;
                    case "SCH_PERMISSION":
                        mapper[i] = (e, v) => e.SCH_PERMISSION = v;
                        break;
                    case "FULLY_PAID":
                        mapper[i] = (e, v) => e.FULLY_PAID = v;
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

        private Lazy<Dictionary<string, IReadOnlyList<STPO>>> Index_STPOKEY;
        private Lazy<Dictionary<int, STPO>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<STPO>>> Index_SGLINK;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STPO by STPOKEY field
        /// </summary>
        /// <param name="STPOKEY">STPOKEY value used to find STPO</param>
        /// <returns>List of related STPO entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STPO> FindBySTPOKEY(string STPOKEY)
        {
            return Index_STPOKEY.Value[STPOKEY];
        }

        /// <summary>
        /// Attempt to find STPO by STPOKEY field
        /// </summary>
        /// <param name="STPOKEY">STPOKEY value used to find STPO</param>
        /// <param name="Value">List of related STPO entities</param>
        /// <returns>True if the list of related STPO entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTPOKEY(string STPOKEY, out IReadOnlyList<STPO> Value)
        {
            return Index_STPOKEY.Value.TryGetValue(STPOKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STPO by STPOKEY field
        /// </summary>
        /// <param name="STPOKEY">STPOKEY value used to find STPO</param>
        /// <returns>List of related STPO entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STPO> TryFindBySTPOKEY(string STPOKEY)
        {
            IReadOnlyList<STPO> value;
            if (Index_STPOKEY.Value.TryGetValue(STPOKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STPO by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STPO</param>
        /// <returns>Related STPO entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STPO FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STPO by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STPO</param>
        /// <param name="Value">Related STPO entity</param>
        /// <returns>True if the related STPO entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STPO Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STPO by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STPO</param>
        /// <returns>Related STPO entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STPO TryFindByTID(int TID)
        {
            STPO value;
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
        /// Find STPO by SGLINK field
        /// </summary>
        /// <param name="SGLINK">SGLINK value used to find STPO</param>
        /// <returns>List of related STPO entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STPO> FindBySGLINK(string SGLINK)
        {
            return Index_SGLINK.Value[SGLINK];
        }

        /// <summary>
        /// Attempt to find STPO by SGLINK field
        /// </summary>
        /// <param name="SGLINK">SGLINK value used to find STPO</param>
        /// <param name="Value">List of related STPO entities</param>
        /// <returns>True if the list of related STPO entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGLINK(string SGLINK, out IReadOnlyList<STPO> Value)
        {
            return Index_SGLINK.Value.TryGetValue(SGLINK, out Value);
        }

        /// <summary>
        /// Attempt to find STPO by SGLINK field
        /// </summary>
        /// <param name="SGLINK">SGLINK value used to find STPO</param>
        /// <returns>List of related STPO entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STPO> TryFindBySGLINK(string SGLINK)
        {
            IReadOnlyList<STPO> value;
            if (Index_SGLINK.Value.TryGetValue(SGLINK, out value))
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
