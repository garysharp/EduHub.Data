using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Fuel Tax Credit Rates Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KFTCDataSet : SetBase<KFTC>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KFTC"; } }

        internal KFTCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KFTCKEY = new Lazy<Dictionary<string, KFTC>>(() => this.ToDictionary(i => i.KFTCKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KFTC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KFTC" /> fields for each CSV column header</returns>
        protected override Action<KFTC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KFTC, string>[Headers.Count];

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

        #region Index Fields

        private Lazy<Dictionary<string, KFTC>> Index_KFTCKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KFTC by KFTCKEY field
        /// </summary>
        /// <param name="KFTCKEY">KFTCKEY value used to find KFTC</param>
        /// <returns>Related KFTC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KFTC FindByKFTCKEY(string KFTCKEY)
        {
            return Index_KFTCKEY.Value[KFTCKEY];
        }

        /// <summary>
        /// Attempt to find KFTC by KFTCKEY field
        /// </summary>
        /// <param name="KFTCKEY">KFTCKEY value used to find KFTC</param>
        /// <param name="Value">Related KFTC entity</param>
        /// <returns>True if the related KFTC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKFTCKEY(string KFTCKEY, out KFTC Value)
        {
            return Index_KFTCKEY.Value.TryGetValue(KFTCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KFTC by KFTCKEY field
        /// </summary>
        /// <param name="KFTCKEY">KFTCKEY value used to find KFTC</param>
        /// <returns>Related KFTC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KFTC TryFindByKFTCKEY(string KFTCKEY)
        {
            KFTC value;
            if (Index_KFTCKEY.Value.TryGetValue(KFTCKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        #endregion

    }
}
