using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// VELS Dimensions Data Set
    /// </summary>
    public sealed partial class KDIDataSet : SetBase<KDI>
    {
        private Lazy<Dictionary<string, KDI>> KDIKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<STVDI>>> STVDI_VDIMENSIONForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STVDO>>> STVDO_VDIMENSIONForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SVAG>>> SVAG_VDIMENSIONForeignIndex;

        internal KDIDataSet(EduHubContext Context)
            : base(Context)
        {
            KDIKEYIndex = new Lazy<Dictionary<string, KDI>>(() => this.ToDictionary(e => e.KDIKEY));

            STVDI_VDIMENSIONForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STVDI>>>(() =>
                    Context.STVDI
                          .Where(e => e.VDIMENSION != null)
                          .GroupBy(e => e.VDIMENSION)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STVDI>)g.ToList()
                          .AsReadOnly()));

            STVDO_VDIMENSIONForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STVDO>>>(() =>
                    Context.STVDO
                          .Where(e => e.VDIMENSION != null)
                          .GroupBy(e => e.VDIMENSION)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STVDO>)g.ToList()
                          .AsReadOnly()));

            SVAG_VDIMENSIONForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SVAG>>>(() =>
                    Context.SVAG
                          .Where(e => e.VDIMENSION != null)
                          .GroupBy(e => e.VDIMENSION)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SVAG>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KDI"; } }

        /// <summary>
        /// Find KDI by KDIKEY key field
        /// </summary>
        /// <param name="Key">KDIKEY value used to find KDI</param>
        /// <returns>Related KDI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KDIKEY value didn't match any KDI entities</exception>
        public KDI FindByKDIKEY(string Key)
        {
            KDI result;
            if (KDIKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KDI by KDIKEY key field
        /// </summary>
        /// <param name="Key">KDIKEY value used to find KDI</param>
        /// <param name="Value">Related KDI entity</param>
        /// <returns>True if the KDI entity is found</returns>
        public bool TryFindByKDIKEY(string Key, out KDI Value)
        {
            return KDIKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KDI by KDIKEY key field
        /// </summary>
        /// <param name="Key">KDIKEY value used to find KDI</param>
        /// <returns>Related KDI entity, or null if not found</returns>
        public KDI TryFindByKDIKEY(string Key)
        {
            KDI result;
            if (KDIKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all STVDI (VELS Dimension Results) entities by [STVDI.VDIMENSION]-&gt;[KDI.KDIKEY]
        /// </summary>
        /// <param name="KDIKEY">KDIKEY value used to find STVDI entities</param>
        /// <returns>A list of related STVDI entities</returns>
        public IReadOnlyList<STVDI> FindSTVDIByVDIMENSION(string KDIKEY)
        {
            IReadOnlyList<STVDI> result;
            if (STVDI_VDIMENSIONForeignIndex.Value.TryGetValue(KDIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STVDI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STVDI entities by [STVDI.VDIMENSION]-&gt;[KDI.KDIKEY]
        /// </summary>
        /// <param name="KDIKEY">KDIKEY value used to find STVDI entities</param>
        /// <param name="Value">A list of related STVDI entities</param>
        /// <returns>True if any STVDI entities are found</returns>
        public bool TryFindSTVDIByVDIMENSION(string KDIKEY, out IReadOnlyList<STVDI> Value)
        {
            return STVDI_VDIMENSIONForeignIndex.Value.TryGetValue(KDIKEY, out Value);
        }

        /// <summary>
        /// Find all STVDO (VELS Domain Results) entities by [STVDO.VDIMENSION]-&gt;[KDI.KDIKEY]
        /// </summary>
        /// <param name="KDIKEY">KDIKEY value used to find STVDO entities</param>
        /// <returns>A list of related STVDO entities</returns>
        public IReadOnlyList<STVDO> FindSTVDOByVDIMENSION(string KDIKEY)
        {
            IReadOnlyList<STVDO> result;
            if (STVDO_VDIMENSIONForeignIndex.Value.TryGetValue(KDIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STVDO>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STVDO entities by [STVDO.VDIMENSION]-&gt;[KDI.KDIKEY]
        /// </summary>
        /// <param name="KDIKEY">KDIKEY value used to find STVDO entities</param>
        /// <param name="Value">A list of related STVDO entities</param>
        /// <returns>True if any STVDO entities are found</returns>
        public bool TryFindSTVDOByVDIMENSION(string KDIKEY, out IReadOnlyList<STVDO> Value)
        {
            return STVDO_VDIMENSIONForeignIndex.Value.TryGetValue(KDIKEY, out Value);
        }

        /// <summary>
        /// Find all SVAG (VELS Aggregated Dimensions) entities by [SVAG.VDIMENSION]-&gt;[KDI.KDIKEY]
        /// </summary>
        /// <param name="KDIKEY">KDIKEY value used to find SVAG entities</param>
        /// <returns>A list of related SVAG entities</returns>
        public IReadOnlyList<SVAG> FindSVAGByVDIMENSION(string KDIKEY)
        {
            IReadOnlyList<SVAG> result;
            if (SVAG_VDIMENSIONForeignIndex.Value.TryGetValue(KDIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SVAG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SVAG entities by [SVAG.VDIMENSION]-&gt;[KDI.KDIKEY]
        /// </summary>
        /// <param name="KDIKEY">KDIKEY value used to find SVAG entities</param>
        /// <param name="Value">A list of related SVAG entities</param>
        /// <returns>True if any SVAG entities are found</returns>
        public bool TryFindSVAGByVDIMENSION(string KDIKEY, out IReadOnlyList<SVAG> Value)
        {
            return SVAG_VDIMENSIONForeignIndex.Value.TryGetValue(KDIKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KDI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KDI" /> fields for each CSV column header</returns>
        protected override Action<KDI, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KDI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KDIKEY":
                        mapper[i] = (e, v) => e.KDIKEY = v;
                        break;
                    case "KDOKEY":
                        mapper[i] = (e, v) => e.KDOKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "MIN_SCORE":
                        mapper[i] = (e, v) => e.MIN_SCORE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "MAX_SCORE":
                        mapper[i] = (e, v) => e.MAX_SCORE = v == null ? (double?)null : double.Parse(v);
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
