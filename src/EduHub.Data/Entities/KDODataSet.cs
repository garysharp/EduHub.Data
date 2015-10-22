using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// VELS Domains Data Set
    /// </summary>
    public sealed partial class KDODataSet : SetBase<KDO>
    {
        private Lazy<Dictionary<string, KDO>> KDOKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<STVDI>>> STVDI_VDOMAINForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STVDO>>> STVDO_VDOMAINForeignIndex;

        internal KDODataSet(EduHubContext Context)
            : base(Context)
        {
            KDOKEYIndex = new Lazy<Dictionary<string, KDO>>(() => this.ToDictionary(e => e.KDOKEY));

            STVDI_VDOMAINForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STVDI>>>(() =>
                    Context.STVDI
                          .Where(e => e.VDOMAIN != null)
                          .GroupBy(e => e.VDOMAIN)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STVDI>)g.ToList()
                          .AsReadOnly()));

            STVDO_VDOMAINForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STVDO>>>(() =>
                    Context.STVDO
                          .Where(e => e.VDOMAIN != null)
                          .GroupBy(e => e.VDOMAIN)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STVDO>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KDO"; } }

        /// <summary>
        /// Find KDO by KDOKEY key field
        /// </summary>
        /// <param name="Key">KDOKEY value used to find KDO</param>
        /// <returns>Related KDO entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KDOKEY value didn't match any KDO entities</exception>
        public KDO FindByKDOKEY(string Key)
        {
            KDO result;
            if (KDOKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KDO by KDOKEY key field
        /// </summary>
        /// <param name="Key">KDOKEY value used to find KDO</param>
        /// <param name="Value">Related KDO entity</param>
        /// <returns>True if the KDO entity is found</returns>
        public bool TryFindByKDOKEY(string Key, out KDO Value)
        {
            return KDOKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KDO by KDOKEY key field
        /// </summary>
        /// <param name="Key">KDOKEY value used to find KDO</param>
        /// <returns>Related KDO entity, or null if not found</returns>
        public KDO TryFindByKDOKEY(string Key)
        {
            KDO result;
            if (KDOKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all STVDI (VELS Dimension Results) entities by [STVDI.VDOMAIN]-&gt;[KDO.KDOKEY]
        /// </summary>
        /// <param name="KDOKEY">KDOKEY value used to find STVDI entities</param>
        /// <returns>A list of related STVDI entities</returns>
        public IReadOnlyList<STVDI> FindSTVDIByVDOMAIN(string KDOKEY)
        {
            IReadOnlyList<STVDI> result;
            if (STVDI_VDOMAINForeignIndex.Value.TryGetValue(KDOKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STVDI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STVDI entities by [STVDI.VDOMAIN]-&gt;[KDO.KDOKEY]
        /// </summary>
        /// <param name="KDOKEY">KDOKEY value used to find STVDI entities</param>
        /// <param name="Value">A list of related STVDI entities</param>
        /// <returns>True if any STVDI entities are found</returns>
        public bool TryFindSTVDIByVDOMAIN(string KDOKEY, out IReadOnlyList<STVDI> Value)
        {
            return STVDI_VDOMAINForeignIndex.Value.TryGetValue(KDOKEY, out Value);
        }

        /// <summary>
        /// Find all STVDO (VELS Domain Results) entities by [STVDO.VDOMAIN]-&gt;[KDO.KDOKEY]
        /// </summary>
        /// <param name="KDOKEY">KDOKEY value used to find STVDO entities</param>
        /// <returns>A list of related STVDO entities</returns>
        public IReadOnlyList<STVDO> FindSTVDOByVDOMAIN(string KDOKEY)
        {
            IReadOnlyList<STVDO> result;
            if (STVDO_VDOMAINForeignIndex.Value.TryGetValue(KDOKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STVDO>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STVDO entities by [STVDO.VDOMAIN]-&gt;[KDO.KDOKEY]
        /// </summary>
        /// <param name="KDOKEY">KDOKEY value used to find STVDO entities</param>
        /// <param name="Value">A list of related STVDO entities</param>
        /// <returns>True if any STVDO entities are found</returns>
        public bool TryFindSTVDOByVDOMAIN(string KDOKEY, out IReadOnlyList<STVDO> Value)
        {
            return STVDO_VDOMAINForeignIndex.Value.TryGetValue(KDOKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KDO" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KDO" /> fields for each CSV column header</returns>
        protected override Action<KDO, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KDO, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KDOKEY":
                        mapper[i] = (e, v) => e.KDOKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "AUSVELS_START":
                        mapper[i] = (e, v) => e.AUSVELS_START = v;
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
