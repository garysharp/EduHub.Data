using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Trace log for finance import and export Data Set
    /// </summary>
    public sealed class KLOGDataSet : SetBase<KLOG>
    {
        private Lazy<Dictionary<int, KLOG>> TIDIndex;

        internal KLOGDataSet(EduHubContext Context)
            : base(Context)
        {
            TIDIndex = new Lazy<Dictionary<int, KLOG>>(() => this.ToDictionary(e => e.TID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KLOG"; } }

        /// <summary>
        /// Find KLOG by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find KLOG</param>
        /// <returns>Related KLOG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TID value didn't match any KLOG entities</exception>
        public KLOG FindByTID(int Key)
        {
            KLOG result;
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
        /// Attempt to find KLOG by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find KLOG</param>
        /// <param name="Value">Related KLOG entity</param>
        /// <returns>True if the KLOG entity is found</returns>
        public bool TryFindByTID(int Key, out KLOG Value)
        {
            return TIDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KLOG by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find KLOG</param>
        /// <returns>Related KLOG entity, or null if not found</returns>
        public KLOG TryFindByTID(int Key)
        {
            KLOG result;
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
        /// Matches CSV file headers to actions, used to deserialize <see cref="KLOG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KLOG" /> fields for each CSV column header</returns>
        protected override Action<KLOG, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KLOG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SEVERITY":
                        mapper[i] = (e, v) => e.SEVERITY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MESSAGE":
                        mapper[i] = (e, v) => e.MESSAGE = v;
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
