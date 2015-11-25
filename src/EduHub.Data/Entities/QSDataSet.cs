using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Stored SQL Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class QSDataSet : SetBase<QS>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "QS"; } }

        internal QSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_QSKEY = new Lazy<Dictionary<string, QS>>(() => this.ToDictionary(i => i.QSKEY));
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

        #region Index Fields

        private Lazy<Dictionary<string, QS>> Index_QSKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find QS by QSKEY field
        /// </summary>
        /// <param name="QSKEY">QSKEY value used to find QS</param>
        /// <returns>Related QS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public QS FindByQSKEY(string QSKEY)
        {
            return Index_QSKEY.Value[QSKEY];
        }

        /// <summary>
        /// Attempt to find QS by QSKEY field
        /// </summary>
        /// <param name="QSKEY">QSKEY value used to find QS</param>
        /// <param name="Value">Related QS entity</param>
        /// <returns>True if the related QS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByQSKEY(string QSKEY, out QS Value)
        {
            return Index_QSKEY.Value.TryGetValue(QSKEY, out Value);
        }

        /// <summary>
        /// Attempt to find QS by QSKEY field
        /// </summary>
        /// <param name="QSKEY">QSKEY value used to find QS</param>
        /// <returns>Related QS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public QS TryFindByQSKEY(string QSKEY)
        {
            QS value;
            if (Index_QSKEY.Value.TryGetValue(QSKEY, out value))
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
