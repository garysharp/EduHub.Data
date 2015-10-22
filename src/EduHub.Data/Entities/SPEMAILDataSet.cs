using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Report email templates Data Set
    /// </summary>
    public sealed partial class SPEMAILDataSet : SetBase<SPEMAIL>
    {
        private Lazy<Dictionary<string, SPEMAIL>> SPEMAILKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<SPEPRINT>>> SPEPRINT_CODEForeignIndex;

        internal SPEMAILDataSet(EduHubContext Context)
            : base(Context)
        {
            SPEMAILKEYIndex = new Lazy<Dictionary<string, SPEMAIL>>(() => this.ToDictionary(e => e.SPEMAILKEY));

            SPEPRINT_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SPEPRINT>>>(() =>
                    Context.SPEPRINT
                          .Where(e => e.CODE != null)
                          .GroupBy(e => e.CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SPEPRINT>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SPEMAIL"; } }

        /// <summary>
        /// Find SPEMAIL by SPEMAILKEY key field
        /// </summary>
        /// <param name="Key">SPEMAILKEY value used to find SPEMAIL</param>
        /// <returns>Related SPEMAIL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SPEMAILKEY value didn't match any SPEMAIL entities</exception>
        public SPEMAIL FindBySPEMAILKEY(string Key)
        {
            SPEMAIL result;
            if (SPEMAILKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SPEMAIL by SPEMAILKEY key field
        /// </summary>
        /// <param name="Key">SPEMAILKEY value used to find SPEMAIL</param>
        /// <param name="Value">Related SPEMAIL entity</param>
        /// <returns>True if the SPEMAIL entity is found</returns>
        public bool TryFindBySPEMAILKEY(string Key, out SPEMAIL Value)
        {
            return SPEMAILKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SPEMAIL by SPEMAILKEY key field
        /// </summary>
        /// <param name="Key">SPEMAILKEY value used to find SPEMAIL</param>
        /// <returns>Related SPEMAIL entity, or null if not found</returns>
        public SPEMAIL TryFindBySPEMAILKEY(string Key)
        {
            SPEMAIL result;
            if (SPEMAILKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all SPEPRINT (Report file audit) entities by [SPEPRINT.CODE]-&gt;[SPEMAIL.SPEMAILKEY]
        /// </summary>
        /// <param name="SPEMAILKEY">SPEMAILKEY value used to find SPEPRINT entities</param>
        /// <returns>A list of related SPEPRINT entities</returns>
        public IReadOnlyList<SPEPRINT> FindSPEPRINTByCODE(string SPEMAILKEY)
        {
            IReadOnlyList<SPEPRINT> result;
            if (SPEPRINT_CODEForeignIndex.Value.TryGetValue(SPEMAILKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SPEPRINT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SPEPRINT entities by [SPEPRINT.CODE]-&gt;[SPEMAIL.SPEMAILKEY]
        /// </summary>
        /// <param name="SPEMAILKEY">SPEMAILKEY value used to find SPEPRINT entities</param>
        /// <param name="Value">A list of related SPEPRINT entities</param>
        /// <returns>True if any SPEPRINT entities are found</returns>
        public bool TryFindSPEPRINTByCODE(string SPEMAILKEY, out IReadOnlyList<SPEPRINT> Value)
        {
            return SPEPRINT_CODEForeignIndex.Value.TryGetValue(SPEMAILKEY, out Value);
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
    }
}
