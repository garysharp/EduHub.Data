using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Import Errors Data Set
    /// </summary>
    public sealed class KTIE_DataSet : SetBase<KTIE_Entity>
    {
        internal KTIE_DataSet(EduHubContext Context)
            : base(Context)
        {
            RECORD_ID_Index = new Lazy<Dictionary<int, KTIE_Entity>>(() => this.ToDictionary(e => e.RECORD_ID));
        }

        public override string SetName { get { return "KTIE"; } }

        private Lazy<Dictionary<int, KTIE_Entity>> RECORD_ID_Index;

        public KTIE_Entity FindByRECORD_ID(int Key)
        {
            KTIE_Entity result;
            if (RECORD_ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByRECORD_ID(int Key, out KTIE_Entity Value)
        {
            return RECORD_ID_Index.Value.TryGetValue(Key, out Value);
        }
        public KTIE_Entity TryFindByRECORD_ID(int Key)
        {
            KTIE_Entity result;
            if (RECORD_ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KTIE_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KTIE_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "RECORD_ID":
                        mapper[i] = (e, v) => e.RECORD_ID = int.Parse(v);
                        break;
                    case "ENTITY":
                        mapper[i] = (e, v) => e.ENTITY = v;
                        break;
                    case "ENTITY_KEY":
                        mapper[i] = (e, v) => e.ENTITY_KEY = v;
                        break;
                    case "ERROR_TEXT":
                        mapper[i] = (e, v) => e.ERROR_TEXT = v;
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
