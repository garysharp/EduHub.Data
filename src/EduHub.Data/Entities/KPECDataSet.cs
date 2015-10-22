using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee Categories Data Set
    /// </summary>
    public sealed partial class KPECDataSet : SetBase<KPEC>
    {
        private Lazy<Dictionary<string, KPEC>> KPECKEYIndex;


        internal KPECDataSet(EduHubContext Context)
            : base(Context)
        {
            KPECKEYIndex = new Lazy<Dictionary<string, KPEC>>(() => this.ToDictionary(e => e.KPECKEY));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KPEC"; } }

        /// <summary>
        /// Find KPEC by KPECKEY key field
        /// </summary>
        /// <param name="Key">KPECKEY value used to find KPEC</param>
        /// <returns>Related KPEC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KPECKEY value didn't match any KPEC entities</exception>
        public KPEC FindByKPECKEY(string Key)
        {
            KPEC result;
            if (KPECKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KPEC by KPECKEY key field
        /// </summary>
        /// <param name="Key">KPECKEY value used to find KPEC</param>
        /// <param name="Value">Related KPEC entity</param>
        /// <returns>True if the KPEC entity is found</returns>
        public bool TryFindByKPECKEY(string Key, out KPEC Value)
        {
            return KPECKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KPEC by KPECKEY key field
        /// </summary>
        /// <param name="Key">KPECKEY value used to find KPEC</param>
        /// <returns>Related KPEC entity, or null if not found</returns>
        public KPEC TryFindByKPECKEY(string Key)
        {
            KPEC result;
            if (KPECKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KPEC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KPEC" /> fields for each CSV column header</returns>
        protected override Action<KPEC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KPEC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KPECKEY":
                        mapper[i] = (e, v) => e.KPECKEY = v;
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
