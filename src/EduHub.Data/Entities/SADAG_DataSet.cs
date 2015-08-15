using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Absence by Cohort Aggregations Data Set
    /// </summary>
    public sealed class SADAG_DataSet : SetBase<SADAG_Entity>
    {
        private Lazy<Dictionary<int, SADAG_Entity>> SADAG_ID_Index;

        internal SADAG_DataSet(EduHubContext Context)
            : base(Context)
        {
            SADAG_ID_Index = new Lazy<Dictionary<int, SADAG_Entity>>(() => this.ToDictionary(e => e.SADAG_ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SADAG"; } }

        /// <summary>
        /// Find SADAG by SADAG_ID key field
        /// </summary>
        /// <param name="Key">SADAG_ID value used to find SADAG</param>
        /// <returns>Related SADAG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SADAG_ID value didn't match any SADAG entities</exception>
        public SADAG_Entity FindBySADAG_ID(int Key)
        {
            SADAG_Entity result;
            if (SADAG_ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SADAG by SADAG_ID key field
        /// </summary>
        /// <param name="Key">SADAG_ID value used to find SADAG</param>
        /// <param name="Value">Related SADAG entity</param>
        /// <returns>True if the SADAG Entity is found</returns>
        public bool TryFindBySADAG_ID(int Key, out SADAG_Entity Value)
        {
            return SADAG_ID_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SADAG by SADAG_ID key field
        /// </summary>
        /// <param name="Key">SADAG_ID value used to find SADAG</param>
        /// <returns>Related SADAG entity, or null if not found</returns>
        public SADAG_Entity TryFindBySADAG_ID(int Key)
        {
            SADAG_Entity result;
            if (SADAG_ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SADAG_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SADAG_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SADAG_ID":
                        mapper[i] = (e, v) => e.SADAG_ID = int.Parse(v);
                        break;
                    case "BRY":
                        mapper[i] = (e, v) => e.BRY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR = v;
                        break;
                    case "FTE":
                        mapper[i] = (e, v) => e.FTE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ABS_CODE":
                        mapper[i] = (e, v) => e.ABS_CODE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DAYS":
                        mapper[i] = (e, v) => e.DAYS = v == null ? (double?)null : double.Parse(v);
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
