using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Cost Centres Data Set
    /// </summary>
    public sealed class PC_DataSet : SetBase<PC_Entity>
    {
        internal PC_DataSet(EduHubContext Context)
            : base(Context)
        {
            PCKEY_Index = new Lazy<Dictionary<string, PC_Entity>>(() => this.ToDictionary(e => e.PCKEY));
        }

        public override string SetName { get { return "PC"; } }

        private Lazy<Dictionary<string, PC_Entity>> PCKEY_Index;

        public PC_Entity FindByPCKEY(string Key)
        {
            PC_Entity result;
            if (PCKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByPCKEY(string Key, out PC_Entity Value)
        {
            return PCKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public PC_Entity TryFindByPCKEY(string Key)
        {
            PC_Entity result;
            if (PCKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<PC_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<PC_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PCKEY":
                        mapper[i] = (e, v) => e.PCKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "SUBPROGRAM":
                        mapper[i] = (e, v) => e.SUBPROGRAM = v;
                        break;
                    case "GLPROGRAM":
                        mapper[i] = (e, v) => e.GLPROGRAM = v;
                        break;
                    case "INITIATIVE":
                        mapper[i] = (e, v) => e.INITIATIVE = v;
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
