using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Task Message Data Set
    /// </summary>
    public sealed class KTMDataSet : SetBase<KTM>
    {
        private Lazy<Dictionary<int, KTM>> TIDIndex;

        internal KTMDataSet(EduHubContext Context)
            : base(Context)
        {
            TIDIndex = new Lazy<Dictionary<int, KTM>>(() => this.ToDictionary(e => e.TID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KTM"; } }

        /// <summary>
        /// Find KTM by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find KTM</param>
        /// <returns>Related KTM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TID value didn't match any KTM entities</exception>
        public KTM FindByTID(int Key)
        {
            KTM result;
            if (TIDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KTM by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find KTM</param>
        /// <param name="Value">Related KTM entity</param>
        /// <returns>True if the KTM entity is found</returns>
        public bool TryFindByTID(int Key, out KTM Value)
        {
            return TIDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KTM by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find KTM</param>
        /// <returns>Related KTM entity, or null if not found</returns>
        public KTM TryFindByTID(int Key)
        {
            KTM result;
            if (TIDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KTM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KTM" /> fields for each CSV column header</returns>
        protected override Action<KTM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KTM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "KTMKEY":
                        mapper[i] = (e, v) => e.KTMKEY = v;
                        break;
                    case "MESSAGE":
                        mapper[i] = (e, v) => e.MESSAGE = v;
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
