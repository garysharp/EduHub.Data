using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Awards and Prizes Data Set
    /// </summary>
    public sealed partial class KGWDataSet : SetBase<KGW>
    {
        private Lazy<Dictionary<string, KGW>> AWARDIndex;

        private Lazy<Dictionary<string, IReadOnlyList<STMB>>> STMB_AWARDForeignIndex;

        internal KGWDataSet(EduHubContext Context)
            : base(Context)
        {
            AWARDIndex = new Lazy<Dictionary<string, KGW>>(() => this.ToDictionary(e => e.AWARD));

            STMB_AWARDForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STMB>>>(() =>
                    Context.STMB
                          .Where(e => e.AWARD != null)
                          .GroupBy(e => e.AWARD)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STMB>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGW"; } }

        /// <summary>
        /// Find KGW by AWARD key field
        /// </summary>
        /// <param name="Key">AWARD value used to find KGW</param>
        /// <returns>Related KGW entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">AWARD value didn't match any KGW entities</exception>
        public KGW FindByAWARD(string Key)
        {
            KGW result;
            if (AWARDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KGW by AWARD key field
        /// </summary>
        /// <param name="Key">AWARD value used to find KGW</param>
        /// <param name="Value">Related KGW entity</param>
        /// <returns>True if the KGW entity is found</returns>
        public bool TryFindByAWARD(string Key, out KGW Value)
        {
            return AWARDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KGW by AWARD key field
        /// </summary>
        /// <param name="Key">AWARD value used to find KGW</param>
        /// <returns>Related KGW entity, or null if not found</returns>
        public KGW TryFindByAWARD(string Key)
        {
            KGW result;
            if (AWARDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all STMB (Student Merit Behaviour Details) entities by [STMB.AWARD]-&gt;[KGW.AWARD]
        /// </summary>
        /// <param name="AWARD">AWARD value used to find STMB entities</param>
        /// <returns>A list of related STMB entities</returns>
        public IReadOnlyList<STMB> FindSTMBByAWARD(string AWARD)
        {
            IReadOnlyList<STMB> result;
            if (STMB_AWARDForeignIndex.Value.TryGetValue(AWARD, out result))
            {
                return result;
            }
            else
            {
                return new List<STMB>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STMB entities by [STMB.AWARD]-&gt;[KGW.AWARD]
        /// </summary>
        /// <param name="AWARD">AWARD value used to find STMB entities</param>
        /// <param name="Value">A list of related STMB entities</param>
        /// <returns>True if any STMB entities are found</returns>
        public bool TryFindSTMBByAWARD(string AWARD, out IReadOnlyList<STMB> Value)
        {
            return STMB_AWARDForeignIndex.Value.TryGetValue(AWARD, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGW" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGW" /> fields for each CSV column header</returns>
        protected override Action<KGW, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGW, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "AWARD":
                        mapper[i] = (e, v) => e.AWARD = v;
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
    }
}
