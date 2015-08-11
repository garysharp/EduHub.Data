using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// PAYG Supplier Details Data Set
    /// </summary>
    public sealed class PPS_DataSet : SetBase<PPS_Entity>
    {
        internal PPS_DataSet(EduHubContext Context)
            : base(Context)
        {
            PPSKEY_Index = new Lazy<Dictionary<string, PPS_Entity>>(() => this.ToDictionary(e => e.PPSKEY));
        }

        public override string SetName { get { return "PPS"; } }

        private Lazy<Dictionary<string, PPS_Entity>> PPSKEY_Index;

        public PPS_Entity FindByPPSKEY(string Key)
        {
            PPS_Entity result;
            if (PPSKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByPPSKEY(string Key, out PPS_Entity Value)
        {
            return PPSKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public PPS_Entity TryFindByPPSKEY(string Key)
        {
            PPS_Entity result;
            if (PPSKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<PPS_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<PPS_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PPSKEY":
                        mapper[i] = (e, v) => e.PPSKEY = v;
                        break;
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
                        break;
                    case "NAME":
                        mapper[i] = (e, v) => e.NAME = v;
                        break;
                    case "CONTACT_NAME":
                        mapper[i] = (e, v) => e.CONTACT_NAME = v;
                        break;
                    case "CONTACT_PHONE":
                        mapper[i] = (e, v) => e.CONTACT_PHONE = v;
                        break;
                    case "FACSIMILE":
                        mapper[i] = (e, v) => e.FACSIMILE = v;
                        break;
                    case "FILE_REFERENCE":
                        mapper[i] = (e, v) => e.FILE_REFERENCE = v;
                        break;
                    case "L1_ADDRESS":
                        mapper[i] = (e, v) => e.L1_ADDRESS = v;
                        break;
                    case "L2_ADDRESS":
                        mapper[i] = (e, v) => e.L2_ADDRESS = v;
                        break;
                    case "SUBURB":
                        mapper[i] = (e, v) => e.SUBURB = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "COUNTRY":
                        mapper[i] = (e, v) => e.COUNTRY = v;
                        break;
                    case "POSTAL_L1_ADD":
                        mapper[i] = (e, v) => e.POSTAL_L1_ADD = v;
                        break;
                    case "POSTAL_L2_ADD":
                        mapper[i] = (e, v) => e.POSTAL_L2_ADD = v;
                        break;
                    case "POSTAL_SUBURB":
                        mapper[i] = (e, v) => e.POSTAL_SUBURB = v;
                        break;
                    case "POSTAL_STATE":
                        mapper[i] = (e, v) => e.POSTAL_STATE = v;
                        break;
                    case "POSTAL_POSTCODE":
                        mapper[i] = (e, v) => e.POSTAL_POSTCODE = v;
                        break;
                    case "POSTAL_COUNTRY":
                        mapper[i] = (e, v) => e.POSTAL_COUNTRY = v;
                        break;
                    case "EMAIL_ADDRESS":
                        mapper[i] = (e, v) => e.EMAIL_ADDRESS = v;
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
