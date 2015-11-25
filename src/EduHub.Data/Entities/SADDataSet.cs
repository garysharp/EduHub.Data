using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accidents Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SADDataSet : SetBase<SAD>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SAD"; } }

        internal SADDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_AREA_DUTY_TEACHER = new Lazy<NullDictionary<string, IReadOnlyList<SAD>>>(() => this.ToGroupedNullDictionary(i => i.AREA_DUTY_TEACHER));
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<SAD>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<SAD>>>(() => this.ToGroupedNullDictionary(i => i.ROOM));
            Index_SADKEY = new Lazy<Dictionary<int, SAD>>(() => this.ToDictionary(i => i.SADKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SAD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SAD" /> fields for each CSV column header</returns>
        protected override Action<SAD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SAD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SADKEY":
                        mapper[i] = (e, v) => e.SADKEY = int.Parse(v);
                        break;
                    case "DETAIL_OUTLINE":
                        mapper[i] = (e, v) => e.DETAIL_OUTLINE = v;
                        break;
                    case "ACCIDENT_DATE":
                        mapper[i] = (e, v) => e.ACCIDENT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ACCIDENT_TIME":
                        mapper[i] = (e, v) => e.ACCIDENT_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "GENERAL_ACTIVITY":
                        mapper[i] = (e, v) => e.GENERAL_ACTIVITY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DETAILED_ACTIVITY":
                        mapper[i] = (e, v) => e.DETAILED_ACTIVITY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OTHER_ACTIVITY_INFO":
                        mapper[i] = (e, v) => e.OTHER_ACTIVITY_INFO = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OTHER_DESC_INFO":
                        mapper[i] = (e, v) => e.OTHER_DESC_INFO = v;
                        break;
                    case "ACCIDENT_SITE":
                        mapper[i] = (e, v) => e.ACCIDENT_SITE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EXTERNAL_ADDRESS":
                        mapper[i] = (e, v) => e.EXTERNAL_ADDRESS = v;
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "AREA_DUTY_TEACHER":
                        mapper[i] = (e, v) => e.AREA_DUTY_TEACHER = v;
                        break;
                    case "DUTY_TEACHER_FULL_NAME":
                        mapper[i] = (e, v) => e.DUTY_TEACHER_FULL_NAME = v;
                        break;
                    case "TEACHERS_ON_DUTY":
                        mapper[i] = (e, v) => e.TEACHERS_ON_DUTY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CREATION_DATE":
                        mapper[i] = (e, v) => e.CREATION_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "MAILED":
                        mapper[i] = (e, v) => e.MAILED = v;
                        break;
                    case "FIRST_INJURED_PARTY":
                        mapper[i] = (e, v) => e.FIRST_INJURED_PARTY = v;
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

        /// <summary>
        /// Merges <see cref="SAD" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SAD" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SAD" /> items to added or update the base <see cref="SAD" /> items</param>
        /// <returns>A merged list of <see cref="SAD" /> items</returns>
        protected override List<SAD> ApplyDeltaItems(List<SAD> Items, List<SAD> DeltaItems)
        {
            Dictionary<int, int> Index_SADKEY = Items.ToIndexDictionary(i => i.SADKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SAD deltaItem in DeltaItems)
            {
                int index;

                if (Index_SADKEY.TryGetValue(deltaItem.SADKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SADKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<SAD>>> Index_AREA_DUTY_TEACHER;
        private Lazy<NullDictionary<int?, IReadOnlyList<SAD>>> Index_CAMPUS;
        private Lazy<NullDictionary<string, IReadOnlyList<SAD>>> Index_ROOM;
        private Lazy<Dictionary<int, SAD>> Index_SADKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SAD by AREA_DUTY_TEACHER field
        /// </summary>
        /// <param name="AREA_DUTY_TEACHER">AREA_DUTY_TEACHER value used to find SAD</param>
        /// <returns>List of related SAD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAD> FindByAREA_DUTY_TEACHER(string AREA_DUTY_TEACHER)
        {
            return Index_AREA_DUTY_TEACHER.Value[AREA_DUTY_TEACHER];
        }

        /// <summary>
        /// Attempt to find SAD by AREA_DUTY_TEACHER field
        /// </summary>
        /// <param name="AREA_DUTY_TEACHER">AREA_DUTY_TEACHER value used to find SAD</param>
        /// <param name="Value">List of related SAD entities</param>
        /// <returns>True if the list of related SAD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAREA_DUTY_TEACHER(string AREA_DUTY_TEACHER, out IReadOnlyList<SAD> Value)
        {
            return Index_AREA_DUTY_TEACHER.Value.TryGetValue(AREA_DUTY_TEACHER, out Value);
        }

        /// <summary>
        /// Attempt to find SAD by AREA_DUTY_TEACHER field
        /// </summary>
        /// <param name="AREA_DUTY_TEACHER">AREA_DUTY_TEACHER value used to find SAD</param>
        /// <returns>List of related SAD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAD> TryFindByAREA_DUTY_TEACHER(string AREA_DUTY_TEACHER)
        {
            IReadOnlyList<SAD> value;
            if (Index_AREA_DUTY_TEACHER.Value.TryGetValue(AREA_DUTY_TEACHER, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAD by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SAD</param>
        /// <returns>List of related SAD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAD> FindByCAMPUS(int? CAMPUS)
        {
            return Index_CAMPUS.Value[CAMPUS];
        }

        /// <summary>
        /// Attempt to find SAD by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SAD</param>
        /// <param name="Value">List of related SAD entities</param>
        /// <returns>True if the list of related SAD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAMPUS(int? CAMPUS, out IReadOnlyList<SAD> Value)
        {
            return Index_CAMPUS.Value.TryGetValue(CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find SAD by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SAD</param>
        /// <returns>List of related SAD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAD> TryFindByCAMPUS(int? CAMPUS)
        {
            IReadOnlyList<SAD> value;
            if (Index_CAMPUS.Value.TryGetValue(CAMPUS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAD by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SAD</param>
        /// <returns>List of related SAD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAD> FindByROOM(string ROOM)
        {
            return Index_ROOM.Value[ROOM];
        }

        /// <summary>
        /// Attempt to find SAD by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SAD</param>
        /// <param name="Value">List of related SAD entities</param>
        /// <returns>True if the list of related SAD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROOM(string ROOM, out IReadOnlyList<SAD> Value)
        {
            return Index_ROOM.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find SAD by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SAD</param>
        /// <returns>List of related SAD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAD> TryFindByROOM(string ROOM)
        {
            IReadOnlyList<SAD> value;
            if (Index_ROOM.Value.TryGetValue(ROOM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAD by SADKEY field
        /// </summary>
        /// <param name="SADKEY">SADKEY value used to find SAD</param>
        /// <returns>Related SAD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAD FindBySADKEY(int SADKEY)
        {
            return Index_SADKEY.Value[SADKEY];
        }

        /// <summary>
        /// Attempt to find SAD by SADKEY field
        /// </summary>
        /// <param name="SADKEY">SADKEY value used to find SAD</param>
        /// <param name="Value">Related SAD entity</param>
        /// <returns>True if the related SAD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySADKEY(int SADKEY, out SAD Value)
        {
            return Index_SADKEY.Value.TryGetValue(SADKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SAD by SADKEY field
        /// </summary>
        /// <param name="SADKEY">SADKEY value used to find SAD</param>
        /// <returns>Related SAD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAD TryFindBySADKEY(int SADKEY)
        {
            SAD value;
            if (Index_SADKEY.Value.TryGetValue(SADKEY, out value))
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
