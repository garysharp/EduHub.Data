using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 User Sessions Data Set
    /// </summary>
    public sealed class SEC_USRDataSet : SetBase<SEC_USR>
    {
        private Lazy<Dictionary<int, SEC_USR>> ROWIDIndex;

        internal SEC_USRDataSet(EduHubContext Context)
            : base(Context)
        {
            ROWIDIndex = new Lazy<Dictionary<int, SEC_USR>>(() => this.ToDictionary(e => e.ROWID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SEC_USR"; } }

        /// <summary>
        /// Find SEC_USR by ROWID key field
        /// </summary>
        /// <param name="Key">ROWID value used to find SEC_USR</param>
        /// <returns>Related SEC_USR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ROWID value didn't match any SEC_USR entities</exception>
        public SEC_USR FindByROWID(int Key)
        {
            SEC_USR result;
            if (ROWIDIndex.Value.TryGetValue(Key, out result))
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
        /// <returns>True if the SEC_USR entity is found</returns>
        public bool TryFindByROWID(int Key, out SEC_USR Value)
        {
            return ROWIDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SEC_USR by ROWID key field
        /// </summary>
        /// <param name="Key">ROWID value used to find SEC_USR</param>
        /// <returns>Related SEC_USR entity, or null if not found</returns>
        public SEC_USR TryFindByROWID(int Key)
        {
            SEC_USR result;
            if (ROWIDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SEC_USR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SEC_USR" /> fields for each CSV column header</returns>
        protected override Action<SEC_USR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SEC_USR, string>[Headers.Count];

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
