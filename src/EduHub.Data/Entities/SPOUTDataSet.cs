using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Stored Procedure Return Values Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPOUTDataSet : SetBase<SPOUT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SPOUT"; } }

        internal SPOUTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SPOUTKEY = new Lazy<Dictionary<string, SPOUT>>(() => this.ToDictionary(i => i.SPOUTKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPOUT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPOUT" /> fields for each CSV column header</returns>
        protected override Action<SPOUT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPOUT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SPOUTKEY":
                        mapper[i] = (e, v) => e.SPOUTKEY = v;
                        break;
                    case "FILE_NAME":
                        mapper[i] = (e, v) => e.FILE_NAME = v;
                        break;
                    case "ENTITYID":
                        mapper[i] = (e, v) => e.ENTITYID = v;
                        break;
                    case "FLAG01":
                        mapper[i] = (e, v) => e.FLAG01 = v;
                        break;
                    case "FLAG02":
                        mapper[i] = (e, v) => e.FLAG02 = v;
                        break;
                    case "FLAG03":
                        mapper[i] = (e, v) => e.FLAG03 = v;
                        break;
                    case "FLAG04":
                        mapper[i] = (e, v) => e.FLAG04 = v;
                        break;
                    case "TXT01":
                        mapper[i] = (e, v) => e.TXT01 = v;
                        break;
                    case "TXT02":
                        mapper[i] = (e, v) => e.TXT02 = v;
                        break;
                    case "TXT03":
                        mapper[i] = (e, v) => e.TXT03 = v;
                        break;
                    case "TXT04":
                        mapper[i] = (e, v) => e.TXT04 = v;
                        break;
                    case "NUM01":
                        mapper[i] = (e, v) => e.NUM01 = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "NUM02":
                        mapper[i] = (e, v) => e.NUM02 = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "NUM03":
                        mapper[i] = (e, v) => e.NUM03 = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "NUM04":
                        mapper[i] = (e, v) => e.NUM04 = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
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
        /// Merges <see cref="SPOUT" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SPOUT" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SPOUT" /> items to added or update the base <see cref="SPOUT" /> items</param>
        /// <returns>A merged list of <see cref="SPOUT" /> items</returns>
        protected override List<SPOUT> ApplyDeltaItems(List<SPOUT> Items, List<SPOUT> DeltaItems)
        {
            Dictionary<string, int> Index_SPOUTKEY = Items.ToIndexDictionary(i => i.SPOUTKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SPOUT deltaItem in DeltaItems)
            {
                int index;

                if (Index_SPOUTKEY.TryGetValue(deltaItem.SPOUTKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SPOUTKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, SPOUT>> Index_SPOUTKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SPOUT by SPOUTKEY field
        /// </summary>
        /// <param name="SPOUTKEY">SPOUTKEY value used to find SPOUT</param>
        /// <returns>Related SPOUT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPOUT FindBySPOUTKEY(string SPOUTKEY)
        {
            return Index_SPOUTKEY.Value[SPOUTKEY];
        }

        /// <summary>
        /// Attempt to find SPOUT by SPOUTKEY field
        /// </summary>
        /// <param name="SPOUTKEY">SPOUTKEY value used to find SPOUT</param>
        /// <param name="Value">Related SPOUT entity</param>
        /// <returns>True if the related SPOUT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySPOUTKEY(string SPOUTKEY, out SPOUT Value)
        {
            return Index_SPOUTKEY.Value.TryGetValue(SPOUTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SPOUT by SPOUTKEY field
        /// </summary>
        /// <param name="SPOUTKEY">SPOUTKEY value used to find SPOUT</param>
        /// <returns>Related SPOUT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPOUT TryFindBySPOUTKEY(string SPOUTKEY)
        {
            SPOUT value;
            if (Index_SPOUTKEY.Value.TryGetValue(SPOUTKEY, out value))
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
