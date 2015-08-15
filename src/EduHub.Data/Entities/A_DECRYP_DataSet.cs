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
        private Lazy<Dictionary<int, A_DECRYP_Entity>> TID_Index;

        internal A_DECRYP_DataSet(EduHubContext Context)
            : base(Context)
        {
            TID_Index = new Lazy<Dictionary<int, A_DECRYP_Entity>>(() => this.ToDictionary(e => e.TID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "A_DECRYP"; } }

        /// <summary>
        /// Find A_DECRYP by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find A_DECRYP</param>
        /// <returns>Related A_DECRYP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TID value didn't match any A_DECRYP entities</exception>
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

        /// <summary>
        /// Attempt to find A_DECRYP by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find A_DECRYP</param>
        /// <param name="Value">Related A_DECRYP entity</param>
        /// <returns>True if the A_DECRYP Entity is found</returns>
        public bool TryFindByTID(int Key, out A_DECRYP_Entity Value)
        {
            return TID_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find A_DECRYP by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find A_DECRYP</param>
        /// <returns>Related A_DECRYP entity, or null if not found</returns>
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
