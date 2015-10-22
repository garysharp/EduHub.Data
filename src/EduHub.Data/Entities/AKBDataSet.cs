using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Sub-Category Data Set
    /// </summary>
    public sealed partial class AKBDataSet : SetBase<AKB>
    {
        private Lazy<Dictionary<string, AKB>> BRANCHIndex;

        private Lazy<Dictionary<string, IReadOnlyList<AR>>> AR_BRANCHForeignIndex;

        internal AKBDataSet(EduHubContext Context)
            : base(Context)
        {
            BRANCHIndex = new Lazy<Dictionary<string, AKB>>(() => this.ToDictionary(e => e.BRANCH));

            AR_BRANCHForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<AR>>>(() =>
                    Context.AR
                          .Where(e => e.BRANCH != null)
                          .GroupBy(e => e.BRANCH)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<AR>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "AKB"; } }

        /// <summary>
        /// Find AKB by BRANCH key field
        /// </summary>
        /// <param name="Key">BRANCH value used to find AKB</param>
        /// <returns>Related AKB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">BRANCH value didn't match any AKB entities</exception>
        public AKB FindByBRANCH(string Key)
        {
            AKB result;
            if (BRANCHIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find AKB by BRANCH key field
        /// </summary>
        /// <param name="Key">BRANCH value used to find AKB</param>
        /// <param name="Value">Related AKB entity</param>
        /// <returns>True if the AKB entity is found</returns>
        public bool TryFindByBRANCH(string Key, out AKB Value)
        {
            return BRANCHIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find AKB by BRANCH key field
        /// </summary>
        /// <param name="Key">BRANCH value used to find AKB</param>
        /// <returns>Related AKB entity, or null if not found</returns>
        public AKB TryFindByBRANCH(string Key)
        {
            AKB result;
            if (BRANCHIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all AR (Assets) entities by [AR.BRANCH]-&gt;[AKB.BRANCH]
        /// </summary>
        /// <param name="BRANCH">BRANCH value used to find AR entities</param>
        /// <returns>A list of related AR entities</returns>
        public IReadOnlyList<AR> FindARByBRANCH(string BRANCH)
        {
            IReadOnlyList<AR> result;
            if (AR_BRANCHForeignIndex.Value.TryGetValue(BRANCH, out result))
            {
                return result;
            }
            else
            {
                return new List<AR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all AR entities by [AR.BRANCH]-&gt;[AKB.BRANCH]
        /// </summary>
        /// <param name="BRANCH">BRANCH value used to find AR entities</param>
        /// <param name="Value">A list of related AR entities</param>
        /// <returns>True if any AR entities are found</returns>
        public bool TryFindARByBRANCH(string BRANCH, out IReadOnlyList<AR> Value)
        {
            return AR_BRANCHForeignIndex.Value.TryGetValue(BRANCH, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AKB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AKB" /> fields for each CSV column header</returns>
        protected override Action<AKB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<AKB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "BRANCH":
                        mapper[i] = (e, v) => e.BRANCH = v;
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
