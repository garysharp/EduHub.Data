using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Depreciation Methods Data Set
    /// </summary>
    public sealed class KADM_DataSet : SetBase<KADM_Entity>
    {
        internal KADM_DataSet(EduHubContext Context)
            : base(Context)
        {
            KADMKEY_Index = new Lazy<Dictionary<string, KADM_Entity>>(() => this.ToDictionary(e => e.KADMKEY));
        }

        public override string SetName { get { return "KADM"; } }

        private Lazy<Dictionary<string, KADM_Entity>> KADMKEY_Index;

        public KADM_Entity FindByKADMKEY(string Key)
        {
            KADM_Entity result;
            if (KADMKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByKADMKEY(string Key, out KADM_Entity Value)
        {
            return KADMKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public KADM_Entity TryFindByKADMKEY(string Key)
        {
            KADM_Entity result;
            if (KADMKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KADM_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KADM_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KADMKEY":
                        mapper[i] = (e, v) => e.KADMKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "DETAIL":
                        mapper[i] = (e, v) => e.DETAIL = v;
                        break;
                    case "DATE_BASED":
                        mapper[i] = (e, v) => e.DATE_BASED = v;
                        break;
                    case "TAX":
                        mapper[i] = (e, v) => e.TAX = v;
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
