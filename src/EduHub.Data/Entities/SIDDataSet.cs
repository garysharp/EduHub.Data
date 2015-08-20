using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Disciplinary Incidents Data Set
    /// </summary>
    public sealed class SIDDataSet : SetBase<SID>
    {
        private Lazy<Dictionary<int, SID>> SIDKEYIndex;

        internal SIDDataSet(EduHubContext Context)
            : base(Context)
        {
            SIDKEYIndex = new Lazy<Dictionary<int, SID>>(() => this.ToDictionary(e => e.SIDKEY));
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
        /// Matches CSV file headers to actions, used to deserialize <see cref="SID" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SID" /> fields for each CSV column header</returns>
        protected override Action<SID, string>[] BuildMapper(List<string> Headers)
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
