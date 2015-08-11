using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// BSB Numbers Data Set
    /// </summary>
    public sealed class KAB_DataSet : SetBase<KAB_Entity>
    {
        internal KAB_DataSet(EduHubContext Context)
            : base(Context)
        {
            BSB_Index = new Lazy<Dictionary<string, KAB_Entity>>(() => this.ToDictionary(e => e.BSB));
        }

        public override string SetName { get { return "KAB"; } }

        private Lazy<Dictionary<string, KAB_Entity>> BSB_Index;

        public KAB_Entity FindByBSB(string Key)
        {
            KAB_Entity result;
            if (BSB_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByBSB(string Key, out KAB_Entity Value)
        {
            return BSB_Index.Value.TryGetValue(Key, out Value);
        }
        public KAB_Entity TryFindByBSB(string Key)
        {
            KAB_Entity result;
            if (BSB_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KAB_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KAB_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "BSB":
                        mapper[i] = (e, v) => e.BSB = v;
                        break;
                    case "BANK":
                        mapper[i] = (e, v) => e.BANK = v;
                        break;
                    case "ADDRESS":
                        mapper[i] = (e, v) => e.ADDRESS = v;
                        break;
                    case "SUBURB":
                        mapper[i] = (e, v) => e.SUBURB = v;
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
