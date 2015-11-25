using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Event Instances Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TETEDataSet : SetBase<TETE>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TETE"; } }

        internal TETEDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TETEKEY = new Lazy<Dictionary<int, IReadOnlyList<TETE>>>(() => this.ToGroupedDictionary(i => i.TETEKEY));
            Index_TID = new Lazy<Dictionary<int, TETE>>(() => this.ToDictionary(i => i.TID));
            Index_LOCATION = new Lazy<NullDictionary<string, IReadOnlyList<TETE>>>(() => this.ToGroupedNullDictionary(i => i.LOCATION));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TETE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TETE" /> fields for each CSV column header</returns>
        protected override Action<TETE, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TETE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "TETEKEY":
                        mapper[i] = (e, v) => e.TETEKEY = int.Parse(v);
                        break;
                    case "EVENT_DATE":
                        mapper[i] = (e, v) => e.EVENT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "COMMENTS":
                        mapper[i] = (e, v) => e.COMMENTS = v;
                        break;
                    case "TIME_FROM":
                        mapper[i] = (e, v) => e.TIME_FROM = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TIME_TO":
                        mapper[i] = (e, v) => e.TIME_TO = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CONVENOR":
                        mapper[i] = (e, v) => e.CONVENOR = v;
                        break;
                    case "CONVENOR_TYPE":
                        mapper[i] = (e, v) => e.CONVENOR_TYPE = v;
                        break;
                    case "LOCATION":
                        mapper[i] = (e, v) => e.LOCATION = v;
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

        private Lazy<Dictionary<int, IReadOnlyList<TETE>>> Index_TETEKEY;
        private Lazy<Dictionary<int, TETE>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<TETE>>> Index_LOCATION;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TETE by TETEKEY field
        /// </summary>
        /// <param name="TETEKEY">TETEKEY value used to find TETE</param>
        /// <returns>List of related TETE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TETE> FindByTETEKEY(int TETEKEY)
        {
            return Index_TETEKEY.Value[TETEKEY];
        }

        /// <summary>
        /// Attempt to find TETE by TETEKEY field
        /// </summary>
        /// <param name="TETEKEY">TETEKEY value used to find TETE</param>
        /// <param name="Value">List of related TETE entities</param>
        /// <returns>True if the list of related TETE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTETEKEY(int TETEKEY, out IReadOnlyList<TETE> Value)
        {
            return Index_TETEKEY.Value.TryGetValue(TETEKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TETE by TETEKEY field
        /// </summary>
        /// <param name="TETEKEY">TETEKEY value used to find TETE</param>
        /// <returns>List of related TETE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TETE> TryFindByTETEKEY(int TETEKEY)
        {
            IReadOnlyList<TETE> value;
            if (Index_TETEKEY.Value.TryGetValue(TETEKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TETE by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TETE</param>
        /// <returns>Related TETE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TETE FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TETE by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TETE</param>
        /// <param name="Value">Related TETE entity</param>
        /// <returns>True if the related TETE entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TETE Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TETE by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TETE</param>
        /// <returns>Related TETE entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TETE TryFindByTID(int TID)
        {
            TETE value;
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
        /// Find TETE by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find TETE</param>
        /// <returns>List of related TETE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TETE> FindByLOCATION(string LOCATION)
        {
            return Index_LOCATION.Value[LOCATION];
        }

        /// <summary>
        /// Attempt to find TETE by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find TETE</param>
        /// <param name="Value">List of related TETE entities</param>
        /// <returns>True if the list of related TETE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLOCATION(string LOCATION, out IReadOnlyList<TETE> Value)
        {
            return Index_LOCATION.Value.TryGetValue(LOCATION, out Value);
        }

        /// <summary>
        /// Attempt to find TETE by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find TETE</param>
        /// <returns>List of related TETE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TETE> TryFindByLOCATION(string LOCATION)
        {
            IReadOnlyList<TETE> value;
            if (Index_LOCATION.Value.TryGetValue(LOCATION, out value))
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
