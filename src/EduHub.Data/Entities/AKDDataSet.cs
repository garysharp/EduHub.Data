using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Departments Data Set
    /// </summary>
    public sealed partial class AKDDataSet : SetBase<AKD>
    {
        private Lazy<Dictionary<string, AKD>> DEPARTMENTIndex;

        private Lazy<Dictionary<string, IReadOnlyList<AR>>> AR_DEPARTMENTForeignIndex;

        internal AKDDataSet(EduHubContext Context)
            : base(Context)
        {
            DEPARTMENTIndex = new Lazy<Dictionary<string, AKD>>(() => this.ToDictionary(e => e.DEPARTMENT));

            AR_DEPARTMENTForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<AR>>>(() =>
                    Context.AR
                          .Where(e => e.DEPARTMENT != null)
                          .GroupBy(e => e.DEPARTMENT)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<AR>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "AKD"; } }

        /// <summary>
        /// Find AKD by DEPARTMENT key field
        /// </summary>
        /// <param name="Key">DEPARTMENT value used to find AKD</param>
        /// <returns>Related AKD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">DEPARTMENT value didn't match any AKD entities</exception>
        public AKD FindByDEPARTMENT(string Key)
        {
            AKD result;
            if (DEPARTMENTIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find AKD by DEPARTMENT key field
        /// </summary>
        /// <param name="Key">DEPARTMENT value used to find AKD</param>
        /// <param name="Value">Related AKD entity</param>
        /// <returns>True if the AKD entity is found</returns>
        public bool TryFindByDEPARTMENT(string Key, out AKD Value)
        {
            return DEPARTMENTIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find AKD by DEPARTMENT key field
        /// </summary>
        /// <param name="Key">DEPARTMENT value used to find AKD</param>
        /// <returns>Related AKD entity, or null if not found</returns>
        public AKD TryFindByDEPARTMENT(string Key)
        {
            AKD result;
            if (DEPARTMENTIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all AR (Assets) entities by [AR.DEPARTMENT]-&gt;[AKD.DEPARTMENT]
        /// </summary>
        /// <param name="DEPARTMENT">DEPARTMENT value used to find AR entities</param>
        /// <returns>A list of related AR entities</returns>
        public IReadOnlyList<AR> FindARByDEPARTMENT(string DEPARTMENT)
        {
            IReadOnlyList<AR> result;
            if (AR_DEPARTMENTForeignIndex.Value.TryGetValue(DEPARTMENT, out result))
            {
                return result;
            }
            else
            {
                return new List<AR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all AR entities by [AR.DEPARTMENT]-&gt;[AKD.DEPARTMENT]
        /// </summary>
        /// <param name="DEPARTMENT">DEPARTMENT value used to find AR entities</param>
        /// <param name="Value">A list of related AR entities</param>
        /// <returns>True if any AR entities are found</returns>
        public bool TryFindARByDEPARTMENT(string DEPARTMENT, out IReadOnlyList<AR> Value)
        {
            return AR_DEPARTMENTForeignIndex.Value.TryGetValue(DEPARTMENT, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AKD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AKD" /> fields for each CSV column header</returns>
        protected override Action<AKD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<AKD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "DEPARTMENT":
                        mapper[i] = (e, v) => e.DEPARTMENT = v;
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
