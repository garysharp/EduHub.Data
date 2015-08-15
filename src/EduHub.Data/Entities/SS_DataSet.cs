using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Specialist Subjects Data Set
    /// </summary>
    public sealed class SS_DataSet : SetBase<SS_Entity>
    {
        private Lazy<Dictionary<string, SS_Entity>> SSKEY_Index;

        internal SS_DataSet(EduHubContext Context)
            : base(Context)
        {
            SSKEY_Index = new Lazy<Dictionary<string, SS_Entity>>(() => this.ToDictionary(e => e.SSKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SS"; } }

        /// <summary>
        /// Find SS by SSKEY key field
        /// </summary>
        /// <param name="Key">SSKEY value used to find SS</param>
        /// <returns>Related SS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SSKEY value didn't match any SS entities</exception>
        public SS_Entity FindBySSKEY(string Key)
        {
            SS_Entity result;
            if (SSKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SS by SSKEY key field
        /// </summary>
        /// <param name="Key">SSKEY value used to find SS</param>
        /// <param name="Value">Related SS entity</param>
        /// <returns>True if the SS Entity is found</returns>
        public bool TryFindBySSKEY(string Key, out SS_Entity Value)
        {
            return SSKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SS by SSKEY key field
        /// </summary>
        /// <param name="Key">SSKEY value used to find SS</param>
        /// <returns>Related SS entity, or null if not found</returns>
        public SS_Entity TryFindBySSKEY(string Key)
        {
            SS_Entity result;
            if (SSKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SS_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SS_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SSKEY":
                        mapper[i] = (e, v) => e.SSKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "FROM_HOMEGROUP":
                        mapper[i] = (e, v) => e.FROM_HOMEGROUP = v;
                        break;
                    case "TO_HOMEGROUP":
                        mapper[i] = (e, v) => e.TO_HOMEGROUP = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "DEFAULT_TEACHER":
                        mapper[i] = (e, v) => e.DEFAULT_TEACHER = v;
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
