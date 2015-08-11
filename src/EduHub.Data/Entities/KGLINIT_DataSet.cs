using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Initiatives Data Set
    /// </summary>
    public sealed class KGLINIT_DataSet : SetBase<KGLINIT_Entity>
    {
        internal KGLINIT_DataSet(EduHubContext Context)
            : base(Context)
        {
            INITIATIVE_Index = new Lazy<Dictionary<string, KGLINIT_Entity>>(() => this.ToDictionary(e => e.INITIATIVE));
        }

        public override string SetName { get { return "KGLINIT"; } }

        private Lazy<Dictionary<string, KGLINIT_Entity>> INITIATIVE_Index;

        public KGLINIT_Entity FindByINITIATIVE(string Key)
        {
            KGLINIT_Entity result;
            if (INITIATIVE_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByINITIATIVE(string Key, out KGLINIT_Entity Value)
        {
            return INITIATIVE_Index.Value.TryGetValue(Key, out Value);
        }
        public KGLINIT_Entity TryFindByINITIATIVE(string Key)
        {
            KGLINIT_Entity result;
            if (INITIATIVE_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KGLINIT_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KGLINIT_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "INITIATIVE":
                        mapper[i] = (e, v) => e.INITIATIVE = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
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
