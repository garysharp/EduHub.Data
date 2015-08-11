using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Types Data Set
    /// </summary>
    public sealed class AKT_DataSet : SetBase<AKT_Entity>
    {
        internal AKT_DataSet(EduHubContext Context)
            : base(Context)
        {
            AKTKEY_Index = new Lazy<Dictionary<string, AKT_Entity>>(() => this.ToDictionary(e => e.AKTKEY));
        }

        public override string SetName { get { return "AKT"; } }

        private Lazy<Dictionary<string, AKT_Entity>> AKTKEY_Index;

        public AKT_Entity FindByAKTKEY(string Key)
        {
            AKT_Entity result;
            if (AKTKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByAKTKEY(string Key, out AKT_Entity Value)
        {
            return AKTKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public AKT_Entity TryFindByAKTKEY(string Key)
        {
            AKT_Entity result;
            if (AKTKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<AKT_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<AKT_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "AKTKEY":
                        mapper[i] = (e, v) => e.AKTKEY = v;
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
