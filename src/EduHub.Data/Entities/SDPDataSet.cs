using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Incident Instigators Data Set
    /// </summary>
    public sealed class SDPDataSet : SetBase<SDP>
    {
        private Lazy<Dictionary<int, SDP>> SDPKEYIndex;

        internal SDPDataSet(EduHubContext Context)
            : base(Context)
        {
            SDPKEYIndex = new Lazy<Dictionary<int, SDP>>(() => this.ToDictionary(e => e.SDPKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SDP"; } }

        /// <summary>
        /// Find SDP by SDPKEY key field
        /// </summary>
        /// <param name="Key">SDPKEY value used to find SDP</param>
        /// <returns>Related SDP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SDPKEY value didn't match any SDP entities</exception>
        public SDP FindBySDPKEY(int Key)
        {
            SDP result;
            if (SDPKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SDP by SDPKEY key field
        /// </summary>
        /// <param name="Key">SDPKEY value used to find SDP</param>
        /// <param name="Value">Related SDP entity</param>
        /// <returns>True if the SDP entity is found</returns>
        public bool TryFindBySDPKEY(int Key, out SDP Value)
        {
            return SDPKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SDP by SDPKEY key field
        /// </summary>
        /// <param name="Key">SDPKEY value used to find SDP</param>
        /// <returns>Related SDP entity, or null if not found</returns>
        public SDP TryFindBySDPKEY(int Key)
        {
            SDP result;
            if (SDPKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SDP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SDP" /> fields for each CSV column header</returns>
        protected override Action<SDP, string>[] BuildMapper(List<string> Headers)
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
    }
}
