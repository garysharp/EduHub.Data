using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Sundry Debtor Fee Groups Data Set
    /// </summary>
    public sealed class SDG_DataSet : SetBase<SDG_Entity>
    {
        private Lazy<Dictionary<string, SDG_Entity>> SDGKEY_Index;

        internal SDG_DataSet(EduHubContext Context)
            : base(Context)
        {
            SDGKEY_Index = new Lazy<Dictionary<string, SDG_Entity>>(() => this.ToDictionary(e => e.SDGKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SDG"; } }

        /// <summary>
        /// Find SDG by SDGKEY key field
        /// </summary>
        /// <param name="Key">SDGKEY value used to find SDG</param>
        /// <returns>Related SDG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SDGKEY value didn't match any SDG entities</exception>
        public SDG_Entity FindBySDGKEY(string Key)
        {
            SDG_Entity result;
            if (SDGKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SDG by SDGKEY key field
        /// </summary>
        /// <param name="Key">SDGKEY value used to find SDG</param>
        /// <param name="Value">Related SDG entity</param>
        /// <returns>True if the SDG Entity is found</returns>
        public bool TryFindBySDGKEY(string Key, out SDG_Entity Value)
        {
            return SDGKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SDG by SDGKEY key field
        /// </summary>
        /// <param name="Key">SDGKEY value used to find SDG</param>
        /// <returns>Related SDG entity, or null if not found</returns>
        public SDG_Entity TryFindBySDGKEY(string Key)
        {
            SDG_Entity result;
            if (SDGKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SDG_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SDG_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SDGKEY":
                        mapper[i] = (e, v) => e.SDGKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "MEMBER_TYPE":
                        mapper[i] = (e, v) => e.MEMBER_TYPE = v;
                        break;
                    case "SDG_MEMO":
                        mapper[i] = (e, v) => e.SDG_MEMO = v;
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
