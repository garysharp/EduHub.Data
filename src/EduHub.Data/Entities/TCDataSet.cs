using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Data Set
    /// </summary>
    public sealed class TCDataSet : SetBase<TC>
    {
        private Lazy<Dictionary<DateTime, TC>> TCKEYIndex;

        internal TCDataSet(EduHubContext Context)
            : base(Context)
        {
            TCKEYIndex = new Lazy<Dictionary<DateTime, TC>>(() => this.ToDictionary(e => e.TCKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TC"; } }

        /// <summary>
        /// Find TC by TCKEY key field
        /// </summary>
        /// <param name="Key">TCKEY value used to find TC</param>
        /// <returns>Related TC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TCKEY value didn't match any TC entities</exception>
        public TC FindByTCKEY(DateTime Key)
        {
            TC result;
            if (TCKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find TC by TCKEY key field
        /// </summary>
        /// <param name="Key">TCKEY value used to find TC</param>
        /// <param name="Value">Related TC entity</param>
        /// <returns>True if the TC entity is found</returns>
        public bool TryFindByTCKEY(DateTime Key, out TC Value)
        {
            return TCKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find TC by TCKEY key field
        /// </summary>
        /// <param name="Key">TCKEY value used to find TC</param>
        /// <returns>Related TC entity, or null if not found</returns>
        public TC TryFindByTCKEY(DateTime Key)
        {
            TC result;
            if (TCKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TC" /> fields for each CSV column header</returns>
        protected override Action<TC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TCKEY":
                        mapper[i] = (e, v) => e.TCKEY = DateTime.Parse(v);
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "DAY_COMMENT":
                        mapper[i] = (e, v) => e.DAY_COMMENT = v;
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
