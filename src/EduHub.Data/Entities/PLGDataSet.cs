using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Leave Management Group Data Set
    /// </summary>
    public sealed partial class PLGDataSet : SetBase<PLG>
    {
        private Lazy<Dictionary<string, PLG>> LEAVE_GROUPIndex;

        private Lazy<Dictionary<string, IReadOnlyList<PE>>> PE_LEAVE_GROUPForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PILI>>> PILI_LEAVE_GROUPForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PLT>>> PLT_LEAVE_GROUPForeignIndex;

        internal PLGDataSet(EduHubContext Context)
            : base(Context)
        {
            LEAVE_GROUPIndex = new Lazy<Dictionary<string, PLG>>(() => this.ToDictionary(e => e.LEAVE_GROUP));

            PE_LEAVE_GROUPForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PE>>>(() =>
                    Context.PE
                          .Where(e => e.LEAVE_GROUP != null)
                          .GroupBy(e => e.LEAVE_GROUP)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PE>)g.ToList()
                          .AsReadOnly()));

            PILI_LEAVE_GROUPForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PILI>>>(() =>
                    Context.PILI
                          .Where(e => e.LEAVE_GROUP != null)
                          .GroupBy(e => e.LEAVE_GROUP)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PILI>)g.ToList()
                          .AsReadOnly()));

            PLT_LEAVE_GROUPForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PLT>>>(() =>
                    Context.PLT
                          .Where(e => e.LEAVE_GROUP != null)
                          .GroupBy(e => e.LEAVE_GROUP)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PLT>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PLG"; } }

        /// <summary>
        /// Find PLG by LEAVE_GROUP key field
        /// </summary>
        /// <param name="Key">LEAVE_GROUP value used to find PLG</param>
        /// <returns>Related PLG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">LEAVE_GROUP value didn't match any PLG entities</exception>
        public PLG FindByLEAVE_GROUP(string Key)
        {
            PLG result;
            if (LEAVE_GROUPIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find PLG by LEAVE_GROUP key field
        /// </summary>
        /// <param name="Key">LEAVE_GROUP value used to find PLG</param>
        /// <param name="Value">Related PLG entity</param>
        /// <returns>True if the PLG entity is found</returns>
        public bool TryFindByLEAVE_GROUP(string Key, out PLG Value)
        {
            return LEAVE_GROUPIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find PLG by LEAVE_GROUP key field
        /// </summary>
        /// <param name="Key">LEAVE_GROUP value used to find PLG</param>
        /// <returns>Related PLG entity, or null if not found</returns>
        public PLG TryFindByLEAVE_GROUP(string Key)
        {
            PLG result;
            if (LEAVE_GROUPIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all PE (Employees) entities by [PE.LEAVE_GROUP]-&gt;[PLG.LEAVE_GROUP]
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PE entities</param>
        /// <returns>A list of related PE entities</returns>
        public IReadOnlyList<PE> FindPEByLEAVE_GROUP(string LEAVE_GROUP)
        {
            IReadOnlyList<PE> result;
            if (PE_LEAVE_GROUPForeignIndex.Value.TryGetValue(LEAVE_GROUP, out result))
            {
                return result;
            }
            else
            {
                return new List<PE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PE entities by [PE.LEAVE_GROUP]-&gt;[PLG.LEAVE_GROUP]
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PE entities</param>
        /// <param name="Value">A list of related PE entities</param>
        /// <returns>True if any PE entities are found</returns>
        public bool TryFindPEByLEAVE_GROUP(string LEAVE_GROUP, out IReadOnlyList<PE> Value)
        {
            return PE_LEAVE_GROUPForeignIndex.Value.TryGetValue(LEAVE_GROUP, out Value);
        }

        /// <summary>
        /// Find all PILI (Pay Item Leave Items) entities by [PILI.LEAVE_GROUP]-&gt;[PLG.LEAVE_GROUP]
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PILI entities</param>
        /// <returns>A list of related PILI entities</returns>
        public IReadOnlyList<PILI> FindPILIByLEAVE_GROUP(string LEAVE_GROUP)
        {
            IReadOnlyList<PILI> result;
            if (PILI_LEAVE_GROUPForeignIndex.Value.TryGetValue(LEAVE_GROUP, out result))
            {
                return result;
            }
            else
            {
                return new List<PILI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PILI entities by [PILI.LEAVE_GROUP]-&gt;[PLG.LEAVE_GROUP]
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PILI entities</param>
        /// <param name="Value">A list of related PILI entities</param>
        /// <returns>True if any PILI entities are found</returns>
        public bool TryFindPILIByLEAVE_GROUP(string LEAVE_GROUP, out IReadOnlyList<PILI> Value)
        {
            return PILI_LEAVE_GROUPForeignIndex.Value.TryGetValue(LEAVE_GROUP, out Value);
        }

        /// <summary>
        /// Find all PLT (Leave Group Types) entities by [PLT.LEAVE_GROUP]-&gt;[PLG.LEAVE_GROUP]
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PLT entities</param>
        /// <returns>A list of related PLT entities</returns>
        public IReadOnlyList<PLT> FindPLTByLEAVE_GROUP(string LEAVE_GROUP)
        {
            IReadOnlyList<PLT> result;
            if (PLT_LEAVE_GROUPForeignIndex.Value.TryGetValue(LEAVE_GROUP, out result))
            {
                return result;
            }
            else
            {
                return new List<PLT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PLT entities by [PLT.LEAVE_GROUP]-&gt;[PLG.LEAVE_GROUP]
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PLT entities</param>
        /// <param name="Value">A list of related PLT entities</param>
        /// <returns>True if any PLT entities are found</returns>
        public bool TryFindPLTByLEAVE_GROUP(string LEAVE_GROUP, out IReadOnlyList<PLT> Value)
        {
            return PLT_LEAVE_GROUPForeignIndex.Value.TryGetValue(LEAVE_GROUP, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PLG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PLG" /> fields for each CSV column header</returns>
        protected override Action<PLG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PLG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "LEAVE_GROUP":
                        mapper[i] = (e, v) => e.LEAVE_GROUP = v;
                        break;
                    case "LEAVE_GROUP_DESC":
                        mapper[i] = (e, v) => e.LEAVE_GROUP_DESC = v;
                        break;
                    case "WEEKLY_HOURS":
                        mapper[i] = (e, v) => e.WEEKLY_HOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "DAILY_HOURS":
                        mapper[i] = (e, v) => e.DAILY_HOURS = v == null ? (double?)null : double.Parse(v);
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
