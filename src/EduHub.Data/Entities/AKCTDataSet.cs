using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Categories Tax Data Set
    /// </summary>
    public sealed partial class AKCTDataSet : SetBase<AKCT>
    {
        private Lazy<Dictionary<string, AKCT>> CATEGORYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<AR>>> AR_TAX_CATEGORYForeignIndex;

        internal AKCTDataSet(EduHubContext Context)
            : base(Context)
        {
            CATEGORYIndex = new Lazy<Dictionary<string, AKCT>>(() => this.ToDictionary(e => e.CATEGORY));

            AR_TAX_CATEGORYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<AR>>>(() =>
                    Context.AR
                          .Where(e => e.TAX_CATEGORY != null)
                          .GroupBy(e => e.TAX_CATEGORY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<AR>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "AKCT"; } }

        /// <summary>
        /// Find AKCT by CATEGORY key field
        /// </summary>
        /// <param name="Key">CATEGORY value used to find AKCT</param>
        /// <returns>Related AKCT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">CATEGORY value didn't match any AKCT entities</exception>
        public AKCT FindByCATEGORY(string Key)
        {
            AKCT result;
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
        /// Attempt to find AKCT by CATEGORY key field
        /// </summary>
        /// <param name="Key">CATEGORY value used to find AKCT</param>
        /// <param name="Value">Related AKCT entity</param>
        /// <returns>True if the AKCT entity is found</returns>
        public bool TryFindByCATEGORY(string Key, out AKCT Value)
        {
            return CATEGORYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find AKCT by CATEGORY key field
        /// </summary>
        /// <param name="Key">CATEGORY value used to find AKCT</param>
        /// <returns>Related AKCT entity, or null if not found</returns>
        public AKCT TryFindByCATEGORY(string Key)
        {
            AKCT result;
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
        /// Find all AR (Assets) entities by [AR.TAX_CATEGORY]-&gt;[AKCT.CATEGORY]
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find AR entities</param>
        /// <returns>A list of related AR entities</returns>
        public IReadOnlyList<AR> FindARByTAX_CATEGORY(string CATEGORY)
        {
            IReadOnlyList<AR> result;
            if (AR_TAX_CATEGORYForeignIndex.Value.TryGetValue(CATEGORY, out result))
            {
                return result;
            }
            else
            {
                return new List<AR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all AR entities by [AR.TAX_CATEGORY]-&gt;[AKCT.CATEGORY]
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find AR entities</param>
        /// <param name="Value">A list of related AR entities</param>
        /// <returns>True if any AR entities are found</returns>
        public bool TryFindARByTAX_CATEGORY(string CATEGORY, out IReadOnlyList<AR> Value)
        {
            return AR_TAX_CATEGORYForeignIndex.Value.TryGetValue(CATEGORY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AKCT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AKCT" /> fields for each CSV column header</returns>
        protected override Action<AKCT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<AKCT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "DEPN_TMETHOD":
                        mapper[i] = (e, v) => e.DEPN_TMETHOD = v;
                        break;
                    case "DEPN_TRATE":
                        mapper[i] = (e, v) => e.DEPN_TRATE = v == null ? (double?)null : double.Parse(v);
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
