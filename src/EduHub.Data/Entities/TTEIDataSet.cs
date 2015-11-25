using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Exam Details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TTEIDataSet : SetBase<TTEI>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TTEI"; } }

        internal TTEIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GKEY = new Lazy<Dictionary<string, IReadOnlyList<TTEI>>>(() => this.ToGroupedDictionary(i => i.GKEY));
            Index_TID = new Lazy<Dictionary<int, TTEI>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TTEI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TTEI" /> fields for each CSV column header</returns>
        protected override Action<TTEI, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TTEI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "GKEY":
                        mapper[i] = (e, v) => e.GKEY = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "MAX_SIZE":
                        mapper[i] = (e, v) => e.MAX_SIZE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAX_LINES":
                        mapper[i] = (e, v) => e.MAX_LINES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "USE_FIXED":
                        mapper[i] = (e, v) => e.USE_FIXED = v;
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

        private Lazy<Dictionary<string, IReadOnlyList<TTEI>>> Index_GKEY;
        private Lazy<Dictionary<int, TTEI>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TTEI by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEI</param>
        /// <returns>List of related TTEI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEI> FindByGKEY(string GKEY)
        {
            return Index_GKEY.Value[GKEY];
        }

        /// <summary>
        /// Attempt to find TTEI by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEI</param>
        /// <param name="Value">List of related TTEI entities</param>
        /// <returns>True if the list of related TTEI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGKEY(string GKEY, out IReadOnlyList<TTEI> Value)
        {
            return Index_GKEY.Value.TryGetValue(GKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TTEI by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEI</param>
        /// <returns>List of related TTEI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEI> TryFindByGKEY(string GKEY)
        {
            IReadOnlyList<TTEI> value;
            if (Index_GKEY.Value.TryGetValue(GKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TTEI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEI</param>
        /// <returns>Related TTEI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTEI FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TTEI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEI</param>
        /// <param name="Value">Related TTEI entity</param>
        /// <returns>True if the related TTEI entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TTEI Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TTEI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEI</param>
        /// <returns>Related TTEI entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTEI TryFindByTID(int TID)
        {
            TTEI value;
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
