using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Contact Relationship Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KPCRDataSet : SetBase<KPCR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KPCR"; } }

        internal KPCRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KPCRKEY = new Lazy<Dictionary<string, KPCR>>(() => this.ToDictionary(i => i.KPCRKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KPCR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KPCR" /> fields for each CSV column header</returns>
        protected override Action<KPCR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KPCR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KPCRKEY":
                        mapper[i] = (e, v) => e.KPCRKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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

        private Lazy<Dictionary<string, KPCR>> Index_KPCRKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KPCR by KPCRKEY field
        /// </summary>
        /// <param name="KPCRKEY">KPCRKEY value used to find KPCR</param>
        /// <returns>Related KPCR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPCR FindByKPCRKEY(string KPCRKEY)
        {
            return Index_KPCRKEY.Value[KPCRKEY];
        }

        /// <summary>
        /// Attempt to find KPCR by KPCRKEY field
        /// </summary>
        /// <param name="KPCRKEY">KPCRKEY value used to find KPCR</param>
        /// <param name="Value">Related KPCR entity</param>
        /// <returns>True if the related KPCR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKPCRKEY(string KPCRKEY, out KPCR Value)
        {
            return Index_KPCRKEY.Value.TryGetValue(KPCRKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KPCR by KPCRKEY field
        /// </summary>
        /// <param name="KPCRKEY">KPCRKEY value used to find KPCR</param>
        /// <returns>Related KPCR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPCR TryFindByKPCRKEY(string KPCRKEY)
        {
            KPCR value;
            if (Index_KPCRKEY.Value.TryGetValue(KPCRKEY, out value))
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
