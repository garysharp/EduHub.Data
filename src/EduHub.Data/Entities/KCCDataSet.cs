using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Dates for Absences Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCCDataSet : SetBase<KCC>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCC"; } }

        internal KCCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KCCKEY = new Lazy<Dictionary<DateTime, KCC>>(() => this.ToDictionary(i => i.KCCKEY));
            Index_CURRENT_QUILT = new Lazy<NullDictionary<string, IReadOnlyList<KCC>>>(() => this.ToGroupedNullDictionary(i => i.CURRENT_QUILT));
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

        #region Index Fields

        private Lazy<Dictionary<DateTime, KCC>> Index_KCCKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<KCC>>> Index_CURRENT_QUILT;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCC by KCCKEY field
        /// </summary>
        /// <param name="KCCKEY">KCCKEY value used to find KCC</param>
        /// <returns>Related KCC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCC FindByKCCKEY(DateTime KCCKEY)
        {
            return Index_KCCKEY.Value[KCCKEY];
        }

        /// <summary>
        /// Attempt to find KCC by KCCKEY field
        /// </summary>
        /// <param name="KCCKEY">KCCKEY value used to find KCC</param>
        /// <param name="Value">Related KCC entity</param>
        /// <returns>True if the related KCC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKCCKEY(DateTime KCCKEY, out KCC Value)
        {
            return Index_KCCKEY.Value.TryGetValue(KCCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KCC by KCCKEY field
        /// </summary>
        /// <param name="KCCKEY">KCCKEY value used to find KCC</param>
        /// <returns>Related KCC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCC TryFindByKCCKEY(DateTime KCCKEY)
        {
            KCC value;
            if (Index_KCCKEY.Value.TryGetValue(KCCKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KCC by CURRENT_QUILT field
        /// </summary>
        /// <param name="CURRENT_QUILT">CURRENT_QUILT value used to find KCC</param>
        /// <returns>List of related KCC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCC> FindByCURRENT_QUILT(string CURRENT_QUILT)
        {
            return Index_CURRENT_QUILT.Value[CURRENT_QUILT];
        }

        /// <summary>
        /// Attempt to find KCC by CURRENT_QUILT field
        /// </summary>
        /// <param name="CURRENT_QUILT">CURRENT_QUILT value used to find KCC</param>
        /// <param name="Value">List of related KCC entities</param>
        /// <returns>True if the list of related KCC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCURRENT_QUILT(string CURRENT_QUILT, out IReadOnlyList<KCC> Value)
        {
            return Index_CURRENT_QUILT.Value.TryGetValue(CURRENT_QUILT, out Value);
        }

        /// <summary>
        /// Attempt to find KCC by CURRENT_QUILT field
        /// </summary>
        /// <param name="CURRENT_QUILT">CURRENT_QUILT value used to find KCC</param>
        /// <returns>List of related KCC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCC> TryFindByCURRENT_QUILT(string CURRENT_QUILT)
        {
            IReadOnlyList<KCC> value;
            if (Index_CURRENT_QUILT.Value.TryGetValue(CURRENT_QUILT, out value))
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
