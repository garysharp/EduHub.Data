using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Event Categories Data Set
    /// </summary>
    public sealed partial class TECDataSet : SetBase<TEC>
    {
        private Lazy<Dictionary<string, TEC>> CATEGORYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<TE>>> TE_CATEGORYForeignIndex;

        internal TECDataSet(EduHubContext Context)
            : base(Context)
        {
            CATEGORYIndex = new Lazy<Dictionary<string, TEC>>(() => this.ToDictionary(e => e.CATEGORY));

            TE_CATEGORYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TE>>>(() =>
                    Context.TE
                          .Where(e => e.CATEGORY != null)
                          .GroupBy(e => e.CATEGORY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TE>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TEC"; } }

        /// <summary>
        /// Find TEC by CATEGORY key field
        /// </summary>
        /// <param name="Key">CATEGORY value used to find TEC</param>
        /// <returns>Related TEC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">CATEGORY value didn't match any TEC entities</exception>
        public TEC FindByCATEGORY(string Key)
        {
            TEC result;
            if (CATEGORYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find TEC by CATEGORY key field
        /// </summary>
        /// <param name="Key">CATEGORY value used to find TEC</param>
        /// <param name="Value">Related TEC entity</param>
        /// <returns>True if the TEC entity is found</returns>
        public bool TryFindByCATEGORY(string Key, out TEC Value)
        {
            return CATEGORYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find TEC by CATEGORY key field
        /// </summary>
        /// <param name="Key">CATEGORY value used to find TEC</param>
        /// <returns>Related TEC entity, or null if not found</returns>
        public TEC TryFindByCATEGORY(string Key)
        {
            TEC result;
            if (CATEGORYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all TE (Calendar Events) entities by [TE.CATEGORY]-&gt;[TEC.CATEGORY]
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find TE entities</param>
        /// <returns>A list of related TE entities</returns>
        public IReadOnlyList<TE> FindTEByCATEGORY(string CATEGORY)
        {
            IReadOnlyList<TE> result;
            if (TE_CATEGORYForeignIndex.Value.TryGetValue(CATEGORY, out result))
            {
                return result;
            }
            else
            {
                return new List<TE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TE entities by [TE.CATEGORY]-&gt;[TEC.CATEGORY]
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find TE entities</param>
        /// <param name="Value">A list of related TE entities</param>
        /// <returns>True if any TE entities are found</returns>
        public bool TryFindTEByCATEGORY(string CATEGORY, out IReadOnlyList<TE> Value)
        {
            return TE_CATEGORYForeignIndex.Value.TryGetValue(CATEGORY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TEC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TEC" /> fields for each CSV column header</returns>
        protected override Action<TEC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TEC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
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
