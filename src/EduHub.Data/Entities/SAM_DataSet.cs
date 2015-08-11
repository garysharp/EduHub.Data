using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Association Members Data Set
    /// </summary>
    public sealed class SAM_DataSet : SetBase<SAM_Entity>
    {
        internal SAM_DataSet(EduHubContext Context)
            : base(Context)
        {
            SAMKEY_Index = new Lazy<Dictionary<int, SAM_Entity>>(() => this.ToDictionary(e => e.SAMKEY));
        }

        public override string SetName { get { return "SAM"; } }

        private Lazy<Dictionary<int, SAM_Entity>> SAMKEY_Index;

        public SAM_Entity FindBySAMKEY(int Key)
        {
            SAM_Entity result;
            if (SAMKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindBySAMKEY(int Key, out SAM_Entity Value)
        {
            return SAMKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public SAM_Entity TryFindBySAMKEY(int Key)
        {
            SAM_Entity result;
            if (SAMKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<SAM_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SAM_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SAMKEY":
                        mapper[i] = (e, v) => e.SAMKEY = int.Parse(v);
                        break;
                    case "PERSON_TYPE":
                        mapper[i] = (e, v) => e.PERSON_TYPE = v;
                        break;
                    case "PERSON":
                        mapper[i] = (e, v) => e.PERSON = v;
                        break;
                    case "WHICH_PARENT":
                        mapper[i] = (e, v) => e.WHICH_PARENT = v;
                        break;
                    case "GENDER":
                        mapper[i] = (e, v) => e.GENDER = v;
                        break;
                    case "BIRTHDATE":
                        mapper[i] = (e, v) => e.BIRTHDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "KOORIE":
                        mapper[i] = (e, v) => e.KOORIE = v;
                        break;
                    case "PARENT_OS":
                        mapper[i] = (e, v) => e.PARENT_OS = v;
                        break;
                    case "LOTE":
                        mapper[i] = (e, v) => e.LOTE = v;
                        break;
                    case "LBOTE":
                        mapper[i] = (e, v) => e.LBOTE = v;
                        break;
                    case "DISABILITY":
                        mapper[i] = (e, v) => e.DISABILITY = v;
                        break;
                    case "ASSOC_NAME":
                        mapper[i] = (e, v) => e.ASSOC_NAME = v;
                        break;
                    case "ASSOC_POSN":
                        mapper[i] = (e, v) => e.ASSOC_POSN = v;
                        break;
                    case "ADDRESSKEY":
                        mapper[i] = (e, v) => e.ADDRESSKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MAILKEY":
                        mapper[i] = (e, v) => e.MAILKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "HOME_E_MAIL":
                        mapper[i] = (e, v) => e.HOME_E_MAIL = v;
                        break;
                    case "WORK_PHONE":
                        mapper[i] = (e, v) => e.WORK_PHONE = v;
                        break;
                    case "WORK_FAX":
                        mapper[i] = (e, v) => e.WORK_FAX = v;
                        break;
                    case "WORK_E_MAIL":
                        mapper[i] = (e, v) => e.WORK_E_MAIL = v;
                        break;
                    case "SURNAME":
                        mapper[i] = (e, v) => e.SURNAME = v;
                        break;
                    case "FIRST_NAME":
                        mapper[i] = (e, v) => e.FIRST_NAME = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "MOBILE_PHONE":
                        mapper[i] = (e, v) => e.MOBILE_PHONE = v;
                        break;
                    case "SIGNATORY":
                        mapper[i] = (e, v) => e.SIGNATORY = v;
                        break;
                    case "SAM_COMMENT":
                        mapper[i] = (e, v) => e.SAM_COMMENT = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
