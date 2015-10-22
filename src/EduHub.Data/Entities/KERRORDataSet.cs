using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Import or Update Errors Data Set
    /// </summary>
    public sealed partial class KERRORDataSet : SetBase<KERROR>
    {
        private Lazy<Dictionary<int, KERROR>> KERROR_IDIndex;


        internal KERRORDataSet(EduHubContext Context)
            : base(Context)
        {
            KERROR_IDIndex = new Lazy<Dictionary<int, KERROR>>(() => this.ToDictionary(e => e.KERROR_ID));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KERROR"; } }

        /// <summary>
        /// Find KERROR by KERROR_ID key field
        /// </summary>
        /// <param name="Key">KERROR_ID value used to find KERROR</param>
        /// <returns>Related KERROR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KERROR_ID value didn't match any KERROR entities</exception>
        public KERROR FindByKERROR_ID(int Key)
        {
            KERROR result;
            if (KERROR_IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KERROR by KERROR_ID key field
        /// </summary>
        /// <param name="Key">KERROR_ID value used to find KERROR</param>
        /// <param name="Value">Related KERROR entity</param>
        /// <returns>True if the KERROR entity is found</returns>
        public bool TryFindByKERROR_ID(int Key, out KERROR Value)
        {
            return KERROR_IDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KERROR by KERROR_ID key field
        /// </summary>
        /// <param name="Key">KERROR_ID value used to find KERROR</param>
        /// <returns>Related KERROR entity, or null if not found</returns>
        public KERROR TryFindByKERROR_ID(int Key)
        {
            KERROR result;
            if (KERROR_IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KERROR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KERROR" /> fields for each CSV column header</returns>
        protected override Action<KERROR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KERROR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KERROR_ID":
                        mapper[i] = (e, v) => e.KERROR_ID = int.Parse(v);
                        break;
                    case "SOURCE":
                        mapper[i] = (e, v) => e.SOURCE = v;
                        break;
                    case "TEXT01":
                        mapper[i] = (e, v) => e.TEXT01 = v;
                        break;
                    case "TEXT02":
                        mapper[i] = (e, v) => e.TEXT02 = v;
                        break;
                    case "TEXT03":
                        mapper[i] = (e, v) => e.TEXT03 = v;
                        break;
                    case "TEXT04":
                        mapper[i] = (e, v) => e.TEXT04 = v;
                        break;
                    case "TEXT05":
                        mapper[i] = (e, v) => e.TEXT05 = v;
                        break;
                    case "TEXT06":
                        mapper[i] = (e, v) => e.TEXT06 = v;
                        break;
                    case "TEXT07":
                        mapper[i] = (e, v) => e.TEXT07 = v;
                        break;
                    case "TEXT08":
                        mapper[i] = (e, v) => e.TEXT08 = v;
                        break;
                    case "TEXT09":
                        mapper[i] = (e, v) => e.TEXT09 = v;
                        break;
                    case "VALIDATION":
                        mapper[i] = (e, v) => e.VALIDATION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PROCESSED":
                        mapper[i] = (e, v) => e.PROCESSED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "ERROR_TEXT":
                        mapper[i] = (e, v) => e.ERROR_TEXT = v;
                        break;
                    case "SPOUTKEY":
                        mapper[i] = (e, v) => e.SPOUTKEY = v;
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
