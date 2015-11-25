using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Notes Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KNDataSet : SetBase<KN>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KN"; } }

        internal KNDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_NOTE_ID = new Lazy<Dictionary<string, KN>>(() => this.ToDictionary(i => i.NOTE_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KN" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KN" /> fields for each CSV column header</returns>
        protected override Action<KN, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KN, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "NOTE_ID":
                        mapper[i] = (e, v) => e.NOTE_ID = v;
                        break;
                    case "CONTENTS":
                        mapper[i] = (e, v) => e.CONTENTS = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "SCOPE":
                        mapper[i] = (e, v) => e.SCOPE = v;
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

        private Lazy<Dictionary<string, KN>> Index_NOTE_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KN by NOTE_ID field
        /// </summary>
        /// <param name="NOTE_ID">NOTE_ID value used to find KN</param>
        /// <returns>Related KN entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KN FindByNOTE_ID(string NOTE_ID)
        {
            return Index_NOTE_ID.Value[NOTE_ID];
        }

        /// <summary>
        /// Attempt to find KN by NOTE_ID field
        /// </summary>
        /// <param name="NOTE_ID">NOTE_ID value used to find KN</param>
        /// <param name="Value">Related KN entity</param>
        /// <returns>True if the related KN entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByNOTE_ID(string NOTE_ID, out KN Value)
        {
            return Index_NOTE_ID.Value.TryGetValue(NOTE_ID, out Value);
        }

        /// <summary>
        /// Attempt to find KN by NOTE_ID field
        /// </summary>
        /// <param name="NOTE_ID">NOTE_ID value used to find KN</param>
        /// <returns>Related KN entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KN TryFindByNOTE_ID(string NOTE_ID)
        {
            KN value;
            if (Index_NOTE_ID.Value.TryGetValue(NOTE_ID, out value))
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
