using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 Login Log Data Set
    /// </summary>
    public sealed class SEC_LLOGDataSet : SetBase<SEC_LLOG>
    {
        private Lazy<Dictionary<int, SEC_LLOG>> LOGINLOGIDIndex;

        internal SEC_LLOGDataSet(EduHubContext Context)
            : base(Context)
        {
            LOGINLOGIDIndex = new Lazy<Dictionary<int, SEC_LLOG>>(() => this.ToDictionary(e => e.LOGINLOGID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SEC_LLOG"; } }

        /// <summary>
        /// Find SEC_LLOG by LOGINLOGID key field
        /// </summary>
        /// <param name="Key">LOGINLOGID value used to find SEC_LLOG</param>
        /// <returns>Related SEC_LLOG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">LOGINLOGID value didn't match any SEC_LLOG entities</exception>
        public SEC_LLOG FindByLOGINLOGID(int Key)
        {
            SEC_LLOG result;
            if (LOGINLOGIDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SEC_LLOG by LOGINLOGID key field
        /// </summary>
        /// <param name="Key">LOGINLOGID value used to find SEC_LLOG</param>
        /// <param name="Value">Related SEC_LLOG entity</param>
        /// <returns>True if the SEC_LLOG entity is found</returns>
        public bool TryFindByLOGINLOGID(int Key, out SEC_LLOG Value)
        {
            return LOGINLOGIDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SEC_LLOG by LOGINLOGID key field
        /// </summary>
        /// <param name="Key">LOGINLOGID value used to find SEC_LLOG</param>
        /// <returns>Related SEC_LLOG entity, or null if not found</returns>
        public SEC_LLOG TryFindByLOGINLOGID(int Key)
        {
            SEC_LLOG result;
            if (LOGINLOGIDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SEC_LLOG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SEC_LLOG" /> fields for each CSV column header</returns>
        protected override Action<SEC_LLOG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SEC_LLOG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "LOGINLOGID":
                        mapper[i] = (e, v) => e.LOGINLOGID = int.Parse(v);
                        break;
                    case "SERVER":
                        mapper[i] = (e, v) => e.SERVER = v;
                        break;
                    case "VERSION":
                        mapper[i] = (e, v) => e.VERSION = v;
                        break;
                    case "USERID":
                        mapper[i] = (e, v) => e.USERID = v;
                        break;
                    case "USERNAME":
                        mapper[i] = (e, v) => e.USERNAME = v;
                        break;
                    case "BROWSER":
                        mapper[i] = (e, v) => e.BROWSER = v;
                        break;
                    case "SCREENSIZE":
                        mapper[i] = (e, v) => e.SCREENSIZE = v;
                        break;
                    case "RESULT":
                        mapper[i] = (e, v) => e.RESULT = v;
                        break;
                    case "IPADDRESS":
                        mapper[i] = (e, v) => e.IPADDRESS = v;
                        break;
                    case "SESSIONID":
                        mapper[i] = (e, v) => e.SESSIONID = v;
                        break;
                    case "LOGGEDOUT":
                        mapper[i] = (e, v) => e.LOGGEDOUT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LOGINTIME":
                        mapper[i] = (e, v) => e.LOGINTIME = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LOGOUTTIME":
                        mapper[i] = (e, v) => e.LOGOUTTIME = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LOGGEDPERIOD":
                        mapper[i] = (e, v) => e.LOGGEDPERIOD = v == null ? (short?)null : short.Parse(v);
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
