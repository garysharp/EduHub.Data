using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Decrypted data IMPORT Data Set
    /// </summary>
    public sealed class A_DECRYP_DataSet : SetBase<A_DECRYP_Entity>
    {
        internal A_DECRYP_DataSet(EduHubContext Context)
            : base(Context)
        {
            TID_Index = new Lazy<Dictionary<int, A_DECRYP_Entity>>(() => this.ToDictionary(e => e.TID));
        }

        public override string SetName { get { return "A_DECRYP"; } }

        private Lazy<Dictionary<int, A_DECRYP_Entity>> TID_Index;

        public A_DECRYP_Entity FindByTID(int Key)
        {
            A_DECRYP_Entity result;
            if (TID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByTID(int Key, out A_DECRYP_Entity Value)
        {
            return TID_Index.Value.TryGetValue(Key, out Value);
        }
        public A_DECRYP_Entity TryFindByTID(int Key)
        {
            A_DECRYP_Entity result;
            if (TID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<A_DECRYP_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<A_DECRYP_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "LINE_TYPE":
                        mapper[i] = (e, v) => e.LINE_TYPE = v;
                        break;
                    case "RECORD":
                        mapper[i] = (e, v) => e.RECORD = v;
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
