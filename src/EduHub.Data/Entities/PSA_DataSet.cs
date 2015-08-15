using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Award Details Data Set
    /// </summary>
    public sealed class PSA_DataSet : SetBase<PSA_Entity>
    {
        private Lazy<Dictionary<string, PSA_Entity>> PSAKEY_Index;

        internal PSA_DataSet(EduHubContext Context)
            : base(Context)
        {
            PSAKEY_Index = new Lazy<Dictionary<string, PSA_Entity>>(() => this.ToDictionary(e => e.PSAKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "PSA"; } }

        /// <summary>
        /// Find PSA by PSAKEY key field
        /// </summary>
        /// <param name="Key">PSAKEY value used to find PSA</param>
        /// <returns>Related PSA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">PSAKEY value didn't match any PSA entities</exception>
        public PSA_Entity FindByPSAKEY(string Key)
        {
            PSA_Entity result;
            if (PSAKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find PSA by PSAKEY key field
        /// </summary>
        /// <param name="Key">PSAKEY value used to find PSA</param>
        /// <param name="Value">Related PSA entity</param>
        /// <returns>True if the PSA Entity is found</returns>
        public bool TryFindByPSAKEY(string Key, out PSA_Entity Value)
        {
            return PSAKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find PSA by PSAKEY key field
        /// </summary>
        /// <param name="Key">PSAKEY value used to find PSA</param>
        /// <returns>Related PSA entity, or null if not found</returns>
        public PSA_Entity TryFindByPSAKEY(string Key)
        {
            PSA_Entity result;
            if (PSAKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<PSA_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<PSA_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PSAKEY":
                        mapper[i] = (e, v) => e.PSAKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "AWARD_TYPE":
                        mapper[i] = (e, v) => e.AWARD_TYPE = v;
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
