using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Data deleted from DataMirror monitored tables Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KDELETEDataSet : SetBase<KDELETE>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KDELETE"; } }

        internal KDELETEDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, KDELETE>>(() => this.ToDictionary(i => i.ID));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<KDELETE>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KDELETE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KDELETE" /> fields for each CSV column header</returns>
        protected override Action<KDELETE, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KDELETE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "TABLENAME":
                        mapper[i] = (e, v) => e.TABLENAME = v;
                        break;
                    case "IDVALUE":
                        mapper[i] = (e, v) => e.IDVALUE = v;
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

        private Lazy<Dictionary<int, KDELETE>> Index_ID;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<KDELETE>>> Index_LW_DATE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KDELETE by ID field
        /// </summary>
        /// <param name="ID">ID value used to find KDELETE</param>
        /// <returns>Related KDELETE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KDELETE FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find KDELETE by ID field
        /// </summary>
        /// <param name="ID">ID value used to find KDELETE</param>
        /// <param name="Value">Related KDELETE entity</param>
        /// <returns>True if the related KDELETE entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out KDELETE Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find KDELETE by ID field
        /// </summary>
        /// <param name="ID">ID value used to find KDELETE</param>
        /// <returns>Related KDELETE entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KDELETE TryFindByID(int ID)
        {
            KDELETE value;
            if (Index_ID.Value.TryGetValue(ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KDELETE by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KDELETE</param>
        /// <returns>List of related KDELETE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KDELETE> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find KDELETE by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KDELETE</param>
        /// <param name="Value">List of related KDELETE entities</param>
        /// <returns>True if the list of related KDELETE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<KDELETE> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find KDELETE by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KDELETE</param>
        /// <returns>List of related KDELETE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KDELETE> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<KDELETE> value;
            if (Index_LW_DATE.Value.TryGetValue(LW_DATE, out value))
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
