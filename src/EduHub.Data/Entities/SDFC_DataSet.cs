using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Sundry Debtor Fees Data Set
    /// </summary>
    public sealed class SDFC_DataSet : SetBase<SDFC_Entity>
    {
        internal SDFC_DataSet(EduHubContext Context)
            : base(Context)
        {
            SDFCKEY_Index = new Lazy<Dictionary<string, SDFC_Entity>>(() => this.ToDictionary(e => e.SDFCKEY));
        }

        public override string SetName { get { return "SDFC"; } }

        private Lazy<Dictionary<string, SDFC_Entity>> SDFCKEY_Index;

        public SDFC_Entity FindBySDFCKEY(string Key)
        {
            SDFC_Entity result;
            if (SDFCKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindBySDFCKEY(string Key, out SDFC_Entity Value)
        {
            return SDFCKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public SDFC_Entity TryFindBySDFCKEY(string Key)
        {
            SDFC_Entity result;
            if (SDFCKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<SDFC_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SDFC_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SDFCKEY":
                        mapper[i] = (e, v) => e.SDFCKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "SDGROUP":
                        mapper[i] = (e, v) => e.SDGROUP = v;
                        break;
                    case "STATEMENT":
                        mapper[i] = (e, v) => e.STATEMENT = v;
                        break;
                    case "METHOD":
                        mapper[i] = (e, v) => e.METHOD = v;
                        break;
                    case "AMOUNT":
                        mapper[i] = (e, v) => e.AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS_AMOUNT":
                        mapper[i] = (e, v) => e.GROSS_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "GST_TYPE":
                        mapper[i] = (e, v) => e.GST_TYPE = v;
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
