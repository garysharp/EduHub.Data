using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Doctors Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCDDataSet : SetBase<KCD>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCD"; } }

        internal KCDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KCDKEY = new Lazy<Dictionary<string, KCD>>(() => this.ToDictionary(i => i.KCDKEY));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<KCD>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCD" /> fields for each CSV column header</returns>
        protected override Action<KCD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCDKEY":
                        mapper[i] = (e, v) => e.KCDKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "DR_GROUP":
                        mapper[i] = (e, v) => e.DR_GROUP = v;
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
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
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "KAP_LINK":
                        mapper[i] = (e, v) => e.KAP_LINK = v;
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

        private Lazy<Dictionary<string, KCD>> Index_KCDKEY;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<KCD>>> Index_LW_DATE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCD by KCDKEY field
        /// </summary>
        /// <param name="KCDKEY">KCDKEY value used to find KCD</param>
        /// <returns>Related KCD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCD FindByKCDKEY(string KCDKEY)
        {
            return Index_KCDKEY.Value[KCDKEY];
        }

        /// <summary>
        /// Attempt to find KCD by KCDKEY field
        /// </summary>
        /// <param name="KCDKEY">KCDKEY value used to find KCD</param>
        /// <param name="Value">Related KCD entity</param>
        /// <returns>True if the related KCD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKCDKEY(string KCDKEY, out KCD Value)
        {
            return Index_KCDKEY.Value.TryGetValue(KCDKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KCD by KCDKEY field
        /// </summary>
        /// <param name="KCDKEY">KCDKEY value used to find KCD</param>
        /// <returns>Related KCD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCD TryFindByKCDKEY(string KCDKEY)
        {
            KCD value;
            if (Index_KCDKEY.Value.TryGetValue(KCDKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KCD by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KCD</param>
        /// <returns>List of related KCD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCD> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find KCD by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KCD</param>
        /// <param name="Value">List of related KCD entities</param>
        /// <returns>True if the list of related KCD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<KCD> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find KCD by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KCD</param>
        /// <returns>List of related KCD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCD> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<KCD> value;
            if (Index_LW_DATE.Value.TryGetValue(LW_DATE, out value))
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
