using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Future Medicare Levy Parameters Data Set
    /// </summary>
    public sealed class PML_NEWDataSet : SetBase<PML_NEW>
    {
        private Lazy<Dictionary<short, PML_NEW>> SCALEIndex;

        internal PML_NEWDataSet(EduHubContext Context)
            : base(Context)
        {
            SCALEIndex = new Lazy<Dictionary<short, PML_NEW>>(() => this.ToDictionary(e => e.SCALE));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PML_NEW"; } }

        /// <summary>
        /// Find PML_NEW by SCALE key field
        /// </summary>
        /// <param name="Key">SCALE value used to find PML_NEW</param>
        /// <returns>Related PML_NEW entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SCALE value didn't match any PML_NEW entities</exception>
        public PML_NEW FindBySCALE(short Key)
        {
            PML_NEW result;
            if (SCALEIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find PML_NEW by SCALE key field
        /// </summary>
        /// <param name="Key">SCALE value used to find PML_NEW</param>
        /// <param name="Value">Related PML_NEW entity</param>
        /// <returns>True if the PML_NEW Entity is found</returns>
        public bool TryFindBySCALE(short Key, out PML_NEW Value)
        {
            return SCALEIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find PML_NEW by SCALE key field
        /// </summary>
        /// <param name="Key">SCALE value used to find PML_NEW</param>
        /// <returns>Related PML_NEW entity, or null if not found</returns>
        public PML_NEW TryFindBySCALE(short Key)
        {
            PML_NEW result;
            if (SCALEIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<PML_NEW, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<PML_NEW, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCALE":
                        mapper[i] = (e, v) => e.SCALE = short.Parse(v);
                        break;
                    case "WEEKLY_EARNING_THRESHOLD":
                        mapper[i] = (e, v) => e.WEEKLY_EARNING_THRESHOLD = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "WEEKLY_SHADEIN_THRESHOLD":
                        mapper[i] = (e, v) => e.WEEKLY_SHADEIN_THRESHOLD = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "MEDLEVY_FAMILY_THRESHOLD":
                        mapper[i] = (e, v) => e.MEDLEVY_FAMILY_THRESHOLD = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "WFT_DIVISOR":
                        mapper[i] = (e, v) => e.WFT_DIVISOR = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ADDITIONAL_CHILD":
                        mapper[i] = (e, v) => e.ADDITIONAL_CHILD = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SOP_MULTIPLIER":
                        mapper[i] = (e, v) => e.SOP_MULTIPLIER = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SOP_DIVISOR":
                        mapper[i] = (e, v) => e.SOP_DIVISOR = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "WLA_FALCTOR":
                        mapper[i] = (e, v) => e.WLA_FALCTOR = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "MEDICARE_LEVY":
                        mapper[i] = (e, v) => e.MEDICARE_LEVY = v == null ? (double?)null : double.Parse(v);
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
