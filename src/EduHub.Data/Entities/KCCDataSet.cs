using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Dates for Absences Data Set
    /// </summary>
    public sealed partial class KCCDataSet : SetBase<KCC>
    {
        private Lazy<Dictionary<DateTime, KCC>> KCCKEYIndex;


        internal KCCDataSet(EduHubContext Context)
            : base(Context)
        {
            KCCKEYIndex = new Lazy<Dictionary<DateTime, KCC>>(() => this.ToDictionary(e => e.KCCKEY));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCC"; } }

        /// <summary>
        /// Find KCC by KCCKEY key field
        /// </summary>
        /// <param name="Key">KCCKEY value used to find KCC</param>
        /// <returns>Related KCC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KCCKEY value didn't match any KCC entities</exception>
        public KCC FindByKCCKEY(DateTime Key)
        {
            KCC result;
            if (KCCKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KCC by KCCKEY key field
        /// </summary>
        /// <param name="Key">KCCKEY value used to find KCC</param>
        /// <param name="Value">Related KCC entity</param>
        /// <returns>True if the KCC entity is found</returns>
        public bool TryFindByKCCKEY(DateTime Key, out KCC Value)
        {
            return KCCKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KCC by KCCKEY key field
        /// </summary>
        /// <param name="Key">KCCKEY value used to find KCC</param>
        /// <returns>Related KCC entity, or null if not found</returns>
        public KCC TryFindByKCCKEY(DateTime Key)
        {
            KCC result;
            if (KCCKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCC" /> fields for each CSV column header</returns>
        protected override Action<KCC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCCKEY":
                        mapper[i] = (e, v) => e.KCCKEY = DateTime.Parse(v);
                        break;
                    case "DAYTODAY":
                        mapper[i] = (e, v) => e.DAYTODAY = v;
                        break;
                    case "DAY_TYPE":
                        mapper[i] = (e, v) => e.DAY_TYPE = v;
                        break;
                    case "JULIAN":
                        mapper[i] = (e, v) => e.JULIAN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SEMESTER":
                        mapper[i] = (e, v) => e.SEMESTER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DAY_YEAR":
                        mapper[i] = (e, v) => e.DAY_YEAR = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DAY_MONTH":
                        mapper[i] = (e, v) => e.DAY_MONTH = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TERM":
                        mapper[i] = (e, v) => e.TERM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "WEEK":
                        mapper[i] = (e, v) => e.WEEK = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DAY_CYCLE":
                        mapper[i] = (e, v) => e.DAY_CYCLE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CURRENT_QUILT":
                        mapper[i] = (e, v) => e.CURRENT_QUILT = v;
                        break;
                    case "HALF_DAY_GENERATED":
                        mapper[i] = (e, v) => e.HALF_DAY_GENERATED = v;
                        break;
                    case "PERIOD_GENERATED":
                        mapper[i] = (e, v) => e.PERIOD_GENERATED = v;
                        break;
                    case "PAR_SOURCE":
                        mapper[i] = (e, v) => e.PAR_SOURCE = v;
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
