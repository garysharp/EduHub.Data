using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Associations Data Set
    /// </summary>
    public sealed partial class SCADataSet : SetBase<SCA>
    {
        private Lazy<Dictionary<string, SCA>> SCAKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<SAM>>> SAM_ASSOC_NAMEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SCAM>>> SCAM_SCAMKEYForeignIndex;

        internal SCADataSet(EduHubContext Context)
            : base(Context)
        {
            SCAKEYIndex = new Lazy<Dictionary<string, SCA>>(() => this.ToDictionary(e => e.SCAKEY));

            SAM_ASSOC_NAMEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SAM>>>(() =>
                    Context.SAM
                          .Where(e => e.ASSOC_NAME != null)
                          .GroupBy(e => e.ASSOC_NAME)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SAM>)g.ToList()
                          .AsReadOnly()));

            SCAM_SCAMKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCAM>>>(() =>
                    Context.SCAM
                          .Where(e => e.SCAMKEY != null)
                          .GroupBy(e => e.SCAMKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCAM>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCA"; } }

        /// <summary>
        /// Find SCA by SCAKEY key field
        /// </summary>
        /// <param name="Key">SCAKEY value used to find SCA</param>
        /// <returns>Related SCA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SCAKEY value didn't match any SCA entities</exception>
        public SCA FindBySCAKEY(string Key)
        {
            SCA result;
            if (SCAKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SCA by SCAKEY key field
        /// </summary>
        /// <param name="Key">SCAKEY value used to find SCA</param>
        /// <param name="Value">Related SCA entity</param>
        /// <returns>True if the SCA entity is found</returns>
        public bool TryFindBySCAKEY(string Key, out SCA Value)
        {
            return SCAKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SCA by SCAKEY key field
        /// </summary>
        /// <param name="Key">SCAKEY value used to find SCA</param>
        /// <returns>Related SCA entity, or null if not found</returns>
        public SCA TryFindBySCAKEY(string Key)
        {
            SCA result;
            if (SCAKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all SAM (School Association Members) entities by [SAM.ASSOC_NAME]-&gt;[SCA.SCAKEY]
        /// </summary>
        /// <param name="SCAKEY">SCAKEY value used to find SAM entities</param>
        /// <returns>A list of related SAM entities</returns>
        public IReadOnlyList<SAM> FindSAMByASSOC_NAME(string SCAKEY)
        {
            IReadOnlyList<SAM> result;
            if (SAM_ASSOC_NAMEForeignIndex.Value.TryGetValue(SCAKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SAM>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SAM entities by [SAM.ASSOC_NAME]-&gt;[SCA.SCAKEY]
        /// </summary>
        /// <param name="SCAKEY">SCAKEY value used to find SAM entities</param>
        /// <param name="Value">A list of related SAM entities</param>
        /// <returns>True if any SAM entities are found</returns>
        public bool TryFindSAMByASSOC_NAME(string SCAKEY, out IReadOnlyList<SAM> Value)
        {
            return SAM_ASSOC_NAMEForeignIndex.Value.TryGetValue(SCAKEY, out Value);
        }

        /// <summary>
        /// Find all SCAM (School Association Meetings) entities by [SCAM.SCAMKEY]-&gt;[SCA.SCAKEY]
        /// </summary>
        /// <param name="SCAKEY">SCAKEY value used to find SCAM entities</param>
        /// <returns>A list of related SCAM entities</returns>
        public IReadOnlyList<SCAM> FindSCAMBySCAMKEY(string SCAKEY)
        {
            IReadOnlyList<SCAM> result;
            if (SCAM_SCAMKEYForeignIndex.Value.TryGetValue(SCAKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SCAM>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCAM entities by [SCAM.SCAMKEY]-&gt;[SCA.SCAKEY]
        /// </summary>
        /// <param name="SCAKEY">SCAKEY value used to find SCAM entities</param>
        /// <param name="Value">A list of related SCAM entities</param>
        /// <returns>True if any SCAM entities are found</returns>
        public bool TryFindSCAMBySCAMKEY(string SCAKEY, out IReadOnlyList<SCAM> Value)
        {
            return SCAM_SCAMKEYForeignIndex.Value.TryGetValue(SCAKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCA" /> fields for each CSV column header</returns>
        protected override Action<SCA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCAKEY":
                        mapper[i] = (e, v) => e.SCAKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "FIRST_DATE":
                        mapper[i] = (e, v) => e.FIRST_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LAST_DATE":
                        mapper[i] = (e, v) => e.LAST_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SCA_MEMO":
                        mapper[i] = (e, v) => e.SCA_MEMO = v;
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
