using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Contact Relationship Data Set
    /// </summary>
    public sealed class KPCRDataSet : SetBase<KPCR>
    {
        private Lazy<Dictionary<string, KPCR>> KPCRKEYIndex;

        internal KPCRDataSet(EduHubContext Context)
            : base(Context)
        {
            KPCRKEYIndex = new Lazy<Dictionary<string, KPCR>>(() => this.ToDictionary(e => e.KPCRKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KPCR"; } }

        /// <summary>
        /// Find KPCR by KPCRKEY key field
        /// </summary>
        /// <param name="Key">KPCRKEY value used to find KPCR</param>
        /// <returns>Related KPCR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KPCRKEY value didn't match any KPCR entities</exception>
        public KPCR FindByKPCRKEY(string Key)
        {
            KPCR result;
            if (KPCRKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KPCR by KPCRKEY key field
        /// </summary>
        /// <param name="Key">KPCRKEY value used to find KPCR</param>
        /// <param name="Value">Related KPCR entity</param>
        /// <returns>True if the KPCR entity is found</returns>
        public bool TryFindByKPCRKEY(string Key, out KPCR Value)
        {
            return KPCRKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KPCR by KPCRKEY key field
        /// </summary>
        /// <param name="Key">KPCRKEY value used to find KPCR</param>
        /// <returns>Related KPCR entity, or null if not found</returns>
        public KPCR TryFindByKPCRKEY(string Key)
        {
            KPCR result;
            if (KPCRKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KPCR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KPCR" /> fields for each CSV column header</returns>
        protected override Action<KPCR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KPCR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KPCRKEY":
                        mapper[i] = (e, v) => e.KPCRKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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
