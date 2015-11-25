using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Disciplinary Incidents Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SIDDataSet : SetBase<SID>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SID"; } }

        internal SIDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<SID>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_INCIDENT_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<SID>>>(() => this.ToGroupedNullDictionary(i => i.INCIDENT_TYPE));
            Index_SIDKEY = new Lazy<Dictionary<int, SID>>(() => this.ToDictionary(i => i.SIDKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SID" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SID" /> fields for each CSV column header</returns>
        protected override Action<SID, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SID, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SIDKEY":
                        mapper[i] = (e, v) => e.SIDKEY = int.Parse(v);
                        break;
                    case "SID_DATE":
                        mapper[i] = (e, v) => e.SID_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SID_TIME":
                        mapper[i] = (e, v) => e.SID_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "INCIDENT_TYPE":
                        mapper[i] = (e, v) => e.INCIDENT_TYPE = v;
                        break;
                    case "INCIDENT_DESC":
                        mapper[i] = (e, v) => e.INCIDENT_DESC = v;
                        break;
                    case "OFFICE_USE_ONLY":
                        mapper[i] = (e, v) => e.OFFICE_USE_ONLY = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EXT_ADDRESS":
                        mapper[i] = (e, v) => e.EXT_ADDRESS = v;
                        break;
                    case "RESP_PERSON_TYPE":
                        mapper[i] = (e, v) => e.RESP_PERSON_TYPE = v;
                        break;
                    case "RESP_PERSON":
                        mapper[i] = (e, v) => e.RESP_PERSON = v;
                        break;
                    case "RESP_PERSON_NAME":
                        mapper[i] = (e, v) => e.RESP_PERSON_NAME = v;
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
        /// Merges <see cref="SID" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SID" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SID" /> items to added or update the base <see cref="SID" /> items</param>
        /// <returns>A merged list of <see cref="SID" /> items</returns>
        protected override List<SID> ApplyDeltaItems(List<SID> Items, List<SID> DeltaItems)
        {
            Dictionary<int, int> Index_SIDKEY = Items.ToIndexDictionary(i => i.SIDKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SID deltaItem in DeltaItems)
            {
                int index;

                if (Index_SIDKEY.TryGetValue(deltaItem.SIDKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SIDKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<int?, IReadOnlyList<SID>>> Index_CAMPUS;
        private Lazy<NullDictionary<string, IReadOnlyList<SID>>> Index_INCIDENT_TYPE;
        private Lazy<Dictionary<int, SID>> Index_SIDKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SID by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SID</param>
        /// <returns>List of related SID entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SID> FindByCAMPUS(int? CAMPUS)
        {
            return Index_CAMPUS.Value[CAMPUS];
        }

        /// <summary>
        /// Attempt to find SID by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SID</param>
        /// <param name="Value">List of related SID entities</param>
        /// <returns>True if the list of related SID entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAMPUS(int? CAMPUS, out IReadOnlyList<SID> Value)
        {
            return Index_CAMPUS.Value.TryGetValue(CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find SID by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SID</param>
        /// <returns>List of related SID entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SID> TryFindByCAMPUS(int? CAMPUS)
        {
            IReadOnlyList<SID> value;
            if (Index_CAMPUS.Value.TryGetValue(CAMPUS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SID by INCIDENT_TYPE field
        /// </summary>
        /// <param name="INCIDENT_TYPE">INCIDENT_TYPE value used to find SID</param>
        /// <returns>List of related SID entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SID> FindByINCIDENT_TYPE(string INCIDENT_TYPE)
        {
            return Index_INCIDENT_TYPE.Value[INCIDENT_TYPE];
        }

        /// <summary>
        /// Attempt to find SID by INCIDENT_TYPE field
        /// </summary>
        /// <param name="INCIDENT_TYPE">INCIDENT_TYPE value used to find SID</param>
        /// <param name="Value">List of related SID entities</param>
        /// <returns>True if the list of related SID entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINCIDENT_TYPE(string INCIDENT_TYPE, out IReadOnlyList<SID> Value)
        {
            return Index_INCIDENT_TYPE.Value.TryGetValue(INCIDENT_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find SID by INCIDENT_TYPE field
        /// </summary>
        /// <param name="INCIDENT_TYPE">INCIDENT_TYPE value used to find SID</param>
        /// <returns>List of related SID entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SID> TryFindByINCIDENT_TYPE(string INCIDENT_TYPE)
        {
            IReadOnlyList<SID> value;
            if (Index_INCIDENT_TYPE.Value.TryGetValue(INCIDENT_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SID by SIDKEY field
        /// </summary>
        /// <param name="SIDKEY">SIDKEY value used to find SID</param>
        /// <returns>Related SID entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SID FindBySIDKEY(int SIDKEY)
        {
            return Index_SIDKEY.Value[SIDKEY];
        }

        /// <summary>
        /// Attempt to find SID by SIDKEY field
        /// </summary>
        /// <param name="SIDKEY">SIDKEY value used to find SID</param>
        /// <param name="Value">Related SID entity</param>
        /// <returns>True if the related SID entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySIDKEY(int SIDKEY, out SID Value)
        {
            return Index_SIDKEY.Value.TryGetValue(SIDKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SID by SIDKEY field
        /// </summary>
        /// <param name="SIDKEY">SIDKEY value used to find SID</param>
        /// <returns>Related SID entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SID TryFindBySIDKEY(int SIDKEY)
        {
            SID value;
            if (Index_SIDKEY.Value.TryGetValue(SIDKEY, out value))
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
