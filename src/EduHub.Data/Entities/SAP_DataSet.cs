using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Association Positions Data Set
    /// </summary>
    public sealed class SAP_DataSet : SetBase<SAP_Entity>
    {
        internal SAP_DataSet(EduHubContext Context)
            : base(Context)
        {
            SAPKEY_Index = new Lazy<Dictionary<string, SAP_Entity>>(() => this.ToDictionary(e => e.SAPKEY));
        }

        public override string SetName { get { return "SAP"; } }

        private Lazy<Dictionary<string, SAP_Entity>> SAPKEY_Index;

        public SAP_Entity FindBySAPKEY(string Key)
        {
            SAP_Entity result;
            if (SAPKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindBySAPKEY(string Key, out SAP_Entity Value)
        {
            return SAPKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public SAP_Entity TryFindBySAPKEY(string Key)
        {
            SAP_Entity result;
            if (SAPKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<SAP_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SAP_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SAPKEY":
                        mapper[i] = (e, v) => e.SAPKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "SORT_CODE":
                        mapper[i] = (e, v) => e.SORT_CODE = v == null ? (short?)null : short.Parse(v);
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
