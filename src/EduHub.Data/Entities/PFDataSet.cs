using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Superannuation Funds Data Set
    /// </summary>
    public sealed class PFDataSet : SetBase<PF>
    {
        private Lazy<Dictionary<string, PF>> PFKEYIndex;

        internal PFDataSet(EduHubContext Context)
            : base(Context)
        {
            PFKEYIndex = new Lazy<Dictionary<string, PF>>(() => this.ToDictionary(e => e.PFKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PF"; } }

        /// <summary>
        /// Find PF by PFKEY key field
        /// </summary>
        /// <param name="Key">PFKEY value used to find PF</param>
        /// <returns>Related PF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">PFKEY value didn't match any PF entities</exception>
        public PF FindByPFKEY(string Key)
        {
            PF result;
            if (PFKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find PF by PFKEY key field
        /// </summary>
        /// <param name="Key">PFKEY value used to find PF</param>
        /// <param name="Value">Related PF entity</param>
        /// <returns>True if the PF Entity is found</returns>
        public bool TryFindByPFKEY(string Key, out PF Value)
        {
            return PFKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find PF by PFKEY key field
        /// </summary>
        /// <param name="Key">PFKEY value used to find PF</param>
        /// <returns>Related PF entity, or null if not found</returns>
        public PF TryFindByPFKEY(string Key)
        {
            PF result;
            if (PFKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<PF, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<PF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PFKEY":
                        mapper[i] = (e, v) => e.PFKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "CREATE_EXPORT_FILE":
                        mapper[i] = (e, v) => e.CREATE_EXPORT_FILE = v;
                        break;
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
                        break;
                    case "USI":
                        mapper[i] = (e, v) => e.USI = v;
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
