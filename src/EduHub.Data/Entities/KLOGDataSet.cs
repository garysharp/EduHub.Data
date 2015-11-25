using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Trace log for finance import and export Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KLOGDataSet : SetBase<KLOG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KLOG"; } }

        internal KLOGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TID = new Lazy<Dictionary<int, KLOG>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KLOG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KLOG" /> fields for each CSV column header</returns>
        protected override Action<KLOG, string>[] BuildMapper(IReadOnlyList<string> Headers)
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

        #region Index Fields

        private Lazy<Dictionary<int, KLOG>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KLOG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KLOG</param>
        /// <returns>Related KLOG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KLOG FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find KLOG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KLOG</param>
        /// <param name="Value">Related KLOG entity</param>
        /// <returns>True if the related KLOG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out KLOG Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find KLOG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KLOG</param>
        /// <returns>Related KLOG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KLOG TryFindByTID(int TID)
        {
            KLOG value;
            if (Index_TID.Value.TryGetValue(TID, out value))
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
