using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Batch Headers Data Set
    /// </summary>
    public sealed class QBDataSet : SetBase<QB>
    {
        private Lazy<Dictionary<int, QB>> QBKEYIndex;

        internal QBDataSet(EduHubContext Context)
            : base(Context)
        {
            QBKEYIndex = new Lazy<Dictionary<int, QB>>(() => this.ToDictionary(e => e.QBKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "QB"; } }

        /// <summary>
        /// Find QB by QBKEY key field
        /// </summary>
        /// <param name="Key">QBKEY value used to find QB</param>
        /// <returns>Related QB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">QBKEY value didn't match any QB entities</exception>
        public QB FindByQBKEY(int Key)
        {
            QB result;
            if (QBKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find QB by QBKEY key field
        /// </summary>
        /// <param name="Key">QBKEY value used to find QB</param>
        /// <param name="Value">Related QB entity</param>
        /// <returns>True if the QB Entity is found</returns>
        public bool TryFindByQBKEY(int Key, out QB Value)
        {
            return QBKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find QB by QBKEY key field
        /// </summary>
        /// <param name="Key">QBKEY value used to find QB</param>
        /// <returns>Related QB entity, or null if not found</returns>
        public QB TryFindByQBKEY(int Key)
        {
            QB result;
            if (QBKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<QB, string>[] BuildMapper(List<string> Headers)
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
    }
}
