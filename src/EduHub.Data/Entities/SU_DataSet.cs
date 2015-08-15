using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subjects Data Set
    /// </summary>
    public sealed class SU_DataSet : SetBase<SU_Entity>
    {
        private Lazy<Dictionary<string, SU_Entity>> SUKEY_Index;

        internal SU_DataSet(EduHubContext Context)
            : base(Context)
        {
            SUKEY_Index = new Lazy<Dictionary<string, SU_Entity>>(() => this.ToDictionary(e => e.SUKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SU"; } }

        /// <summary>
        /// Find SU by SUKEY key field
        /// </summary>
        /// <param name="Key">SUKEY value used to find SU</param>
        /// <returns>Related SU entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SUKEY value didn't match any SU entities</exception>
        public SU_Entity FindBySUKEY(string Key)
        {
            SU_Entity result;
            if (SUKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SU by SUKEY key field
        /// </summary>
        /// <param name="Key">SUKEY value used to find SU</param>
        /// <param name="Value">Related SU entity</param>
        /// <returns>True if the SU Entity is found</returns>
        public bool TryFindBySUKEY(string Key, out SU_Entity Value)
        {
            return SUKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SU by SUKEY key field
        /// </summary>
        /// <param name="Key">SUKEY value used to find SU</param>
        /// <returns>Related SU entity, or null if not found</returns>
        public SU_Entity TryFindBySUKEY(string Key)
        {
            SU_Entity result;
            if (SUKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SU_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SU_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SUKEY":
                        mapper[i] = (e, v) => e.SUKEY = v;
                        break;
                    case "FULLNAME":
                        mapper[i] = (e, v) => e.FULLNAME = v;
                        break;
                    case "SHORTNAME":
                        mapper[i] = (e, v) => e.SHORTNAME = v;
                        break;
                    case "FACULTY":
                        mapper[i] = (e, v) => e.FACULTY = v;
                        break;
                    case "PROMOTE":
                        mapper[i] = (e, v) => e.PROMOTE = v;
                        break;
                    case "OVERVIEW":
                        mapper[i] = (e, v) => e.OVERVIEW = v;
                        break;
                    case "PRIORITY":
                        mapper[i] = (e, v) => e.PRIORITY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SUBJECT_ACADEMIC_YEAR":
                        mapper[i] = (e, v) => e.SUBJECT_ACADEMIC_YEAR = v;
                        break;
                    case "SEMESTER":
                        mapper[i] = (e, v) => e.SEMESTER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DURATION":
                        mapper[i] = (e, v) => e.DURATION = v;
                        break;
                    case "SUBJECT_TYPE":
                        mapper[i] = (e, v) => e.SUBJECT_TYPE = v;
                        break;
                    case "PRINT_SEQ_NO":
                        mapper[i] = (e, v) => e.PRINT_SEQ_NO = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ELECTIVE":
                        mapper[i] = (e, v) => e.ELECTIVE = v;
                        break;
                    case "VCAA_ID":
                        mapper[i] = (e, v) => e.VCAA_ID = v;
                        break;
                    case "FEE_CODE":
                        mapper[i] = (e, v) => e.FEE_CODE = v;
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
