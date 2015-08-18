using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 Error Log Data Set
    /// </summary>
    public sealed class SEC_ELOGDataSet : SetBase<SEC_ELOG>
    {
        private Lazy<Dictionary<int, SEC_ELOG>> ERRORCOUNTIndex;

        internal SEC_ELOGDataSet(EduHubContext Context)
            : base(Context)
        {
            ERRORCOUNTIndex = new Lazy<Dictionary<int, SEC_ELOG>>(() => this.ToDictionary(e => e.ERRORCOUNT));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SEC_ELOG"; } }

        /// <summary>
        /// Find SEC_ELOG by ERRORCOUNT key field
        /// </summary>
        /// <param name="Key">ERRORCOUNT value used to find SEC_ELOG</param>
        /// <returns>Related SEC_ELOG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ERRORCOUNT value didn't match any SEC_ELOG entities</exception>
        public SEC_ELOG FindByERRORCOUNT(int Key)
        {
            SEC_ELOG result;
            if (ERRORCOUNTIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SEC_ELOG by ERRORCOUNT key field
        /// </summary>
        /// <param name="Key">ERRORCOUNT value used to find SEC_ELOG</param>
        /// <param name="Value">Related SEC_ELOG entity</param>
        /// <returns>True if the SEC_ELOG Entity is found</returns>
        public bool TryFindByERRORCOUNT(int Key, out SEC_ELOG Value)
        {
            return ERRORCOUNTIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SEC_ELOG by ERRORCOUNT key field
        /// </summary>
        /// <param name="Key">ERRORCOUNT value used to find SEC_ELOG</param>
        /// <returns>Related SEC_ELOG entity, or null if not found</returns>
        public SEC_ELOG TryFindByERRORCOUNT(int Key)
        {
            SEC_ELOG result;
            if (ERRORCOUNTIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SEC_ELOG, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SEC_ELOG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ERRORCOUNT":
                        mapper[i] = (e, v) => e.ERRORCOUNT = int.Parse(v);
                        break;
                    case "ERRORDESCRIPTION":
                        mapper[i] = (e, v) => e.ERRORDESCRIPTION = v;
                        break;
                    case "ERRORTYPE":
                        mapper[i] = (e, v) => e.ERRORTYPE = v;
                        break;
                    case "ERRORTIME":
                        mapper[i] = (e, v) => e.ERRORTIME = v == null ? (DateTime?)null : DateTime.Parse(v);
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
