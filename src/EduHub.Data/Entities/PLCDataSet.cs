using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Leave Code Description Data Set
    /// </summary>
    public sealed partial class PLCDataSet : SetBase<PLC>
    {
        private Lazy<Dictionary<string, PLC>> PLCKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<PELA>>> PELA_LEAVE_CODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PELD>>> PELD_LEAVE_CODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PILI>>> PILI_LEAVE_CODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PLT>>> PLT_LEAVE_CODEForeignIndex;

        internal PLCDataSet(EduHubContext Context)
            : base(Context)
        {
            PLCKEYIndex = new Lazy<Dictionary<string, PLC>>(() => this.ToDictionary(e => e.PLCKEY));

            PELA_LEAVE_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PELA>>>(() =>
                    Context.PELA
                          .Where(e => e.LEAVE_CODE != null)
                          .GroupBy(e => e.LEAVE_CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PELA>)g.ToList()
                          .AsReadOnly()));

            PELD_LEAVE_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PELD>>>(() =>
                    Context.PELD
                          .Where(e => e.LEAVE_CODE != null)
                          .GroupBy(e => e.LEAVE_CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PELD>)g.ToList()
                          .AsReadOnly()));

            PILI_LEAVE_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PILI>>>(() =>
                    Context.PILI
                          .Where(e => e.LEAVE_CODE != null)
                          .GroupBy(e => e.LEAVE_CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PILI>)g.ToList()
                          .AsReadOnly()));

            PLT_LEAVE_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PLT>>>(() =>
                    Context.PLT
                          .Where(e => e.LEAVE_CODE != null)
                          .GroupBy(e => e.LEAVE_CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PLT>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PLC"; } }

        /// <summary>
        /// Find PLC by PLCKEY key field
        /// </summary>
        /// <param name="Key">PLCKEY value used to find PLC</param>
        /// <returns>Related PLC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">PLCKEY value didn't match any PLC entities</exception>
        public PLC FindByPLCKEY(string Key)
        {
            PLC result;
            if (PLCKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find PLC by PLCKEY key field
        /// </summary>
        /// <param name="Key">PLCKEY value used to find PLC</param>
        /// <param name="Value">Related PLC entity</param>
        /// <returns>True if the PLC entity is found</returns>
        public bool TryFindByPLCKEY(string Key, out PLC Value)
        {
            return PLCKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find PLC by PLCKEY key field
        /// </summary>
        /// <param name="Key">PLCKEY value used to find PLC</param>
        /// <returns>Related PLC entity, or null if not found</returns>
        public PLC TryFindByPLCKEY(string Key)
        {
            PLC result;
            if (PLCKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all PELA (Employee Leave Audit) entities by [PELA.LEAVE_CODE]-&gt;[PLC.PLCKEY]
        /// </summary>
        /// <param name="PLCKEY">PLCKEY value used to find PELA entities</param>
        /// <returns>A list of related PELA entities</returns>
        public IReadOnlyList<PELA> FindPELAByLEAVE_CODE(string PLCKEY)
        {
            IReadOnlyList<PELA> result;
            if (PELA_LEAVE_CODEForeignIndex.Value.TryGetValue(PLCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PELA>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PELA entities by [PELA.LEAVE_CODE]-&gt;[PLC.PLCKEY]
        /// </summary>
        /// <param name="PLCKEY">PLCKEY value used to find PELA entities</param>
        /// <param name="Value">A list of related PELA entities</param>
        /// <returns>True if any PELA entities are found</returns>
        public bool TryFindPELAByLEAVE_CODE(string PLCKEY, out IReadOnlyList<PELA> Value)
        {
            return PELA_LEAVE_CODEForeignIndex.Value.TryGetValue(PLCKEY, out Value);
        }

        /// <summary>
        /// Find all PELD (Employee Leave Details) entities by [PELD.LEAVE_CODE]-&gt;[PLC.PLCKEY]
        /// </summary>
        /// <param name="PLCKEY">PLCKEY value used to find PELD entities</param>
        /// <returns>A list of related PELD entities</returns>
        public IReadOnlyList<PELD> FindPELDByLEAVE_CODE(string PLCKEY)
        {
            IReadOnlyList<PELD> result;
            if (PELD_LEAVE_CODEForeignIndex.Value.TryGetValue(PLCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PELD>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PELD entities by [PELD.LEAVE_CODE]-&gt;[PLC.PLCKEY]
        /// </summary>
        /// <param name="PLCKEY">PLCKEY value used to find PELD entities</param>
        /// <param name="Value">A list of related PELD entities</param>
        /// <returns>True if any PELD entities are found</returns>
        public bool TryFindPELDByLEAVE_CODE(string PLCKEY, out IReadOnlyList<PELD> Value)
        {
            return PELD_LEAVE_CODEForeignIndex.Value.TryGetValue(PLCKEY, out Value);
        }

        /// <summary>
        /// Find all PILI (Pay Item Leave Items) entities by [PILI.LEAVE_CODE]-&gt;[PLC.PLCKEY]
        /// </summary>
        /// <param name="PLCKEY">PLCKEY value used to find PILI entities</param>
        /// <returns>A list of related PILI entities</returns>
        public IReadOnlyList<PILI> FindPILIByLEAVE_CODE(string PLCKEY)
        {
            IReadOnlyList<PILI> result;
            if (PILI_LEAVE_CODEForeignIndex.Value.TryGetValue(PLCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PILI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PILI entities by [PILI.LEAVE_CODE]-&gt;[PLC.PLCKEY]
        /// </summary>
        /// <param name="PLCKEY">PLCKEY value used to find PILI entities</param>
        /// <param name="Value">A list of related PILI entities</param>
        /// <returns>True if any PILI entities are found</returns>
        public bool TryFindPILIByLEAVE_CODE(string PLCKEY, out IReadOnlyList<PILI> Value)
        {
            return PILI_LEAVE_CODEForeignIndex.Value.TryGetValue(PLCKEY, out Value);
        }

        /// <summary>
        /// Find all PLT (Leave Group Types) entities by [PLT.LEAVE_CODE]-&gt;[PLC.PLCKEY]
        /// </summary>
        /// <param name="PLCKEY">PLCKEY value used to find PLT entities</param>
        /// <returns>A list of related PLT entities</returns>
        public IReadOnlyList<PLT> FindPLTByLEAVE_CODE(string PLCKEY)
        {
            IReadOnlyList<PLT> result;
            if (PLT_LEAVE_CODEForeignIndex.Value.TryGetValue(PLCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PLT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PLT entities by [PLT.LEAVE_CODE]-&gt;[PLC.PLCKEY]
        /// </summary>
        /// <param name="PLCKEY">PLCKEY value used to find PLT entities</param>
        /// <param name="Value">A list of related PLT entities</param>
        /// <returns>True if any PLT entities are found</returns>
        public bool TryFindPLTByLEAVE_CODE(string PLCKEY, out IReadOnlyList<PLT> Value)
        {
            return PLT_LEAVE_CODEForeignIndex.Value.TryGetValue(PLCKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PLC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PLC" /> fields for each CSV column header</returns>
        protected override Action<PLC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PLC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PLCKEY":
                        mapper[i] = (e, v) => e.PLCKEY = v;
                        break;
                    case "LEAVE_DESC":
                        mapper[i] = (e, v) => e.LEAVE_DESC = v;
                        break;
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
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
