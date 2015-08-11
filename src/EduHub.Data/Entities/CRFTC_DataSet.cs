using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Creditor Fuel Tax Credits Data Set
    /// </summary>
    public sealed class CRFTC_DataSet : SetBase<CRFTC_Entity>
    {
        internal CRFTC_DataSet(EduHubContext Context)
            : base(Context)
        {
            TRREF_Index = new Lazy<Dictionary<string, CRFTC_Entity>>(() => this.ToDictionary(e => e.TRREF));
        }

        public override string SetName { get { return "CRFTC"; } }

        private Lazy<Dictionary<string, CRFTC_Entity>> TRREF_Index;

        public CRFTC_Entity FindByTRREF(string Key)
        {
            CRFTC_Entity result;
            if (TRREF_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByTRREF(string Key, out CRFTC_Entity Value)
        {
            return TRREF_Index.Value.TryGetValue(Key, out Value);
        }
        public CRFTC_Entity TryFindByTRREF(string Key)
        {
            CRFTC_Entity result;
            if (TRREF_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<CRFTC_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<CRFTC_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "TRDATE":
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRREF":
                        mapper[i] = (e, v) => e.TRREF = v;
                        break;
                    case "FUEL_TYPE":
                        mapper[i] = (e, v) => e.FUEL_TYPE = v;
                        break;
                    case "FTC_CODE":
                        mapper[i] = (e, v) => e.FTC_CODE = v;
                        break;
                    case "TOT_LITRES":
                        mapper[i] = (e, v) => e.TOT_LITRES = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "CLAIM_PERC":
                        mapper[i] = (e, v) => e.CLAIM_PERC = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "CLAIM_LITRES":
                        mapper[i] = (e, v) => e.CLAIM_LITRES = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "CLAIM_AMOUNT":
                        mapper[i] = (e, v) => e.CLAIM_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CLAIM_PERIOD":
                        mapper[i] = (e, v) => e.CLAIM_PERIOD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
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
