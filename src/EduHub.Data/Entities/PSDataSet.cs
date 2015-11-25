using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Steps or Pay Class Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PSDataSet : SetBase<PS>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PS"; } }

        internal PSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PSKEY = new Lazy<Dictionary<short, PS>>(() => this.ToDictionary(i => i.PSKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PS" /> fields for each CSV column header</returns>
        protected override Action<PS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PSKEY":
                        mapper[i] = (e, v) => e.PSKEY = short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "PAY_TYPE":
                        mapper[i] = (e, v) => e.PAY_TYPE = v;
                        break;
                    case "EFFECTIVE_DATE":
                        mapper[i] = (e, v) => e.EFFECTIVE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ANNUAL_RATE":
                        mapper[i] = (e, v) => e.ANNUAL_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "MONTHLY_RATE":
                        mapper[i] = (e, v) => e.MONTHLY_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "FORTNIGHTLY_RATE":
                        mapper[i] = (e, v) => e.FORTNIGHTLY_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "WEEKLY_RATE":
                        mapper[i] = (e, v) => e.WEEKLY_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "HOURLY_RATE":
                        mapper[i] = (e, v) => e.HOURLY_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "STD_WEEKLY_HOURS":
                        mapper[i] = (e, v) => e.STD_WEEKLY_HOURS = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "STD_MONTHLY_HOURS":
                        mapper[i] = (e, v) => e.STD_MONTHLY_HOURS = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
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

        private Lazy<Dictionary<short, PS>> Index_PSKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PS by PSKEY field
        /// </summary>
        /// <param name="PSKEY">PSKEY value used to find PS</param>
        /// <returns>Related PS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PS FindByPSKEY(short PSKEY)
        {
            return Index_PSKEY.Value[PSKEY];
        }

        /// <summary>
        /// Attempt to find PS by PSKEY field
        /// </summary>
        /// <param name="PSKEY">PSKEY value used to find PS</param>
        /// <param name="Value">Related PS entity</param>
        /// <returns>True if the related PS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPSKEY(short PSKEY, out PS Value)
        {
            return Index_PSKEY.Value.TryGetValue(PSKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PS by PSKEY field
        /// </summary>
        /// <param name="PSKEY">PSKEY value used to find PS</param>
        /// <returns>Related PS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PS TryFindByPSKEY(short PSKEY)
        {
            PS value;
            if (Index_PSKEY.Value.TryGetValue(PSKEY, out value))
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
