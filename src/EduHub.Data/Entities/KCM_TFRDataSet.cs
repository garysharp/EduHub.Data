using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// KCM Transfer Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCM_TFRDataSet : SetBase<KCM_TFR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCM_TFR"; } }

        internal KCM_TFRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ORIG_SCHOOL = new Lazy<Dictionary<string, IReadOnlyList<KCM_TFR>>>(() => this.ToGroupedDictionary(i => i.ORIG_SCHOOL));
            Index_TID = new Lazy<Dictionary<int, KCM_TFR>>(() => this.ToDictionary(i => i.TID));
            Index_KCM_TRANS_ID = new Lazy<NullDictionary<string, KCM_TFR>>(() => this.ToNullDictionary(i => i.KCM_TRANS_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCM_TFR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCM_TFR" /> fields for each CSV column header</returns>
        protected override Action<KCM_TFR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCM_TFR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ORIG_SCHOOL":
                        mapper[i] = (e, v) => e.ORIG_SCHOOL = v;
                        break;
                    case "KCM_TRANS_ID":
                        mapper[i] = (e, v) => e.KCM_TRANS_ID = v;
                        break;
                    case "KCMKEY":
                        mapper[i] = (e, v) => e.KCMKEY = v;
                        break;
                    case "KCMKEY_NEW":
                        mapper[i] = (e, v) => e.KCMKEY_NEW = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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

        private Lazy<Dictionary<string, IReadOnlyList<KCM_TFR>>> Index_ORIG_SCHOOL;
        private Lazy<Dictionary<int, KCM_TFR>> Index_TID;
        private Lazy<NullDictionary<string, KCM_TFR>> Index_KCM_TRANS_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCM_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find KCM_TFR</param>
        /// <returns>List of related KCM_TFR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCM_TFR> FindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            return Index_ORIG_SCHOOL.Value[ORIG_SCHOOL];
        }

        /// <summary>
        /// Attempt to find KCM_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find KCM_TFR</param>
        /// <param name="Value">List of related KCM_TFR entities</param>
        /// <returns>True if the list of related KCM_TFR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByORIG_SCHOOL(string ORIG_SCHOOL, out IReadOnlyList<KCM_TFR> Value)
        {
            return Index_ORIG_SCHOOL.Value.TryGetValue(ORIG_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find KCM_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find KCM_TFR</param>
        /// <returns>List of related KCM_TFR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCM_TFR> TryFindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            IReadOnlyList<KCM_TFR> value;
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
        /// Find KCM_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KCM_TFR</param>
        /// <returns>Related KCM_TFR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCM_TFR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find KCM_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KCM_TFR</param>
        /// <param name="Value">Related KCM_TFR entity</param>
        /// <returns>True if the related KCM_TFR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out KCM_TFR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find KCM_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KCM_TFR</param>
        /// <returns>Related KCM_TFR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCM_TFR TryFindByTID(int TID)
        {
            KCM_TFR value;
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
        /// Find KCM_TFR by KCM_TRANS_ID field
        /// </summary>
        /// <param name="KCM_TRANS_ID">KCM_TRANS_ID value used to find KCM_TFR</param>
        /// <returns>Related KCM_TFR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCM_TFR FindByKCM_TRANS_ID(string KCM_TRANS_ID)
        {
            return Index_KCM_TRANS_ID.Value[KCM_TRANS_ID];
        }

        /// <summary>
        /// Attempt to find KCM_TFR by KCM_TRANS_ID field
        /// </summary>
        /// <param name="KCM_TRANS_ID">KCM_TRANS_ID value used to find KCM_TFR</param>
        /// <param name="Value">Related KCM_TFR entity</param>
        /// <returns>True if the related KCM_TFR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKCM_TRANS_ID(string KCM_TRANS_ID, out KCM_TFR Value)
        {
            return Index_KCM_TRANS_ID.Value.TryGetValue(KCM_TRANS_ID, out Value);
        }

        /// <summary>
        /// Attempt to find KCM_TFR by KCM_TRANS_ID field
        /// </summary>
        /// <param name="KCM_TRANS_ID">KCM_TRANS_ID value used to find KCM_TFR</param>
        /// <returns>Related KCM_TFR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCM_TFR TryFindByKCM_TRANS_ID(string KCM_TRANS_ID)
        {
            KCM_TFR value;
            if (Index_KCM_TRANS_ID.Value.TryGetValue(KCM_TRANS_ID, out value))
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
