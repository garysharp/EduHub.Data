using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Medicare Levy Parameters Data Set
    /// </summary>
    public sealed partial class PMLDataSet : SetBase<PML>
    {
        private Lazy<Dictionary<short, PML>> SCALEIndex;


        internal PMLDataSet(EduHubContext Context)
            : base(Context)
        {
            SCALEIndex = new Lazy<Dictionary<short, PML>>(() => this.ToDictionary(e => e.SCALE));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PML"; } }

        /// <summary>
        /// Find PML by SCALE key field
        /// </summary>
        /// <param name="Key">SCALE value used to find PML</param>
        /// <returns>Related PML entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SCALE value didn't match any PML entities</exception>
        public PML FindBySCALE(short Key)
        {
            PML result;
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
        /// Attempt to find PML by SCALE key field
        /// </summary>
        /// <param name="Key">SCALE value used to find PML</param>
        /// <param name="Value">Related PML entity</param>
        /// <returns>True if the PML entity is found</returns>
        public bool TryFindBySCALE(short Key, out PML Value)
        {
            return SCALEIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find PML by SCALE key field
        /// </summary>
        /// <param name="Key">SCALE value used to find PML</param>
        /// <returns>Related PML entity, or null if not found</returns>
        public PML TryFindBySCALE(short Key)
        {
            PML result;
            if (SCALEIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PML" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PML" /> fields for each CSV column header</returns>
        protected override Action<PML, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PML, string>[Headers.Count];

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
