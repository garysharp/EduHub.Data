using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Financial Data Export Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class FDT_EXPDataSet : SetBase<FDT_EXP>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "FDT_EXP"; } }

        internal FDT_EXPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_DEST = new Lazy<Dictionary<string, IReadOnlyList<FDT_EXP>>>(() => this.ToGroupedDictionary(i => i.DEST));
            Index_TID = new Lazy<Dictionary<int, FDT_EXP>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="FDT_EXP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="FDT_EXP" /> fields for each CSV column header</returns>
        protected override Action<FDT_EXP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<FDT_EXP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "DEST":
                        mapper[i] = (e, v) => e.DEST = v;
                        break;
                    case "DEST_ID":
                        mapper[i] = (e, v) => e.DEST_ID = v;
                        break;
                    case "SOURCE":
                        mapper[i] = (e, v) => e.SOURCE = v;
                        break;
                    case "SOURCE_KEY":
                        mapper[i] = (e, v) => e.SOURCE_KEY = v;
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
                        break;
                    case "EXP_DATE":
                        mapper[i] = (e, v) => e.EXP_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "EXP_TIME":
                        mapper[i] = (e, v) => e.EXP_TIME = v == null ? (short?)null : short.Parse(v);
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

        private Lazy<Dictionary<string, IReadOnlyList<FDT_EXP>>> Index_DEST;
        private Lazy<Dictionary<int, FDT_EXP>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find FDT_EXP by DEST field
        /// </summary>
        /// <param name="DEST">DEST value used to find FDT_EXP</param>
        /// <returns>List of related FDT_EXP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<FDT_EXP> FindByDEST(string DEST)
        {
            return Index_DEST.Value[DEST];
        }

        /// <summary>
        /// Attempt to find FDT_EXP by DEST field
        /// </summary>
        /// <param name="DEST">DEST value used to find FDT_EXP</param>
        /// <param name="Value">List of related FDT_EXP entities</param>
        /// <returns>True if the list of related FDT_EXP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDEST(string DEST, out IReadOnlyList<FDT_EXP> Value)
        {
            return Index_DEST.Value.TryGetValue(DEST, out Value);
        }

        /// <summary>
        /// Attempt to find FDT_EXP by DEST field
        /// </summary>
        /// <param name="DEST">DEST value used to find FDT_EXP</param>
        /// <returns>List of related FDT_EXP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<FDT_EXP> TryFindByDEST(string DEST)
        {
            IReadOnlyList<FDT_EXP> value;
            if (Index_DEST.Value.TryGetValue(DEST, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find FDT_EXP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find FDT_EXP</param>
        /// <returns>Related FDT_EXP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public FDT_EXP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find FDT_EXP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find FDT_EXP</param>
        /// <param name="Value">Related FDT_EXP entity</param>
        /// <returns>True if the related FDT_EXP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out FDT_EXP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find FDT_EXP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find FDT_EXP</param>
        /// <returns>Related FDT_EXP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public FDT_EXP TryFindByTID(int TID)
        {
            FDT_EXP value;
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
