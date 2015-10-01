using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// SMS messages Data Set
    /// </summary>
    public sealed class SPSMSDataSet : SetBase<SPSMS>
    {
        private Lazy<Dictionary<int, SPSMS>> SPSMSKEYIndex;

        internal SPSMSDataSet(EduHubContext Context)
            : base(Context)
        {
            SPSMSKEYIndex = new Lazy<Dictionary<int, SPSMS>>(() => this.ToDictionary(e => e.SPSMSKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SPSMS"; } }

        /// <summary>
        /// Find SPSMS by SPSMSKEY key field
        /// </summary>
        /// <param name="Key">SPSMSKEY value used to find SPSMS</param>
        /// <returns>Related SPSMS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SPSMSKEY value didn't match any SPSMS entities</exception>
        public SPSMS FindBySPSMSKEY(int Key)
        {
            SPSMS result;
            if (SPSMSKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SPSMS by SPSMSKEY key field
        /// </summary>
        /// <param name="Key">SPSMSKEY value used to find SPSMS</param>
        /// <param name="Value">Related SPSMS entity</param>
        /// <returns>True if the SPSMS entity is found</returns>
        public bool TryFindBySPSMSKEY(int Key, out SPSMS Value)
        {
            return SPSMSKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SPSMS by SPSMSKEY key field
        /// </summary>
        /// <param name="Key">SPSMSKEY value used to find SPSMS</param>
        /// <returns>Related SPSMS entity, or null if not found</returns>
        public SPSMS TryFindBySPSMSKEY(int Key)
        {
            SPSMS result;
            if (SPSMSKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPSMS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPSMS" /> fields for each CSV column header</returns>
        protected override Action<SPSMS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPSMS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SPSMSKEY":
                        mapper[i] = (e, v) => e.SPSMSKEY = int.Parse(v);
                        break;
                    case "MESSAGE":
                        mapper[i] = (e, v) => e.MESSAGE = v;
                        break;
                    case "CREATED_DATE":
                        mapper[i] = (e, v) => e.CREATED_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CREATED_BY":
                        mapper[i] = (e, v) => e.CREATED_BY = v;
                        break;
                    case "NOTIFY_REPLIES":
                        mapper[i] = (e, v) => e.NOTIFY_REPLIES = v;
                        break;
                    case "AUTO_MESSAGE":
                        mapper[i] = (e, v) => e.AUTO_MESSAGE = v;
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_USER":
                        mapper[i] = (e, v) => e.LW_USER = v;
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
