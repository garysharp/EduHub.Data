using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Transport Company Data Set
    /// </summary>
    public sealed class KTRCMP_DataSet : SetBase<KTRCMP_Entity>
    {
        internal KTRCMP_DataSet(EduHubContext Context)
            : base(Context)
        {
            COMPANY_ID_Index = new Lazy<Dictionary<int, KTRCMP_Entity>>(() => this.ToDictionary(e => e.COMPANY_ID));
        }

        public override string SetName { get { return "KTRCMP"; } }

        private Lazy<Dictionary<int, KTRCMP_Entity>> COMPANY_ID_Index;

        public KTRCMP_Entity FindByCOMPANY_ID(int Key)
        {
            KTRCMP_Entity result;
            if (COMPANY_ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByCOMPANY_ID(int Key, out KTRCMP_Entity Value)
        {
            return COMPANY_ID_Index.Value.TryGetValue(Key, out Value);
        }
        public KTRCMP_Entity TryFindByCOMPANY_ID(int Key)
        {
            KTRCMP_Entity result;
            if (COMPANY_ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KTRCMP_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KTRCMP_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "COMPANY_ID":
                        mapper[i] = (e, v) => e.COMPANY_ID = int.Parse(v);
                        break;
                    case "COMPANY_CODE":
                        mapper[i] = (e, v) => e.COMPANY_CODE = v;
                        break;
                    case "COMPANY_NAME":
                        mapper[i] = (e, v) => e.COMPANY_NAME = v;
                        break;
                    case "CONTACT":
                        mapper[i] = (e, v) => e.CONTACT = v;
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
                    case "PHONE":
                        mapper[i] = (e, v) => e.PHONE = v;
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "EMAIL":
                        mapper[i] = (e, v) => e.EMAIL = v;
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
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }
    }
}
