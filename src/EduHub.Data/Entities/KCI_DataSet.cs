using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Religious Instruction Curricula Data Set
    /// </summary>
    public sealed class KCI_DataSet : SetBase<KCI_Entity>
    {
        private Lazy<Dictionary<string, KCI_Entity>> KCIKEY_Index;

        internal KCI_DataSet(EduHubContext Context)
            : base(Context)
        {
            KCIKEY_Index = new Lazy<Dictionary<string, KCI_Entity>>(() => this.ToDictionary(e => e.KCIKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "KCI"; } }

        /// <summary>
        /// Find KCI by KCIKEY key field
        /// </summary>
        /// <param name="Key">KCIKEY value used to find KCI</param>
        /// <returns>Related KCI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KCIKEY value didn't match any KCI entities</exception>
        public KCI_Entity FindByKCIKEY(string Key)
        {
            KCI_Entity result;
            if (KCIKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KCI by KCIKEY key field
        /// </summary>
        /// <param name="Key">KCIKEY value used to find KCI</param>
        /// <param name="Value">Related KCI entity</param>
        /// <returns>True if the KCI Entity is found</returns>
        public bool TryFindByKCIKEY(string Key, out KCI_Entity Value)
        {
            return KCIKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KCI by KCIKEY key field
        /// </summary>
        /// <param name="Key">KCIKEY value used to find KCI</param>
        /// <returns>Related KCI entity, or null if not found</returns>
        public KCI_Entity TryFindByKCIKEY(string Key)
        {
            KCI_Entity result;
            if (KCIKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KCI_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KCI_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCIKEY":
                        mapper[i] = (e, v) => e.KCIKEY = v;
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
