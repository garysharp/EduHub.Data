using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Sickbay Medication Administrations Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SAIMDataSet : SetBase<SAIM>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SAIM"; } }

        internal SAIMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_INVOLVEMENTID = new Lazy<Dictionary<int, IReadOnlyList<SAIM>>>(() => this.ToGroupedDictionary(i => i.INVOLVEMENTID));
            Index_TID = new Lazy<Dictionary<int, SAIM>>(() => this.ToDictionary(i => i.TID));
            Index_STAFF = new Lazy<NullDictionary<string, IReadOnlyList<SAIM>>>(() => this.ToGroupedNullDictionary(i => i.STAFF));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SAIM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SAIM" /> fields for each CSV column header</returns>
        protected override Action<SAIM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SAIM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "INVOLVEMENTID":
                        mapper[i] = (e, v) => e.INVOLVEMENTID = int.Parse(v);
                        break;
                    case "MEDICATION":
                        mapper[i] = (e, v) => e.MEDICATION = v;
                        break;
                    case "STAFF":
                        mapper[i] = (e, v) => e.STAFF = v;
                        break;
                    case "ADMIN_BY_OTHER":
                        mapper[i] = (e, v) => e.ADMIN_BY_OTHER = v;
                        break;
                    case "ADMIN_TIME":
                        mapper[i] = (e, v) => e.ADMIN_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DOSE":
                        mapper[i] = (e, v) => e.DOSE = v;
                        break;
                    case "ADMIN_NOTES":
                        mapper[i] = (e, v) => e.ADMIN_NOTES = v;
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

        private Lazy<Dictionary<int, IReadOnlyList<SAIM>>> Index_INVOLVEMENTID;
        private Lazy<Dictionary<int, SAIM>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<SAIM>>> Index_STAFF;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SAIM by INVOLVEMENTID field
        /// </summary>
        /// <param name="INVOLVEMENTID">INVOLVEMENTID value used to find SAIM</param>
        /// <returns>List of related SAIM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAIM> FindByINVOLVEMENTID(int INVOLVEMENTID)
        {
            return Index_INVOLVEMENTID.Value[INVOLVEMENTID];
        }

        /// <summary>
        /// Attempt to find SAIM by INVOLVEMENTID field
        /// </summary>
        /// <param name="INVOLVEMENTID">INVOLVEMENTID value used to find SAIM</param>
        /// <param name="Value">List of related SAIM entities</param>
        /// <returns>True if the list of related SAIM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINVOLVEMENTID(int INVOLVEMENTID, out IReadOnlyList<SAIM> Value)
        {
            return Index_INVOLVEMENTID.Value.TryGetValue(INVOLVEMENTID, out Value);
        }

        /// <summary>
        /// Attempt to find SAIM by INVOLVEMENTID field
        /// </summary>
        /// <param name="INVOLVEMENTID">INVOLVEMENTID value used to find SAIM</param>
        /// <returns>List of related SAIM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAIM> TryFindByINVOLVEMENTID(int INVOLVEMENTID)
        {
            IReadOnlyList<SAIM> value;
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
        /// Find SAIM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SAIM</param>
        /// <returns>Related SAIM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAIM FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SAIM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SAIM</param>
        /// <param name="Value">Related SAIM entity</param>
        /// <returns>True if the related SAIM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SAIM Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SAIM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SAIM</param>
        /// <returns>Related SAIM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAIM TryFindByTID(int TID)
        {
            SAIM value;
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
        /// Find SAIM by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find SAIM</param>
        /// <returns>List of related SAIM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAIM> FindBySTAFF(string STAFF)
        {
            return Index_STAFF.Value[STAFF];
        }

        /// <summary>
        /// Attempt to find SAIM by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find SAIM</param>
        /// <param name="Value">List of related SAIM entities</param>
        /// <returns>True if the list of related SAIM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTAFF(string STAFF, out IReadOnlyList<SAIM> Value)
        {
            return Index_STAFF.Value.TryGetValue(STAFF, out Value);
        }

        /// <summary>
        /// Attempt to find SAIM by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find SAIM</param>
        /// <returns>List of related SAIM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAIM> TryFindBySTAFF(string STAFF)
        {
            IReadOnlyList<SAIM> value;
            if (Index_STAFF.Value.TryGetValue(STAFF, out value))
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
