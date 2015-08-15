using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// FTE Student Retentions Data Set
    /// </summary>
    public sealed class SRAG_DataSet : SetBase<SRAG_Entity>
    {
        private Lazy<Dictionary<int, SRAG_Entity>> SRAG_ID_Index;

        internal SRAG_DataSet(EduHubContext Context)
            : base(Context)
        {
            SRAG_ID_Index = new Lazy<Dictionary<int, SRAG_Entity>>(() => this.ToDictionary(e => e.SRAG_ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SRAG"; } }

        /// <summary>
        /// Find SRAG by SRAG_ID key field
        /// </summary>
        /// <param name="Key">SRAG_ID value used to find SRAG</param>
        /// <returns>Related SRAG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SRAG_ID value didn't match any SRAG entities</exception>
        public SRAG_Entity FindBySRAG_ID(int Key)
        {
            SRAG_Entity result;
            if (SRAG_ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SRAG by SRAG_ID key field
        /// </summary>
        /// <param name="Key">SRAG_ID value used to find SRAG</param>
        /// <param name="Value">Related SRAG entity</param>
        /// <returns>True if the SRAG Entity is found</returns>
        public bool TryFindBySRAG_ID(int Key, out SRAG_Entity Value)
        {
            return SRAG_ID_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SRAG by SRAG_ID key field
        /// </summary>
        /// <param name="Key">SRAG_ID value used to find SRAG</param>
        /// <returns>Related SRAG entity, or null if not found</returns>
        public SRAG_Entity TryFindBySRAG_ID(int Key)
        {
            SRAG_Entity result;
            if (SRAG_ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SRAG_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SRAG_Entity, string>[Headers.Count];

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
    }
}
