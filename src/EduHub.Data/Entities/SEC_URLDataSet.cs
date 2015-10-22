﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 School Links URL Data Set
    /// </summary>
    public sealed partial class SEC_URLDataSet : SetBase<SEC_URL>
    {
        private Lazy<Dictionary<int, SEC_URL>> SCHOOLURLIDIndex;


        internal SEC_URLDataSet(EduHubContext Context)
            : base(Context)
        {
            SCHOOLURLIDIndex = new Lazy<Dictionary<int, SEC_URL>>(() => this.ToDictionary(e => e.SCHOOLURLID));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SEC_URL"; } }

        /// <summary>
        /// Find SEC_URL by SCHOOLURLID key field
        /// </summary>
        /// <param name="Key">SCHOOLURLID value used to find SEC_URL</param>
        /// <returns>Related SEC_URL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SCHOOLURLID value didn't match any SEC_URL entities</exception>
        public SEC_URL FindBySCHOOLURLID(int Key)
        {
            SEC_URL result;
            if (SCHOOLURLIDIndex.Value.TryGetValue(Key, out result))
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
        /// <returns>True if the SEC_URL entity is found</returns>
        public bool TryFindBySCHOOLURLID(int Key, out SEC_URL Value)
        {
            return SCHOOLURLIDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SEC_URL by SCHOOLURLID key field
        /// </summary>
        /// <param name="Key">SCHOOLURLID value used to find SEC_URL</param>
        /// <returns>Related SEC_URL entity, or null if not found</returns>
        public SEC_URL TryFindBySCHOOLURLID(int Key)
        {
            SEC_URL result;
            if (SCHOOLURLIDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
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
    }
}
