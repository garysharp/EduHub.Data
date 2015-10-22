using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// PAYG Payment Summary Box Data Set
    /// </summary>
    public sealed partial class PGDataSet : SetBase<PG>
    {
        private Lazy<Dictionary<short, PG>> PAYG_BOXIndex;

        private Lazy<Dictionary<short, IReadOnlyList<PI>>> PI_PAYG_BOXForeignIndex;

        internal PGDataSet(EduHubContext Context)
            : base(Context)
        {
            PAYG_BOXIndex = new Lazy<Dictionary<short, PG>>(() => this.ToDictionary(e => e.PAYG_BOX));

            PI_PAYG_BOXForeignIndex =
                new Lazy<Dictionary<short, IReadOnlyList<PI>>>(() =>
                    Context.PI
                          .Where(e => e.PAYG_BOX != null)
                          .GroupBy(e => e.PAYG_BOX.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PI>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PG"; } }

        /// <summary>
        /// Find PG by PAYG_BOX key field
        /// </summary>
        /// <param name="Key">PAYG_BOX value used to find PG</param>
        /// <returns>Related PG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">PAYG_BOX value didn't match any PG entities</exception>
        public PG FindByPAYG_BOX(short Key)
        {
            PG result;
            if (PAYG_BOXIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find PG by PAYG_BOX key field
        /// </summary>
        /// <param name="Key">PAYG_BOX value used to find PG</param>
        /// <param name="Value">Related PG entity</param>
        /// <returns>True if the PG entity is found</returns>
        public bool TryFindByPAYG_BOX(short Key, out PG Value)
        {
            return PAYG_BOXIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find PG by PAYG_BOX key field
        /// </summary>
        /// <param name="Key">PAYG_BOX value used to find PG</param>
        /// <returns>Related PG entity, or null if not found</returns>
        public PG TryFindByPAYG_BOX(short Key)
        {
            PG result;
            if (PAYG_BOXIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all PI (Pay Items) entities by [PI.PAYG_BOX]-&gt;[PG.PAYG_BOX]
        /// </summary>
        /// <param name="PAYG_BOX">PAYG_BOX value used to find PI entities</param>
        /// <returns>A list of related PI entities</returns>
        public IReadOnlyList<PI> FindPIByPAYG_BOX(short PAYG_BOX)
        {
            IReadOnlyList<PI> result;
            if (PI_PAYG_BOXForeignIndex.Value.TryGetValue(PAYG_BOX, out result))
            {
                return result;
            }
            else
            {
                return new List<PI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PI entities by [PI.PAYG_BOX]-&gt;[PG.PAYG_BOX]
        /// </summary>
        /// <param name="PAYG_BOX">PAYG_BOX value used to find PI entities</param>
        /// <param name="Value">A list of related PI entities</param>
        /// <returns>True if any PI entities are found</returns>
        public bool TryFindPIByPAYG_BOX(short PAYG_BOX, out IReadOnlyList<PI> Value)
        {
            return PI_PAYG_BOXForeignIndex.Value.TryGetValue(PAYG_BOX, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PG" /> fields for each CSV column header</returns>
        protected override Action<PG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PAYG_BOX":
                        mapper[i] = (e, v) => e.PAYG_BOX = short.Parse(v);
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
