using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Associations Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCADataSet : SetBase<SCA>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCA"; } }

        internal SCADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SCAKEY = new Lazy<Dictionary<string, SCA>>(() => this.ToDictionary(i => i.SCAKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCA" /> fields for each CSV column header</returns>
        protected override Action<SCA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCAKEY":
                        mapper[i] = (e, v) => e.SCAKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "FIRST_DATE":
                        mapper[i] = (e, v) => e.FIRST_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LAST_DATE":
                        mapper[i] = (e, v) => e.LAST_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SCA_MEMO":
                        mapper[i] = (e, v) => e.SCA_MEMO = v;
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

        /// <summary>
        /// Merges <see cref="SCA" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SCA" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SCA" /> items to added or update the base <see cref="SCA" /> items</param>
        /// <returns>A merged list of <see cref="SCA" /> items</returns>
        protected override List<SCA> ApplyDeltaItems(List<SCA> Items, List<SCA> DeltaItems)
        {
            Dictionary<string, int> Index_SCAKEY = Items.ToIndexDictionary(i => i.SCAKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SCA deltaItem in DeltaItems)
            {
                int index;

                if (Index_SCAKEY.TryGetValue(deltaItem.SCAKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SCAKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, SCA>> Index_SCAKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCA by SCAKEY field
        /// </summary>
        /// <param name="SCAKEY">SCAKEY value used to find SCA</param>
        /// <returns>Related SCA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCA FindBySCAKEY(string SCAKEY)
        {
            return Index_SCAKEY.Value[SCAKEY];
        }

        /// <summary>
        /// Attempt to find SCA by SCAKEY field
        /// </summary>
        /// <param name="SCAKEY">SCAKEY value used to find SCA</param>
        /// <param name="Value">Related SCA entity</param>
        /// <returns>True if the related SCA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCAKEY(string SCAKEY, out SCA Value)
        {
            return Index_SCAKEY.Value.TryGetValue(SCAKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SCA by SCAKEY field
        /// </summary>
        /// <param name="SCAKEY">SCAKEY value used to find SCA</param>
        /// <returns>Related SCA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCA TryFindBySCAKEY(string SCAKEY)
        {
            SCA value;
            if (Index_SCAKEY.Value.TryGetValue(SCAKEY, out value))
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
