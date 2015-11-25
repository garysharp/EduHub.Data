using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Types Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AKTDataSet : SetBase<AKT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "AKT"; } }

        internal AKTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_AKTKEY = new Lazy<Dictionary<string, AKT>>(() => this.ToDictionary(i => i.AKTKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AKT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AKT" /> fields for each CSV column header</returns>
        protected override Action<AKT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<AKT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "AKTKEY":
                        mapper[i] = (e, v) => e.AKTKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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

        private Lazy<Dictionary<string, AKT>> Index_AKTKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find AKT by AKTKEY field
        /// </summary>
        /// <param name="AKTKEY">AKTKEY value used to find AKT</param>
        /// <returns>Related AKT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKT FindByAKTKEY(string AKTKEY)
        {
            return Index_AKTKEY.Value[AKTKEY];
        }

        /// <summary>
        /// Attempt to find AKT by AKTKEY field
        /// </summary>
        /// <param name="AKTKEY">AKTKEY value used to find AKT</param>
        /// <param name="Value">Related AKT entity</param>
        /// <returns>True if the related AKT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAKTKEY(string AKTKEY, out AKT Value)
        {
            return Index_AKTKEY.Value.TryGetValue(AKTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find AKT by AKTKEY field
        /// </summary>
        /// <param name="AKTKEY">AKTKEY value used to find AKT</param>
        /// <returns>Related AKT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKT TryFindByAKTKEY(string AKTKEY)
        {
            AKT value;
            if (Index_AKTKEY.Value.TryGetValue(AKTKEY, out value))
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
