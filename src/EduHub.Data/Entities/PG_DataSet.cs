using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// PAYG Payment Summary Box Data Set
    /// </summary>
    public sealed class PG_DataSet : SetBase<PG_Entity>
    {
        internal PG_DataSet(EduHubContext Context)
            : base(Context)
        {
            PAYG_BOX_Index = new Lazy<Dictionary<short, PG_Entity>>(() => this.ToDictionary(e => e.PAYG_BOX));
        }

        public override string SetName { get { return "PG"; } }

        private Lazy<Dictionary<short, PG_Entity>> PAYG_BOX_Index;

        public PG_Entity FindByPAYG_BOX(short Key)
        {
            PG_Entity result;
            if (PAYG_BOX_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByPAYG_BOX(short Key, out PG_Entity Value)
        {
            return PAYG_BOX_Index.Value.TryGetValue(Key, out Value);
        }
        public PG_Entity TryFindByPAYG_BOX(short Key)
        {
            PG_Entity result;
            if (PAYG_BOX_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<PG_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<PG_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PAYG_BOX":
                        mapper[i] = (e, v) => e.PAYG_BOX = short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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
