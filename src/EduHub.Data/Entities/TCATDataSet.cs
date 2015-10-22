using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Absence Types Data Set
    /// </summary>
    public sealed partial class TCATDataSet : SetBase<TCAT>
    {
        private Lazy<Dictionary<string, TCAT>> TCATKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<TCTB>>> TCTB_ABSENCE_TYPEForeignIndex;

        internal TCATDataSet(EduHubContext Context)
            : base(Context)
        {
            TCATKEYIndex = new Lazy<Dictionary<string, TCAT>>(() => this.ToDictionary(e => e.TCATKEY));

            TCTB_ABSENCE_TYPEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TCTB>>>(() =>
                    Context.TCTB
                          .Where(e => e.ABSENCE_TYPE != null)
                          .GroupBy(e => e.ABSENCE_TYPE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TCTB>)g.ToList()
                          .AsReadOnly()));

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
        /// Find all TCTB (Teacher Absences) entities by [TCTB.ABSENCE_TYPE]-&gt;[TCAT.TCATKEY]
        /// </summary>
        /// <param name="TCATKEY">TCATKEY value used to find TCTB entities</param>
        /// <returns>A list of related TCTB entities</returns>
        public IReadOnlyList<TCTB> FindTCTBByABSENCE_TYPE(string TCATKEY)
        {
            IReadOnlyList<TCTB> result;
            if (TCTB_ABSENCE_TYPEForeignIndex.Value.TryGetValue(TCATKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TCTB>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TCTB entities by [TCTB.ABSENCE_TYPE]-&gt;[TCAT.TCATKEY]
        /// </summary>
        /// <param name="TCATKEY">TCATKEY value used to find TCTB entities</param>
        /// <param name="Value">A list of related TCTB entities</param>
        /// <returns>True if any TCTB entities are found</returns>
        public bool TryFindTCTBByABSENCE_TYPE(string TCATKEY, out IReadOnlyList<TCTB> Value)
        {
            return TCTB_ABSENCE_TYPEForeignIndex.Value.TryGetValue(TCATKEY, out Value);
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
