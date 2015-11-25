using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// CSEF Receipt details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KEMADataSet : SetBase<KEMA>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KEMA"; } }

        internal KEMADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TID = new Lazy<Dictionary<int, KEMA>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KEMA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KEMA" /> fields for each CSV column header</returns>
        protected override Action<KEMA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KEMA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "FAMILY_KEY":
                        mapper[i] = (e, v) => e.FAMILY_KEY = v;
                        break;
                    case "STREGISTRATION":
                        mapper[i] = (e, v) => e.STREGISTRATION = v;
                        break;
                    case "EMA_PERIOD":
                        mapper[i] = (e, v) => e.EMA_PERIOD = v;
                        break;
                    case "EMA_TRAMT":
                        mapper[i] = (e, v) => e.EMA_TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "DELETE_FLAG":
                        mapper[i] = (e, v) => e.DELETE_FLAG = v;
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

        private Lazy<Dictionary<int, KEMA>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KEMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KEMA</param>
        /// <returns>Related KEMA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KEMA FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find KEMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KEMA</param>
        /// <param name="Value">Related KEMA entity</param>
        /// <returns>True if the related KEMA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out KEMA Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find KEMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KEMA</param>
        /// <returns>Related KEMA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KEMA TryFindByTID(int TID)
        {
            KEMA value;
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
