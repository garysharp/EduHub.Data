using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Association Member Attendances Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SAMADataSet : SetBase<SAMA>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SAMA"; } }

        internal SAMADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SAMAKEY = new Lazy<Dictionary<int, IReadOnlyList<SAMA>>>(() => this.ToGroupedDictionary(i => i.SAMAKEY));
            Index_TID = new Lazy<Dictionary<int, SAMA>>(() => this.ToDictionary(i => i.TID));
            Index_SAMAKEY_SCAM_TID = new Lazy<Dictionary<Tuple<int, int?>, SAMA>>(() => this.ToDictionary(i => Tuple.Create(i.SAMAKEY, i.SCAM_TID)));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SAMA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SAMA" /> fields for each CSV column header</returns>
        protected override Action<SAMA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SAMA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SAMAKEY":
                        mapper[i] = (e, v) => e.SAMAKEY = int.Parse(v);
                        break;
                    case "SCAM_TID":
                        mapper[i] = (e, v) => e.SCAM_TID = v == null ? (int?)null : int.Parse(v);
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

        #region Index Fields

        private Lazy<Dictionary<int, IReadOnlyList<SAMA>>> Index_SAMAKEY;
        private Lazy<Dictionary<int, SAMA>> Index_TID;
        private Lazy<Dictionary<Tuple<int, int?>, SAMA>> Index_SAMAKEY_SCAM_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SAMA by SAMAKEY field
        /// </summary>
        /// <param name="SAMAKEY">SAMAKEY value used to find SAMA</param>
        /// <returns>List of related SAMA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAMA> FindBySAMAKEY(int SAMAKEY)
        {
            return Index_SAMAKEY.Value[SAMAKEY];
        }

        /// <summary>
        /// Attempt to find SAMA by SAMAKEY field
        /// </summary>
        /// <param name="SAMAKEY">SAMAKEY value used to find SAMA</param>
        /// <param name="Value">List of related SAMA entities</param>
        /// <returns>True if the list of related SAMA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySAMAKEY(int SAMAKEY, out IReadOnlyList<SAMA> Value)
        {
            return Index_SAMAKEY.Value.TryGetValue(SAMAKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SAMA by SAMAKEY field
        /// </summary>
        /// <param name="SAMAKEY">SAMAKEY value used to find SAMA</param>
        /// <returns>List of related SAMA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAMA> TryFindBySAMAKEY(int SAMAKEY)
        {
            IReadOnlyList<SAMA> value;
            if (Index_SAMAKEY.Value.TryGetValue(SAMAKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SAMA</param>
        /// <returns>Related SAMA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAMA FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SAMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SAMA</param>
        /// <param name="Value">Related SAMA entity</param>
        /// <returns>True if the related SAMA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SAMA Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SAMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SAMA</param>
        /// <returns>Related SAMA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAMA TryFindByTID(int TID)
        {
            SAMA value;
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
        /// Find SAMA by SAMAKEY and SCAM_TID fields
        /// </summary>
        /// <param name="SAMAKEY">SAMAKEY value used to find SAMA</param>
        /// <param name="SCAM_TID">SCAM_TID value used to find SAMA</param>
        /// <returns>Related SAMA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAMA FindBySAMAKEY_SCAM_TID(int SAMAKEY, int? SCAM_TID)
        {
            return Index_SAMAKEY_SCAM_TID.Value[Tuple.Create(SAMAKEY, SCAM_TID)];
        }

        /// <summary>
        /// Attempt to find SAMA by SAMAKEY and SCAM_TID fields
        /// </summary>
        /// <param name="SAMAKEY">SAMAKEY value used to find SAMA</param>
        /// <param name="SCAM_TID">SCAM_TID value used to find SAMA</param>
        /// <param name="Value">Related SAMA entity</param>
        /// <returns>True if the related SAMA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySAMAKEY_SCAM_TID(int SAMAKEY, int? SCAM_TID, out SAMA Value)
        {
            return Index_SAMAKEY_SCAM_TID.Value.TryGetValue(Tuple.Create(SAMAKEY, SCAM_TID), out Value);
        }

        /// <summary>
        /// Attempt to find SAMA by SAMAKEY and SCAM_TID fields
        /// </summary>
        /// <param name="SAMAKEY">SAMAKEY value used to find SAMA</param>
        /// <param name="SCAM_TID">SCAM_TID value used to find SAMA</param>
        /// <returns>Related SAMA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAMA TryFindBySAMAKEY_SCAM_TID(int SAMAKEY, int? SCAM_TID)
        {
            SAMA value;
            if (Index_SAMAKEY_SCAM_TID.Value.TryGetValue(Tuple.Create(SAMAKEY, SCAM_TID), out value))
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
