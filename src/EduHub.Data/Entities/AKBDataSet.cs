using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Sub-Category Data Set
    /// </summary>
    public sealed class AKBDataSet : SetBase<AKB>
    {
        private Lazy<Dictionary<string, AKB>> BRANCHIndex;

        internal AKBDataSet(EduHubContext Context)
            : base(Context)
        {
            BRANCHIndex = new Lazy<Dictionary<string, AKB>>(() => this.ToDictionary(e => e.BRANCH));
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
        /// <returns>True if the AKB Entity is found</returns>
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

        protected override Action<AKB, string>[] BuildMapper(List<string> Headers)
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
