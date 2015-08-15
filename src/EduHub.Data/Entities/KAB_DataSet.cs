using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// BSB Numbers Data Set
    /// </summary>
    public sealed class KAB_DataSet : SetBase<KAB_Entity>
    {
        private Lazy<Dictionary<string, KAB_Entity>> BSB_Index;

        internal KAB_DataSet(EduHubContext Context)
            : base(Context)
        {
            BSB_Index = new Lazy<Dictionary<string, KAB_Entity>>(() => this.ToDictionary(e => e.BSB));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "KAB"; } }

        /// <summary>
        /// Find KAB by BSB key field
        /// </summary>
        /// <param name="Key">BSB value used to find KAB</param>
        /// <returns>Related KAB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">BSB value didn't match any KAB entities</exception>
        public KAB_Entity FindByBSB(string Key)
        {
            KAB_Entity result;
            if (BSB_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KAB by BSB key field
        /// </summary>
        /// <param name="Key">BSB value used to find KAB</param>
        /// <param name="Value">Related KAB entity</param>
        /// <returns>True if the KAB Entity is found</returns>
        public bool TryFindByBSB(string Key, out KAB_Entity Value)
        {
            return BSB_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KAB by BSB key field
        /// </summary>
        /// <param name="Key">BSB value used to find KAB</param>
        /// <returns>Related KAB entity, or null if not found</returns>
        public KAB_Entity TryFindByBSB(string Key)
        {
            KAB_Entity result;
            if (BSB_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KAB_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KAB_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "BSB":
                        mapper[i] = (e, v) => e.BSB = v;
                        break;
                    case "BANK":
                        mapper[i] = (e, v) => e.BANK = v;
                        break;
                    case "ADDRESS":
                        mapper[i] = (e, v) => e.ADDRESS = v;
                        break;
                    case "SUBURB":
                        mapper[i] = (e, v) => e.SUBURB = v;
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
