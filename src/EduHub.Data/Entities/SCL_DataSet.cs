using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject Classes Data Set
    /// </summary>
    public sealed class SCL_DataSet : SetBase<SCL_Entity>
    {
        internal SCL_DataSet(EduHubContext Context)
            : base(Context)
        {
            SCLKEY_Index = new Lazy<Dictionary<string, SCL_Entity>>(() => this.ToDictionary(e => e.SCLKEY));
        }

        public override string SetName { get { return "SCL"; } }

        private Lazy<Dictionary<string, SCL_Entity>> SCLKEY_Index;

        public SCL_Entity FindBySCLKEY(string Key)
        {
            SCL_Entity result;
            if (SCLKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindBySCLKEY(string Key, out SCL_Entity Value)
        {
            return SCLKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public SCL_Entity TryFindBySCLKEY(string Key)
        {
            SCL_Entity result;
            if (SCLKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<SCL_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SCL_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCLKEY":
                        mapper[i] = (e, v) => e.SCLKEY = v;
                        break;
                    case "QUILT":
                        mapper[i] = (e, v) => e.QUILT = v;
                        break;
                    case "SUBJECT":
                        mapper[i] = (e, v) => e.SUBJECT = v;
                        break;
                    case "CLASS":
                        mapper[i] = (e, v) => e.CLASS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHER01":
                        mapper[i] = (e, v) => e.TEACHER01 = v;
                        break;
                    case "TEACHER02":
                        mapper[i] = (e, v) => e.TEACHER02 = v;
                        break;
                    case "ROOM01":
                        mapper[i] = (e, v) => e.ROOM01 = v;
                        break;
                    case "ROOM02":
                        mapper[i] = (e, v) => e.ROOM02 = v;
                        break;
                    case "FREQUENCY":
                        mapper[i] = (e, v) => e.FREQUENCY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PRINT_FLAGS01":
                        mapper[i] = (e, v) => e.PRINT_FLAGS01 = v;
                        break;
                    case "PRINT_FLAGS02":
                        mapper[i] = (e, v) => e.PRINT_FLAGS02 = v;
                        break;
                    case "PRINT_FLAGS03":
                        mapper[i] = (e, v) => e.PRINT_FLAGS03 = v;
                        break;
                    case "PERIOD_ABSENCES":
                        mapper[i] = (e, v) => e.PERIOD_ABSENCES = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ALIAS":
                        mapper[i] = (e, v) => e.ALIAS = v;
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
