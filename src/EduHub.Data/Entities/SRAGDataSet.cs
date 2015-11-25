using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// FTE Student Retentions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SRAGDataSet : SetBase<SRAG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SRAG"; } }

        internal SRAGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SRAG_ID = new Lazy<Dictionary<int, SRAG>>(() => this.ToDictionary(i => i.SRAG_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SRAG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SRAG" /> fields for each CSV column header</returns>
        protected override Action<SRAG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SRAG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SRAG_ID":
                        mapper[i] = (e, v) => e.SRAG_ID = int.Parse(v);
                        break;
                    case "BRY":
                        mapper[i] = (e, v) => e.BRY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD":
                        mapper[i] = (e, v) => e.PERIOD = v;
                        break;
                    case "RETENTION":
                        mapper[i] = (e, v) => e.RETENTION = v == null ? (double?)null : double.Parse(v);
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

        private Lazy<Dictionary<int, SRAG>> Index_SRAG_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SRAG by SRAG_ID field
        /// </summary>
        /// <param name="SRAG_ID">SRAG_ID value used to find SRAG</param>
        /// <returns>Related SRAG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SRAG FindBySRAG_ID(int SRAG_ID)
        {
            return Index_SRAG_ID.Value[SRAG_ID];
        }

        /// <summary>
        /// Attempt to find SRAG by SRAG_ID field
        /// </summary>
        /// <param name="SRAG_ID">SRAG_ID value used to find SRAG</param>
        /// <param name="Value">Related SRAG entity</param>
        /// <returns>True if the related SRAG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySRAG_ID(int SRAG_ID, out SRAG Value)
        {
            return Index_SRAG_ID.Value.TryGetValue(SRAG_ID, out Value);
        }

        /// <summary>
        /// Attempt to find SRAG by SRAG_ID field
        /// </summary>
        /// <param name="SRAG_ID">SRAG_ID value used to find SRAG</param>
        /// <returns>Related SRAG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SRAG TryFindBySRAG_ID(int SRAG_ID)
        {
            SRAG value;
            if (Index_SRAG_ID.Value.TryGetValue(SRAG_ID, out value))
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
