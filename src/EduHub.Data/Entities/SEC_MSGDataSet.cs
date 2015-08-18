using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 School Message Data Set
    /// </summary>
    public sealed class SEC_MSGDataSet : SetBase<SEC_MSG>
    {
        private Lazy<Dictionary<int, SEC_MSG>> SCHOOLMSGIDIndex;

        internal SEC_MSGDataSet(EduHubContext Context)
            : base(Context)
        {
            SCHOOLMSGIDIndex = new Lazy<Dictionary<int, SEC_MSG>>(() => this.ToDictionary(e => e.SCHOOLMSGID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SEC_MSG"; } }

        /// <summary>
        /// Find SEC_MSG by SCHOOLMSGID key field
        /// </summary>
        /// <param name="Key">SCHOOLMSGID value used to find SEC_MSG</param>
        /// <returns>Related SEC_MSG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SCHOOLMSGID value didn't match any SEC_MSG entities</exception>
        public SEC_MSG FindBySCHOOLMSGID(int Key)
        {
            SEC_MSG result;
            if (SCHOOLMSGIDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SEC_MSG by SCHOOLMSGID key field
        /// </summary>
        /// <param name="Key">SCHOOLMSGID value used to find SEC_MSG</param>
        /// <param name="Value">Related SEC_MSG entity</param>
        /// <returns>True if the SEC_MSG Entity is found</returns>
        public bool TryFindBySCHOOLMSGID(int Key, out SEC_MSG Value)
        {
            return SCHOOLMSGIDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SEC_MSG by SCHOOLMSGID key field
        /// </summary>
        /// <param name="Key">SCHOOLMSGID value used to find SEC_MSG</param>
        /// <returns>Related SEC_MSG entity, or null if not found</returns>
        public SEC_MSG TryFindBySCHOOLMSGID(int Key)
        {
            SEC_MSG result;
            if (SCHOOLMSGIDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SEC_MSG, string>[] BuildMapper(List<string> Headers)
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
    }
}
