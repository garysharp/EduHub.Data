using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 User Sessions Data Set
    /// </summary>
    public sealed class SEC_USR_DataSet : SetBase<SEC_USR_Entity>
    {
        private Lazy<Dictionary<int, SEC_USR_Entity>> ROWID_Index;

        internal SEC_USR_DataSet(EduHubContext Context)
            : base(Context)
        {
            ROWID_Index = new Lazy<Dictionary<int, SEC_USR_Entity>>(() => this.ToDictionary(e => e.ROWID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SEC_USR"; } }

        /// <summary>
        /// Find SEC_USR by ROWID key field
        /// </summary>
        /// <param name="Key">ROWID value used to find SEC_USR</param>
        /// <returns>Related SEC_USR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ROWID value didn't match any SEC_USR entities</exception>
        public SEC_USR_Entity FindByROWID(int Key)
        {
            SEC_USR_Entity result;
            if (ROWID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SEC_USR by ROWID key field
        /// </summary>
        /// <param name="Key">ROWID value used to find SEC_USR</param>
        /// <param name="Value">Related SEC_USR entity</param>
        /// <returns>True if the SEC_USR Entity is found</returns>
        public bool TryFindByROWID(int Key, out SEC_USR_Entity Value)
        {
            return ROWID_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SEC_USR by ROWID key field
        /// </summary>
        /// <param name="Key">ROWID value used to find SEC_USR</param>
        /// <returns>Related SEC_USR entity, or null if not found</returns>
        public SEC_USR_Entity TryFindByROWID(int Key)
        {
            SEC_USR_Entity result;
            if (ROWID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SEC_USR_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SEC_USR_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ROWID":
                        mapper[i] = (e, v) => e.ROWID = int.Parse(v);
                        break;
                    case "SESSIONID":
                        mapper[i] = (e, v) => e.SESSIONID = v;
                        break;
                    case "USERID":
                        mapper[i] = (e, v) => e.USERID = v;
                        break;
                    case "DATECREATED":
                        mapper[i] = (e, v) => e.DATECREATED = v == null ? (DateTime?)null : DateTime.Parse(v);
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
