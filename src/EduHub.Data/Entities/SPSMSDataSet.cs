using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// SMS messages Data Set
    /// </summary>
    public sealed partial class SPSMSDataSet : SetBase<SPSMS>
    {
        private Lazy<Dictionary<int, SPSMS>> SPSMSKEYIndex;

        private Lazy<Dictionary<int, IReadOnlyList<SPRECIP>>> SPRECIP_CODEForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<SPREPLY>>> SPREPLY_CODEForeignIndex;

        internal SPSMSDataSet(EduHubContext Context)
            : base(Context)
        {
            SPSMSKEYIndex = new Lazy<Dictionary<int, SPSMS>>(() => this.ToDictionary(e => e.SPSMSKEY));

            SPRECIP_CODEForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<SPRECIP>>>(() =>
                    Context.SPRECIP
                          .Where(e => e.CODE != null)
                          .GroupBy(e => e.CODE.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SPRECIP>)g.ToList()
                          .AsReadOnly()));

            SPREPLY_CODEForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<SPREPLY>>>(() =>
                    Context.SPREPLY
                          .Where(e => e.CODE != null)
                          .GroupBy(e => e.CODE.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SPREPLY>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SPSMS"; } }

        /// <summary>
        /// Find SPSMS by SPSMSKEY key field
        /// </summary>
        /// <param name="Key">SPSMSKEY value used to find SPSMS</param>
        /// <returns>Related SPSMS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SPSMSKEY value didn't match any SPSMS entities</exception>
        public SPSMS FindBySPSMSKEY(int Key)
        {
            SPSMS result;
            if (SPSMSKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SPSMS by SPSMSKEY key field
        /// </summary>
        /// <param name="Key">SPSMSKEY value used to find SPSMS</param>
        /// <param name="Value">Related SPSMS entity</param>
        /// <returns>True if the SPSMS entity is found</returns>
        public bool TryFindBySPSMSKEY(int Key, out SPSMS Value)
        {
            return SPSMSKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SPSMS by SPSMSKEY key field
        /// </summary>
        /// <param name="Key">SPSMSKEY value used to find SPSMS</param>
        /// <returns>Related SPSMS entity, or null if not found</returns>
        public SPSMS TryFindBySPSMSKEY(int Key)
        {
            SPSMS result;
            if (SPSMSKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all SPRECIP (SMS Recipients) entities by [SPRECIP.CODE]-&gt;[SPSMS.SPSMSKEY]
        /// </summary>
        /// <param name="SPSMSKEY">SPSMSKEY value used to find SPRECIP entities</param>
        /// <returns>A list of related SPRECIP entities</returns>
        public IReadOnlyList<SPRECIP> FindSPRECIPByCODE(int SPSMSKEY)
        {
            IReadOnlyList<SPRECIP> result;
            if (SPRECIP_CODEForeignIndex.Value.TryGetValue(SPSMSKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SPRECIP>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SPRECIP entities by [SPRECIP.CODE]-&gt;[SPSMS.SPSMSKEY]
        /// </summary>
        /// <param name="SPSMSKEY">SPSMSKEY value used to find SPRECIP entities</param>
        /// <param name="Value">A list of related SPRECIP entities</param>
        /// <returns>True if any SPRECIP entities are found</returns>
        public bool TryFindSPRECIPByCODE(int SPSMSKEY, out IReadOnlyList<SPRECIP> Value)
        {
            return SPRECIP_CODEForeignIndex.Value.TryGetValue(SPSMSKEY, out Value);
        }

        /// <summary>
        /// Find all SPREPLY (SMS Recipients) entities by [SPREPLY.CODE]-&gt;[SPSMS.SPSMSKEY]
        /// </summary>
        /// <param name="SPSMSKEY">SPSMSKEY value used to find SPREPLY entities</param>
        /// <returns>A list of related SPREPLY entities</returns>
        public IReadOnlyList<SPREPLY> FindSPREPLYByCODE(int SPSMSKEY)
        {
            IReadOnlyList<SPREPLY> result;
            if (SPREPLY_CODEForeignIndex.Value.TryGetValue(SPSMSKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SPREPLY>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SPREPLY entities by [SPREPLY.CODE]-&gt;[SPSMS.SPSMSKEY]
        /// </summary>
        /// <param name="SPSMSKEY">SPSMSKEY value used to find SPREPLY entities</param>
        /// <param name="Value">A list of related SPREPLY entities</param>
        /// <returns>True if any SPREPLY entities are found</returns>
        public bool TryFindSPREPLYByCODE(int SPSMSKEY, out IReadOnlyList<SPREPLY> Value)
        {
            return SPREPLY_CODEForeignIndex.Value.TryGetValue(SPSMSKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPSMS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPSMS" /> fields for each CSV column header</returns>
        protected override Action<SPSMS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPSMS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SPSMSKEY":
                        mapper[i] = (e, v) => e.SPSMSKEY = int.Parse(v);
                        break;
                    case "MESSAGE":
                        mapper[i] = (e, v) => e.MESSAGE = v;
                        break;
                    case "CREATED_DATE":
                        mapper[i] = (e, v) => e.CREATED_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CREATED_BY":
                        mapper[i] = (e, v) => e.CREATED_BY = v;
                        break;
                    case "NOTIFY_REPLIES":
                        mapper[i] = (e, v) => e.NOTIFY_REPLIES = v;
                        break;
                    case "AUTO_MESSAGE":
                        mapper[i] = (e, v) => e.AUTO_MESSAGE = v;
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
