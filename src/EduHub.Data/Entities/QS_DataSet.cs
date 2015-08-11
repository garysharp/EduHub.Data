using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Stored SQL Data Set
    /// </summary>
    public sealed class QS_DataSet : SetBase<QS_Entity>
    {
        internal QS_DataSet(EduHubContext Context)
            : base(Context)
        {
            QSKEY_Index = new Lazy<Dictionary<string, QS_Entity>>(() => this.ToDictionary(e => e.QSKEY));
        }

        public override string SetName { get { return "QS"; } }

        private Lazy<Dictionary<string, QS_Entity>> QSKEY_Index;

        public QS_Entity FindByQSKEY(string Key)
        {
            QS_Entity result;
            if (QSKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByQSKEY(string Key, out QS_Entity Value)
        {
            return QSKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public QS_Entity TryFindByQSKEY(string Key)
        {
            QS_Entity result;
            if (QSKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<QS_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<QS_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "QSKEY":
                        mapper[i] = (e, v) => e.QSKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "SQLTEXT":
                        mapper[i] = (e, v) => e.SQLTEXT = v;
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
