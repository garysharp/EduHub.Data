using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Contact Links Data Set
    /// </summary>
    public sealed class KPCLDataSet : SetBase<KPCL>
    {
        private Lazy<Dictionary<int, KPCL>> KPCLKEYIndex;

        internal KPCLDataSet(EduHubContext Context)
            : base(Context)
        {
            KPCLKEYIndex = new Lazy<Dictionary<int, KPCL>>(() => this.ToDictionary(e => e.KPCLKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KPCL"; } }

        /// <summary>
        /// Find KPCL by KPCLKEY key field
        /// </summary>
        /// <param name="Key">KPCLKEY value used to find KPCL</param>
        /// <returns>Related KPCL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KPCLKEY value didn't match any KPCL entities</exception>
        public KPCL FindByKPCLKEY(int Key)
        {
            KPCL result;
            if (KPCLKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KPCL by KPCLKEY key field
        /// </summary>
        /// <param name="Key">KPCLKEY value used to find KPCL</param>
        /// <param name="Value">Related KPCL entity</param>
        /// <returns>True if the KPCL entity is found</returns>
        public bool TryFindByKPCLKEY(int Key, out KPCL Value)
        {
            return KPCLKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KPCL by KPCLKEY key field
        /// </summary>
        /// <param name="Key">KPCLKEY value used to find KPCL</param>
        /// <returns>Related KPCL entity, or null if not found</returns>
        public KPCL TryFindByKPCLKEY(int Key)
        {
            KPCL result;
            if (KPCLKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KPCL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KPCL" /> fields for each CSV column header</returns>
        protected override Action<KPCL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KPCL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KPCLKEY":
                        mapper[i] = (e, v) => e.KPCLKEY = int.Parse(v);
                        break;
                    case "LINK":
                        mapper[i] = (e, v) => e.LINK = v;
                        break;
                    case "SOURCE":
                        mapper[i] = (e, v) => e.SOURCE = v;
                        break;
                    case "CONTACT":
                        mapper[i] = (e, v) => e.CONTACT = v;
                        break;
                    case "CONTACT_TYPE":
                        mapper[i] = (e, v) => e.CONTACT_TYPE = v;
                        break;
                    case "CONTACT_PREFERENCE":
                        mapper[i] = (e, v) => e.CONTACT_PREFERENCE = v == null ? (short?)null : short.Parse(v);
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
