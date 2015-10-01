using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Absence Types Data Set
    /// </summary>
    public sealed class TCATDataSet : SetBase<TCAT>
    {
        private Lazy<Dictionary<string, TCAT>> TCATKEYIndex;

        internal TCATDataSet(EduHubContext Context)
            : base(Context)
        {
            TCATKEYIndex = new Lazy<Dictionary<string, TCAT>>(() => this.ToDictionary(e => e.TCATKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TCAT"; } }

        /// <summary>
        /// Find TCAT by TCATKEY key field
        /// </summary>
        /// <param name="Key">TCATKEY value used to find TCAT</param>
        /// <returns>Related TCAT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TCATKEY value didn't match any TCAT entities</exception>
        public TCAT FindByTCATKEY(string Key)
        {
            TCAT result;
            if (TCATKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find TCAT by TCATKEY key field
        /// </summary>
        /// <param name="Key">TCATKEY value used to find TCAT</param>
        /// <param name="Value">Related TCAT entity</param>
        /// <returns>True if the TCAT entity is found</returns>
        public bool TryFindByTCATKEY(string Key, out TCAT Value)
        {
            return TCATKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find TCAT by TCATKEY key field
        /// </summary>
        /// <param name="Key">TCATKEY value used to find TCAT</param>
        /// <returns>Related TCAT entity, or null if not found</returns>
        public TCAT TryFindByTCATKEY(string Key)
        {
            TCAT result;
            if (TCATKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
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
    }
}
