using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Account Types Data Set
    /// </summary>
    public sealed class KGLT_DataSet : SetBase<KGLT_Entity>
    {
        internal KGLT_DataSet(EduHubContext Context)
            : base(Context)
        {
            GL_TYPE_Index = new Lazy<Dictionary<string, KGLT_Entity>>(() => this.ToDictionary(e => e.GL_TYPE));
        }

        public override string SetName { get { return "KGLT"; } }

        private Lazy<Dictionary<string, KGLT_Entity>> GL_TYPE_Index;

        public KGLT_Entity FindByGL_TYPE(string Key)
        {
            KGLT_Entity result;
            if (GL_TYPE_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByGL_TYPE(string Key, out KGLT_Entity Value)
        {
            return GL_TYPE_Index.Value.TryGetValue(Key, out Value);
        }
        public KGLT_Entity TryFindByGL_TYPE(string Key)
        {
            KGLT_Entity result;
            if (GL_TYPE_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KGLT_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KGLT_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "GL_TYPE":
                        mapper[i] = (e, v) => e.GL_TYPE = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
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
