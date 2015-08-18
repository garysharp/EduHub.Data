using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Addresses Data Set
    /// </summary>
    public sealed class UMDataSet : SetBase<UM>
    {
        private Lazy<Dictionary<int, UM>> UMKEYIndex;

        internal UMDataSet(EduHubContext Context)
            : base(Context)
        {
            UMKEYIndex = new Lazy<Dictionary<int, UM>>(() => this.ToDictionary(e => e.UMKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "UM"; } }

        /// <summary>
        /// Find UM by UMKEY key field
        /// </summary>
        /// <param name="Key">UMKEY value used to find UM</param>
        /// <returns>Related UM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">UMKEY value didn't match any UM entities</exception>
        public UM FindByUMKEY(int Key)
        {
            UM result;
            if (UMKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find UM by UMKEY key field
        /// </summary>
        /// <param name="Key">UMKEY value used to find UM</param>
        /// <param name="Value">Related UM entity</param>
        /// <returns>True if the UM Entity is found</returns>
        public bool TryFindByUMKEY(int Key, out UM Value)
        {
            return UMKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find UM by UMKEY key field
        /// </summary>
        /// <param name="Key">UMKEY value used to find UM</param>
        /// <returns>Related UM entity, or null if not found</returns>
        public UM TryFindByUMKEY(int Key)
        {
            UM result;
            if (UMKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<UM, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<UM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "UMKEY":
                        mapper[i] = (e, v) => e.UMKEY = int.Parse(v);
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
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "SILENT":
                        mapper[i] = (e, v) => e.SILENT = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "KAP_LINK":
                        mapper[i] = (e, v) => e.KAP_LINK = v;
                        break;
                    case "COUNTRY":
                        mapper[i] = (e, v) => e.COUNTRY = v;
                        break;
                    case "DPID":
                        mapper[i] = (e, v) => e.DPID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BARCODE":
                        mapper[i] = (e, v) => e.BARCODE = v;
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
