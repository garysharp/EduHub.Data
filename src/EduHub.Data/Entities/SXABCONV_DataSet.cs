using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Converted Student Half-Day Absences Data Set
    /// </summary>
    public sealed class SXABCONV_DataSet : SetBase<SXABCONV_Entity>
    {
        private Lazy<Dictionary<int, SXABCONV_Entity>> SXABCONV_ID_Index;

        internal SXABCONV_DataSet(EduHubContext Context)
            : base(Context)
        {
            SXABCONV_ID_Index = new Lazy<Dictionary<int, SXABCONV_Entity>>(() => this.ToDictionary(e => e.SXABCONV_ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SXABCONV"; } }

        /// <summary>
        /// Find SXABCONV by SXABCONV_ID key field
        /// </summary>
        /// <param name="Key">SXABCONV_ID value used to find SXABCONV</param>
        /// <returns>Related SXABCONV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SXABCONV_ID value didn't match any SXABCONV entities</exception>
        public SXABCONV_Entity FindBySXABCONV_ID(int Key)
        {
            SXABCONV_Entity result;
            if (SXABCONV_ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SXABCONV by SXABCONV_ID key field
        /// </summary>
        /// <param name="Key">SXABCONV_ID value used to find SXABCONV</param>
        /// <param name="Value">Related SXABCONV entity</param>
        /// <returns>True if the SXABCONV Entity is found</returns>
        public bool TryFindBySXABCONV_ID(int Key, out SXABCONV_Entity Value)
        {
            return SXABCONV_ID_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SXABCONV by SXABCONV_ID key field
        /// </summary>
        /// <param name="Key">SXABCONV_ID value used to find SXABCONV</param>
        /// <returns>Related SXABCONV entity, or null if not found</returns>
        public SXABCONV_Entity TryFindBySXABCONV_ID(int Key)
        {
            SXABCONV_Entity result;
            if (SXABCONV_ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SXABCONV_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SXABCONV_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SXABCONV_ID":
                        mapper[i] = (e, v) => e.SXABCONV_ID = int.Parse(v);
                        break;
                    case "STKEY":
                        mapper[i] = (e, v) => e.STKEY = v;
                        break;
                    case "ST_YEAR_LEVEL":
                        mapper[i] = (e, v) => e.ST_YEAR_LEVEL = v;
                        break;
                    case "ABSENCE_DATE":
                        mapper[i] = (e, v) => e.ABSENCE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AM_TYPE":
                        mapper[i] = (e, v) => e.AM_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM_ATTENDED":
                        mapper[i] = (e, v) => e.AM_ATTENDED = v;
                        break;
                    case "AM_APPROVED":
                        mapper[i] = (e, v) => e.AM_APPROVED = v;
                        break;
                    case "PM_TYPE":
                        mapper[i] = (e, v) => e.PM_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM_ATTENDED":
                        mapper[i] = (e, v) => e.PM_ATTENDED = v;
                        break;
                    case "PM_APPROVED":
                        mapper[i] = (e, v) => e.PM_APPROVED = v;
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "RECORD_SOURCE":
                        mapper[i] = (e, v) => e.RECORD_SOURCE = v;
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
