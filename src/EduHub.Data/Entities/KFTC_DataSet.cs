using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Fuel Tax Credit Rates Data Set
    /// </summary>
    public sealed class KFTC_DataSet : SetBase<KFTC_Entity>
    {
        private Lazy<Dictionary<string, KFTC_Entity>> KFTCKEY_Index;

        internal KFTC_DataSet(EduHubContext Context)
            : base(Context)
        {
            KFTCKEY_Index = new Lazy<Dictionary<string, KFTC_Entity>>(() => this.ToDictionary(e => e.KFTCKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "KFTC"; } }

        /// <summary>
        /// Find KFTC by KFTCKEY key field
        /// </summary>
        /// <param name="Key">KFTCKEY value used to find KFTC</param>
        /// <returns>Related KFTC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KFTCKEY value didn't match any KFTC entities</exception>
        public KFTC_Entity FindByKFTCKEY(string Key)
        {
            KFTC_Entity result;
            if (KFTCKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KFTC by KFTCKEY key field
        /// </summary>
        /// <param name="Key">KFTCKEY value used to find KFTC</param>
        /// <param name="Value">Related KFTC entity</param>
        /// <returns>True if the KFTC Entity is found</returns>
        public bool TryFindByKFTCKEY(string Key, out KFTC_Entity Value)
        {
            return KFTCKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KFTC by KFTCKEY key field
        /// </summary>
        /// <param name="Key">KFTCKEY value used to find KFTC</param>
        /// <returns>Related KFTC entity, or null if not found</returns>
        public KFTC_Entity TryFindByKFTCKEY(string Key)
        {
            KFTC_Entity result;
            if (KFTCKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KFTC_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KFTC_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KFTCKEY":
                        mapper[i] = (e, v) => e.KFTCKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "FTC_RATE":
                        mapper[i] = (e, v) => e.FTC_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "GL_CODE":
                        mapper[i] = (e, v) => e.GL_CODE = v;
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
                    case "INACTIVE":
                        mapper[i] = (e, v) => e.INACTIVE = v;
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
