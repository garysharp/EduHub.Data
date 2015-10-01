using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Stored SQL Data Set
    /// </summary>
    public sealed class QSDataSet : SetBase<QS>
    {
        private Lazy<Dictionary<string, QS>> QSKEYIndex;

        internal QSDataSet(EduHubContext Context)
            : base(Context)
        {
            QSKEYIndex = new Lazy<Dictionary<string, QS>>(() => this.ToDictionary(e => e.QSKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "QS"; } }

        /// <summary>
        /// Find QS by QSKEY key field
        /// </summary>
        /// <param name="Key">QSKEY value used to find QS</param>
        /// <returns>Related QS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">QSKEY value didn't match any QS entities</exception>
        public QS FindByQSKEY(string Key)
        {
            QS result;
            if (QSKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find QS by QSKEY key field
        /// </summary>
        /// <param name="Key">QSKEY value used to find QS</param>
        /// <param name="Value">Related QS entity</param>
        /// <returns>True if the QS entity is found</returns>
        public bool TryFindByQSKEY(string Key, out QS Value)
        {
            return QSKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find QS by QSKEY key field
        /// </summary>
        /// <param name="Key">QSKEY value used to find QS</param>
        /// <returns>Related QS entity, or null if not found</returns>
        public QS TryFindByQSKEY(string Key)
        {
            QS result;
            if (QSKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="QS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="QS" /> fields for each CSV column header</returns>
        protected override Action<QS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<QS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "QSKEY":
                        mapper[i] = (e, v) => e.QSKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "SQLTEXT":
                        mapper[i] = (e, v) => e.SQLTEXT = v;
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
