using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Transport Modes Data Set
    /// </summary>
    public sealed partial class TRPMODEDataSet : SetBase<TRPMODE>
    {
        private Lazy<Dictionary<int, TRPMODE>> TRANSPORT_MODE_IDIndex;

        private Lazy<Dictionary<int, IReadOnlyList<STTRIPS>>> STTRIPS_AM_TRANSPORT_MODEForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<STTRIPS>>> STTRIPS_PM_TRANSPORT_MODEForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<TRPROUT>>> TRPROUT_TRANSPORT_MODE_IDForeignIndex;

        internal TRPMODEDataSet(EduHubContext Context)
            : base(Context)
        {
            TRANSPORT_MODE_IDIndex = new Lazy<Dictionary<int, TRPMODE>>(() => this.ToDictionary(e => e.TRANSPORT_MODE_ID));

            STTRIPS_AM_TRANSPORT_MODEForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<STTRIPS>>>(() =>
                    Context.STTRIPS
                          .Where(e => e.AM_TRANSPORT_MODE != null)
                          .GroupBy(e => e.AM_TRANSPORT_MODE.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STTRIPS>)g.ToList()
                          .AsReadOnly()));

            STTRIPS_PM_TRANSPORT_MODEForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<STTRIPS>>>(() =>
                    Context.STTRIPS
                          .Where(e => e.PM_TRANSPORT_MODE != null)
                          .GroupBy(e => e.PM_TRANSPORT_MODE.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STTRIPS>)g.ToList()
                          .AsReadOnly()));

            TRPROUT_TRANSPORT_MODE_IDForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<TRPROUT>>>(() =>
                    Context.TRPROUT
                          .Where(e => e.TRANSPORT_MODE_ID != null)
                          .GroupBy(e => e.TRANSPORT_MODE_ID.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TRPROUT>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TRPMODE"; } }

        /// <summary>
        /// Find TRPMODE by TRANSPORT_MODE_ID key field
        /// </summary>
        /// <param name="Key">TRANSPORT_MODE_ID value used to find TRPMODE</param>
        /// <returns>Related TRPMODE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TRANSPORT_MODE_ID value didn't match any TRPMODE entities</exception>
        public TRPMODE FindByTRANSPORT_MODE_ID(int Key)
        {
            TRPMODE result;
            if (TRANSPORT_MODE_IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find TRPMODE by TRANSPORT_MODE_ID key field
        /// </summary>
        /// <param name="Key">TRANSPORT_MODE_ID value used to find TRPMODE</param>
        /// <param name="Value">Related TRPMODE entity</param>
        /// <returns>True if the TRPMODE entity is found</returns>
        public bool TryFindByTRANSPORT_MODE_ID(int Key, out TRPMODE Value)
        {
            return TRANSPORT_MODE_IDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find TRPMODE by TRANSPORT_MODE_ID key field
        /// </summary>
        /// <param name="Key">TRANSPORT_MODE_ID value used to find TRPMODE</param>
        /// <returns>Related TRPMODE entity, or null if not found</returns>
        public TRPMODE TryFindByTRANSPORT_MODE_ID(int Key)
        {
            TRPMODE result;
            if (TRANSPORT_MODE_IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all STTRIPS (Student Trips) entities by [STTRIPS.AM_TRANSPORT_MODE]-&gt;[TRPMODE.TRANSPORT_MODE_ID]
        /// </summary>
        /// <param name="TRANSPORT_MODE_ID">TRANSPORT_MODE_ID value used to find STTRIPS entities</param>
        /// <returns>A list of related STTRIPS entities</returns>
        public IReadOnlyList<STTRIPS> FindSTTRIPSByAM_TRANSPORT_MODE(int TRANSPORT_MODE_ID)
        {
            IReadOnlyList<STTRIPS> result;
            if (STTRIPS_AM_TRANSPORT_MODEForeignIndex.Value.TryGetValue(TRANSPORT_MODE_ID, out result))
            {
                return result;
            }
            else
            {
                return new List<STTRIPS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STTRIPS entities by [STTRIPS.AM_TRANSPORT_MODE]-&gt;[TRPMODE.TRANSPORT_MODE_ID]
        /// </summary>
        /// <param name="TRANSPORT_MODE_ID">TRANSPORT_MODE_ID value used to find STTRIPS entities</param>
        /// <param name="Value">A list of related STTRIPS entities</param>
        /// <returns>True if any STTRIPS entities are found</returns>
        public bool TryFindSTTRIPSByAM_TRANSPORT_MODE(int TRANSPORT_MODE_ID, out IReadOnlyList<STTRIPS> Value)
        {
            return STTRIPS_AM_TRANSPORT_MODEForeignIndex.Value.TryGetValue(TRANSPORT_MODE_ID, out Value);
        }

        /// <summary>
        /// Find all STTRIPS (Student Trips) entities by [STTRIPS.PM_TRANSPORT_MODE]-&gt;[TRPMODE.TRANSPORT_MODE_ID]
        /// </summary>
        /// <param name="TRANSPORT_MODE_ID">TRANSPORT_MODE_ID value used to find STTRIPS entities</param>
        /// <returns>A list of related STTRIPS entities</returns>
        public IReadOnlyList<STTRIPS> FindSTTRIPSByPM_TRANSPORT_MODE(int TRANSPORT_MODE_ID)
        {
            IReadOnlyList<STTRIPS> result;
            if (STTRIPS_PM_TRANSPORT_MODEForeignIndex.Value.TryGetValue(TRANSPORT_MODE_ID, out result))
            {
                return result;
            }
            else
            {
                return new List<STTRIPS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STTRIPS entities by [STTRIPS.PM_TRANSPORT_MODE]-&gt;[TRPMODE.TRANSPORT_MODE_ID]
        /// </summary>
        /// <param name="TRANSPORT_MODE_ID">TRANSPORT_MODE_ID value used to find STTRIPS entities</param>
        /// <param name="Value">A list of related STTRIPS entities</param>
        /// <returns>True if any STTRIPS entities are found</returns>
        public bool TryFindSTTRIPSByPM_TRANSPORT_MODE(int TRANSPORT_MODE_ID, out IReadOnlyList<STTRIPS> Value)
        {
            return STTRIPS_PM_TRANSPORT_MODEForeignIndex.Value.TryGetValue(TRANSPORT_MODE_ID, out Value);
        }

        /// <summary>
        /// Find all TRPROUT (Student Transport Routes) entities by [TRPROUT.TRANSPORT_MODE_ID]-&gt;[TRPMODE.TRANSPORT_MODE_ID]
        /// </summary>
        /// <param name="TRANSPORT_MODE_ID">TRANSPORT_MODE_ID value used to find TRPROUT entities</param>
        /// <returns>A list of related TRPROUT entities</returns>
        public IReadOnlyList<TRPROUT> FindTRPROUTByTRANSPORT_MODE_ID(int TRANSPORT_MODE_ID)
        {
            IReadOnlyList<TRPROUT> result;
            if (TRPROUT_TRANSPORT_MODE_IDForeignIndex.Value.TryGetValue(TRANSPORT_MODE_ID, out result))
            {
                return result;
            }
            else
            {
                return new List<TRPROUT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TRPROUT entities by [TRPROUT.TRANSPORT_MODE_ID]-&gt;[TRPMODE.TRANSPORT_MODE_ID]
        /// </summary>
        /// <param name="TRANSPORT_MODE_ID">TRANSPORT_MODE_ID value used to find TRPROUT entities</param>
        /// <param name="Value">A list of related TRPROUT entities</param>
        /// <returns>True if any TRPROUT entities are found</returns>
        public bool TryFindTRPROUTByTRANSPORT_MODE_ID(int TRANSPORT_MODE_ID, out IReadOnlyList<TRPROUT> Value)
        {
            return TRPROUT_TRANSPORT_MODE_IDForeignIndex.Value.TryGetValue(TRANSPORT_MODE_ID, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TRPMODE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TRPMODE" /> fields for each CSV column header</returns>
        protected override Action<TRPMODE, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TRPMODE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TRANSPORT_MODE_ID":
                        mapper[i] = (e, v) => e.TRANSPORT_MODE_ID = int.Parse(v);
                        break;
                    case "TRANSPORT_MODE_DESC":
                        mapper[i] = (e, v) => e.TRANSPORT_MODE_DESC = v;
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
