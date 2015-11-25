using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 User Sessions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SEC_USRDataSet : SetBase<SEC_USR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SEC_USR"; } }

        internal SEC_USRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ROWID = new Lazy<Dictionary<int, SEC_USR>>(() => this.ToDictionary(i => i.ROWID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SEC_USR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SEC_USR" /> fields for each CSV column header</returns>
        protected override Action<SEC_USR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SEC_USR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ROWID":
                        mapper[i] = (e, v) => e.ROWID = int.Parse(v);
                        break;
                    case "SESSIONID":
                        mapper[i] = (e, v) => e.SESSIONID = v;
                        break;
                    case "USERID":
                        mapper[i] = (e, v) => e.USERID = v;
                        break;
                    case "DATECREATED":
                        mapper[i] = (e, v) => e.DATECREATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SEC_USR" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SEC_USR" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SEC_USR" /> items to added or update the base <see cref="SEC_USR" /> items</param>
        /// <returns>A merged list of <see cref="SEC_USR" /> items</returns>
        protected override List<SEC_USR> ApplyDeltaItems(List<SEC_USR> Items, List<SEC_USR> DeltaItems)
        {
            Dictionary<int, int> Index_ROWID = Items.ToIndexDictionary(i => i.ROWID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SEC_USR deltaItem in DeltaItems)
            {
                int index;

                if (Index_ROWID.TryGetValue(deltaItem.ROWID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.ROWID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, SEC_USR>> Index_ROWID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SEC_USR by ROWID field
        /// </summary>
        /// <param name="ROWID">ROWID value used to find SEC_USR</param>
        /// <returns>Related SEC_USR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_USR FindByROWID(int ROWID)
        {
            return Index_ROWID.Value[ROWID];
        }

        /// <summary>
        /// Attempt to find SEC_USR by ROWID field
        /// </summary>
        /// <param name="ROWID">ROWID value used to find SEC_USR</param>
        /// <param name="Value">Related SEC_USR entity</param>
        /// <returns>True if the related SEC_USR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROWID(int ROWID, out SEC_USR Value)
        {
            return Index_ROWID.Value.TryGetValue(ROWID, out Value);
        }

        /// <summary>
        /// Attempt to find SEC_USR by ROWID field
        /// </summary>
        /// <param name="ROWID">ROWID value used to find SEC_USR</param>
        /// <returns>Related SEC_USR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_USR TryFindByROWID(int ROWID)
        {
            SEC_USR value;
            if (Index_ROWID.Value.TryGetValue(ROWID, out value))
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
