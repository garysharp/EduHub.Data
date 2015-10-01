using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// GST Percentages Data Set
    /// </summary>
    public sealed class KGSTDataSet : SetBase<KGST>
    {
        private Lazy<Dictionary<string, KGST>> KGSTKEYIndex;

        internal KGSTDataSet(EduHubContext Context)
            : base(Context)
        {
            KGSTKEYIndex = new Lazy<Dictionary<string, KGST>>(() => this.ToDictionary(e => e.KGSTKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGST"; } }

        /// <summary>
        /// Find KGST by KGSTKEY key field
        /// </summary>
        /// <param name="Key">KGSTKEY value used to find KGST</param>
        /// <returns>Related KGST entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KGSTKEY value didn't match any KGST entities</exception>
        public KGST FindByKGSTKEY(string Key)
        {
            KGST result;
            if (KGSTKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KGST by KGSTKEY key field
        /// </summary>
        /// <param name="Key">KGSTKEY value used to find KGST</param>
        /// <param name="Value">Related KGST entity</param>
        /// <returns>True if the KGST entity is found</returns>
        public bool TryFindByKGSTKEY(string Key, out KGST Value)
        {
            return KGSTKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KGST by KGSTKEY key field
        /// </summary>
        /// <param name="Key">KGSTKEY value used to find KGST</param>
        /// <returns>Related KGST entity, or null if not found</returns>
        public KGST TryFindByKGSTKEY(string Key)
        {
            KGST result;
            if (KGSTKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGST" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGST" /> fields for each CSV column header</returns>
        protected override Action<KGST, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGST, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGSTKEY":
                        mapper[i] = (e, v) => e.KGSTKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "SALE_PURCH":
                        mapper[i] = (e, v) => e.SALE_PURCH = v;
                        break;
                    case "GST_RATE":
                        mapper[i] = (e, v) => e.GST_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "GST_BOX":
                        mapper[i] = (e, v) => e.GST_BOX = v;
                        break;
                    case "GLGST_CODE":
                        mapper[i] = (e, v) => e.GLGST_CODE = v;
                        break;
                    case "GST_RECLAIM":
                        mapper[i] = (e, v) => e.GST_RECLAIM = v;
                        break;
                    case "PRIOR_PERIOD_GST":
                        mapper[i] = (e, v) => e.PRIOR_PERIOD_GST = v;
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
