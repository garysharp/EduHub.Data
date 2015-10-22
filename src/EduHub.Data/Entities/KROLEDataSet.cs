using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Role Codes Data Set
    /// </summary>
    public sealed partial class KROLEDataSet : SetBase<KROLE>
    {
        private Lazy<Dictionary<string, KROLE>> KROLEKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<KREPORT>>> KREPORT_ROLE_CODEForeignIndex;

        internal KROLEDataSet(EduHubContext Context)
            : base(Context)
        {
            KROLEKEYIndex = new Lazy<Dictionary<string, KROLE>>(() => this.ToDictionary(e => e.KROLEKEY));

            KREPORT_ROLE_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<KREPORT>>>(() =>
                    Context.KREPORT
                          .Where(e => e.ROLE_CODE != null)
                          .GroupBy(e => e.ROLE_CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<KREPORT>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KROLE"; } }

        /// <summary>
        /// Find KROLE by KROLEKEY key field
        /// </summary>
        /// <param name="Key">KROLEKEY value used to find KROLE</param>
        /// <returns>Related KROLE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KROLEKEY value didn't match any KROLE entities</exception>
        public KROLE FindByKROLEKEY(string Key)
        {
            KROLE result;
            if (KROLEKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KROLE by KROLEKEY key field
        /// </summary>
        /// <param name="Key">KROLEKEY value used to find KROLE</param>
        /// <param name="Value">Related KROLE entity</param>
        /// <returns>True if the KROLE entity is found</returns>
        public bool TryFindByKROLEKEY(string Key, out KROLE Value)
        {
            return KROLEKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KROLE by KROLEKEY key field
        /// </summary>
        /// <param name="Key">KROLEKEY value used to find KROLE</param>
        /// <returns>Related KROLE entity, or null if not found</returns>
        public KROLE TryFindByKROLEKEY(string Key)
        {
            KROLE result;
            if (KROLEKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all KREPORT (Reports for emailing) entities by [KREPORT.ROLE_CODE]-&gt;[KROLE.KROLEKEY]
        /// </summary>
        /// <param name="KROLEKEY">KROLEKEY value used to find KREPORT entities</param>
        /// <returns>A list of related KREPORT entities</returns>
        public IReadOnlyList<KREPORT> FindKREPORTByROLE_CODE(string KROLEKEY)
        {
            IReadOnlyList<KREPORT> result;
            if (KREPORT_ROLE_CODEForeignIndex.Value.TryGetValue(KROLEKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<KREPORT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all KREPORT entities by [KREPORT.ROLE_CODE]-&gt;[KROLE.KROLEKEY]
        /// </summary>
        /// <param name="KROLEKEY">KROLEKEY value used to find KREPORT entities</param>
        /// <param name="Value">A list of related KREPORT entities</param>
        /// <returns>True if any KREPORT entities are found</returns>
        public bool TryFindKREPORTByROLE_CODE(string KROLEKEY, out IReadOnlyList<KREPORT> Value)
        {
            return KREPORT_ROLE_CODEForeignIndex.Value.TryGetValue(KROLEKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KROLE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KROLE" /> fields for each CSV column header</returns>
        protected override Action<KROLE, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KROLE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KROLEKEY":
                        mapper[i] = (e, v) => e.KROLEKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ROLE_NAME":
                        mapper[i] = (e, v) => e.ROLE_NAME = v;
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
