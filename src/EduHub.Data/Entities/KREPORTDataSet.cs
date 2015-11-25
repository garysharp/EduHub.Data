using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Reports for emailing Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KREPORTDataSet : SetBase<KREPORT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KREPORT"; } }

        internal KREPORTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KREPORTKEY = new Lazy<Dictionary<string, KREPORT>>(() => this.ToDictionary(i => i.KREPORTKEY));
            Index_ROLE_CODE = new Lazy<NullDictionary<string, IReadOnlyList<KREPORT>>>(() => this.ToGroupedNullDictionary(i => i.ROLE_CODE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KREPORT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KREPORT" /> fields for each CSV column header</returns>
        protected override Action<KREPORT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KREPORT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KREPORTKEY":
                        mapper[i] = (e, v) => e.KREPORTKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ROLE_CODE":
                        mapper[i] = (e, v) => e.ROLE_CODE = v;
                        break;
                    case "REPORT_NAME":
                        mapper[i] = (e, v) => e.REPORT_NAME = v;
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

        private Lazy<Dictionary<string, KREPORT>> Index_KREPORTKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<KREPORT>>> Index_ROLE_CODE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KREPORT by KREPORTKEY field
        /// </summary>
        /// <param name="KREPORTKEY">KREPORTKEY value used to find KREPORT</param>
        /// <returns>Related KREPORT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KREPORT FindByKREPORTKEY(string KREPORTKEY)
        {
            return Index_KREPORTKEY.Value[KREPORTKEY];
        }

        /// <summary>
        /// Attempt to find KREPORT by KREPORTKEY field
        /// </summary>
        /// <param name="KREPORTKEY">KREPORTKEY value used to find KREPORT</param>
        /// <param name="Value">Related KREPORT entity</param>
        /// <returns>True if the related KREPORT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKREPORTKEY(string KREPORTKEY, out KREPORT Value)
        {
            return Index_KREPORTKEY.Value.TryGetValue(KREPORTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KREPORT by KREPORTKEY field
        /// </summary>
        /// <param name="KREPORTKEY">KREPORTKEY value used to find KREPORT</param>
        /// <returns>Related KREPORT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KREPORT TryFindByKREPORTKEY(string KREPORTKEY)
        {
            KREPORT value;
            if (Index_KREPORTKEY.Value.TryGetValue(KREPORTKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KREPORT by ROLE_CODE field
        /// </summary>
        /// <param name="ROLE_CODE">ROLE_CODE value used to find KREPORT</param>
        /// <returns>List of related KREPORT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KREPORT> FindByROLE_CODE(string ROLE_CODE)
        {
            return Index_ROLE_CODE.Value[ROLE_CODE];
        }

        /// <summary>
        /// Attempt to find KREPORT by ROLE_CODE field
        /// </summary>
        /// <param name="ROLE_CODE">ROLE_CODE value used to find KREPORT</param>
        /// <param name="Value">List of related KREPORT entities</param>
        /// <returns>True if the list of related KREPORT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROLE_CODE(string ROLE_CODE, out IReadOnlyList<KREPORT> Value)
        {
            return Index_ROLE_CODE.Value.TryGetValue(ROLE_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find KREPORT by ROLE_CODE field
        /// </summary>
        /// <param name="ROLE_CODE">ROLE_CODE value used to find KREPORT</param>
        /// <returns>List of related KREPORT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KREPORT> TryFindByROLE_CODE(string ROLE_CODE)
        {
            IReadOnlyList<KREPORT> value;
            if (Index_ROLE_CODE.Value.TryGetValue(ROLE_CODE, out value))
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
