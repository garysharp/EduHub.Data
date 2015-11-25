using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Batch Headers Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class QBDataSet : SetBase<QB>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "QB"; } }

        internal QBDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_QBKEY = new Lazy<Dictionary<int, QB>>(() => this.ToDictionary(i => i.QBKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="QB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="QB" /> fields for each CSV column header</returns>
        protected override Action<QB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<QB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "QBKEY":
                        mapper[i] = (e, v) => e.QBKEY = int.Parse(v);
                        break;
                    case "NARRATIVE":
                        mapper[i] = (e, v) => e.NARRATIVE = v;
                        break;
                    case "TOTAL":
                        mapper[i] = (e, v) => e.TOTAL = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CLASS":
                        mapper[i] = (e, v) => e.CLASS = v;
                        break;
                    case "QUANTITY":
                        mapper[i] = (e, v) => e.QUANTITY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BATCHTYPE":
                        mapper[i] = (e, v) => e.BATCHTYPE = v;
                        break;
                    case "TRANSTYPE":
                        mapper[i] = (e, v) => e.TRANSTYPE = v;
                        break;
                    case "BATCHDATA":
                        mapper[i] = (e, v) => e.BATCHDATA = null; // eduHub is not encoding byte arrays
                        break;
                    case "BATCHPRINTED":
                        mapper[i] = (e, v) => e.BATCHPRINTED = v;
                        break;
                    case "BANKPRINTED":
                        mapper[i] = (e, v) => e.BANKPRINTED = v;
                        break;
                    case "BATCHTRACE":
                        mapper[i] = (e, v) => e.BATCHTRACE = v;
                        break;
                    case "BATCHCLASS":
                        mapper[i] = (e, v) => e.BATCHCLASS = v == null ? (short?)null : short.Parse(v);
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

        private Lazy<Dictionary<int, QB>> Index_QBKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find QB by QBKEY field
        /// </summary>
        /// <param name="QBKEY">QBKEY value used to find QB</param>
        /// <returns>Related QB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public QB FindByQBKEY(int QBKEY)
        {
            return Index_QBKEY.Value[QBKEY];
        }

        /// <summary>
        /// Attempt to find QB by QBKEY field
        /// </summary>
        /// <param name="QBKEY">QBKEY value used to find QB</param>
        /// <param name="Value">Related QB entity</param>
        /// <returns>True if the related QB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByQBKEY(int QBKEY, out QB Value)
        {
            return Index_QBKEY.Value.TryGetValue(QBKEY, out Value);
        }

        /// <summary>
        /// Attempt to find QB by QBKEY field
        /// </summary>
        /// <param name="QBKEY">QBKEY value used to find QB</param>
        /// <returns>Related QB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public QB TryFindByQBKEY(int QBKEY)
        {
            QB value;
            if (Index_QBKEY.Value.TryGetValue(QBKEY, out value))
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
