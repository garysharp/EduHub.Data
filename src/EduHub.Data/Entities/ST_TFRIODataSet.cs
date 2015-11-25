using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Data Transfer Table Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class ST_TFRIODataSet : SetBase<ST_TFRIO>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "ST_TFRIO"; } }

        internal ST_TFRIODataSet(EduHubContext Context)
            : base(Context)
        {
            Index_DEST_SCHOOL = new Lazy<Dictionary<string, IReadOnlyList<ST_TFRIO>>>(() => this.ToGroupedDictionary(i => i.DEST_SCHOOL));
            Index_TID = new Lazy<Dictionary<int, ST_TFRIO>>(() => this.ToDictionary(i => i.TID));
            Index_ST_TRANS_ID = new Lazy<NullDictionary<string, ST_TFRIO>>(() => this.ToNullDictionary(i => i.ST_TRANS_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="ST_TFRIO" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="ST_TFRIO" /> fields for each CSV column header</returns>
        protected override Action<ST_TFRIO, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<ST_TFRIO, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ST_TRANS_ID":
                        mapper[i] = (e, v) => e.ST_TRANS_ID = v;
                        break;
                    case "STKEY":
                        mapper[i] = (e, v) => e.STKEY = v;
                        break;
                    case "STKEY_NEW":
                        mapper[i] = (e, v) => e.STKEY_NEW = v;
                        break;
                    case "REGISTRATION":
                        mapper[i] = (e, v) => e.REGISTRATION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TFR_PERMISSION":
                        mapper[i] = (e, v) => e.TFR_PERMISSION = v;
                        break;
                    case "SOURCE_SCHOOL":
                        mapper[i] = (e, v) => e.SOURCE_SCHOOL = v;
                        break;
                    case "DEST_SCHOOL":
                        mapper[i] = (e, v) => e.DEST_SCHOOL = v;
                        break;
                    case "RECD_AT_DEST":
                        mapper[i] = (e, v) => e.RECD_AT_DEST = v;
                        break;
                    case "TFR_STATUS":
                        mapper[i] = (e, v) => e.TFR_STATUS = v;
                        break;
                    case "TFR_DATE":
                        mapper[i] = (e, v) => e.TFR_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TFR_COMMENT":
                        mapper[i] = (e, v) => e.TFR_COMMENT = v;
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

        private Lazy<Dictionary<string, IReadOnlyList<ST_TFRIO>>> Index_DEST_SCHOOL;
        private Lazy<Dictionary<int, ST_TFRIO>> Index_TID;
        private Lazy<NullDictionary<string, ST_TFRIO>> Index_ST_TRANS_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find ST_TFRIO by DEST_SCHOOL field
        /// </summary>
        /// <param name="DEST_SCHOOL">DEST_SCHOOL value used to find ST_TFRIO</param>
        /// <returns>List of related ST_TFRIO entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST_TFRIO> FindByDEST_SCHOOL(string DEST_SCHOOL)
        {
            return Index_DEST_SCHOOL.Value[DEST_SCHOOL];
        }

        /// <summary>
        /// Attempt to find ST_TFRIO by DEST_SCHOOL field
        /// </summary>
        /// <param name="DEST_SCHOOL">DEST_SCHOOL value used to find ST_TFRIO</param>
        /// <param name="Value">List of related ST_TFRIO entities</param>
        /// <returns>True if the list of related ST_TFRIO entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDEST_SCHOOL(string DEST_SCHOOL, out IReadOnlyList<ST_TFRIO> Value)
        {
            return Index_DEST_SCHOOL.Value.TryGetValue(DEST_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find ST_TFRIO by DEST_SCHOOL field
        /// </summary>
        /// <param name="DEST_SCHOOL">DEST_SCHOOL value used to find ST_TFRIO</param>
        /// <returns>List of related ST_TFRIO entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST_TFRIO> TryFindByDEST_SCHOOL(string DEST_SCHOOL)
        {
            IReadOnlyList<ST_TFRIO> value;
            if (Index_DEST_SCHOOL.Value.TryGetValue(DEST_SCHOOL, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST_TFRIO by TID field
        /// </summary>
        /// <param name="TID">TID value used to find ST_TFRIO</param>
        /// <returns>Related ST_TFRIO entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public ST_TFRIO FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find ST_TFRIO by TID field
        /// </summary>
        /// <param name="TID">TID value used to find ST_TFRIO</param>
        /// <param name="Value">Related ST_TFRIO entity</param>
        /// <returns>True if the related ST_TFRIO entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out ST_TFRIO Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find ST_TFRIO by TID field
        /// </summary>
        /// <param name="TID">TID value used to find ST_TFRIO</param>
        /// <returns>Related ST_TFRIO entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public ST_TFRIO TryFindByTID(int TID)
        {
            ST_TFRIO value;
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
        /// Find ST_TFRIO by ST_TRANS_ID field
        /// </summary>
        /// <param name="ST_TRANS_ID">ST_TRANS_ID value used to find ST_TFRIO</param>
        /// <returns>Related ST_TFRIO entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public ST_TFRIO FindByST_TRANS_ID(string ST_TRANS_ID)
        {
            return Index_ST_TRANS_ID.Value[ST_TRANS_ID];
        }

        /// <summary>
        /// Attempt to find ST_TFRIO by ST_TRANS_ID field
        /// </summary>
        /// <param name="ST_TRANS_ID">ST_TRANS_ID value used to find ST_TFRIO</param>
        /// <param name="Value">Related ST_TFRIO entity</param>
        /// <returns>True if the related ST_TFRIO entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByST_TRANS_ID(string ST_TRANS_ID, out ST_TFRIO Value)
        {
            return Index_ST_TRANS_ID.Value.TryGetValue(ST_TRANS_ID, out Value);
        }

        /// <summary>
        /// Attempt to find ST_TFRIO by ST_TRANS_ID field
        /// </summary>
        /// <param name="ST_TRANS_ID">ST_TRANS_ID value used to find ST_TFRIO</param>
        /// <returns>Related ST_TFRIO entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public ST_TFRIO TryFindByST_TRANS_ID(string ST_TRANS_ID)
        {
            ST_TFRIO value;
            if (Index_ST_TRANS_ID.Value.TryGetValue(ST_TRANS_ID, out value))
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
