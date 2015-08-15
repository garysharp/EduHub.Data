using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Disciplinary Incidents Data Set
    /// </summary>
    public sealed class SID_DataSet : SetBase<SID_Entity>
    {
        private Lazy<Dictionary<int, SID_Entity>> SIDKEY_Index;

        internal SID_DataSet(EduHubContext Context)
            : base(Context)
        {
            SIDKEY_Index = new Lazy<Dictionary<int, SID_Entity>>(() => this.ToDictionary(e => e.SIDKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SID"; } }

        /// <summary>
        /// Find SID by SIDKEY key field
        /// </summary>
        /// <param name="Key">SIDKEY value used to find SID</param>
        /// <returns>Related SID entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SIDKEY value didn't match any SID entities</exception>
        public SID_Entity FindBySIDKEY(int Key)
        {
            SID_Entity result;
            if (SIDKEY_Index.Value.TryGetValue(Key, out result))
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
        /// <returns>True if the SID Entity is found</returns>
        public bool TryFindBySIDKEY(int Key, out SID_Entity Value)
        {
            return SIDKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SID by SIDKEY key field
        /// </summary>
        /// <param name="Key">SIDKEY value used to find SID</param>
        /// <returns>Related SID entity, or null if not found</returns>
        public SID_Entity TryFindBySIDKEY(int Key)
        {
            SID_Entity result;
            if (SIDKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SID_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SID_Entity, string>[Headers.Count];

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
