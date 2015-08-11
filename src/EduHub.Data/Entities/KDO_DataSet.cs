using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// VELS Domains Data Set
    /// </summary>
    public sealed class KDO_DataSet : SetBase<KDO_Entity>
    {
        internal KDO_DataSet(EduHubContext Context)
            : base(Context)
        {
            KDOKEY_Index = new Lazy<Dictionary<string, KDO_Entity>>(() => this.ToDictionary(e => e.KDOKEY));
        }

        public override string SetName { get { return "KDO"; } }

        private Lazy<Dictionary<string, KDO_Entity>> KDOKEY_Index;

        public KDO_Entity FindByKDOKEY(string Key)
        {
            KDO_Entity result;
            if (KDOKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByKDOKEY(string Key, out KDO_Entity Value)
        {
            return KDOKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public KDO_Entity TryFindByKDOKEY(string Key)
        {
            KDO_Entity result;
            if (KDOKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KDO_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KDO_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KDOKEY":
                        mapper[i] = (e, v) => e.KDOKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "AUSVELS_START":
                        mapper[i] = (e, v) => e.AUSVELS_START = v;
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
