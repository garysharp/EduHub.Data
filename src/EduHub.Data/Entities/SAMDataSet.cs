using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Association Members Data Set
    /// </summary>
    public sealed partial class SAMDataSet : SetBase<SAM>
    {
        private Lazy<Dictionary<int, SAM>> SAMKEYIndex;

        private Lazy<Dictionary<int, IReadOnlyList<SAMA>>> SAMA_SAMAKEYForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<SCI>>> SCI_SAM_SCH_COUNCILForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<SCI>>> SCI_SCH_COUNCIL_PRESForeignIndex;

        internal SAMDataSet(EduHubContext Context)
            : base(Context)
        {
            SAMKEYIndex = new Lazy<Dictionary<int, SAM>>(() => this.ToDictionary(e => e.SAMKEY));

            SAMA_SAMAKEYForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<SAMA>>>(() =>
                    Context.SAMA
                          .Where(e => e.SAMAKEY != null)
                          .GroupBy(e => e.SAMAKEY.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SAMA>)g.ToList()
                          .AsReadOnly()));

            SCI_SAM_SCH_COUNCILForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<SCI>>>(() =>
                    Context.SCI
                          .Where(e => e.SAM_SCH_COUNCIL != null)
                          .GroupBy(e => e.SAM_SCH_COUNCIL.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCI>)g.ToList()
                          .AsReadOnly()));

            SCI_SCH_COUNCIL_PRESForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<SCI>>>(() =>
                    Context.SCI
                          .Where(e => e.SCH_COUNCIL_PRES != null)
                          .GroupBy(e => e.SCH_COUNCIL_PRES.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCI>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SAM"; } }

        /// <summary>
        /// Find SAM by SAMKEY key field
        /// </summary>
        /// <param name="Key">SAMKEY value used to find SAM</param>
        /// <returns>Related SAM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SAMKEY value didn't match any SAM entities</exception>
        public SAM FindBySAMKEY(int Key)
        {
            SAM result;
            if (SAMKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SAM by SAMKEY key field
        /// </summary>
        /// <param name="Key">SAMKEY value used to find SAM</param>
        /// <param name="Value">Related SAM entity</param>
        /// <returns>True if the SAM entity is found</returns>
        public bool TryFindBySAMKEY(int Key, out SAM Value)
        {
            return SAMKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SAM by SAMKEY key field
        /// </summary>
        /// <param name="Key">SAMKEY value used to find SAM</param>
        /// <returns>Related SAM entity, or null if not found</returns>
        public SAM TryFindBySAMKEY(int Key)
        {
            SAM result;
            if (SAMKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all SAMA (Association Member Attendances) entities by [SAMA.SAMAKEY]-&gt;[SAM.SAMKEY]
        /// </summary>
        /// <param name="SAMKEY">SAMKEY value used to find SAMA entities</param>
        /// <returns>A list of related SAMA entities</returns>
        public IReadOnlyList<SAMA> FindSAMABySAMAKEY(int SAMKEY)
        {
            IReadOnlyList<SAMA> result;
            if (SAMA_SAMAKEYForeignIndex.Value.TryGetValue(SAMKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SAMA>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SAMA entities by [SAMA.SAMAKEY]-&gt;[SAM.SAMKEY]
        /// </summary>
        /// <param name="SAMKEY">SAMKEY value used to find SAMA entities</param>
        /// <param name="Value">A list of related SAMA entities</param>
        /// <returns>True if any SAMA entities are found</returns>
        public bool TryFindSAMABySAMAKEY(int SAMKEY, out IReadOnlyList<SAMA> Value)
        {
            return SAMA_SAMAKEYForeignIndex.Value.TryGetValue(SAMKEY, out Value);
        }

        /// <summary>
        /// Find all SCI (School Information) entities by [SCI.SAM_SCH_COUNCIL]-&gt;[SAM.SAMKEY]
        /// </summary>
        /// <param name="SAMKEY">SAMKEY value used to find SCI entities</param>
        /// <returns>A list of related SCI entities</returns>
        public IReadOnlyList<SCI> FindSCIBySAM_SCH_COUNCIL(int SAMKEY)
        {
            IReadOnlyList<SCI> result;
            if (SCI_SAM_SCH_COUNCILForeignIndex.Value.TryGetValue(SAMKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SCI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCI entities by [SCI.SAM_SCH_COUNCIL]-&gt;[SAM.SAMKEY]
        /// </summary>
        /// <param name="SAMKEY">SAMKEY value used to find SCI entities</param>
        /// <param name="Value">A list of related SCI entities</param>
        /// <returns>True if any SCI entities are found</returns>
        public bool TryFindSCIBySAM_SCH_COUNCIL(int SAMKEY, out IReadOnlyList<SCI> Value)
        {
            return SCI_SAM_SCH_COUNCILForeignIndex.Value.TryGetValue(SAMKEY, out Value);
        }

        /// <summary>
        /// Find all SCI (School Information) entities by [SCI.SCH_COUNCIL_PRES]-&gt;[SAM.SAMKEY]
        /// </summary>
        /// <param name="SAMKEY">SAMKEY value used to find SCI entities</param>
        /// <returns>A list of related SCI entities</returns>
        public IReadOnlyList<SCI> FindSCIBySCH_COUNCIL_PRES(int SAMKEY)
        {
            IReadOnlyList<SCI> result;
            if (SCI_SCH_COUNCIL_PRESForeignIndex.Value.TryGetValue(SAMKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SCI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCI entities by [SCI.SCH_COUNCIL_PRES]-&gt;[SAM.SAMKEY]
        /// </summary>
        /// <param name="SAMKEY">SAMKEY value used to find SCI entities</param>
        /// <param name="Value">A list of related SCI entities</param>
        /// <returns>True if any SCI entities are found</returns>
        public bool TryFindSCIBySCH_COUNCIL_PRES(int SAMKEY, out IReadOnlyList<SCI> Value)
        {
            return SCI_SCH_COUNCIL_PRESForeignIndex.Value.TryGetValue(SAMKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SAM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SAM" /> fields for each CSV column header</returns>
        protected override Action<SAM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SAM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SAMKEY":
                        mapper[i] = (e, v) => e.SAMKEY = int.Parse(v);
                        break;
                    case "PERSON_TYPE":
                        mapper[i] = (e, v) => e.PERSON_TYPE = v;
                        break;
                    case "PERSON":
                        mapper[i] = (e, v) => e.PERSON = v;
                        break;
                    case "WHICH_PARENT":
                        mapper[i] = (e, v) => e.WHICH_PARENT = v;
                        break;
                    case "GENDER":
                        mapper[i] = (e, v) => e.GENDER = v;
                        break;
                    case "BIRTHDATE":
                        mapper[i] = (e, v) => e.BIRTHDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "KOORIE":
                        mapper[i] = (e, v) => e.KOORIE = v;
                        break;
                    case "PARENT_OS":
                        mapper[i] = (e, v) => e.PARENT_OS = v;
                        break;
                    case "LOTE":
                        mapper[i] = (e, v) => e.LOTE = v;
                        break;
                    case "LBOTE":
                        mapper[i] = (e, v) => e.LBOTE = v;
                        break;
                    case "DISABILITY":
                        mapper[i] = (e, v) => e.DISABILITY = v;
                        break;
                    case "ASSOC_NAME":
                        mapper[i] = (e, v) => e.ASSOC_NAME = v;
                        break;
                    case "ASSOC_POSN":
                        mapper[i] = (e, v) => e.ASSOC_POSN = v;
                        break;
                    case "ADDRESSKEY":
                        mapper[i] = (e, v) => e.ADDRESSKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MAILKEY":
                        mapper[i] = (e, v) => e.MAILKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "HOME_E_MAIL":
                        mapper[i] = (e, v) => e.HOME_E_MAIL = v;
                        break;
                    case "WORK_PHONE":
                        mapper[i] = (e, v) => e.WORK_PHONE = v;
                        break;
                    case "WORK_FAX":
                        mapper[i] = (e, v) => e.WORK_FAX = v;
                        break;
                    case "WORK_E_MAIL":
                        mapper[i] = (e, v) => e.WORK_E_MAIL = v;
                        break;
                    case "SURNAME":
                        mapper[i] = (e, v) => e.SURNAME = v;
                        break;
                    case "FIRST_NAME":
                        mapper[i] = (e, v) => e.FIRST_NAME = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "MOBILE_PHONE":
                        mapper[i] = (e, v) => e.MOBILE_PHONE = v;
                        break;
                    case "SIGNATORY":
                        mapper[i] = (e, v) => e.SIGNATORY = v;
                        break;
                    case "SAM_COMMENT":
                        mapper[i] = (e, v) => e.SAM_COMMENT = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
