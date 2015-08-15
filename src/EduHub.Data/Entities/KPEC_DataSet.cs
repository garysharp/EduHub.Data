using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee Categories Data Set
    /// </summary>
    public sealed class KPEC_DataSet : SetBase<KPEC_Entity>
    {
        private Lazy<Dictionary<string, KPEC_Entity>> KPECKEY_Index;

        internal KPEC_DataSet(EduHubContext Context)
            : base(Context)
        {
            KPECKEY_Index = new Lazy<Dictionary<string, KPEC_Entity>>(() => this.ToDictionary(e => e.KPECKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "KPEC"; } }

        /// <summary>
        /// Find KPEC by KPECKEY key field
        /// </summary>
        /// <param name="Key">KPECKEY value used to find KPEC</param>
        /// <returns>Related KPEC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KPECKEY value didn't match any KPEC entities</exception>
        public KPEC_Entity FindByKPECKEY(string Key)
        {
            KPEC_Entity result;
            if (KPECKEY_Index.Value.TryGetValue(Key, out result))
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
        /// <returns>True if the KPEC Entity is found</returns>
        public bool TryFindByKPECKEY(string Key, out KPEC_Entity Value)
        {
            return KPECKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KPEC by KPECKEY key field
        /// </summary>
        /// <param name="Key">KPECKEY value used to find KPEC</param>
        /// <returns>Related KPEC entity, or null if not found</returns>
        public KPEC_Entity TryFindByKPECKEY(string Key)
        {
            KPEC_Entity result;
            if (KPECKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KPEC_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KPEC_Entity, string>[Headers.Count];

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
