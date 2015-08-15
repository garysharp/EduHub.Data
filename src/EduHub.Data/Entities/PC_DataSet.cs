using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Cost Centres Data Set
    /// </summary>
    public sealed class PC_DataSet : SetBase<PC_Entity>
    {
        private Lazy<Dictionary<string, PC_Entity>> PCKEY_Index;

        internal PC_DataSet(EduHubContext Context)
            : base(Context)
        {
            PCKEY_Index = new Lazy<Dictionary<string, PC_Entity>>(() => this.ToDictionary(e => e.PCKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "PC"; } }

        /// <summary>
        /// Find PC by PCKEY key field
        /// </summary>
        /// <param name="Key">PCKEY value used to find PC</param>
        /// <returns>Related PC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">PCKEY value didn't match any PC entities</exception>
        public PC_Entity FindByPCKEY(string Key)
        {
            PC_Entity result;
            if (PCKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find PC by PCKEY key field
        /// </summary>
        /// <param name="Key">PCKEY value used to find PC</param>
        /// <param name="Value">Related PC entity</param>
        /// <returns>True if the PC Entity is found</returns>
        public bool TryFindByPCKEY(string Key, out PC_Entity Value)
        {
            return PCKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find PC by PCKEY key field
        /// </summary>
        /// <param name="Key">PCKEY value used to find PC</param>
        /// <returns>Related PC entity, or null if not found</returns>
        public PC_Entity TryFindByPCKEY(string Key)
        {
            PC_Entity result;
            if (PCKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<PC_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<PC_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PCKEY":
                        mapper[i] = (e, v) => e.PCKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "SUBPROGRAM":
                        mapper[i] = (e, v) => e.SUBPROGRAM = v;
                        break;
                    case "GLPROGRAM":
                        mapper[i] = (e, v) => e.GLPROGRAM = v;
                        break;
                    case "INITIATIVE":
                        mapper[i] = (e, v) => e.INITIATIVE = v;
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
