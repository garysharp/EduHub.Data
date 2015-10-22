using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Release Types Data Set
    /// </summary>
    public sealed partial class AKRDataSet : SetBase<AKR>
    {
        private Lazy<Dictionary<string, AKR>> AKRKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<AR>>> AR_RELEASE_TYPEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ARF>>> ARF_RELEASE_TYPEForeignIndex;

        internal AKRDataSet(EduHubContext Context)
            : base(Context)
        {
            AKRKEYIndex = new Lazy<Dictionary<string, AKR>>(() => this.ToDictionary(e => e.AKRKEY));

            AR_RELEASE_TYPEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<AR>>>(() =>
                    Context.AR
                          .Where(e => e.RELEASE_TYPE != null)
                          .GroupBy(e => e.RELEASE_TYPE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<AR>)g.ToList()
                          .AsReadOnly()));

            ARF_RELEASE_TYPEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ARF>>>(() =>
                    Context.ARF
                          .Where(e => e.RELEASE_TYPE != null)
                          .GroupBy(e => e.RELEASE_TYPE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ARF>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "AKR"; } }

        /// <summary>
        /// Find AKR by AKRKEY key field
        /// </summary>
        /// <param name="Key">AKRKEY value used to find AKR</param>
        /// <returns>Related AKR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">AKRKEY value didn't match any AKR entities</exception>
        public AKR FindByAKRKEY(string Key)
        {
            AKR result;
            if (AKRKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find AKR by AKRKEY key field
        /// </summary>
        /// <param name="Key">AKRKEY value used to find AKR</param>
        /// <param name="Value">Related AKR entity</param>
        /// <returns>True if the AKR entity is found</returns>
        public bool TryFindByAKRKEY(string Key, out AKR Value)
        {
            return AKRKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find AKR by AKRKEY key field
        /// </summary>
        /// <param name="Key">AKRKEY value used to find AKR</param>
        /// <returns>Related AKR entity, or null if not found</returns>
        public AKR TryFindByAKRKEY(string Key)
        {
            AKR result;
            if (AKRKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all AR (Assets) entities by [AR.RELEASE_TYPE]-&gt;[AKR.AKRKEY]
        /// </summary>
        /// <param name="AKRKEY">AKRKEY value used to find AR entities</param>
        /// <returns>A list of related AR entities</returns>
        public IReadOnlyList<AR> FindARByRELEASE_TYPE(string AKRKEY)
        {
            IReadOnlyList<AR> result;
            if (AR_RELEASE_TYPEForeignIndex.Value.TryGetValue(AKRKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<AR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all AR entities by [AR.RELEASE_TYPE]-&gt;[AKR.AKRKEY]
        /// </summary>
        /// <param name="AKRKEY">AKRKEY value used to find AR entities</param>
        /// <param name="Value">A list of related AR entities</param>
        /// <returns>True if any AR entities are found</returns>
        public bool TryFindARByRELEASE_TYPE(string AKRKEY, out IReadOnlyList<AR> Value)
        {
            return AR_RELEASE_TYPEForeignIndex.Value.TryGetValue(AKRKEY, out Value);
        }

        /// <summary>
        /// Find all ARF (Asset Financial Transactions) entities by [ARF.RELEASE_TYPE]-&gt;[AKR.AKRKEY]
        /// </summary>
        /// <param name="AKRKEY">AKRKEY value used to find ARF entities</param>
        /// <returns>A list of related ARF entities</returns>
        public IReadOnlyList<ARF> FindARFByRELEASE_TYPE(string AKRKEY)
        {
            IReadOnlyList<ARF> result;
            if (ARF_RELEASE_TYPEForeignIndex.Value.TryGetValue(AKRKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<ARF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ARF entities by [ARF.RELEASE_TYPE]-&gt;[AKR.AKRKEY]
        /// </summary>
        /// <param name="AKRKEY">AKRKEY value used to find ARF entities</param>
        /// <param name="Value">A list of related ARF entities</param>
        /// <returns>True if any ARF entities are found</returns>
        public bool TryFindARFByRELEASE_TYPE(string AKRKEY, out IReadOnlyList<ARF> Value)
        {
            return ARF_RELEASE_TYPEForeignIndex.Value.TryGetValue(AKRKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AKR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AKR" /> fields for each CSV column header</returns>
        protected override Action<AKR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<AKR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "AKRKEY":
                        mapper[i] = (e, v) => e.AKRKEY = v;
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
