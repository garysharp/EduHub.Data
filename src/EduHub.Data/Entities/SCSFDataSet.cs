using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// CSF Strands Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCSFDataSet : SetBase<SCSF>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCSF"; } }

        internal SCSFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SCSFKEY = new Lazy<Dictionary<string, SCSF>>(() => this.ToDictionary(i => i.SCSFKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCSF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCSF" /> fields for each CSV column header</returns>
        protected override Action<SCSF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCSF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCSFKEY":
                        mapper[i] = (e, v) => e.SCSFKEY = v;
                        break;
                    case "KLA":
                        mapper[i] = (e, v) => e.KLA = v;
                        break;
                    case "STRAND":
                        mapper[i] = (e, v) => e.STRAND = v;
                        break;
                    case "SUB_STRAND":
                        mapper[i] = (e, v) => e.SUB_STRAND = v;
                        break;
                    case "ENABLED":
                        mapper[i] = (e, v) => e.ENABLED = v;
                        break;
                    case "DEET_REQUIRED":
                        mapper[i] = (e, v) => e.DEET_REQUIRED = v;
                        break;
                    case "LOW_LEVEL":
                        mapper[i] = (e, v) => e.LOW_LEVEL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "HIGH_LEVEL":
                        mapper[i] = (e, v) => e.HIGH_LEVEL = v == null ? (short?)null : short.Parse(v);
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

        private Lazy<Dictionary<string, SCSF>> Index_SCSFKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCSF by SCSFKEY field
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSF</param>
        /// <returns>Related SCSF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCSF FindBySCSFKEY(string SCSFKEY)
        {
            return Index_SCSFKEY.Value[SCSFKEY];
        }

        /// <summary>
        /// Attempt to find SCSF by SCSFKEY field
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSF</param>
        /// <param name="Value">Related SCSF entity</param>
        /// <returns>True if the related SCSF entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCSFKEY(string SCSFKEY, out SCSF Value)
        {
            return Index_SCSFKEY.Value.TryGetValue(SCSFKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SCSF by SCSFKEY field
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSF</param>
        /// <returns>Related SCSF entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCSF TryFindBySCSFKEY(string SCSFKEY)
        {
            SCSF value;
            if (Index_SCSFKEY.Value.TryGetValue(SCSFKEY, out value))
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
