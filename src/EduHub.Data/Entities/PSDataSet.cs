using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Steps or Pay Class Data Set
    /// </summary>
    public sealed class PSDataSet : SetBase<PS>
    {
        private Lazy<Dictionary<short, PS>> PSKEYIndex;

        internal PSDataSet(EduHubContext Context)
            : base(Context)
        {
            PSKEYIndex = new Lazy<Dictionary<short, PS>>(() => this.ToDictionary(e => e.PSKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PS"; } }

        /// <summary>
        /// Find PS by PSKEY key field
        /// </summary>
        /// <param name="Key">PSKEY value used to find PS</param>
        /// <returns>Related PS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">PSKEY value didn't match any PS entities</exception>
        public PS FindByPSKEY(short Key)
        {
            PS result;
            if (PSKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find PS by PSKEY key field
        /// </summary>
        /// <param name="Key">PSKEY value used to find PS</param>
        /// <param name="Value">Related PS entity</param>
        /// <returns>True if the PS Entity is found</returns>
        public bool TryFindByPSKEY(short Key, out PS Value)
        {
            return PSKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find PS by PSKEY key field
        /// </summary>
        /// <param name="Key">PSKEY value used to find PS</param>
        /// <returns>Related PS entity, or null if not found</returns>
        public PS TryFindByPSKEY(short Key)
        {
            PS result;
            if (PSKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<PS, string>[] BuildMapper(List<string> Headers)
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
    }
}
