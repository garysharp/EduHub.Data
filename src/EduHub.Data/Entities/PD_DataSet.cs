using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Departments Data Set
    /// </summary>
    public sealed class PD_DataSet : SetBase<PD_Entity>
    {
        private Lazy<Dictionary<string, PD_Entity>> PDKEY_Index;

        internal PD_DataSet(EduHubContext Context)
            : base(Context)
        {
            PDKEY_Index = new Lazy<Dictionary<string, PD_Entity>>(() => this.ToDictionary(e => e.PDKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "PD"; } }

        /// <summary>
        /// Find PD by PDKEY key field
        /// </summary>
        /// <param name="Key">PDKEY value used to find PD</param>
        /// <returns>Related PD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">PDKEY value didn't match any PD entities</exception>
        public PD_Entity FindByPDKEY(string Key)
        {
            PD_Entity result;
            if (PDKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find PD by PDKEY key field
        /// </summary>
        /// <param name="Key">PDKEY value used to find PD</param>
        /// <param name="Value">Related PD entity</param>
        /// <returns>True if the PD Entity is found</returns>
        public bool TryFindByPDKEY(string Key, out PD_Entity Value)
        {
            return PDKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find PD by PDKEY key field
        /// </summary>
        /// <param name="Key">PDKEY value used to find PD</param>
        /// <returns>Related PD entity, or null if not found</returns>
        public PD_Entity TryFindByPDKEY(string Key)
        {
            PD_Entity result;
            if (PDKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<PD_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<PD_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PDKEY":
                        mapper[i] = (e, v) => e.PDKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "GLBANK":
                        mapper[i] = (e, v) => e.GLBANK = v;
                        break;
                    case "GLTAX":
                        mapper[i] = (e, v) => e.GLTAX = v;
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
