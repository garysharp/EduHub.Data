using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Leave Group Types Data Set
    /// </summary>
    public sealed partial class PLTDataSet : SetBase<PLT>
    {
        private Lazy<Dictionary<string, PLT>> PLTKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<PELD>>> PELD_PLTKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PILI>>> PILI_PLTKEYForeignIndex;

        internal PLTDataSet(EduHubContext Context)
            : base(Context)
        {
            PLTKEYIndex = new Lazy<Dictionary<string, PLT>>(() => this.ToDictionary(e => e.PLTKEY));

            PELD_PLTKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PELD>>>(() =>
                    Context.PELD
                          .Where(e => e.PLTKEY != null)
                          .GroupBy(e => e.PLTKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PELD>)g.ToList()
                          .AsReadOnly()));

            PILI_PLTKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PILI>>>(() =>
                    Context.PILI
                          .Where(e => e.PLTKEY != null)
                          .GroupBy(e => e.PLTKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PILI>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PLT"; } }

        /// <summary>
        /// Find PLT by PLTKEY key field
        /// </summary>
        /// <param name="Key">PLTKEY value used to find PLT</param>
        /// <returns>Related PLT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">PLTKEY value didn't match any PLT entities</exception>
        public PLT FindByPLTKEY(string Key)
        {
            PLT result;
            if (PLTKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find PLT by PLTKEY key field
        /// </summary>
        /// <param name="Key">PLTKEY value used to find PLT</param>
        /// <param name="Value">Related PLT entity</param>
        /// <returns>True if the PLT entity is found</returns>
        public bool TryFindByPLTKEY(string Key, out PLT Value)
        {
            return PLTKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find PLT by PLTKEY key field
        /// </summary>
        /// <param name="Key">PLTKEY value used to find PLT</param>
        /// <returns>Related PLT entity, or null if not found</returns>
        public PLT TryFindByPLTKEY(string Key)
        {
            PLT result;
            if (PLTKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all PELD (Employee Leave Details) entities by [PELD.PLTKEY]-&gt;[PLT.PLTKEY]
        /// </summary>
        /// <param name="PLTKEY">PLTKEY value used to find PELD entities</param>
        /// <returns>A list of related PELD entities</returns>
        public IReadOnlyList<PELD> FindPELDByPLTKEY(string PLTKEY)
        {
            IReadOnlyList<PELD> result;
            if (PELD_PLTKEYForeignIndex.Value.TryGetValue(PLTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PELD>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PELD entities by [PELD.PLTKEY]-&gt;[PLT.PLTKEY]
        /// </summary>
        /// <param name="PLTKEY">PLTKEY value used to find PELD entities</param>
        /// <param name="Value">A list of related PELD entities</param>
        /// <returns>True if any PELD entities are found</returns>
        public bool TryFindPELDByPLTKEY(string PLTKEY, out IReadOnlyList<PELD> Value)
        {
            return PELD_PLTKEYForeignIndex.Value.TryGetValue(PLTKEY, out Value);
        }

        /// <summary>
        /// Find all PILI (Pay Item Leave Items) entities by [PILI.PLTKEY]-&gt;[PLT.PLTKEY]
        /// </summary>
        /// <param name="PLTKEY">PLTKEY value used to find PILI entities</param>
        /// <returns>A list of related PILI entities</returns>
        public IReadOnlyList<PILI> FindPILIByPLTKEY(string PLTKEY)
        {
            IReadOnlyList<PILI> result;
            if (PILI_PLTKEYForeignIndex.Value.TryGetValue(PLTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PILI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PILI entities by [PILI.PLTKEY]-&gt;[PLT.PLTKEY]
        /// </summary>
        /// <param name="PLTKEY">PLTKEY value used to find PILI entities</param>
        /// <param name="Value">A list of related PILI entities</param>
        /// <returns>True if any PILI entities are found</returns>
        public bool TryFindPILIByPLTKEY(string PLTKEY, out IReadOnlyList<PILI> Value)
        {
            return PILI_PLTKEYForeignIndex.Value.TryGetValue(PLTKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PLT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PLT" /> fields for each CSV column header</returns>
        protected override Action<PLT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PLT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PLTKEY":
                        mapper[i] = (e, v) => e.PLTKEY = v;
                        break;
                    case "LEAVE_GROUP":
                        mapper[i] = (e, v) => e.LEAVE_GROUP = v;
                        break;
                    case "LEAVE_CODE":
                        mapper[i] = (e, v) => e.LEAVE_CODE = v;
                        break;
                    case "CALC_METHOD":
                        mapper[i] = (e, v) => e.CALC_METHOD = v;
                        break;
                    case "PERIOD_ALLOT01":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT01 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT02":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT02 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT03":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT03 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT04":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT04 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT05":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT05 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT06":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT06 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT07":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT07 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT08":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT08 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT09":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT09 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT10":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT10 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT11":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT11 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT12":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT12 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_LENGTH01":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH01 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH02":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH02 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH03":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH03 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH04":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH04 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH05":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH05 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH06":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH06 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH07":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH07 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH08":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH08 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH09":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH09 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH10":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH10 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH11":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH11 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH12":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH12 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_UNITS":
                        mapper[i] = (e, v) => e.PERIOD_UNITS = v;
                        break;
                    case "ANNUAL_ENTITLEMENT":
                        mapper[i] = (e, v) => e.ANNUAL_ENTITLEMENT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ROLL_OVER":
                        mapper[i] = (e, v) => e.ROLL_OVER = v;
                        break;
                    case "ROLL_PERCENT":
                        mapper[i] = (e, v) => e.ROLL_PERCENT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "LEAVE_LOADING":
                        mapper[i] = (e, v) => e.LEAVE_LOADING = v;
                        break;
                    case "LOADING_PERCENT":
                        mapper[i] = (e, v) => e.LOADING_PERCENT = v == null ? (double?)null : double.Parse(v);
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
