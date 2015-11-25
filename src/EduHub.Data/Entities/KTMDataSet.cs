using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Task Message Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KTMDataSet : SetBase<KTM>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KTM"; } }

        internal KTMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TID = new Lazy<Dictionary<int, KTM>>(() => this.ToDictionary(i => i.TID));
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

        #region Index Fields

        private Lazy<Dictionary<int, KTM>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KTM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KTM</param>
        /// <returns>Related KTM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTM FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find KTM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KTM</param>
        /// <param name="Value">Related KTM entity</param>
        /// <returns>True if the related KTM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out KTM Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find KTM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KTM</param>
        /// <returns>Related KTM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTM TryFindByTID(int TID)
        {
            KTM value;
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
