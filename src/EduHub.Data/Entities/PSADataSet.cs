using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Award Details Data Set
    /// </summary>
    public sealed partial class PSADataSet : SetBase<PSA>
    {
        private Lazy<Dictionary<string, PSA>> PSAKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<PI>>> PI_AWARDForeignIndex;

        internal PSADataSet(EduHubContext Context)
            : base(Context)
        {
            PSAKEYIndex = new Lazy<Dictionary<string, PSA>>(() => this.ToDictionary(e => e.PSAKEY));

            PI_AWARDForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PI>>>(() =>
                    Context.PI
                          .Where(e => e.AWARD != null)
                          .GroupBy(e => e.AWARD)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PI>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PSA"; } }

        /// <summary>
        /// Find PSA by PSAKEY key field
        /// </summary>
        /// <param name="Key">PSAKEY value used to find PSA</param>
        /// <returns>Related PSA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">PSAKEY value didn't match any PSA entities</exception>
        public PSA FindByPSAKEY(string Key)
        {
            PSA result;
            if (PSAKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find PSA by PSAKEY key field
        /// </summary>
        /// <param name="Key">PSAKEY value used to find PSA</param>
        /// <param name="Value">Related PSA entity</param>
        /// <returns>True if the PSA entity is found</returns>
        public bool TryFindByPSAKEY(string Key, out PSA Value)
        {
            return PSAKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find PSA by PSAKEY key field
        /// </summary>
        /// <param name="Key">PSAKEY value used to find PSA</param>
        /// <returns>Related PSA entity, or null if not found</returns>
        public PSA TryFindByPSAKEY(string Key)
        {
            PSA result;
            if (PSAKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all PI (Pay Items) entities by [PI.AWARD]-&gt;[PSA.PSAKEY]
        /// </summary>
        /// <param name="PSAKEY">PSAKEY value used to find PI entities</param>
        /// <returns>A list of related PI entities</returns>
        public IReadOnlyList<PI> FindPIByAWARD(string PSAKEY)
        {
            IReadOnlyList<PI> result;
            if (PI_AWARDForeignIndex.Value.TryGetValue(PSAKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PI entities by [PI.AWARD]-&gt;[PSA.PSAKEY]
        /// </summary>
        /// <param name="PSAKEY">PSAKEY value used to find PI entities</param>
        /// <param name="Value">A list of related PI entities</param>
        /// <returns>True if any PI entities are found</returns>
        public bool TryFindPIByAWARD(string PSAKEY, out IReadOnlyList<PI> Value)
        {
            return PI_AWARDForeignIndex.Value.TryGetValue(PSAKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PSA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PSA" /> fields for each CSV column header</returns>
        protected override Action<PSA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PSA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PSAKEY":
                        mapper[i] = (e, v) => e.PSAKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "AWARD_TYPE":
                        mapper[i] = (e, v) => e.AWARD_TYPE = v;
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
