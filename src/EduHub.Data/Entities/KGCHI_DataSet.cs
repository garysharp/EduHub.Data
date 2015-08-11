using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Group History Data Set
    /// </summary>
    public sealed class KGCHI_DataSet : SetBase<KGCHI_Entity>
    {
        internal KGCHI_DataSet(EduHubContext Context)
            : base(Context)
        {
            KGCHIKEY_Index = new Lazy<Dictionary<int, KGCHI_Entity>>(() => this.ToDictionary(e => e.KGCHIKEY));
        }

        public override string SetName { get { return "KGCHI"; } }

        private Lazy<Dictionary<int, KGCHI_Entity>> KGCHIKEY_Index;

        public KGCHI_Entity FindByKGCHIKEY(int Key)
        {
            KGCHI_Entity result;
            if (KGCHIKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByKGCHIKEY(int Key, out KGCHI_Entity Value)
        {
            return KGCHIKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public KGCHI_Entity TryFindByKGCHIKEY(int Key)
        {
            KGCHI_Entity result;
            if (KGCHIKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KGCHI_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KGCHI_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGCHIKEY":
                        mapper[i] = (e, v) => e.KGCHIKEY = int.Parse(v);
                        break;
                    case "KGCKEY":
                        mapper[i] = (e, v) => e.KGCKEY = v;
                        break;
                    case "CREATION_USER":
                        mapper[i] = (e, v) => e.CREATION_USER = v;
                        break;
                    case "CREATION_DATE":
                        mapper[i] = (e, v) => e.CREATION_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CREATION_TIME":
                        mapper[i] = (e, v) => e.CREATION_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OBSOLETE_USER":
                        mapper[i] = (e, v) => e.OBSOLETE_USER = v;
                        break;
                    case "OBSOLETE_DATE":
                        mapper[i] = (e, v) => e.OBSOLETE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "OBSOLETE_TIME":
                        mapper[i] = (e, v) => e.OBSOLETE_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v;
                        break;
                    case "TEACHER":
                        mapper[i] = (e, v) => e.TEACHER = v;
                        break;
                    case "TEACHER_B":
                        mapper[i] = (e, v) => e.TEACHER_B = v;
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "CHANGE_MADE":
                        mapper[i] = (e, v) => e.CHANGE_MADE = v;
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
