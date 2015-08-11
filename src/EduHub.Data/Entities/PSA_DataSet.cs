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
        internal PSA_DataSet(EduHubContext Context)
            : base(Context)
        {
            PSAKEY_Index = new Lazy<Dictionary<string, PSA_Entity>>(() => this.ToDictionary(e => e.PSAKEY));
        }

        public override string SetName { get { return "PSA"; } }

        private Lazy<Dictionary<string, PSA_Entity>> PSAKEY_Index;

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
        public bool TryFindByPSAKEY(string Key, out PSA_Entity Value)
        {
            return PSAKEY_Index.Value.TryGetValue(Key, out Value);
        }
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
