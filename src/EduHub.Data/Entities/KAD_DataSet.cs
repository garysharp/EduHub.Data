using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Delivery Addresses Data Set
    /// </summary>
    public sealed class KAD_DataSet : SetBase<KAD_Entity>
    {
        private Lazy<Dictionary<string, KAD_Entity>> KADKEY_Index;

        internal KAD_DataSet(EduHubContext Context)
            : base(Context)
        {
            KADKEY_Index = new Lazy<Dictionary<string, KAD_Entity>>(() => this.ToDictionary(e => e.KADKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "KAD"; } }

        /// <summary>
        /// Find KAD by KADKEY key field
        /// </summary>
        /// <param name="Key">KADKEY value used to find KAD</param>
        /// <returns>Related KAD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KADKEY value didn't match any KAD entities</exception>
        public KAD_Entity FindByKADKEY(string Key)
        {
            KAD_Entity result;
            if (KADKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KAD by KADKEY key field
        /// </summary>
        /// <param name="Key">KADKEY value used to find KAD</param>
        /// <param name="Value">Related KAD entity</param>
        /// <returns>True if the KAD Entity is found</returns>
        public bool TryFindByKADKEY(string Key, out KAD_Entity Value)
        {
            return KADKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KAD by KADKEY key field
        /// </summary>
        /// <param name="Key">KADKEY value used to find KAD</param>
        /// <returns>Related KAD entity, or null if not found</returns>
        public KAD_Entity TryFindByKADKEY(string Key)
        {
            KAD_Entity result;
            if (KADKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KAD_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KAD_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KADKEY":
                        mapper[i] = (e, v) => e.KADKEY = v;
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "ADDRESS03":
                        mapper[i] = (e, v) => e.ADDRESS03 = v;
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
