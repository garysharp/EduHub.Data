using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Association Positions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SAPDataSet : SetBase<SAP>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SAP"; } }

        internal SAPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SAPKEY = new Lazy<Dictionary<string, SAP>>(() => this.ToDictionary(i => i.SAPKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SAP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SAP" /> fields for each CSV column header</returns>
        protected override Action<SAP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SAP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SAPKEY":
                        mapper[i] = (e, v) => e.SAPKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "SORT_CODE":
                        mapper[i] = (e, v) => e.SORT_CODE = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="SAP" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SAP" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SAP" /> items to added or update the base <see cref="SAP" /> items</param>
        /// <returns>A merged list of <see cref="SAP" /> items</returns>
        protected override List<SAP> ApplyDeltaItems(List<SAP> Items, List<SAP> DeltaItems)
        {
            Dictionary<string, int> Index_SAPKEY = Items.ToIndexDictionary(i => i.SAPKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SAP deltaItem in DeltaItems)
            {
                int index;

                if (Index_SAPKEY.TryGetValue(deltaItem.SAPKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SAPKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, SAP>> Index_SAPKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SAP by SAPKEY field
        /// </summary>
        /// <param name="SAPKEY">SAPKEY value used to find SAP</param>
        /// <returns>Related SAP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAP FindBySAPKEY(string SAPKEY)
        {
            return Index_SAPKEY.Value[SAPKEY];
        }

        /// <summary>
        /// Attempt to find SAP by SAPKEY field
        /// </summary>
        /// <param name="SAPKEY">SAPKEY value used to find SAP</param>
        /// <param name="Value">Related SAP entity</param>
        /// <returns>True if the related SAP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySAPKEY(string SAPKEY, out SAP Value)
        {
            return Index_SAPKEY.Value.TryGetValue(SAPKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SAP by SAPKEY field
        /// </summary>
        /// <param name="SAPKEY">SAPKEY value used to find SAP</param>
        /// <returns>Related SAP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAP TryFindBySAPKEY(string SAPKEY)
        {
            SAP value;
            if (Index_SAPKEY.Value.TryGetValue(SAPKEY, out value))
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
