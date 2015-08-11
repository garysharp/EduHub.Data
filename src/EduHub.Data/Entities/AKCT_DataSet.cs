using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Categories Tax Data Set
    /// </summary>
    public sealed class AKCT_DataSet : SetBase<AKCT_Entity>
    {
        internal AKCT_DataSet(EduHubContext Context)
            : base(Context)
        {
            CATEGORY_Index = new Lazy<Dictionary<string, AKCT_Entity>>(() => this.ToDictionary(e => e.CATEGORY));
        }

        public override string SetName { get { return "AKCT"; } }

        private Lazy<Dictionary<string, AKCT_Entity>> CATEGORY_Index;

        public AKCT_Entity FindByCATEGORY(string Key)
        {
            AKCT_Entity result;
            if (CATEGORY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByCATEGORY(string Key, out AKCT_Entity Value)
        {
            return CATEGORY_Index.Value.TryGetValue(Key, out Value);
        }
        public AKCT_Entity TryFindByCATEGORY(string Key)
        {
            AKCT_Entity result;
            if (CATEGORY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<AKCT_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<AKCT_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "DEPN_TMETHOD":
                        mapper[i] = (e, v) => e.DEPN_TMETHOD = v;
                        break;
                    case "DEPN_TRATE":
                        mapper[i] = (e, v) => e.DEPN_TRATE = v == null ? (double?)null : double.Parse(v);
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
