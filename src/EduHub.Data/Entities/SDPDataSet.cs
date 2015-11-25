using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Incident Instigators Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SDPDataSet : SetBase<SDP>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SDP"; } }

        internal SDPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_INCIDENT_KEY = new Lazy<NullDictionary<int?, IReadOnlyList<SDP>>>(() => this.ToGroupedNullDictionary(i => i.INCIDENT_KEY));
            Index_SDPKEY = new Lazy<Dictionary<int, SDP>>(() => this.ToDictionary(i => i.SDPKEY));
            Index_STUDENT_KEY = new Lazy<NullDictionary<string, IReadOnlyList<SDP>>>(() => this.ToGroupedNullDictionary(i => i.STUDENT_KEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SDP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SDP" /> fields for each CSV column header</returns>
        protected override Action<SDP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SDP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SDPKEY":
                        mapper[i] = (e, v) => e.SDPKEY = int.Parse(v);
                        break;
                    case "INCIDENT_KEY":
                        mapper[i] = (e, v) => e.INCIDENT_KEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "INCIDENT_TYPE":
                        mapper[i] = (e, v) => e.INCIDENT_TYPE = v;
                        break;
                    case "INCIDENT_DATE":
                        mapper[i] = (e, v) => e.INCIDENT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "STUDENT_KEY":
                        mapper[i] = (e, v) => e.STUDENT_KEY = v;
                        break;
                    case "INVOLVEMENT_DESC":
                        mapper[i] = (e, v) => e.INVOLVEMENT_DESC = v;
                        break;
                    case "FOLLOW_UP_DATE":
                        mapper[i] = (e, v) => e.FOLLOW_UP_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "FOLLOW_UP_DETAILS":
                        mapper[i] = (e, v) => e.FOLLOW_UP_DETAILS = v;
                        break;
                    case "FOLLOW_UP_OUTCOME":
                        mapper[i] = (e, v) => e.FOLLOW_UP_OUTCOME = v;
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

        /// <summary>
        /// Merges <see cref="SDP" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SDP" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SDP" /> items to added or update the base <see cref="SDP" /> items</param>
        /// <returns>A merged list of <see cref="SDP" /> items</returns>
        protected override List<SDP> ApplyDeltaItems(List<SDP> Items, List<SDP> DeltaItems)
        {
            Dictionary<int, int> Index_SDPKEY = Items.ToIndexDictionary(i => i.SDPKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SDP deltaItem in DeltaItems)
            {
                int index;

                if (Index_SDPKEY.TryGetValue(deltaItem.SDPKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SDPKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<int?, IReadOnlyList<SDP>>> Index_INCIDENT_KEY;
        private Lazy<Dictionary<int, SDP>> Index_SDPKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SDP>>> Index_STUDENT_KEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SDP by INCIDENT_KEY field
        /// </summary>
        /// <param name="INCIDENT_KEY">INCIDENT_KEY value used to find SDP</param>
        /// <returns>List of related SDP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDP> FindByINCIDENT_KEY(int? INCIDENT_KEY)
        {
            return Index_INCIDENT_KEY.Value[INCIDENT_KEY];
        }

        /// <summary>
        /// Attempt to find SDP by INCIDENT_KEY field
        /// </summary>
        /// <param name="INCIDENT_KEY">INCIDENT_KEY value used to find SDP</param>
        /// <param name="Value">List of related SDP entities</param>
        /// <returns>True if the list of related SDP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINCIDENT_KEY(int? INCIDENT_KEY, out IReadOnlyList<SDP> Value)
        {
            return Index_INCIDENT_KEY.Value.TryGetValue(INCIDENT_KEY, out Value);
        }

        /// <summary>
        /// Attempt to find SDP by INCIDENT_KEY field
        /// </summary>
        /// <param name="INCIDENT_KEY">INCIDENT_KEY value used to find SDP</param>
        /// <returns>List of related SDP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDP> TryFindByINCIDENT_KEY(int? INCIDENT_KEY)
        {
            IReadOnlyList<SDP> value;
            if (Index_INCIDENT_KEY.Value.TryGetValue(INCIDENT_KEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SDP by SDPKEY field
        /// </summary>
        /// <param name="SDPKEY">SDPKEY value used to find SDP</param>
        /// <returns>Related SDP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SDP FindBySDPKEY(int SDPKEY)
        {
            return Index_SDPKEY.Value[SDPKEY];
        }

        /// <summary>
        /// Attempt to find SDP by SDPKEY field
        /// </summary>
        /// <param name="SDPKEY">SDPKEY value used to find SDP</param>
        /// <param name="Value">Related SDP entity</param>
        /// <returns>True if the related SDP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySDPKEY(int SDPKEY, out SDP Value)
        {
            return Index_SDPKEY.Value.TryGetValue(SDPKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SDP by SDPKEY field
        /// </summary>
        /// <param name="SDPKEY">SDPKEY value used to find SDP</param>
        /// <returns>Related SDP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SDP TryFindBySDPKEY(int SDPKEY)
        {
            SDP value;
            if (Index_SDPKEY.Value.TryGetValue(SDPKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SDP by STUDENT_KEY field
        /// </summary>
        /// <param name="STUDENT_KEY">STUDENT_KEY value used to find SDP</param>
        /// <returns>List of related SDP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDP> FindBySTUDENT_KEY(string STUDENT_KEY)
        {
            return Index_STUDENT_KEY.Value[STUDENT_KEY];
        }

        /// <summary>
        /// Attempt to find SDP by STUDENT_KEY field
        /// </summary>
        /// <param name="STUDENT_KEY">STUDENT_KEY value used to find SDP</param>
        /// <param name="Value">List of related SDP entities</param>
        /// <returns>True if the list of related SDP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTUDENT_KEY(string STUDENT_KEY, out IReadOnlyList<SDP> Value)
        {
            return Index_STUDENT_KEY.Value.TryGetValue(STUDENT_KEY, out Value);
        }

        /// <summary>
        /// Attempt to find SDP by STUDENT_KEY field
        /// </summary>
        /// <param name="STUDENT_KEY">STUDENT_KEY value used to find SDP</param>
        /// <returns>List of related SDP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDP> TryFindBySTUDENT_KEY(string STUDENT_KEY)
        {
            IReadOnlyList<SDP> value;
            if (Index_STUDENT_KEY.Value.TryGetValue(STUDENT_KEY, out value))
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
