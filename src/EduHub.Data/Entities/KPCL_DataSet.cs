using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Contact Links Data Set
    /// </summary>
    public sealed class KPCL_DataSet : SetBase<KPCL_Entity>
    {
        private Lazy<Dictionary<int, KPCL_Entity>> KPCLKEY_Index;

        internal KPCL_DataSet(EduHubContext Context)
            : base(Context)
        {
            KPCLKEY_Index = new Lazy<Dictionary<int, KPCL_Entity>>(() => this.ToDictionary(e => e.KPCLKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "KPCL"; } }

        /// <summary>
        /// Find KPCL by KPCLKEY key field
        /// </summary>
        /// <param name="Key">KPCLKEY value used to find KPCL</param>
        /// <returns>Related KPCL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KPCLKEY value didn't match any KPCL entities</exception>
        public KPCL_Entity FindByKPCLKEY(int Key)
        {
            KPCL_Entity result;
            if (KPCLKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KPCL by KPCLKEY key field
        /// </summary>
        /// <param name="Key">KPCLKEY value used to find KPCL</param>
        /// <param name="Value">Related KPCL entity</param>
        /// <returns>True if the KPCL Entity is found</returns>
        public bool TryFindByKPCLKEY(int Key, out KPCL_Entity Value)
        {
            return KPCLKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KPCL by KPCLKEY key field
        /// </summary>
        /// <param name="Key">KPCLKEY value used to find KPCL</param>
        /// <returns>Related KPCL entity, or null if not found</returns>
        public KPCL_Entity TryFindByKPCLKEY(int Key)
        {
            KPCL_Entity result;
            if (KPCLKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KPCL_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KPCL_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KPCLKEY":
                        mapper[i] = (e, v) => e.KPCLKEY = int.Parse(v);
                        break;
                    case "LINK":
                        mapper[i] = (e, v) => e.LINK = v;
                        break;
                    case "SOURCE":
                        mapper[i] = (e, v) => e.SOURCE = v;
                        break;
                    case "CONTACT":
                        mapper[i] = (e, v) => e.CONTACT = v;
                        break;
                    case "CONTACT_TYPE":
                        mapper[i] = (e, v) => e.CONTACT_TYPE = v;
                        break;
                    case "CONTACT_PREFERENCE":
                        mapper[i] = (e, v) => e.CONTACT_PREFERENCE = v == null ? (short?)null : short.Parse(v);
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
