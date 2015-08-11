using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Payroll Groups Data Set
    /// </summary>
    public sealed class PN_DataSet : SetBase<PN_Entity>
    {
        internal PN_DataSet(EduHubContext Context)
            : base(Context)
        {
            PNKEY_Index = new Lazy<Dictionary<short, PN_Entity>>(() => this.ToDictionary(e => e.PNKEY));
        }

        public override string SetName { get { return "PN"; } }

        private Lazy<Dictionary<short, PN_Entity>> PNKEY_Index;

        public PN_Entity FindByPNKEY(short Key)
        {
            PN_Entity result;
            if (PNKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByPNKEY(short Key, out PN_Entity Value)
        {
            return PNKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public PN_Entity TryFindByPNKEY(short Key)
        {
            PN_Entity result;
            if (PNKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<PN_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<PN_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PNKEY":
                        mapper[i] = (e, v) => e.PNKEY = short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "TRANSTYPE":
                        mapper[i] = (e, v) => e.TRANSTYPE = v;
                        break;
                    case "FIRSTDATE":
                        mapper[i] = (e, v) => e.FIRSTDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "NEXTDATE":
                        mapper[i] = (e, v) => e.NEXTDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "NO_PAYS":
                        mapper[i] = (e, v) => e.NO_PAYS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ROUNDOFF":
                        mapper[i] = (e, v) => e.ROUNDOFF = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PPDKEY":
                        mapper[i] = (e, v) => e.PPDKEY = v;
                        break;
                    case "PAY_TYPE":
                        mapper[i] = (e, v) => e.PAY_TYPE = v;
                        break;
                    case "ACN":
                        mapper[i] = (e, v) => e.ACN = v;
                        break;
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
                        break;
                    case "DD_GLCODE":
                        mapper[i] = (e, v) => e.DD_GLCODE = v;
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
