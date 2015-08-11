using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Fuel Tax Credit Rates Data Set
    /// </summary>
    public sealed class KFTC_DataSet : SetBase<KFTC_Entity>
    {
        internal KFTC_DataSet(EduHubContext Context)
            : base(Context)
        {
            KFTCKEY_Index = new Lazy<Dictionary<string, KFTC_Entity>>(() => this.ToDictionary(e => e.KFTCKEY));
        }

        public override string SetName { get { return "KFTC"; } }

        private Lazy<Dictionary<string, KFTC_Entity>> KFTCKEY_Index;

        public KFTC_Entity FindByKFTCKEY(string Key)
        {
            KFTC_Entity result;
            if (KFTCKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByKFTCKEY(string Key, out KFTC_Entity Value)
        {
            return KFTCKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public KFTC_Entity TryFindByKFTCKEY(string Key)
        {
            KFTC_Entity result;
            if (KFTCKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KFTC_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KFTC_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KFTCKEY":
                        mapper[i] = (e, v) => e.KFTCKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "FTC_RATE":
                        mapper[i] = (e, v) => e.FTC_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "GL_CODE":
                        mapper[i] = (e, v) => e.GL_CODE = v;
                        break;
                    case "SUBPROGRAM":
                        mapper[i] = (e, v) => e.SUBPROGRAM = v;
                        break;
                    case "GLPROGRAM":
                        mapper[i] = (e, v) => e.GLPROGRAM = v;
                        break;
                    case "INITIATIVE":
                        mapper[i] = (e, v) => e.INITIATIVE = v;
                        break;
                    case "INACTIVE":
                        mapper[i] = (e, v) => e.INACTIVE = v;
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
