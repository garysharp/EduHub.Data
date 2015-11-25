using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Specialist Subjects per Home Group Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SSHGDataSet : SetBase<SSHG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SSHG"; } }

        internal SSHGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SUBJECT = new Lazy<Dictionary<string, IReadOnlyList<SSHG>>>(() => this.ToGroupedDictionary(i => i.SUBJECT));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<SSHG>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_TID = new Lazy<Dictionary<int, SSHG>>(() => this.ToDictionary(i => i.TID));
            Index_HOMEGROUP = new Lazy<NullDictionary<string, IReadOnlyList<SSHG>>>(() => this.ToGroupedNullDictionary(i => i.HOMEGROUP));
            Index_TEACHER = new Lazy<NullDictionary<string, IReadOnlyList<SSHG>>>(() => this.ToGroupedNullDictionary(i => i.TEACHER));
            Index_STUDENT = new Lazy<NullDictionary<string, IReadOnlyList<SSHG>>>(() => this.ToGroupedNullDictionary(i => i.STUDENT));
            Index_TEACHING_HG = new Lazy<NullDictionary<string, IReadOnlyList<SSHG>>>(() => this.ToGroupedNullDictionary(i => i.TEACHING_HG));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SSHG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SSHG" /> fields for each CSV column header</returns>
        protected override Action<SSHG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SSHG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "HOMEGROUP":
                        mapper[i] = (e, v) => e.HOMEGROUP = v;
                        break;
                    case "SUBJECT":
                        mapper[i] = (e, v) => e.SUBJECT = v;
                        break;
                    case "TEACHER":
                        mapper[i] = (e, v) => e.TEACHER = v;
                        break;
                    case "STUDENT":
                        mapper[i] = (e, v) => e.STUDENT = v;
                        break;
                    case "VARIATION":
                        mapper[i] = (e, v) => e.VARIATION = v;
                        break;
                    case "TEACHING_HG":
                        mapper[i] = (e, v) => e.TEACHING_HG = v;
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

        private Lazy<Dictionary<string, IReadOnlyList<SSHG>>> Index_SUBJECT;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<SSHG>>> Index_LW_DATE;
        private Lazy<Dictionary<int, SSHG>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<SSHG>>> Index_HOMEGROUP;
        private Lazy<NullDictionary<string, IReadOnlyList<SSHG>>> Index_TEACHER;
        private Lazy<NullDictionary<string, IReadOnlyList<SSHG>>> Index_STUDENT;
        private Lazy<NullDictionary<string, IReadOnlyList<SSHG>>> Index_TEACHING_HG;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SSHG by SUBJECT field
        /// </summary>
        /// <param name="SUBJECT">SUBJECT value used to find SSHG</param>
        /// <returns>List of related SSHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> FindBySUBJECT(string SUBJECT)
        {
            return Index_SUBJECT.Value[SUBJECT];
        }

        /// <summary>
        /// Attempt to find SSHG by SUBJECT field
        /// </summary>
        /// <param name="SUBJECT">SUBJECT value used to find SSHG</param>
        /// <param name="Value">List of related SSHG entities</param>
        /// <returns>True if the list of related SSHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT(string SUBJECT, out IReadOnlyList<SSHG> Value)
        {
            return Index_SUBJECT.Value.TryGetValue(SUBJECT, out Value);
        }

        /// <summary>
        /// Attempt to find SSHG by SUBJECT field
        /// </summary>
        /// <param name="SUBJECT">SUBJECT value used to find SSHG</param>
        /// <returns>List of related SSHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> TryFindBySUBJECT(string SUBJECT)
        {
            IReadOnlyList<SSHG> value;
            if (Index_SUBJECT.Value.TryGetValue(SUBJECT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SSHG by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SSHG</param>
        /// <returns>List of related SSHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find SSHG by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SSHG</param>
        /// <param name="Value">List of related SSHG entities</param>
        /// <returns>True if the list of related SSHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<SSHG> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find SSHG by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SSHG</param>
        /// <returns>List of related SSHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<SSHG> value;
            if (Index_LW_DATE.Value.TryGetValue(LW_DATE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SSHG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SSHG</param>
        /// <returns>Related SSHG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SSHG FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SSHG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SSHG</param>
        /// <param name="Value">Related SSHG entity</param>
        /// <returns>True if the related SSHG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SSHG Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SSHG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SSHG</param>
        /// <returns>Related SSHG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SSHG TryFindByTID(int TID)
        {
            SSHG value;
            if (Index_TID.Value.TryGetValue(TID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SSHG by HOMEGROUP field
        /// </summary>
        /// <param name="HOMEGROUP">HOMEGROUP value used to find SSHG</param>
        /// <returns>List of related SSHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> FindByHOMEGROUP(string HOMEGROUP)
        {
            return Index_HOMEGROUP.Value[HOMEGROUP];
        }

        /// <summary>
        /// Attempt to find SSHG by HOMEGROUP field
        /// </summary>
        /// <param name="HOMEGROUP">HOMEGROUP value used to find SSHG</param>
        /// <param name="Value">List of related SSHG entities</param>
        /// <returns>True if the list of related SSHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByHOMEGROUP(string HOMEGROUP, out IReadOnlyList<SSHG> Value)
        {
            return Index_HOMEGROUP.Value.TryGetValue(HOMEGROUP, out Value);
        }

        /// <summary>
        /// Attempt to find SSHG by HOMEGROUP field
        /// </summary>
        /// <param name="HOMEGROUP">HOMEGROUP value used to find SSHG</param>
        /// <returns>List of related SSHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> TryFindByHOMEGROUP(string HOMEGROUP)
        {
            IReadOnlyList<SSHG> value;
            if (Index_HOMEGROUP.Value.TryGetValue(HOMEGROUP, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SSHG by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find SSHG</param>
        /// <returns>List of related SSHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> FindByTEACHER(string TEACHER)
        {
            return Index_TEACHER.Value[TEACHER];
        }

        /// <summary>
        /// Attempt to find SSHG by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find SSHG</param>
        /// <param name="Value">List of related SSHG entities</param>
        /// <returns>True if the list of related SSHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACHER(string TEACHER, out IReadOnlyList<SSHG> Value)
        {
            return Index_TEACHER.Value.TryGetValue(TEACHER, out Value);
        }

        /// <summary>
        /// Attempt to find SSHG by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find SSHG</param>
        /// <returns>List of related SSHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> TryFindByTEACHER(string TEACHER)
        {
            IReadOnlyList<SSHG> value;
            if (Index_TEACHER.Value.TryGetValue(TEACHER, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SSHG by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find SSHG</param>
        /// <returns>List of related SSHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> FindBySTUDENT(string STUDENT)
        {
            return Index_STUDENT.Value[STUDENT];
        }

        /// <summary>
        /// Attempt to find SSHG by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find SSHG</param>
        /// <param name="Value">List of related SSHG entities</param>
        /// <returns>True if the list of related SSHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTUDENT(string STUDENT, out IReadOnlyList<SSHG> Value)
        {
            return Index_STUDENT.Value.TryGetValue(STUDENT, out Value);
        }

        /// <summary>
        /// Attempt to find SSHG by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find SSHG</param>
        /// <returns>List of related SSHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> TryFindBySTUDENT(string STUDENT)
        {
            IReadOnlyList<SSHG> value;
            if (Index_STUDENT.Value.TryGetValue(STUDENT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SSHG by TEACHING_HG field
        /// </summary>
        /// <param name="TEACHING_HG">TEACHING_HG value used to find SSHG</param>
        /// <returns>List of related SSHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> FindByTEACHING_HG(string TEACHING_HG)
        {
            return Index_TEACHING_HG.Value[TEACHING_HG];
        }

        /// <summary>
        /// Attempt to find SSHG by TEACHING_HG field
        /// </summary>
        /// <param name="TEACHING_HG">TEACHING_HG value used to find SSHG</param>
        /// <param name="Value">List of related SSHG entities</param>
        /// <returns>True if the list of related SSHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACHING_HG(string TEACHING_HG, out IReadOnlyList<SSHG> Value)
        {
            return Index_TEACHING_HG.Value.TryGetValue(TEACHING_HG, out Value);
        }

        /// <summary>
        /// Attempt to find SSHG by TEACHING_HG field
        /// </summary>
        /// <param name="TEACHING_HG">TEACHING_HG value used to find SSHG</param>
        /// <returns>List of related SSHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> TryFindByTEACHING_HG(string TEACHING_HG)
        {
            IReadOnlyList<SSHG> value;
            if (Index_TEACHING_HG.Value.TryGetValue(TEACHING_HG, out value))
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
