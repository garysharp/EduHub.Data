using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Release Types Data Set
    /// </summary>
    public sealed class AKR_DataSet : SetBase<AKR_Entity>
    {
        private Lazy<Dictionary<string, AKR_Entity>> AKRKEY_Index;

        internal AKR_DataSet(EduHubContext Context)
            : base(Context)
        {
            AKRKEY_Index = new Lazy<Dictionary<string, AKR_Entity>>(() => this.ToDictionary(e => e.AKRKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "AKR"; } }

        /// <summary>
        /// Find AKR by AKRKEY key field
        /// </summary>
        /// <param name="Key">AKRKEY value used to find AKR</param>
        /// <returns>Related AKR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">AKRKEY value didn't match any AKR entities</exception>
        public AKR_Entity FindByAKRKEY(string Key)
        {
            AKR_Entity result;
            if (AKRKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find AKR by AKRKEY key field
        /// </summary>
        /// <param name="Key">AKRKEY value used to find AKR</param>
        /// <param name="Value">Related AKR entity</param>
        /// <returns>True if the AKR Entity is found</returns>
        public bool TryFindByAKRKEY(string Key, out AKR_Entity Value)
        {
            return AKRKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find AKR by AKRKEY key field
        /// </summary>
        /// <param name="Key">AKRKEY value used to find AKR</param>
        /// <returns>Related AKR entity, or null if not found</returns>
        public AKR_Entity TryFindByAKRKEY(string Key)
        {
            AKR_Entity result;
            if (AKRKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<AKR_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<AKR_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "AKRKEY":
                        mapper[i] = (e, v) => e.AKRKEY = v;
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
