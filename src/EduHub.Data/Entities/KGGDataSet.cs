using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Year 9-12 Exit Categories Data Set
    /// </summary>
    public sealed class KGGDataSet : SetBase<KGG>
    {
        private Lazy<Dictionary<string, KGG>> KGGKEYIndex;

        internal KGGDataSet(EduHubContext Context)
            : base(Context)
        {
            KGGKEYIndex = new Lazy<Dictionary<string, KGG>>(() => this.ToDictionary(e => e.KGGKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGG"; } }

        /// <summary>
        /// Find KGG by KGGKEY key field
        /// </summary>
        /// <param name="Key">KGGKEY value used to find KGG</param>
        /// <returns>Related KGG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KGGKEY value didn't match any KGG entities</exception>
        public KGG FindByKGGKEY(string Key)
        {
            KGG result;
            if (KGGKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KGG by KGGKEY key field
        /// </summary>
        /// <param name="Key">KGGKEY value used to find KGG</param>
        /// <param name="Value">Related KGG entity</param>
        /// <returns>True if the KGG entity is found</returns>
        public bool TryFindByKGGKEY(string Key, out KGG Value)
        {
            return KGGKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KGG by KGGKEY key field
        /// </summary>
        /// <param name="Key">KGGKEY value used to find KGG</param>
        /// <returns>Related KGG entity, or null if not found</returns>
        public KGG TryFindByKGGKEY(string Key)
        {
            KGG result;
            if (KGGKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGG" /> fields for each CSV column header</returns>
        protected override Action<KGG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGGKEY":
                        mapper[i] = (e, v) => e.KGGKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "EDFLAG_ORDER":
                        mapper[i] = (e, v) => e.EDFLAG_ORDER = v;
                        break;
                    case "OPEN_CLOSED":
                        mapper[i] = (e, v) => e.OPEN_CLOSED = v;
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
