using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Report email templates Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPEMAILDataSet : SetBase<SPEMAIL>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SPEMAIL"; } }

        internal SPEMAILDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SPEMAILKEY = new Lazy<Dictionary<string, SPEMAIL>>(() => this.ToDictionary(i => i.SPEMAILKEY));
            Index_REPORT = new Lazy<NullDictionary<string, IReadOnlyList<SPEMAIL>>>(() => this.ToGroupedNullDictionary(i => i.REPORT));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPEMAIL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPEMAIL" /> fields for each CSV column header</returns>
        protected override Action<SPEMAIL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPEMAIL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SPEMAILKEY":
                        mapper[i] = (e, v) => e.SPEMAILKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "REPORT":
                        mapper[i] = (e, v) => e.REPORT = v;
                        break;
                    case "PRINT_PATH":
                        mapper[i] = (e, v) => e.PRINT_PATH = v;
                        break;
                    case "IMPORTANCE":
                        mapper[i] = (e, v) => e.IMPORTANCE = v;
                        break;
                    case "SEND_OPTION":
                        mapper[i] = (e, v) => e.SEND_OPTION = v;
                        break;
                    case "EMAIL_SUBJECT":
                        mapper[i] = (e, v) => e.EMAIL_SUBJECT = v;
                        break;
                    case "EMAIL_MESSAGE":
                        mapper[i] = (e, v) => e.EMAIL_MESSAGE = v;
                        break;
                    case "EMAIL_HTML":
                        mapper[i] = (e, v) => e.EMAIL_HTML = v;
                        break;
                    case "HTML_MESSAGE":
                        mapper[i] = (e, v) => e.HTML_MESSAGE = v;
                        break;
                    case "FROM_ADDRESS":
                        mapper[i] = (e, v) => e.FROM_ADDRESS = v;
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

        private Lazy<Dictionary<string, SPEMAIL>> Index_SPEMAILKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SPEMAIL>>> Index_REPORT;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SPEMAIL by SPEMAILKEY field
        /// </summary>
        /// <param name="SPEMAILKEY">SPEMAILKEY value used to find SPEMAIL</param>
        /// <returns>Related SPEMAIL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPEMAIL FindBySPEMAILKEY(string SPEMAILKEY)
        {
            return Index_SPEMAILKEY.Value[SPEMAILKEY];
        }

        /// <summary>
        /// Attempt to find SPEMAIL by SPEMAILKEY field
        /// </summary>
        /// <param name="SPEMAILKEY">SPEMAILKEY value used to find SPEMAIL</param>
        /// <param name="Value">Related SPEMAIL entity</param>
        /// <returns>True if the related SPEMAIL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySPEMAILKEY(string SPEMAILKEY, out SPEMAIL Value)
        {
            return Index_SPEMAILKEY.Value.TryGetValue(SPEMAILKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SPEMAIL by SPEMAILKEY field
        /// </summary>
        /// <param name="SPEMAILKEY">SPEMAILKEY value used to find SPEMAIL</param>
        /// <returns>Related SPEMAIL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPEMAIL TryFindBySPEMAILKEY(string SPEMAILKEY)
        {
            SPEMAIL value;
            if (Index_SPEMAILKEY.Value.TryGetValue(SPEMAILKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SPEMAIL by REPORT field
        /// </summary>
        /// <param name="REPORT">REPORT value used to find SPEMAIL</param>
        /// <returns>List of related SPEMAIL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPEMAIL> FindByREPORT(string REPORT)
        {
            return Index_REPORT.Value[REPORT];
        }

        /// <summary>
        /// Attempt to find SPEMAIL by REPORT field
        /// </summary>
        /// <param name="REPORT">REPORT value used to find SPEMAIL</param>
        /// <param name="Value">List of related SPEMAIL entities</param>
        /// <returns>True if the list of related SPEMAIL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByREPORT(string REPORT, out IReadOnlyList<SPEMAIL> Value)
        {
            return Index_REPORT.Value.TryGetValue(REPORT, out Value);
        }

        /// <summary>
        /// Attempt to find SPEMAIL by REPORT field
        /// </summary>
        /// <param name="REPORT">REPORT value used to find SPEMAIL</param>
        /// <returns>List of related SPEMAIL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPEMAIL> TryFindByREPORT(string REPORT)
        {
            IReadOnlyList<SPEMAIL> value;
            if (Index_REPORT.Value.TryGetValue(REPORT, out value))
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
