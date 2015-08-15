using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 School Links URL Data Set
    /// </summary>
    public sealed class SEC_URL_DataSet : SetBase<SEC_URL_Entity>
    {
        private Lazy<Dictionary<int, SEC_URL_Entity>> SCHOOLURLID_Index;

        internal SEC_URL_DataSet(EduHubContext Context)
            : base(Context)
        {
            SCHOOLURLID_Index = new Lazy<Dictionary<int, SEC_URL_Entity>>(() => this.ToDictionary(e => e.SCHOOLURLID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SEC_URL"; } }

        /// <summary>
        /// Find SEC_URL by SCHOOLURLID key field
        /// </summary>
        /// <param name="Key">SCHOOLURLID value used to find SEC_URL</param>
        /// <returns>Related SEC_URL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SCHOOLURLID value didn't match any SEC_URL entities</exception>
        public SEC_URL_Entity FindBySCHOOLURLID(int Key)
        {
            SEC_URL_Entity result;
            if (SCHOOLURLID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SEC_URL by SCHOOLURLID key field
        /// </summary>
        /// <param name="Key">SCHOOLURLID value used to find SEC_URL</param>
        /// <param name="Value">Related SEC_URL entity</param>
        /// <returns>True if the SEC_URL Entity is found</returns>
        public bool TryFindBySCHOOLURLID(int Key, out SEC_URL_Entity Value)
        {
            return SCHOOLURLID_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SEC_URL by SCHOOLURLID key field
        /// </summary>
        /// <param name="Key">SCHOOLURLID value used to find SEC_URL</param>
        /// <returns>Related SEC_URL entity, or null if not found</returns>
        public SEC_URL_Entity TryFindBySCHOOLURLID(int Key)
        {
            SEC_URL_Entity result;
            if (SCHOOLURLID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SEC_URL_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SEC_URL_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCHOOLURLID":
                        mapper[i] = (e, v) => e.SCHOOLURLID = int.Parse(v);
                        break;
                    case "LINKNAME":
                        mapper[i] = (e, v) => e.LINKNAME = v;
                        break;
                    case "MAINURL":
                        mapper[i] = (e, v) => e.MAINURL = v;
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
