using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject Classes Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCLDataSet : SetBase<SCL>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCL"; } }

        internal SCLDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SCLKEY = new Lazy<Dictionary<string, SCL>>(() => this.ToDictionary(i => i.SCLKEY));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<SCL>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_QUILT_SUBJECT_CLASS = new Lazy<Dictionary<Tuple<string, string, short?>, SCL>>(() => this.ToDictionary(i => Tuple.Create(i.QUILT, i.SUBJECT, i.CLASS)));
            Index_QUILT = new Lazy<NullDictionary<string, IReadOnlyList<SCL>>>(() => this.ToGroupedNullDictionary(i => i.QUILT));
            Index_SUBJECT = new Lazy<NullDictionary<string, IReadOnlyList<SCL>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT));
            Index_TEACHER01 = new Lazy<NullDictionary<string, IReadOnlyList<SCL>>>(() => this.ToGroupedNullDictionary(i => i.TEACHER01));
            Index_TEACHER02 = new Lazy<NullDictionary<string, IReadOnlyList<SCL>>>(() => this.ToGroupedNullDictionary(i => i.TEACHER02));
            Index_ROOM01 = new Lazy<NullDictionary<string, IReadOnlyList<SCL>>>(() => this.ToGroupedNullDictionary(i => i.ROOM01));
            Index_ROOM02 = new Lazy<NullDictionary<string, IReadOnlyList<SCL>>>(() => this.ToGroupedNullDictionary(i => i.ROOM02));
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<SCL>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCL" /> fields for each CSV column header</returns>
        protected override Action<SCL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCLKEY":
                        mapper[i] = (e, v) => e.SCLKEY = v;
                        break;
                    case "QUILT":
                        mapper[i] = (e, v) => e.QUILT = v;
                        break;
                    case "SUBJECT":
                        mapper[i] = (e, v) => e.SUBJECT = v;
                        break;
                    case "CLASS":
                        mapper[i] = (e, v) => e.CLASS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHER01":
                        mapper[i] = (e, v) => e.TEACHER01 = v;
                        break;
                    case "TEACHER02":
                        mapper[i] = (e, v) => e.TEACHER02 = v;
                        break;
                    case "ROOM01":
                        mapper[i] = (e, v) => e.ROOM01 = v;
                        break;
                    case "ROOM02":
                        mapper[i] = (e, v) => e.ROOM02 = v;
                        break;
                    case "FREQUENCY":
                        mapper[i] = (e, v) => e.FREQUENCY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PRINT_FLAGS01":
                        mapper[i] = (e, v) => e.PRINT_FLAGS01 = v;
                        break;
                    case "PRINT_FLAGS02":
                        mapper[i] = (e, v) => e.PRINT_FLAGS02 = v;
                        break;
                    case "PRINT_FLAGS03":
                        mapper[i] = (e, v) => e.PRINT_FLAGS03 = v;
                        break;
                    case "PERIOD_ABSENCES":
                        mapper[i] = (e, v) => e.PERIOD_ABSENCES = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ALIAS":
                        mapper[i] = (e, v) => e.ALIAS = v;
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

        private Lazy<Dictionary<string, SCL>> Index_SCLKEY;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<SCL>>> Index_LW_DATE;
        private Lazy<Dictionary<Tuple<string, string, short?>, SCL>> Index_QUILT_SUBJECT_CLASS;
        private Lazy<NullDictionary<string, IReadOnlyList<SCL>>> Index_QUILT;
        private Lazy<NullDictionary<string, IReadOnlyList<SCL>>> Index_SUBJECT;
        private Lazy<NullDictionary<string, IReadOnlyList<SCL>>> Index_TEACHER01;
        private Lazy<NullDictionary<string, IReadOnlyList<SCL>>> Index_TEACHER02;
        private Lazy<NullDictionary<string, IReadOnlyList<SCL>>> Index_ROOM01;
        private Lazy<NullDictionary<string, IReadOnlyList<SCL>>> Index_ROOM02;
        private Lazy<NullDictionary<int?, IReadOnlyList<SCL>>> Index_CAMPUS;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCL by SCLKEY field
        /// </summary>
        /// <param name="SCLKEY">SCLKEY value used to find SCL</param>
        /// <returns>Related SCL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCL FindBySCLKEY(string SCLKEY)
        {
            return Index_SCLKEY.Value[SCLKEY];
        }

        /// <summary>
        /// Attempt to find SCL by SCLKEY field
        /// </summary>
        /// <param name="SCLKEY">SCLKEY value used to find SCL</param>
        /// <param name="Value">Related SCL entity</param>
        /// <returns>True if the related SCL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCLKEY(string SCLKEY, out SCL Value)
        {
            return Index_SCLKEY.Value.TryGetValue(SCLKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SCL by SCLKEY field
        /// </summary>
        /// <param name="SCLKEY">SCLKEY value used to find SCL</param>
        /// <returns>Related SCL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCL TryFindBySCLKEY(string SCLKEY)
        {
            SCL value;
            if (Index_SCLKEY.Value.TryGetValue(SCLKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCL by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SCL</param>
        /// <returns>List of related SCL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find SCL by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SCL</param>
        /// <param name="Value">List of related SCL entities</param>
        /// <returns>True if the list of related SCL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<SCL> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find SCL by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SCL</param>
        /// <returns>List of related SCL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<SCL> value;
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
        /// Find SCL by QUILT, SUBJECT and CLASS fields
        /// </summary>
        /// <param name="QUILT">QUILT value used to find SCL</param>
        /// <param name="SUBJECT">SUBJECT value used to find SCL</param>
        /// <param name="CLASS">CLASS value used to find SCL</param>
        /// <returns>Related SCL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCL FindByQUILT_SUBJECT_CLASS(string QUILT, string SUBJECT, short? CLASS)
        {
            return Index_QUILT_SUBJECT_CLASS.Value[Tuple.Create(QUILT, SUBJECT, CLASS)];
        }

        /// <summary>
        /// Attempt to find SCL by QUILT, SUBJECT and CLASS fields
        /// </summary>
        /// <param name="QUILT">QUILT value used to find SCL</param>
        /// <param name="SUBJECT">SUBJECT value used to find SCL</param>
        /// <param name="CLASS">CLASS value used to find SCL</param>
        /// <param name="Value">Related SCL entity</param>
        /// <returns>True if the related SCL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByQUILT_SUBJECT_CLASS(string QUILT, string SUBJECT, short? CLASS, out SCL Value)
        {
            return Index_QUILT_SUBJECT_CLASS.Value.TryGetValue(Tuple.Create(QUILT, SUBJECT, CLASS), out Value);
        }

        /// <summary>
        /// Attempt to find SCL by QUILT, SUBJECT and CLASS fields
        /// </summary>
        /// <param name="QUILT">QUILT value used to find SCL</param>
        /// <param name="SUBJECT">SUBJECT value used to find SCL</param>
        /// <param name="CLASS">CLASS value used to find SCL</param>
        /// <returns>Related SCL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCL TryFindByQUILT_SUBJECT_CLASS(string QUILT, string SUBJECT, short? CLASS)
        {
            SCL value;
            if (Index_QUILT_SUBJECT_CLASS.Value.TryGetValue(Tuple.Create(QUILT, SUBJECT, CLASS), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCL by QUILT field
        /// </summary>
        /// <param name="QUILT">QUILT value used to find SCL</param>
        /// <returns>List of related SCL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> FindByQUILT(string QUILT)
        {
            return Index_QUILT.Value[QUILT];
        }

        /// <summary>
        /// Attempt to find SCL by QUILT field
        /// </summary>
        /// <param name="QUILT">QUILT value used to find SCL</param>
        /// <param name="Value">List of related SCL entities</param>
        /// <returns>True if the list of related SCL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByQUILT(string QUILT, out IReadOnlyList<SCL> Value)
        {
            return Index_QUILT.Value.TryGetValue(QUILT, out Value);
        }

        /// <summary>
        /// Attempt to find SCL by QUILT field
        /// </summary>
        /// <param name="QUILT">QUILT value used to find SCL</param>
        /// <returns>List of related SCL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> TryFindByQUILT(string QUILT)
        {
            IReadOnlyList<SCL> value;
            if (Index_QUILT.Value.TryGetValue(QUILT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCL by SUBJECT field
        /// </summary>
        /// <param name="SUBJECT">SUBJECT value used to find SCL</param>
        /// <returns>List of related SCL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> FindBySUBJECT(string SUBJECT)
        {
            return Index_SUBJECT.Value[SUBJECT];
        }

        /// <summary>
        /// Attempt to find SCL by SUBJECT field
        /// </summary>
        /// <param name="SUBJECT">SUBJECT value used to find SCL</param>
        /// <param name="Value">List of related SCL entities</param>
        /// <returns>True if the list of related SCL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT(string SUBJECT, out IReadOnlyList<SCL> Value)
        {
            return Index_SUBJECT.Value.TryGetValue(SUBJECT, out Value);
        }

        /// <summary>
        /// Attempt to find SCL by SUBJECT field
        /// </summary>
        /// <param name="SUBJECT">SUBJECT value used to find SCL</param>
        /// <returns>List of related SCL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> TryFindBySUBJECT(string SUBJECT)
        {
            IReadOnlyList<SCL> value;
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
        /// Find SCL by TEACHER01 field
        /// </summary>
        /// <param name="TEACHER01">TEACHER01 value used to find SCL</param>
        /// <returns>List of related SCL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> FindByTEACHER01(string TEACHER01)
        {
            return Index_TEACHER01.Value[TEACHER01];
        }

        /// <summary>
        /// Attempt to find SCL by TEACHER01 field
        /// </summary>
        /// <param name="TEACHER01">TEACHER01 value used to find SCL</param>
        /// <param name="Value">List of related SCL entities</param>
        /// <returns>True if the list of related SCL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACHER01(string TEACHER01, out IReadOnlyList<SCL> Value)
        {
            return Index_TEACHER01.Value.TryGetValue(TEACHER01, out Value);
        }

        /// <summary>
        /// Attempt to find SCL by TEACHER01 field
        /// </summary>
        /// <param name="TEACHER01">TEACHER01 value used to find SCL</param>
        /// <returns>List of related SCL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> TryFindByTEACHER01(string TEACHER01)
        {
            IReadOnlyList<SCL> value;
            if (Index_TEACHER01.Value.TryGetValue(TEACHER01, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCL by TEACHER02 field
        /// </summary>
        /// <param name="TEACHER02">TEACHER02 value used to find SCL</param>
        /// <returns>List of related SCL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> FindByTEACHER02(string TEACHER02)
        {
            return Index_TEACHER02.Value[TEACHER02];
        }

        /// <summary>
        /// Attempt to find SCL by TEACHER02 field
        /// </summary>
        /// <param name="TEACHER02">TEACHER02 value used to find SCL</param>
        /// <param name="Value">List of related SCL entities</param>
        /// <returns>True if the list of related SCL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACHER02(string TEACHER02, out IReadOnlyList<SCL> Value)
        {
            return Index_TEACHER02.Value.TryGetValue(TEACHER02, out Value);
        }

        /// <summary>
        /// Attempt to find SCL by TEACHER02 field
        /// </summary>
        /// <param name="TEACHER02">TEACHER02 value used to find SCL</param>
        /// <returns>List of related SCL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> TryFindByTEACHER02(string TEACHER02)
        {
            IReadOnlyList<SCL> value;
            if (Index_TEACHER02.Value.TryGetValue(TEACHER02, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCL by ROOM01 field
        /// </summary>
        /// <param name="ROOM01">ROOM01 value used to find SCL</param>
        /// <returns>List of related SCL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> FindByROOM01(string ROOM01)
        {
            return Index_ROOM01.Value[ROOM01];
        }

        /// <summary>
        /// Attempt to find SCL by ROOM01 field
        /// </summary>
        /// <param name="ROOM01">ROOM01 value used to find SCL</param>
        /// <param name="Value">List of related SCL entities</param>
        /// <returns>True if the list of related SCL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROOM01(string ROOM01, out IReadOnlyList<SCL> Value)
        {
            return Index_ROOM01.Value.TryGetValue(ROOM01, out Value);
        }

        /// <summary>
        /// Attempt to find SCL by ROOM01 field
        /// </summary>
        /// <param name="ROOM01">ROOM01 value used to find SCL</param>
        /// <returns>List of related SCL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> TryFindByROOM01(string ROOM01)
        {
            IReadOnlyList<SCL> value;
            if (Index_ROOM01.Value.TryGetValue(ROOM01, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCL by ROOM02 field
        /// </summary>
        /// <param name="ROOM02">ROOM02 value used to find SCL</param>
        /// <returns>List of related SCL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> FindByROOM02(string ROOM02)
        {
            return Index_ROOM02.Value[ROOM02];
        }

        /// <summary>
        /// Attempt to find SCL by ROOM02 field
        /// </summary>
        /// <param name="ROOM02">ROOM02 value used to find SCL</param>
        /// <param name="Value">List of related SCL entities</param>
        /// <returns>True if the list of related SCL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROOM02(string ROOM02, out IReadOnlyList<SCL> Value)
        {
            return Index_ROOM02.Value.TryGetValue(ROOM02, out Value);
        }

        /// <summary>
        /// Attempt to find SCL by ROOM02 field
        /// </summary>
        /// <param name="ROOM02">ROOM02 value used to find SCL</param>
        /// <returns>List of related SCL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> TryFindByROOM02(string ROOM02)
        {
            IReadOnlyList<SCL> value;
            if (Index_ROOM02.Value.TryGetValue(ROOM02, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCL by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SCL</param>
        /// <returns>List of related SCL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> FindByCAMPUS(int? CAMPUS)
        {
            return Index_CAMPUS.Value[CAMPUS];
        }

        /// <summary>
        /// Attempt to find SCL by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SCL</param>
        /// <param name="Value">List of related SCL entities</param>
        /// <returns>True if the list of related SCL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAMPUS(int? CAMPUS, out IReadOnlyList<SCL> Value)
        {
            return Index_CAMPUS.Value.TryGetValue(CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find SCL by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SCL</param>
        /// <returns>List of related SCL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCL> TryFindByCAMPUS(int? CAMPUS)
        {
            IReadOnlyList<SCL> value;
            if (Index_CAMPUS.Value.TryGetValue(CAMPUS, out value))
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
