using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Disciplinary Incidents Data Set
    /// </summary>
    public sealed partial class SIDDataSet : SetBase<SID>
    {
        private Lazy<Dictionary<int, SID>> SIDKEYIndex;

        private Lazy<Dictionary<int, IReadOnlyList<SDP>>> SDP_INCIDENT_KEYForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<SIDV>>> SIDV_INCIDENT_KEYForeignIndex;

        internal SIDDataSet(EduHubContext Context)
            : base(Context)
        {
            SIDKEYIndex = new Lazy<Dictionary<int, SID>>(() => this.ToDictionary(e => e.SIDKEY));

            SDP_INCIDENT_KEYForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<SDP>>>(() =>
                    Context.SDP
                          .Where(e => e.INCIDENT_KEY != null)
                          .GroupBy(e => e.INCIDENT_KEY.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SDP>)g.ToList()
                          .AsReadOnly()));

            SIDV_INCIDENT_KEYForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<SIDV>>>(() =>
                    Context.SIDV
                          .Where(e => e.INCIDENT_KEY != null)
                          .GroupBy(e => e.INCIDENT_KEY.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SIDV>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SID"; } }

        /// <summary>
        /// Find SID by SIDKEY key field
        /// </summary>
        /// <param name="Key">SIDKEY value used to find SID</param>
        /// <returns>Related SID entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SIDKEY value didn't match any SID entities</exception>
        public SID FindBySIDKEY(int Key)
        {
            SID result;
            if (SIDKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SID by SIDKEY key field
        /// </summary>
        /// <param name="Key">SIDKEY value used to find SID</param>
        /// <param name="Value">Related SID entity</param>
        /// <returns>True if the SID entity is found</returns>
        public bool TryFindBySIDKEY(int Key, out SID Value)
        {
            return SIDKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SID by SIDKEY key field
        /// </summary>
        /// <param name="Key">SIDKEY value used to find SID</param>
        /// <returns>Related SID entity, or null if not found</returns>
        public SID TryFindBySIDKEY(int Key)
        {
            SID result;
            if (SIDKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all SDP (Incident Instigators) entities by [SDP.INCIDENT_KEY]-&gt;[SID.SIDKEY]
        /// </summary>
        /// <param name="SIDKEY">SIDKEY value used to find SDP entities</param>
        /// <returns>A list of related SDP entities</returns>
        public IReadOnlyList<SDP> FindSDPByINCIDENT_KEY(int SIDKEY)
        {
            IReadOnlyList<SDP> result;
            if (SDP_INCIDENT_KEYForeignIndex.Value.TryGetValue(SIDKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SDP>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SDP entities by [SDP.INCIDENT_KEY]-&gt;[SID.SIDKEY]
        /// </summary>
        /// <param name="SIDKEY">SIDKEY value used to find SDP entities</param>
        /// <param name="Value">A list of related SDP entities</param>
        /// <returns>True if any SDP entities are found</returns>
        public bool TryFindSDPByINCIDENT_KEY(int SIDKEY, out IReadOnlyList<SDP> Value)
        {
            return SDP_INCIDENT_KEYForeignIndex.Value.TryGetValue(SIDKEY, out Value);
        }

        /// <summary>
        /// Find all SIDV (Incident Victims/Recipients) entities by [SIDV.INCIDENT_KEY]-&gt;[SID.SIDKEY]
        /// </summary>
        /// <param name="SIDKEY">SIDKEY value used to find SIDV entities</param>
        /// <returns>A list of related SIDV entities</returns>
        public IReadOnlyList<SIDV> FindSIDVByINCIDENT_KEY(int SIDKEY)
        {
            IReadOnlyList<SIDV> result;
            if (SIDV_INCIDENT_KEYForeignIndex.Value.TryGetValue(SIDKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SIDV>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SIDV entities by [SIDV.INCIDENT_KEY]-&gt;[SID.SIDKEY]
        /// </summary>
        /// <param name="SIDKEY">SIDKEY value used to find SIDV entities</param>
        /// <param name="Value">A list of related SIDV entities</param>
        /// <returns>True if any SIDV entities are found</returns>
        public bool TryFindSIDVByINCIDENT_KEY(int SIDKEY, out IReadOnlyList<SIDV> Value)
        {
            return SIDV_INCIDENT_KEYForeignIndex.Value.TryGetValue(SIDKEY, out Value);
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
    }
}
