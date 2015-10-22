using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Superannuation Funds Data Set
    /// </summary>
    public sealed partial class PFDataSet : SetBase<PF>
    {
        private Lazy<Dictionary<string, PF>> PFKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<PEPS>>> PEPS_SUPER_FUNDForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PEPU>>> PEPU_SUPER_FUNDForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PEPUH>>> PEPUH_SUPER_FUNDForeignIndex;

        internal PFDataSet(EduHubContext Context)
            : base(Context)
        {
            PFKEYIndex = new Lazy<Dictionary<string, PF>>(() => this.ToDictionary(e => e.PFKEY));

            PEPS_SUPER_FUNDForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PEPS>>>(() =>
                    Context.PEPS
                          .Where(e => e.SUPER_FUND != null)
                          .GroupBy(e => e.SUPER_FUND)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEPS>)g.ToList()
                          .AsReadOnly()));

            PEPU_SUPER_FUNDForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PEPU>>>(() =>
                    Context.PEPU
                          .Where(e => e.SUPER_FUND != null)
                          .GroupBy(e => e.SUPER_FUND)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEPU>)g.ToList()
                          .AsReadOnly()));

            PEPUH_SUPER_FUNDForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PEPUH>>>(() =>
                    Context.PEPUH
                          .Where(e => e.SUPER_FUND != null)
                          .GroupBy(e => e.SUPER_FUND)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEPUH>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PF"; } }

        /// <summary>
        /// Find PF by PFKEY key field
        /// </summary>
        /// <param name="Key">PFKEY value used to find PF</param>
        /// <returns>Related PF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">PFKEY value didn't match any PF entities</exception>
        public PF FindByPFKEY(string Key)
        {
            PF result;
            if (PFKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find PF by PFKEY key field
        /// </summary>
        /// <param name="Key">PFKEY value used to find PF</param>
        /// <param name="Value">Related PF entity</param>
        /// <returns>True if the PF entity is found</returns>
        public bool TryFindByPFKEY(string Key, out PF Value)
        {
            return PFKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find PF by PFKEY key field
        /// </summary>
        /// <param name="Key">PFKEY value used to find PF</param>
        /// <returns>Related PF entity, or null if not found</returns>
        public PF TryFindByPFKEY(string Key)
        {
            PF result;
            if (PFKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all PEPS (Standard and Last Pays) entities by [PEPS.SUPER_FUND]-&gt;[PF.PFKEY]
        /// </summary>
        /// <param name="PFKEY">PFKEY value used to find PEPS entities</param>
        /// <returns>A list of related PEPS entities</returns>
        public IReadOnlyList<PEPS> FindPEPSBySUPER_FUND(string PFKEY)
        {
            IReadOnlyList<PEPS> result;
            if (PEPS_SUPER_FUNDForeignIndex.Value.TryGetValue(PFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PEPS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEPS entities by [PEPS.SUPER_FUND]-&gt;[PF.PFKEY]
        /// </summary>
        /// <param name="PFKEY">PFKEY value used to find PEPS entities</param>
        /// <param name="Value">A list of related PEPS entities</param>
        /// <returns>True if any PEPS entities are found</returns>
        public bool TryFindPEPSBySUPER_FUND(string PFKEY, out IReadOnlyList<PEPS> Value)
        {
            return PEPS_SUPER_FUNDForeignIndex.Value.TryGetValue(PFKEY, out Value);
        }

        /// <summary>
        /// Find all PEPU (Super (SGL and Employee) YTD Transactions) entities by [PEPU.SUPER_FUND]-&gt;[PF.PFKEY]
        /// </summary>
        /// <param name="PFKEY">PFKEY value used to find PEPU entities</param>
        /// <returns>A list of related PEPU entities</returns>
        public IReadOnlyList<PEPU> FindPEPUBySUPER_FUND(string PFKEY)
        {
            IReadOnlyList<PEPU> result;
            if (PEPU_SUPER_FUNDForeignIndex.Value.TryGetValue(PFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PEPU>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEPU entities by [PEPU.SUPER_FUND]-&gt;[PF.PFKEY]
        /// </summary>
        /// <param name="PFKEY">PFKEY value used to find PEPU entities</param>
        /// <param name="Value">A list of related PEPU entities</param>
        /// <returns>True if any PEPU entities are found</returns>
        public bool TryFindPEPUBySUPER_FUND(string PFKEY, out IReadOnlyList<PEPU> Value)
        {
            return PEPU_SUPER_FUNDForeignIndex.Value.TryGetValue(PFKEY, out Value);
        }

        /// <summary>
        /// Find all PEPUH (Super (SGL and Employee) History YTD Transactions) entities by [PEPUH.SUPER_FUND]-&gt;[PF.PFKEY]
        /// </summary>
        /// <param name="PFKEY">PFKEY value used to find PEPUH entities</param>
        /// <returns>A list of related PEPUH entities</returns>
        public IReadOnlyList<PEPUH> FindPEPUHBySUPER_FUND(string PFKEY)
        {
            IReadOnlyList<PEPUH> result;
            if (PEPUH_SUPER_FUNDForeignIndex.Value.TryGetValue(PFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PEPUH>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEPUH entities by [PEPUH.SUPER_FUND]-&gt;[PF.PFKEY]
        /// </summary>
        /// <param name="PFKEY">PFKEY value used to find PEPUH entities</param>
        /// <param name="Value">A list of related PEPUH entities</param>
        /// <returns>True if any PEPUH entities are found</returns>
        public bool TryFindPEPUHBySUPER_FUND(string PFKEY, out IReadOnlyList<PEPUH> Value)
        {
            return PEPUH_SUPER_FUNDForeignIndex.Value.TryGetValue(PFKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PF" /> fields for each CSV column header</returns>
        protected override Action<PF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PFKEY":
                        mapper[i] = (e, v) => e.PFKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "CREATE_EXPORT_FILE":
                        mapper[i] = (e, v) => e.CREATE_EXPORT_FILE = v;
                        break;
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
                        break;
                    case "USI":
                        mapper[i] = (e, v) => e.USI = v;
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
