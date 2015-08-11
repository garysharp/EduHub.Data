using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Year 9-12 Exit Destinations Data Set
    /// </summary>
    public sealed class KGD_DataSet : SetBase<KGD_Entity>
    {
        internal KGD_DataSet(EduHubContext Context)
            : base(Context)
        {
            KGDKEY_Index = new Lazy<Dictionary<string, KGD_Entity>>(() => this.ToDictionary(e => e.KGDKEY));
        }

        public override string SetName { get { return "KGD"; } }

        private Lazy<Dictionary<string, KGD_Entity>> KGDKEY_Index;

        public KGD_Entity FindByKGDKEY(string Key)
        {
            KGD_Entity result;
            if (KGDKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByKGDKEY(string Key, out KGD_Entity Value)
        {
            return KGDKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public KGD_Entity TryFindByKGDKEY(string Key)
        {
            KGD_Entity result;
            if (KGDKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KGD_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KGD_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGDKEY":
                        mapper[i] = (e, v) => e.KGDKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
                        break;
                    case "OPEN_CLOSED":
                        mapper[i] = (e, v) => e.OPEN_CLOSED = v;
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
