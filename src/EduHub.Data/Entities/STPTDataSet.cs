using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Part-Time Enrolments Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STPTDataSet : SetBase<STPT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "STPT"; } }

        internal STPTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_STPTKEY = new Lazy<Dictionary<string, IReadOnlyList<STPT>>>(() => this.ToGroupedDictionary(i => i.STPTKEY));
            Index_TID = new Lazy<Dictionary<int, STPT>>(() => this.ToDictionary(i => i.TID));
            Index_STPTKEY_SCHL_NUM = new Lazy<Dictionary<Tuple<string, string>, STPT>>(() => this.ToDictionary(i => Tuple.Create(i.STPTKEY, i.SCHL_NUM)));
            Index_SCHL_NUM = new Lazy<NullDictionary<string, IReadOnlyList<STPT>>>(() => this.ToGroupedNullDictionary(i => i.SCHL_NUM));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STPT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STPT" /> fields for each CSV column header</returns>
        protected override Action<STPT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STPT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "STPTKEY":
                        mapper[i] = (e, v) => e.STPTKEY = v;
                        break;
                    case "SCHL_NUM":
                        mapper[i] = (e, v) => e.SCHL_NUM = v;
                        break;
                    case "SGB_TIME_FRACTION":
                        mapper[i] = (e, v) => e.SGB_TIME_FRACTION = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ACTUAL_TIME_FRACTION":
                        mapper[i] = (e, v) => e.ACTUAL_TIME_FRACTION = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ENROLLED":
                        mapper[i] = (e, v) => e.ENROLLED = v;
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

        private Lazy<Dictionary<string, IReadOnlyList<STPT>>> Index_STPTKEY;
        private Lazy<Dictionary<int, STPT>> Index_TID;
        private Lazy<Dictionary<Tuple<string, string>, STPT>> Index_STPTKEY_SCHL_NUM;
        private Lazy<NullDictionary<string, IReadOnlyList<STPT>>> Index_SCHL_NUM;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STPT by STPTKEY field
        /// </summary>
        /// <param name="STPTKEY">STPTKEY value used to find STPT</param>
        /// <returns>List of related STPT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STPT> FindBySTPTKEY(string STPTKEY)
        {
            return Index_STPTKEY.Value[STPTKEY];
        }

        /// <summary>
        /// Attempt to find STPT by STPTKEY field
        /// </summary>
        /// <param name="STPTKEY">STPTKEY value used to find STPT</param>
        /// <param name="Value">List of related STPT entities</param>
        /// <returns>True if the list of related STPT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTPTKEY(string STPTKEY, out IReadOnlyList<STPT> Value)
        {
            return Index_STPTKEY.Value.TryGetValue(STPTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STPT by STPTKEY field
        /// </summary>
        /// <param name="STPTKEY">STPTKEY value used to find STPT</param>
        /// <returns>List of related STPT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STPT> TryFindBySTPTKEY(string STPTKEY)
        {
            IReadOnlyList<STPT> value;
            if (Index_STPTKEY.Value.TryGetValue(STPTKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STPT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STPT</param>
        /// <returns>Related STPT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STPT FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STPT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STPT</param>
        /// <param name="Value">Related STPT entity</param>
        /// <returns>True if the related STPT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STPT Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STPT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STPT</param>
        /// <returns>Related STPT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STPT TryFindByTID(int TID)
        {
            STPT value;
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
        /// Find STPT by STPTKEY and SCHL_NUM fields
        /// </summary>
        /// <param name="STPTKEY">STPTKEY value used to find STPT</param>
        /// <param name="SCHL_NUM">SCHL_NUM value used to find STPT</param>
        /// <returns>Related STPT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STPT FindBySTPTKEY_SCHL_NUM(string STPTKEY, string SCHL_NUM)
        {
            return Index_STPTKEY_SCHL_NUM.Value[Tuple.Create(STPTKEY, SCHL_NUM)];
        }

        /// <summary>
        /// Attempt to find STPT by STPTKEY and SCHL_NUM fields
        /// </summary>
        /// <param name="STPTKEY">STPTKEY value used to find STPT</param>
        /// <param name="SCHL_NUM">SCHL_NUM value used to find STPT</param>
        /// <param name="Value">Related STPT entity</param>
        /// <returns>True if the related STPT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTPTKEY_SCHL_NUM(string STPTKEY, string SCHL_NUM, out STPT Value)
        {
            return Index_STPTKEY_SCHL_NUM.Value.TryGetValue(Tuple.Create(STPTKEY, SCHL_NUM), out Value);
        }

        /// <summary>
        /// Attempt to find STPT by STPTKEY and SCHL_NUM fields
        /// </summary>
        /// <param name="STPTKEY">STPTKEY value used to find STPT</param>
        /// <param name="SCHL_NUM">SCHL_NUM value used to find STPT</param>
        /// <returns>Related STPT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STPT TryFindBySTPTKEY_SCHL_NUM(string STPTKEY, string SCHL_NUM)
        {
            STPT value;
            if (Index_STPTKEY_SCHL_NUM.Value.TryGetValue(Tuple.Create(STPTKEY, SCHL_NUM), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STPT by SCHL_NUM field
        /// </summary>
        /// <param name="SCHL_NUM">SCHL_NUM value used to find STPT</param>
        /// <returns>List of related STPT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STPT> FindBySCHL_NUM(string SCHL_NUM)
        {
            return Index_SCHL_NUM.Value[SCHL_NUM];
        }

        /// <summary>
        /// Attempt to find STPT by SCHL_NUM field
        /// </summary>
        /// <param name="SCHL_NUM">SCHL_NUM value used to find STPT</param>
        /// <param name="Value">List of related STPT entities</param>
        /// <returns>True if the list of related STPT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCHL_NUM(string SCHL_NUM, out IReadOnlyList<STPT> Value)
        {
            return Index_SCHL_NUM.Value.TryGetValue(SCHL_NUM, out Value);
        }

        /// <summary>
        /// Attempt to find STPT by SCHL_NUM field
        /// </summary>
        /// <param name="SCHL_NUM">SCHL_NUM value used to find STPT</param>
        /// <returns>List of related STPT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STPT> TryFindBySCHL_NUM(string SCHL_NUM)
        {
            IReadOnlyList<STPT> value;
            if (Index_SCHL_NUM.Value.TryGetValue(SCHL_NUM, out value))
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
