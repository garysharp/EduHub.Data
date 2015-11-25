using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 School Message Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SEC_MSGDataSet : SetBase<SEC_MSG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SEC_MSG"; } }

        internal SEC_MSGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SCHOOLMSGID = new Lazy<Dictionary<int, SEC_MSG>>(() => this.ToDictionary(i => i.SCHOOLMSGID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SEC_MSG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SEC_MSG" /> fields for each CSV column header</returns>
        protected override Action<SEC_MSG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SEC_MSG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCHOOLMSGID":
                        mapper[i] = (e, v) => e.SCHOOLMSGID = int.Parse(v);
                        break;
                    case "MSGTEXT":
                        mapper[i] = (e, v) => e.MSGTEXT = v;
                        break;
                    case "EDITBYUSERID":
                        mapper[i] = (e, v) => e.EDITBYUSERID = v;
                        break;
                    case "EDITDATE":
                        mapper[i] = (e, v) => e.EDITDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        #region Index Fields

        private Lazy<Dictionary<int, SEC_MSG>> Index_SCHOOLMSGID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SEC_MSG by SCHOOLMSGID field
        /// </summary>
        /// <param name="SCHOOLMSGID">SCHOOLMSGID value used to find SEC_MSG</param>
        /// <returns>Related SEC_MSG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_MSG FindBySCHOOLMSGID(int SCHOOLMSGID)
        {
            return Index_SCHOOLMSGID.Value[SCHOOLMSGID];
        }

        /// <summary>
        /// Attempt to find SEC_MSG by SCHOOLMSGID field
        /// </summary>
        /// <param name="SCHOOLMSGID">SCHOOLMSGID value used to find SEC_MSG</param>
        /// <param name="Value">Related SEC_MSG entity</param>
        /// <returns>True if the related SEC_MSG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCHOOLMSGID(int SCHOOLMSGID, out SEC_MSG Value)
        {
            return Index_SCHOOLMSGID.Value.TryGetValue(SCHOOLMSGID, out Value);
        }

        /// <summary>
        /// Attempt to find SEC_MSG by SCHOOLMSGID field
        /// </summary>
        /// <param name="SCHOOLMSGID">SCHOOLMSGID value used to find SEC_MSG</param>
        /// <returns>Related SEC_MSG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_MSG TryFindBySCHOOLMSGID(int SCHOOLMSGID)
        {
            SEC_MSG value;
            if (Index_SCHOOLMSGID.Value.TryGetValue(SCHOOLMSGID, out value))
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
