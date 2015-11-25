using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Depreciation Methods Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KADMDataSet : SetBase<KADM>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KADM"; } }

        internal KADMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KADMKEY = new Lazy<Dictionary<string, KADM>>(() => this.ToDictionary(i => i.KADMKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KADM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KADM" /> fields for each CSV column header</returns>
        protected override Action<KADM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KADM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KADMKEY":
                        mapper[i] = (e, v) => e.KADMKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "DETAIL":
                        mapper[i] = (e, v) => e.DETAIL = v;
                        break;
                    case "DATE_BASED":
                        mapper[i] = (e, v) => e.DATE_BASED = v;
                        break;
                    case "TAX":
                        mapper[i] = (e, v) => e.TAX = v;
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

        #region Index Fields

        private Lazy<Dictionary<string, KADM>> Index_KADMKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KADM by KADMKEY field
        /// </summary>
        /// <param name="KADMKEY">KADMKEY value used to find KADM</param>
        /// <returns>Related KADM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KADM FindByKADMKEY(string KADMKEY)
        {
            return Index_KADMKEY.Value[KADMKEY];
        }

        /// <summary>
        /// Attempt to find KADM by KADMKEY field
        /// </summary>
        /// <param name="KADMKEY">KADMKEY value used to find KADM</param>
        /// <param name="Value">Related KADM entity</param>
        /// <returns>True if the related KADM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKADMKEY(string KADMKEY, out KADM Value)
        {
            return Index_KADMKEY.Value.TryGetValue(KADMKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KADM by KADMKEY field
        /// </summary>
        /// <param name="KADMKEY">KADMKEY value used to find KADM</param>
        /// <returns>Related KADM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KADM TryFindByKADMKEY(string KADMKEY)
        {
            KADM value;
            if (Index_KADMKEY.Value.TryGetValue(KADMKEY, out value))
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
