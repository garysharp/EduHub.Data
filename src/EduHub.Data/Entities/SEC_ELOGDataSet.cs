using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 Error Log Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SEC_ELOGDataSet : SetBase<SEC_ELOG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SEC_ELOG"; } }

        internal SEC_ELOGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ERRORCOUNT = new Lazy<Dictionary<int, SEC_ELOG>>(() => this.ToDictionary(i => i.ERRORCOUNT));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SEC_ELOG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SEC_ELOG" /> fields for each CSV column header</returns>
        protected override Action<SEC_ELOG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SEC_ELOG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ERRORCOUNT":
                        mapper[i] = (e, v) => e.ERRORCOUNT = int.Parse(v);
                        break;
                    case "ERRORDESCRIPTION":
                        mapper[i] = (e, v) => e.ERRORDESCRIPTION = v;
                        break;
                    case "ERRORTYPE":
                        mapper[i] = (e, v) => e.ERRORTYPE = v;
                        break;
                    case "ERRORTIME":
                        mapper[i] = (e, v) => e.ERRORTIME = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SEC_ELOG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SEC_ELOG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SEC_ELOG" /> items to added or update the base <see cref="SEC_ELOG" /> items</param>
        /// <returns>A merged list of <see cref="SEC_ELOG" /> items</returns>
        protected override List<SEC_ELOG> ApplyDeltaItems(List<SEC_ELOG> Items, List<SEC_ELOG> DeltaItems)
        {
            Dictionary<int, int> Index_ERRORCOUNT = Items.ToIndexDictionary(i => i.ERRORCOUNT);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SEC_ELOG deltaItem in DeltaItems)
            {
                int index;

                if (Index_ERRORCOUNT.TryGetValue(deltaItem.ERRORCOUNT, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.ERRORCOUNT)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, SEC_ELOG>> Index_ERRORCOUNT;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SEC_ELOG by ERRORCOUNT field
        /// </summary>
        /// <param name="ERRORCOUNT">ERRORCOUNT value used to find SEC_ELOG</param>
        /// <returns>Related SEC_ELOG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_ELOG FindByERRORCOUNT(int ERRORCOUNT)
        {
            return Index_ERRORCOUNT.Value[ERRORCOUNT];
        }

        /// <summary>
        /// Attempt to find SEC_ELOG by ERRORCOUNT field
        /// </summary>
        /// <param name="ERRORCOUNT">ERRORCOUNT value used to find SEC_ELOG</param>
        /// <param name="Value">Related SEC_ELOG entity</param>
        /// <returns>True if the related SEC_ELOG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByERRORCOUNT(int ERRORCOUNT, out SEC_ELOG Value)
        {
            return Index_ERRORCOUNT.Value.TryGetValue(ERRORCOUNT, out Value);
        }

        /// <summary>
        /// Attempt to find SEC_ELOG by ERRORCOUNT field
        /// </summary>
        /// <param name="ERRORCOUNT">ERRORCOUNT value used to find SEC_ELOG</param>
        /// <returns>Related SEC_ELOG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_ELOG TryFindByERRORCOUNT(int ERRORCOUNT)
        {
            SEC_ELOG value;
            if (Index_ERRORCOUNT.Value.TryGetValue(ERRORCOUNT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        #endregion

    }
}
