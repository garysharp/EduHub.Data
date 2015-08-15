using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Events Data Set
    /// </summary>
    public sealed class TE_DataSet : SetBase<TE_Entity>
    {
        private Lazy<Dictionary<int, TE_Entity>> TEKEY_Index;

        internal TE_DataSet(EduHubContext Context)
            : base(Context)
        {
            TEKEY_Index = new Lazy<Dictionary<int, TE_Entity>>(() => this.ToDictionary(e => e.TEKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "TE"; } }

        /// <summary>
        /// Find TE by TEKEY key field
        /// </summary>
        /// <param name="Key">TEKEY value used to find TE</param>
        /// <returns>Related TE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TEKEY value didn't match any TE entities</exception>
        public TE_Entity FindByTEKEY(int Key)
        {
            TE_Entity result;
            if (TEKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find TE by TEKEY key field
        /// </summary>
        /// <param name="Key">TEKEY value used to find TE</param>
        /// <param name="Value">Related TE entity</param>
        /// <returns>True if the TE Entity is found</returns>
        public bool TryFindByTEKEY(int Key, out TE_Entity Value)
        {
            return TEKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find TE by TEKEY key field
        /// </summary>
        /// <param name="Key">TEKEY value used to find TE</param>
        /// <returns>Related TE entity, or null if not found</returns>
        public TE_Entity TryFindByTEKEY(int Key)
        {
            TE_Entity result;
            if (TEKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<TE_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<TE_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TEKEY":
                        mapper[i] = (e, v) => e.TEKEY = int.Parse(v);
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "COMMENTS":
                        mapper[i] = (e, v) => e.COMMENTS = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "RECURRENCE":
                        mapper[i] = (e, v) => e.RECURRENCE = v;
                        break;
                    case "RECUR_DAYS":
                        mapper[i] = (e, v) => e.RECUR_DAYS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TIME_FROM":
                        mapper[i] = (e, v) => e.TIME_FROM = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TIME_TO":
                        mapper[i] = (e, v) => e.TIME_TO = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CONVENOR":
                        mapper[i] = (e, v) => e.CONVENOR = v;
                        break;
                    case "CONVENOR_TYPE":
                        mapper[i] = (e, v) => e.CONVENOR_TYPE = v;
                        break;
                    case "LOCATION":
                        mapper[i] = (e, v) => e.LOCATION = v;
                        break;
                    case "EVENT_GROUP":
                        mapper[i] = (e, v) => e.EVENT_GROUP = v;
                        break;
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
                        break;
                    case "COLOUR":
                        mapper[i] = (e, v) => e.COLOUR = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EVENT_CODE":
                        mapper[i] = (e, v) => e.EVENT_CODE = v;
                        break;
                    case "START_YEAR":
                        mapper[i] = (e, v) => e.START_YEAR = v;
                        break;
                    case "END_YEAR":
                        mapper[i] = (e, v) => e.END_YEAR = v;
                        break;
                    case "START_FORM":
                        mapper[i] = (e, v) => e.START_FORM = v;
                        break;
                    case "END_FORM":
                        mapper[i] = (e, v) => e.END_FORM = v;
                        break;
                    case "SUBJ":
                        mapper[i] = (e, v) => e.SUBJ = v;
                        break;
                    case "START_CLASS_NUM":
                        mapper[i] = (e, v) => e.START_CLASS_NUM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "END_CLASS_NUM":
                        mapper[i] = (e, v) => e.END_CLASS_NUM = v == null ? (short?)null : short.Parse(v);
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
