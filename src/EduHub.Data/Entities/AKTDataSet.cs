using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Types Data Set
    /// </summary>
    public sealed partial class AKTDataSet : SetBase<AKT>
    {
        private Lazy<Dictionary<string, AKT>> AKTKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<AR>>> AR_ASSET_TYPEForeignIndex;

        internal AKTDataSet(EduHubContext Context)
            : base(Context)
        {
            AKTKEYIndex = new Lazy<Dictionary<string, AKT>>(() => this.ToDictionary(e => e.AKTKEY));

            AR_ASSET_TYPEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<AR>>>(() =>
                    Context.AR
                          .Where(e => e.ASSET_TYPE != null)
                          .GroupBy(e => e.ASSET_TYPE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<AR>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "AKT"; } }

        /// <summary>
        /// Find AKT by AKTKEY key field
        /// </summary>
        /// <param name="Key">AKTKEY value used to find AKT</param>
        /// <returns>Related AKT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">AKTKEY value didn't match any AKT entities</exception>
        public AKT FindByAKTKEY(string Key)
        {
            AKT result;
            if (AKTKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find AKT by AKTKEY key field
        /// </summary>
        /// <param name="Key">AKTKEY value used to find AKT</param>
        /// <param name="Value">Related AKT entity</param>
        /// <returns>True if the AKT entity is found</returns>
        public bool TryFindByAKTKEY(string Key, out AKT Value)
        {
            return AKTKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find AKT by AKTKEY key field
        /// </summary>
        /// <param name="Key">AKTKEY value used to find AKT</param>
        /// <returns>Related AKT entity, or null if not found</returns>
        public AKT TryFindByAKTKEY(string Key)
        {
            AKT result;
            if (AKTKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all AR (Assets) entities by [AR.ASSET_TYPE]-&gt;[AKT.AKTKEY]
        /// </summary>
        /// <param name="AKTKEY">AKTKEY value used to find AR entities</param>
        /// <returns>A list of related AR entities</returns>
        public IReadOnlyList<AR> FindARByASSET_TYPE(string AKTKEY)
        {
            IReadOnlyList<AR> result;
            if (AR_ASSET_TYPEForeignIndex.Value.TryGetValue(AKTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<AR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all AR entities by [AR.ASSET_TYPE]-&gt;[AKT.AKTKEY]
        /// </summary>
        /// <param name="AKTKEY">AKTKEY value used to find AR entities</param>
        /// <param name="Value">A list of related AR entities</param>
        /// <returns>True if any AR entities are found</returns>
        public bool TryFindARByASSET_TYPE(string AKTKEY, out IReadOnlyList<AR> Value)
        {
            return AR_ASSET_TYPEForeignIndex.Value.TryGetValue(AKTKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AKT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AKT" /> fields for each CSV column header</returns>
        protected override Action<AKT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<AKT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "AKTKEY":
                        mapper[i] = (e, v) => e.AKTKEY = v;
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
