using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Qualifications Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SFQADataSet : SetBase<SFQA>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SFQA"; } }

        internal SFQADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TEACH = new Lazy<Dictionary<string, IReadOnlyList<SFQA>>>(() => this.ToGroupedDictionary(i => i.TEACH));
            Index_TID = new Lazy<Dictionary<int, SFQA>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SFQA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SFQA" /> fields for each CSV column header</returns>
        protected override Action<SFQA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SFQA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "TEACH":
                        mapper[i] = (e, v) => e.TEACH = v;
                        break;
                    case "QUALIFICATION":
                        mapper[i] = (e, v) => e.QUALIFICATION = v;
                        break;
                    case "YEAR_COMPLETED":
                        mapper[i] = (e, v) => e.YEAR_COMPLETED = v;
                        break;
                    case "INSTITUTION":
                        mapper[i] = (e, v) => e.INSTITUTION = v;
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

        private Lazy<Dictionary<string, IReadOnlyList<SFQA>>> Index_TEACH;
        private Lazy<Dictionary<int, SFQA>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SFQA by TEACH field
        /// </summary>
        /// <param name="TEACH">TEACH value used to find SFQA</param>
        /// <returns>List of related SFQA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SFQA> FindByTEACH(string TEACH)
        {
            return Index_TEACH.Value[TEACH];
        }

        /// <summary>
        /// Attempt to find SFQA by TEACH field
        /// </summary>
        /// <param name="TEACH">TEACH value used to find SFQA</param>
        /// <param name="Value">List of related SFQA entities</param>
        /// <returns>True if the list of related SFQA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACH(string TEACH, out IReadOnlyList<SFQA> Value)
        {
            return Index_TEACH.Value.TryGetValue(TEACH, out Value);
        }

        /// <summary>
        /// Attempt to find SFQA by TEACH field
        /// </summary>
        /// <param name="TEACH">TEACH value used to find SFQA</param>
        /// <returns>List of related SFQA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SFQA> TryFindByTEACH(string TEACH)
        {
            IReadOnlyList<SFQA> value;
            if (Index_TEACH.Value.TryGetValue(TEACH, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SFQA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SFQA</param>
        /// <returns>Related SFQA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SFQA FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SFQA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SFQA</param>
        /// <param name="Value">Related SFQA entity</param>
        /// <returns>True if the related SFQA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SFQA Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SFQA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SFQA</param>
        /// <returns>Related SFQA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SFQA TryFindByTID(int TID)
        {
            SFQA value;
            if (Index_TID.Value.TryGetValue(TID, out value))
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
