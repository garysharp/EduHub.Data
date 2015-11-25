using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Absence Types Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TCATDataSet : SetBase<TCAT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TCAT"; } }

        internal TCATDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TCATKEY = new Lazy<Dictionary<string, TCAT>>(() => this.ToDictionary(i => i.TCATKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TCAT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TCAT" /> fields for each CSV column header</returns>
        protected override Action<TCAT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TCAT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TCATKEY":
                        mapper[i] = (e, v) => e.TCATKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
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

        private Lazy<Dictionary<string, TCAT>> Index_TCATKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TCAT by TCATKEY field
        /// </summary>
        /// <param name="TCATKEY">TCATKEY value used to find TCAT</param>
        /// <returns>Related TCAT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TCAT FindByTCATKEY(string TCATKEY)
        {
            return Index_TCATKEY.Value[TCATKEY];
        }

        /// <summary>
        /// Attempt to find TCAT by TCATKEY field
        /// </summary>
        /// <param name="TCATKEY">TCATKEY value used to find TCAT</param>
        /// <param name="Value">Related TCAT entity</param>
        /// <returns>True if the related TCAT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTCATKEY(string TCATKEY, out TCAT Value)
        {
            return Index_TCATKEY.Value.TryGetValue(TCATKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TCAT by TCATKEY field
        /// </summary>
        /// <param name="TCATKEY">TCATKEY value used to find TCAT</param>
        /// <returns>Related TCAT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TCAT TryFindByTCATKEY(string TCATKEY)
        {
            TCAT value;
            if (Index_TCATKEY.Value.TryGetValue(TCATKEY, out value))
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
