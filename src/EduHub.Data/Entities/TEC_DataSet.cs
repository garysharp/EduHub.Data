using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Event Categories Data Set
    /// </summary>
    public sealed class TEC_DataSet : SetBase<TEC_Entity>
    {
        internal TEC_DataSet(EduHubContext Context)
            : base(Context)
        {
            CATEGORY_Index = new Lazy<Dictionary<string, TEC_Entity>>(() => this.ToDictionary(e => e.CATEGORY));
        }

        public override string SetName { get { return "TEC"; } }

        private Lazy<Dictionary<string, TEC_Entity>> CATEGORY_Index;

        public TEC_Entity FindByCATEGORY(string Key)
        {
            TEC_Entity result;
            if (CATEGORY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByCATEGORY(string Key, out TEC_Entity Value)
        {
            return CATEGORY_Index.Value.TryGetValue(Key, out Value);
        }
        public TEC_Entity TryFindByCATEGORY(string Key)
        {
            TEC_Entity result;
            if (CATEGORY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<TEC_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<TEC_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
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
