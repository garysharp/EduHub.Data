using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 School Links URL Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SEC_URLDataSet : SetBase<SEC_URL>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SEC_URL"; } }

        internal SEC_URLDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SCHOOLURLID = new Lazy<Dictionary<int, SEC_URL>>(() => this.ToDictionary(i => i.SCHOOLURLID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SEC_URL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SEC_URL" /> fields for each CSV column header</returns>
        protected override Action<SEC_URL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SEC_URL, string>[Headers.Count];

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

        #region Index Fields

        private Lazy<Dictionary<int, SEC_URL>> Index_SCHOOLURLID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SEC_URL by SCHOOLURLID field
        /// </summary>
        /// <param name="SCHOOLURLID">SCHOOLURLID value used to find SEC_URL</param>
        /// <returns>Related SEC_URL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_URL FindBySCHOOLURLID(int SCHOOLURLID)
        {
            return Index_SCHOOLURLID.Value[SCHOOLURLID];
        }

        /// <summary>
        /// Attempt to find SEC_URL by SCHOOLURLID field
        /// </summary>
        /// <param name="SCHOOLURLID">SCHOOLURLID value used to find SEC_URL</param>
        /// <param name="Value">Related SEC_URL entity</param>
        /// <returns>True if the related SEC_URL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCHOOLURLID(int SCHOOLURLID, out SEC_URL Value)
        {
            return Index_SCHOOLURLID.Value.TryGetValue(SCHOOLURLID, out Value);
        }

        /// <summary>
        /// Attempt to find SEC_URL by SCHOOLURLID field
        /// </summary>
        /// <param name="SCHOOLURLID">SCHOOLURLID value used to find SEC_URL</param>
        /// <returns>Related SEC_URL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_URL TryFindBySCHOOLURLID(int SCHOOLURLID)
        {
            SEC_URL value;
            if (Index_SCHOOLURLID.Value.TryGetValue(SCHOOLURLID, out value))
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
