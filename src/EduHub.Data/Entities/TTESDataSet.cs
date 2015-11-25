using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Exam Subjects Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TTESDataSet : SetBase<TTES>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TTES"; } }

        internal TTESDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GKEY = new Lazy<Dictionary<string, IReadOnlyList<TTES>>>(() => this.ToGroupedDictionary(i => i.GKEY));
            Index_TID = new Lazy<Dictionary<int, TTES>>(() => this.ToDictionary(i => i.TID));
            Index_SUBJ = new Lazy<NullDictionary<string, IReadOnlyList<TTES>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TTES" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TTES" /> fields for each CSV column header</returns>
        protected override Action<TTES, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TTES, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "GKEY":
                        mapper[i] = (e, v) => e.GKEY = v;
                        break;
                    case "TTEI_TID":
                        mapper[i] = (e, v) => e.TTEI_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SUBJ":
                        mapper[i] = (e, v) => e.SUBJ = v;
                        break;
                    case "UNITS":
                        mapper[i] = (e, v) => e.UNITS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "INCLUDE01":
                        mapper[i] = (e, v) => e.INCLUDE01 = v;
                        break;
                    case "INCLUDE02":
                        mapper[i] = (e, v) => e.INCLUDE02 = v;
                        break;
                    case "INCLUDE03":
                        mapper[i] = (e, v) => e.INCLUDE03 = v;
                        break;
                    case "INCLUDE04":
                        mapper[i] = (e, v) => e.INCLUDE04 = v;
                        break;
                    case "INCLUDE05":
                        mapper[i] = (e, v) => e.INCLUDE05 = v;
                        break;
                    case "INCLUDE06":
                        mapper[i] = (e, v) => e.INCLUDE06 = v;
                        break;
                    case "INCLUDE07":
                        mapper[i] = (e, v) => e.INCLUDE07 = v;
                        break;
                    case "INCLUDE08":
                        mapper[i] = (e, v) => e.INCLUDE08 = v;
                        break;
                    case "INCLUDE09":
                        mapper[i] = (e, v) => e.INCLUDE09 = v;
                        break;
                    case "INCLUDE10":
                        mapper[i] = (e, v) => e.INCLUDE10 = v;
                        break;
                    case "INCLUDE11":
                        mapper[i] = (e, v) => e.INCLUDE11 = v;
                        break;
                    case "INCLUDE12":
                        mapper[i] = (e, v) => e.INCLUDE12 = v;
                        break;
                    case "INCLUDE13":
                        mapper[i] = (e, v) => e.INCLUDE13 = v;
                        break;
                    case "INCLUDE14":
                        mapper[i] = (e, v) => e.INCLUDE14 = v;
                        break;
                    case "INCLUDE15":
                        mapper[i] = (e, v) => e.INCLUDE15 = v;
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

        private Lazy<Dictionary<string, IReadOnlyList<TTES>>> Index_GKEY;
        private Lazy<Dictionary<int, TTES>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<TTES>>> Index_SUBJ;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TTES by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTES</param>
        /// <returns>List of related TTES entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTES> FindByGKEY(string GKEY)
        {
            return Index_GKEY.Value[GKEY];
        }

        /// <summary>
        /// Attempt to find TTES by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTES</param>
        /// <param name="Value">List of related TTES entities</param>
        /// <returns>True if the list of related TTES entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGKEY(string GKEY, out IReadOnlyList<TTES> Value)
        {
            return Index_GKEY.Value.TryGetValue(GKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TTES by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTES</param>
        /// <returns>List of related TTES entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTES> TryFindByGKEY(string GKEY)
        {
            IReadOnlyList<TTES> value;
            if (Index_GKEY.Value.TryGetValue(GKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TTES by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTES</param>
        /// <returns>Related TTES entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTES FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TTES by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTES</param>
        /// <param name="Value">Related TTES entity</param>
        /// <returns>True if the related TTES entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TTES Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TTES by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTES</param>
        /// <returns>Related TTES entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTES TryFindByTID(int TID)
        {
            TTES value;
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
        /// Find TTES by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find TTES</param>
        /// <returns>List of related TTES entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTES> FindBySUBJ(string SUBJ)
        {
            return Index_SUBJ.Value[SUBJ];
        }

        /// <summary>
        /// Attempt to find TTES by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find TTES</param>
        /// <param name="Value">List of related TTES entities</param>
        /// <returns>True if the list of related TTES entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ(string SUBJ, out IReadOnlyList<TTES> Value)
        {
            return Index_SUBJ.Value.TryGetValue(SUBJ, out Value);
        }

        /// <summary>
        /// Attempt to find TTES by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find TTES</param>
        /// <returns>List of related TTES entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTES> TryFindBySUBJ(string SUBJ)
        {
            IReadOnlyList<TTES> value;
            if (Index_SUBJ.Value.TryGetValue(SUBJ, out value))
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
