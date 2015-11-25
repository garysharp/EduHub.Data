using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 Login Log Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SEC_LLOGDataSet : SetBase<SEC_LLOG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SEC_LLOG"; } }

        internal SEC_LLOGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_LOGINLOGID = new Lazy<Dictionary<int, SEC_LLOG>>(() => this.ToDictionary(i => i.LOGINLOGID));
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

        /// <summary>
        /// Merges <see cref="SEC_LLOG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SEC_LLOG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SEC_LLOG" /> items to added or update the base <see cref="SEC_LLOG" /> items</param>
        /// <returns>A merged list of <see cref="SEC_LLOG" /> items</returns>
        protected override List<SEC_LLOG> ApplyDeltaItems(List<SEC_LLOG> Items, List<SEC_LLOG> DeltaItems)
        {
            Dictionary<int, int> Index_LOGINLOGID = Items.ToIndexDictionary(i => i.LOGINLOGID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SEC_LLOG deltaItem in DeltaItems)
            {
                int index;

                if (Index_LOGINLOGID.TryGetValue(deltaItem.LOGINLOGID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.LOGINLOGID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, SEC_LLOG>> Index_LOGINLOGID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SEC_LLOG by LOGINLOGID field
        /// </summary>
        /// <param name="LOGINLOGID">LOGINLOGID value used to find SEC_LLOG</param>
        /// <returns>Related SEC_LLOG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_LLOG FindByLOGINLOGID(int LOGINLOGID)
        {
            return Index_LOGINLOGID.Value[LOGINLOGID];
        }

        /// <summary>
        /// Attempt to find SEC_LLOG by LOGINLOGID field
        /// </summary>
        /// <param name="LOGINLOGID">LOGINLOGID value used to find SEC_LLOG</param>
        /// <param name="Value">Related SEC_LLOG entity</param>
        /// <returns>True if the related SEC_LLOG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLOGINLOGID(int LOGINLOGID, out SEC_LLOG Value)
        {
            return Index_LOGINLOGID.Value.TryGetValue(LOGINLOGID, out Value);
        }

        /// <summary>
        /// Attempt to find SEC_LLOG by LOGINLOGID field
        /// </summary>
        /// <param name="LOGINLOGID">LOGINLOGID value used to find SEC_LLOG</param>
        /// <returns>Related SEC_LLOG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_LLOG TryFindByLOGINLOGID(int LOGINLOGID)
        {
            SEC_LLOG value;
            if (Index_LOGINLOGID.Value.TryGetValue(LOGINLOGID, out value))
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
