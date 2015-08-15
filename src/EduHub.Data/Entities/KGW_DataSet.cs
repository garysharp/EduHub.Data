using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Awards and Prizes Data Set
    /// </summary>
    public sealed class KGW_DataSet : SetBase<KGW_Entity>
    {
        private Lazy<Dictionary<string, KGW_Entity>> AWARD_Index;

        internal KGW_DataSet(EduHubContext Context)
            : base(Context)
        {
            AWARD_Index = new Lazy<Dictionary<string, KGW_Entity>>(() => this.ToDictionary(e => e.AWARD));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "KGW"; } }

        /// <summary>
        /// Find KGW by AWARD key field
        /// </summary>
        /// <param name="Key">AWARD value used to find KGW</param>
        /// <returns>Related KGW entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">AWARD value didn't match any KGW entities</exception>
        public KGW_Entity FindByAWARD(string Key)
        {
            KGW_Entity result;
            if (AWARD_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KGW by AWARD key field
        /// </summary>
        /// <param name="Key">AWARD value used to find KGW</param>
        /// <param name="Value">Related KGW entity</param>
        /// <returns>True if the KGW Entity is found</returns>
        public bool TryFindByAWARD(string Key, out KGW_Entity Value)
        {
            return AWARD_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KGW by AWARD key field
        /// </summary>
        /// <param name="Key">AWARD value used to find KGW</param>
        /// <returns>Related KGW entity, or null if not found</returns>
        public KGW_Entity TryFindByAWARD(string Key)
        {
            KGW_Entity result;
            if (AWARD_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KGW_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KGW_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "AWARD":
                        mapper[i] = (e, v) => e.AWARD = v;
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
