using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Archived Census Class Sizes Data Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_ACLDataSet : SetBase<SCEN_ACL>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_ACL"; } }

        internal SCEN_ACLDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, SCEN_ACL>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_ACL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_ACL" /> fields for each CSV column header</returns>
        protected override Action<SCEN_ACL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_ACL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "ID_RETURN":
                        mapper[i] = (e, v) => e.ID_RETURN = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CAMPUSNUMBER":
                        mapper[i] = (e, v) => e.CAMPUSNUMBER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CLASSCODE":
                        mapper[i] = (e, v) => e.CLASSCODE = v;
                        break;
                    case "CLASSTYPE":
                        mapper[i] = (e, v) => e.CLASSTYPE = v;
                        break;
                    case "FTETEACHERS":
                        mapper[i] = (e, v) => e.FTETEACHERS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PREP":
                        mapper[i] = (e, v) => e.PREP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR01":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR01 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR02":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR02 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR03":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR03 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR04":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR04 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR05":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR05 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR06":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR06 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR07":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR07 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR08":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR08 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR09":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR09 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR10":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR10 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR11":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR11 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR12":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR12 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PRIMARYUG":
                        mapper[i] = (e, v) => e.PRIMARYUG = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SENIORUG":
                        mapper[i] = (e, v) => e.SENIORUG = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CREATED":
                        mapper[i] = (e, v) => e.CREATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CREATEUSER":
                        mapper[i] = (e, v) => e.CREATEUSER = v;
                        break;
                    case "LUPDATEUSER":
                        mapper[i] = (e, v) => e.LUPDATEUSER = v;
                        break;
                    case "LUPDATED":
                        mapper[i] = (e, v) => e.LUPDATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SCEN_ACL" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SCEN_ACL" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SCEN_ACL" /> items to added or update the base <see cref="SCEN_ACL" /> items</param>
        /// <returns>A merged list of <see cref="SCEN_ACL" /> items</returns>
        protected override List<SCEN_ACL> ApplyDeltaItems(List<SCEN_ACL> Items, List<SCEN_ACL> DeltaItems)
        {
            Dictionary<int, int> Index_ID = Items.ToIndexDictionary(i => i.ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SCEN_ACL deltaItem in DeltaItems)
            {
                int index;

                if (Index_ID.TryGetValue(deltaItem.ID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.ID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, SCEN_ACL>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCEN_ACL by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_ACL</param>
        /// <returns>Related SCEN_ACL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_ACL FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find SCEN_ACL by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_ACL</param>
        /// <param name="Value">Related SCEN_ACL entity</param>
        /// <returns>True if the related SCEN_ACL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out SCEN_ACL Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_ACL by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_ACL</param>
        /// <returns>Related SCEN_ACL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_ACL TryFindByID(int ID)
        {
            SCEN_ACL value;
            if (Index_ID.Value.TryGetValue(ID, out value))
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
