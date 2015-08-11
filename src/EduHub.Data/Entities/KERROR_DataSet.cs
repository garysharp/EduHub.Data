using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Import or Update Errors Data Set
    /// </summary>
    public sealed class KERROR_DataSet : SetBase<KERROR_Entity>
    {
        internal KERROR_DataSet(EduHubContext Context)
            : base(Context)
        {
            KERROR_ID_Index = new Lazy<Dictionary<int, KERROR_Entity>>(() => this.ToDictionary(e => e.KERROR_ID));
        }

        public override string SetName { get { return "KERROR"; } }

        private Lazy<Dictionary<int, KERROR_Entity>> KERROR_ID_Index;

        public KERROR_Entity FindByKERROR_ID(int Key)
        {
            KERROR_Entity result;
            if (KERROR_ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByKERROR_ID(int Key, out KERROR_Entity Value)
        {
            return KERROR_ID_Index.Value.TryGetValue(Key, out Value);
        }
        public KERROR_Entity TryFindByKERROR_ID(int Key)
        {
            KERROR_Entity result;
            if (KERROR_ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KERROR_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KERROR_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KERROR_ID":
                        mapper[i] = (e, v) => e.KERROR_ID = int.Parse(v);
                        break;
                    case "SOURCE":
                        mapper[i] = (e, v) => e.SOURCE = v;
                        break;
                    case "TEXT01":
                        mapper[i] = (e, v) => e.TEXT01 = v;
                        break;
                    case "TEXT02":
                        mapper[i] = (e, v) => e.TEXT02 = v;
                        break;
                    case "TEXT03":
                        mapper[i] = (e, v) => e.TEXT03 = v;
                        break;
                    case "TEXT04":
                        mapper[i] = (e, v) => e.TEXT04 = v;
                        break;
                    case "TEXT05":
                        mapper[i] = (e, v) => e.TEXT05 = v;
                        break;
                    case "TEXT06":
                        mapper[i] = (e, v) => e.TEXT06 = v;
                        break;
                    case "TEXT07":
                        mapper[i] = (e, v) => e.TEXT07 = v;
                        break;
                    case "TEXT08":
                        mapper[i] = (e, v) => e.TEXT08 = v;
                        break;
                    case "TEXT09":
                        mapper[i] = (e, v) => e.TEXT09 = v;
                        break;
                    case "VALIDATION":
                        mapper[i] = (e, v) => e.VALIDATION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PROCESSED":
                        mapper[i] = (e, v) => e.PROCESSED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "ERROR_TEXT":
                        mapper[i] = (e, v) => e.ERROR_TEXT = v;
                        break;
                    case "SPOUTKEY":
                        mapper[i] = (e, v) => e.SPOUTKEY = v;
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
