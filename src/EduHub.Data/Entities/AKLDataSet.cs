using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Locations Data Set
    /// </summary>
    public sealed partial class AKLDataSet : SetBase<AKL>
    {
        private Lazy<Dictionary<string, AKL>> LOCATIONIndex;

        private Lazy<Dictionary<string, IReadOnlyList<AR>>> AR_LOCATIONForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ARF>>> ARF_LOCATIONForeignIndex;

        internal AKLDataSet(EduHubContext Context)
            : base(Context)
        {
            LOCATIONIndex = new Lazy<Dictionary<string, AKL>>(() => this.ToDictionary(e => e.LOCATION));

            AR_LOCATIONForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<AR>>>(() =>
                    Context.AR
                          .Where(e => e.LOCATION != null)
                          .GroupBy(e => e.LOCATION)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<AR>)g.ToList()
                          .AsReadOnly()));

            ARF_LOCATIONForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ARF>>>(() =>
                    Context.ARF
                          .Where(e => e.LOCATION != null)
                          .GroupBy(e => e.LOCATION)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ARF>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "AKL"; } }

        /// <summary>
        /// Find AKL by LOCATION key field
        /// </summary>
        /// <param name="Key">LOCATION value used to find AKL</param>
        /// <returns>Related AKL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">LOCATION value didn't match any AKL entities</exception>
        public AKL FindByLOCATION(string Key)
        {
            AKL result;
            if (LOCATIONIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find AKL by LOCATION key field
        /// </summary>
        /// <param name="Key">LOCATION value used to find AKL</param>
        /// <param name="Value">Related AKL entity</param>
        /// <returns>True if the AKL entity is found</returns>
        public bool TryFindByLOCATION(string Key, out AKL Value)
        {
            return LOCATIONIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find AKL by LOCATION key field
        /// </summary>
        /// <param name="Key">LOCATION value used to find AKL</param>
        /// <returns>Related AKL entity, or null if not found</returns>
        public AKL TryFindByLOCATION(string Key)
        {
            AKL result;
            if (LOCATIONIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all AR (Assets) entities by [AR.LOCATION]-&gt;[AKL.LOCATION]
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find AR entities</param>
        /// <returns>A list of related AR entities</returns>
        public IReadOnlyList<AR> FindARByLOCATION(string LOCATION)
        {
            IReadOnlyList<AR> result;
            if (AR_LOCATIONForeignIndex.Value.TryGetValue(LOCATION, out result))
            {
                return result;
            }
            else
            {
                return new List<AR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all AR entities by [AR.LOCATION]-&gt;[AKL.LOCATION]
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find AR entities</param>
        /// <param name="Value">A list of related AR entities</param>
        /// <returns>True if any AR entities are found</returns>
        public bool TryFindARByLOCATION(string LOCATION, out IReadOnlyList<AR> Value)
        {
            return AR_LOCATIONForeignIndex.Value.TryGetValue(LOCATION, out Value);
        }

        /// <summary>
        /// Find all ARF (Asset Financial Transactions) entities by [ARF.LOCATION]-&gt;[AKL.LOCATION]
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find ARF entities</param>
        /// <returns>A list of related ARF entities</returns>
        public IReadOnlyList<ARF> FindARFByLOCATION(string LOCATION)
        {
            IReadOnlyList<ARF> result;
            if (ARF_LOCATIONForeignIndex.Value.TryGetValue(LOCATION, out result))
            {
                return result;
            }
            else
            {
                return new List<ARF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ARF entities by [ARF.LOCATION]-&gt;[AKL.LOCATION]
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find ARF entities</param>
        /// <param name="Value">A list of related ARF entities</param>
        /// <returns>True if any ARF entities are found</returns>
        public bool TryFindARFByLOCATION(string LOCATION, out IReadOnlyList<ARF> Value)
        {
            return ARF_LOCATIONForeignIndex.Value.TryGetValue(LOCATION, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AKL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AKL" /> fields for each CSV column header</returns>
        protected override Action<AKL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<AKL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "LOCATION":
                        mapper[i] = (e, v) => e.LOCATION = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ESTIMATE_UNITS":
                        mapper[i] = (e, v) => e.ESTIMATE_UNITS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PERIOD_UNITS":
                        mapper[i] = (e, v) => e.PERIOD_UNITS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "UNITS_TO_DATE":
                        mapper[i] = (e, v) => e.UNITS_TO_DATE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ACUTOFF":
                        mapper[i] = (e, v) => e.ACUTOFF = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DATEFU":
                        mapper[i] = (e, v) => e.DATEFU = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PURDATE":
                        mapper[i] = (e, v) => e.PURDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AFLAG":
                        mapper[i] = (e, v) => e.AFLAG = v;
                        break;
                    case "TFLAG":
                        mapper[i] = (e, v) => e.TFLAG = v;
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
