using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// KCD Transfer Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCD_TFRDataSet : SetBase<KCD_TFR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCD_TFR"; } }

        internal KCD_TFRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ORIG_SCHOOL = new Lazy<Dictionary<string, IReadOnlyList<KCD_TFR>>>(() => this.ToGroupedDictionary(i => i.ORIG_SCHOOL));
            Index_TID = new Lazy<Dictionary<int, KCD_TFR>>(() => this.ToDictionary(i => i.TID));
            Index_KCD_TRANS_ID = new Lazy<NullDictionary<string, KCD_TFR>>(() => this.ToNullDictionary(i => i.KCD_TRANS_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCD_TFR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCD_TFR" /> fields for each CSV column header</returns>
        protected override Action<KCD_TFR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCD_TFR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ORIG_SCHOOL":
                        mapper[i] = (e, v) => e.ORIG_SCHOOL = v;
                        break;
                    case "KCD_TRANS_ID":
                        mapper[i] = (e, v) => e.KCD_TRANS_ID = v;
                        break;
                    case "KCDKEY":
                        mapper[i] = (e, v) => e.KCDKEY = v;
                        break;
                    case "KCDKEY_NEW":
                        mapper[i] = (e, v) => e.KCDKEY_NEW = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "DR_GROUP":
                        mapper[i] = (e, v) => e.DR_GROUP = v;
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "SUBURB":
                        mapper[i] = (e, v) => e.SUBURB = v;
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
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "KAP_LINK":
                        mapper[i] = (e, v) => e.KAP_LINK = v;
                        break;
                    case "KAP_LINK_NEW":
                        mapper[i] = (e, v) => e.KAP_LINK_NEW = v;
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

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<KCD_TFR>>> Index_ORIG_SCHOOL;
        private Lazy<Dictionary<int, KCD_TFR>> Index_TID;
        private Lazy<NullDictionary<string, KCD_TFR>> Index_KCD_TRANS_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCD_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find KCD_TFR</param>
        /// <returns>List of related KCD_TFR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCD_TFR> FindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            return Index_ORIG_SCHOOL.Value[ORIG_SCHOOL];
        }

        /// <summary>
        /// Attempt to find KCD_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find KCD_TFR</param>
        /// <param name="Value">List of related KCD_TFR entities</param>
        /// <returns>True if the list of related KCD_TFR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByORIG_SCHOOL(string ORIG_SCHOOL, out IReadOnlyList<KCD_TFR> Value)
        {
            return Index_ORIG_SCHOOL.Value.TryGetValue(ORIG_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find KCD_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find KCD_TFR</param>
        /// <returns>List of related KCD_TFR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCD_TFR> TryFindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            IReadOnlyList<KCD_TFR> value;
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
        /// Find KCD_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KCD_TFR</param>
        /// <returns>Related KCD_TFR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCD_TFR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find KCD_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KCD_TFR</param>
        /// <param name="Value">Related KCD_TFR entity</param>
        /// <returns>True if the related KCD_TFR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out KCD_TFR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find KCD_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KCD_TFR</param>
        /// <returns>Related KCD_TFR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCD_TFR TryFindByTID(int TID)
        {
            KCD_TFR value;
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
        /// Find KCD_TFR by KCD_TRANS_ID field
        /// </summary>
        /// <param name="KCD_TRANS_ID">KCD_TRANS_ID value used to find KCD_TFR</param>
        /// <returns>Related KCD_TFR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCD_TFR FindByKCD_TRANS_ID(string KCD_TRANS_ID)
        {
            return Index_KCD_TRANS_ID.Value[KCD_TRANS_ID];
        }

        /// <summary>
        /// Attempt to find KCD_TFR by KCD_TRANS_ID field
        /// </summary>
        /// <param name="KCD_TRANS_ID">KCD_TRANS_ID value used to find KCD_TFR</param>
        /// <param name="Value">Related KCD_TFR entity</param>
        /// <returns>True if the related KCD_TFR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKCD_TRANS_ID(string KCD_TRANS_ID, out KCD_TFR Value)
        {
            return Index_KCD_TRANS_ID.Value.TryGetValue(KCD_TRANS_ID, out Value);
        }

        /// <summary>
        /// Attempt to find KCD_TFR by KCD_TRANS_ID field
        /// </summary>
        /// <param name="KCD_TRANS_ID">KCD_TRANS_ID value used to find KCD_TFR</param>
        /// <returns>Related KCD_TFR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCD_TFR TryFindByKCD_TRANS_ID(string KCD_TRANS_ID)
        {
            KCD_TFR value;
            if (Index_KCD_TRANS_ID.Value.TryGetValue(KCD_TRANS_ID, out value))
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
