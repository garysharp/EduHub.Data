using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Groupings Data Set
    /// </summary>
    public sealed partial class SGDataSet : SetBase<SG>
    {
        private Lazy<Dictionary<string, SG>> SGKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<SGAM>>> SGAM_SGAMKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SGHG>>> SGHG_SGHGKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SGM>>> SGM_SGMKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SGMA>>> SGMA_SGMAKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SGSC>>> SGSC_SGSCKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SGSG>>> SGSG_SGSGKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SGSG>>> SGSG_SGLINKForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SGTRX>>> SGTRX_SGTRXKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SPU>>> SPU_MAILING_LISTForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STPO>>> STPO_SGLINKForeignIndex;

        internal SGDataSet(EduHubContext Context)
            : base(Context)
        {
            SGKEYIndex = new Lazy<Dictionary<string, SG>>(() => this.ToDictionary(e => e.SGKEY));

            SGAM_SGAMKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SGAM>>>(() =>
                    Context.SGAM
                          .Where(e => e.SGAMKEY != null)
                          .GroupBy(e => e.SGAMKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SGAM>)g.ToList()
                          .AsReadOnly()));

            SGHG_SGHGKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SGHG>>>(() =>
                    Context.SGHG
                          .Where(e => e.SGHGKEY != null)
                          .GroupBy(e => e.SGHGKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SGHG>)g.ToList()
                          .AsReadOnly()));

            SGM_SGMKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SGM>>>(() =>
                    Context.SGM
                          .Where(e => e.SGMKEY != null)
                          .GroupBy(e => e.SGMKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SGM>)g.ToList()
                          .AsReadOnly()));

            SGMA_SGMAKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SGMA>>>(() =>
                    Context.SGMA
                          .Where(e => e.SGMAKEY != null)
                          .GroupBy(e => e.SGMAKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SGMA>)g.ToList()
                          .AsReadOnly()));

            SGSC_SGSCKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SGSC>>>(() =>
                    Context.SGSC
                          .Where(e => e.SGSCKEY != null)
                          .GroupBy(e => e.SGSCKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SGSC>)g.ToList()
                          .AsReadOnly()));

            SGSG_SGSGKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SGSG>>>(() =>
                    Context.SGSG
                          .Where(e => e.SGSGKEY != null)
                          .GroupBy(e => e.SGSGKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SGSG>)g.ToList()
                          .AsReadOnly()));

            SGSG_SGLINKForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SGSG>>>(() =>
                    Context.SGSG
                          .Where(e => e.SGLINK != null)
                          .GroupBy(e => e.SGLINK)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SGSG>)g.ToList()
                          .AsReadOnly()));

            SGTRX_SGTRXKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SGTRX>>>(() =>
                    Context.SGTRX
                          .Where(e => e.SGTRXKEY != null)
                          .GroupBy(e => e.SGTRXKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SGTRX>)g.ToList()
                          .AsReadOnly()));

            SPU_MAILING_LISTForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SPU>>>(() =>
                    Context.SPU
                          .Where(e => e.MAILING_LIST != null)
                          .GroupBy(e => e.MAILING_LIST)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SPU>)g.ToList()
                          .AsReadOnly()));

            STPO_SGLINKForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STPO>>>(() =>
                    Context.STPO
                          .Where(e => e.SGLINK != null)
                          .GroupBy(e => e.SGLINK)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STPO>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SG"; } }

        /// <summary>
        /// Find SG by SGKEY key field
        /// </summary>
        /// <param name="Key">SGKEY value used to find SG</param>
        /// <returns>Related SG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SGKEY value didn't match any SG entities</exception>
        public SG FindBySGKEY(string Key)
        {
            SG result;
            if (SGKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SG by SGKEY key field
        /// </summary>
        /// <param name="Key">SGKEY value used to find SG</param>
        /// <param name="Value">Related SG entity</param>
        /// <returns>True if the SG entity is found</returns>
        public bool TryFindBySGKEY(string Key, out SG Value)
        {
            return SGKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SG by SGKEY key field
        /// </summary>
        /// <param name="Key">SGKEY value used to find SG</param>
        /// <returns>Related SG entity, or null if not found</returns>
        public SG TryFindBySGKEY(string Key)
        {
            SG result;
            if (SGKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all SGAM (Adult Group Members) entities by [SGAM.SGAMKEY]-&gt;[SG.SGKEY]
        /// </summary>
        /// <param name="SGKEY">SGKEY value used to find SGAM entities</param>
        /// <returns>A list of related SGAM entities</returns>
        public IReadOnlyList<SGAM> FindSGAMBySGAMKEY(string SGKEY)
        {
            IReadOnlyList<SGAM> result;
            if (SGAM_SGAMKEYForeignIndex.Value.TryGetValue(SGKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SGAM>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SGAM entities by [SGAM.SGAMKEY]-&gt;[SG.SGKEY]
        /// </summary>
        /// <param name="SGKEY">SGKEY value used to find SGAM entities</param>
        /// <param name="Value">A list of related SGAM entities</param>
        /// <returns>True if any SGAM entities are found</returns>
        public bool TryFindSGAMBySGAMKEY(string SGKEY, out IReadOnlyList<SGAM> Value)
        {
            return SGAM_SGAMKEYForeignIndex.Value.TryGetValue(SGKEY, out Value);
        }

        /// <summary>
        /// Find all SGHG (Home Group Eligibility Criteria) entities by [SGHG.SGHGKEY]-&gt;[SG.SGKEY]
        /// </summary>
        /// <param name="SGKEY">SGKEY value used to find SGHG entities</param>
        /// <returns>A list of related SGHG entities</returns>
        public IReadOnlyList<SGHG> FindSGHGBySGHGKEY(string SGKEY)
        {
            IReadOnlyList<SGHG> result;
            if (SGHG_SGHGKEYForeignIndex.Value.TryGetValue(SGKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SGHG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SGHG entities by [SGHG.SGHGKEY]-&gt;[SG.SGKEY]
        /// </summary>
        /// <param name="SGKEY">SGKEY value used to find SGHG entities</param>
        /// <param name="Value">A list of related SGHG entities</param>
        /// <returns>True if any SGHG entities are found</returns>
        public bool TryFindSGHGBySGHGKEY(string SGKEY, out IReadOnlyList<SGHG> Value)
        {
            return SGHG_SGHGKEYForeignIndex.Value.TryGetValue(SGKEY, out Value);
        }

        /// <summary>
        /// Find all SGM (Special Group Meetings) entities by [SGM.SGMKEY]-&gt;[SG.SGKEY]
        /// </summary>
        /// <param name="SGKEY">SGKEY value used to find SGM entities</param>
        /// <returns>A list of related SGM entities</returns>
        public IReadOnlyList<SGM> FindSGMBySGMKEY(string SGKEY)
        {
            IReadOnlyList<SGM> result;
            if (SGM_SGMKEYForeignIndex.Value.TryGetValue(SGKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SGM>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SGM entities by [SGM.SGMKEY]-&gt;[SG.SGKEY]
        /// </summary>
        /// <param name="SGKEY">SGKEY value used to find SGM entities</param>
        /// <param name="Value">A list of related SGM entities</param>
        /// <returns>True if any SGM entities are found</returns>
        public bool TryFindSGMBySGMKEY(string SGKEY, out IReadOnlyList<SGM> Value)
        {
            return SGM_SGMKEYForeignIndex.Value.TryGetValue(SGKEY, out Value);
        }

        /// <summary>
        /// Find all SGMA (Group Meeting Attendance) entities by [SGMA.SGMAKEY]-&gt;[SG.SGKEY]
        /// </summary>
        /// <param name="SGKEY">SGKEY value used to find SGMA entities</param>
        /// <returns>A list of related SGMA entities</returns>
        public IReadOnlyList<SGMA> FindSGMABySGMAKEY(string SGKEY)
        {
            IReadOnlyList<SGMA> result;
            if (SGMA_SGMAKEYForeignIndex.Value.TryGetValue(SGKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SGMA>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SGMA entities by [SGMA.SGMAKEY]-&gt;[SG.SGKEY]
        /// </summary>
        /// <param name="SGKEY">SGKEY value used to find SGMA entities</param>
        /// <param name="Value">A list of related SGMA entities</param>
        /// <returns>True if any SGMA entities are found</returns>
        public bool TryFindSGMABySGMAKEY(string SGKEY, out IReadOnlyList<SGMA> Value)
        {
            return SGMA_SGMAKEYForeignIndex.Value.TryGetValue(SGKEY, out Value);
        }

        /// <summary>
        /// Find all SGSC (Subject/Class Eligibility Criteria) entities by [SGSC.SGSCKEY]-&gt;[SG.SGKEY]
        /// </summary>
        /// <param name="SGKEY">SGKEY value used to find SGSC entities</param>
        /// <returns>A list of related SGSC entities</returns>
        public IReadOnlyList<SGSC> FindSGSCBySGSCKEY(string SGKEY)
        {
            IReadOnlyList<SGSC> result;
            if (SGSC_SGSCKEYForeignIndex.Value.TryGetValue(SGKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SGSC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SGSC entities by [SGSC.SGSCKEY]-&gt;[SG.SGKEY]
        /// </summary>
        /// <param name="SGKEY">SGKEY value used to find SGSC entities</param>
        /// <param name="Value">A list of related SGSC entities</param>
        /// <returns>True if any SGSC entities are found</returns>
        public bool TryFindSGSCBySGSCKEY(string SGKEY, out IReadOnlyList<SGSC> Value)
        {
            return SGSC_SGSCKEYForeignIndex.Value.TryGetValue(SGKEY, out Value);
        }

        /// <summary>
        /// Find all SGSG (Group Membership Eligibility Criteria) entities by [SGSG.SGSGKEY]-&gt;[SG.SGKEY]
        /// </summary>
        /// <param name="SGKEY">SGKEY value used to find SGSG entities</param>
        /// <returns>A list of related SGSG entities</returns>
        public IReadOnlyList<SGSG> FindSGSGBySGSGKEY(string SGKEY)
        {
            IReadOnlyList<SGSG> result;
            if (SGSG_SGSGKEYForeignIndex.Value.TryGetValue(SGKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SGSG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SGSG entities by [SGSG.SGSGKEY]-&gt;[SG.SGKEY]
        /// </summary>
        /// <param name="SGKEY">SGKEY value used to find SGSG entities</param>
        /// <param name="Value">A list of related SGSG entities</param>
        /// <returns>True if any SGSG entities are found</returns>
        public bool TryFindSGSGBySGSGKEY(string SGKEY, out IReadOnlyList<SGSG> Value)
        {
            return SGSG_SGSGKEYForeignIndex.Value.TryGetValue(SGKEY, out Value);
        }

        /// <summary>
        /// Find all SGSG (Group Membership Eligibility Criteria) entities by [SGSG.SGLINK]-&gt;[SG.SGKEY]
        /// </summary>
        /// <param name="SGKEY">SGKEY value used to find SGSG entities</param>
        /// <returns>A list of related SGSG entities</returns>
        public IReadOnlyList<SGSG> FindSGSGBySGLINK(string SGKEY)
        {
            IReadOnlyList<SGSG> result;
            if (SGSG_SGLINKForeignIndex.Value.TryGetValue(SGKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SGSG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SGSG entities by [SGSG.SGLINK]-&gt;[SG.SGKEY]
        /// </summary>
        /// <param name="SGKEY">SGKEY value used to find SGSG entities</param>
        /// <param name="Value">A list of related SGSG entities</param>
        /// <returns>True if any SGSG entities are found</returns>
        public bool TryFindSGSGBySGLINK(string SGKEY, out IReadOnlyList<SGSG> Value)
        {
            return SGSG_SGLINKForeignIndex.Value.TryGetValue(SGKEY, out Value);
        }

        /// <summary>
        /// Find all SGTRX (Temporary Group Transactions) entities by [SGTRX.SGTRXKEY]-&gt;[SG.SGKEY]
        /// </summary>
        /// <param name="SGKEY">SGKEY value used to find SGTRX entities</param>
        /// <returns>A list of related SGTRX entities</returns>
        public IReadOnlyList<SGTRX> FindSGTRXBySGTRXKEY(string SGKEY)
        {
            IReadOnlyList<SGTRX> result;
            if (SGTRX_SGTRXKEYForeignIndex.Value.TryGetValue(SGKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SGTRX>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SGTRX entities by [SGTRX.SGTRXKEY]-&gt;[SG.SGKEY]
        /// </summary>
        /// <param name="SGKEY">SGKEY value used to find SGTRX entities</param>
        /// <param name="Value">A list of related SGTRX entities</param>
        /// <returns>True if any SGTRX entities are found</returns>
        public bool TryFindSGTRXBySGTRXKEY(string SGKEY, out IReadOnlyList<SGTRX> Value)
        {
            return SGTRX_SGTRXKEYForeignIndex.Value.TryGetValue(SGKEY, out Value);
        }

        /// <summary>
        /// Find all SPU (Publications) entities by [SPU.MAILING_LIST]-&gt;[SG.SGKEY]
        /// </summary>
        /// <param name="SGKEY">SGKEY value used to find SPU entities</param>
        /// <returns>A list of related SPU entities</returns>
        public IReadOnlyList<SPU> FindSPUByMAILING_LIST(string SGKEY)
        {
            IReadOnlyList<SPU> result;
            if (SPU_MAILING_LISTForeignIndex.Value.TryGetValue(SGKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SPU>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SPU entities by [SPU.MAILING_LIST]-&gt;[SG.SGKEY]
        /// </summary>
        /// <param name="SGKEY">SGKEY value used to find SPU entities</param>
        /// <param name="Value">A list of related SPU entities</param>
        /// <returns>True if any SPU entities are found</returns>
        public bool TryFindSPUByMAILING_LIST(string SGKEY, out IReadOnlyList<SPU> Value)
        {
            return SPU_MAILING_LISTForeignIndex.Value.TryGetValue(SGKEY, out Value);
        }

        /// <summary>
        /// Find all STPO (Position or Group Memberships) entities by [STPO.SGLINK]-&gt;[SG.SGKEY]
        /// </summary>
        /// <param name="SGKEY">SGKEY value used to find STPO entities</param>
        /// <returns>A list of related STPO entities</returns>
        public IReadOnlyList<STPO> FindSTPOBySGLINK(string SGKEY)
        {
            IReadOnlyList<STPO> result;
            if (STPO_SGLINKForeignIndex.Value.TryGetValue(SGKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STPO>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STPO entities by [STPO.SGLINK]-&gt;[SG.SGKEY]
        /// </summary>
        /// <param name="SGKEY">SGKEY value used to find STPO entities</param>
        /// <param name="Value">A list of related STPO entities</param>
        /// <returns>True if any STPO entities are found</returns>
        public bool TryFindSTPOBySGLINK(string SGKEY, out IReadOnlyList<STPO> Value)
        {
            return STPO_SGLINKForeignIndex.Value.TryGetValue(SGKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SG" /> fields for each CSV column header</returns>
        protected override Action<SG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SGKEY":
                        mapper[i] = (e, v) => e.SGKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "GROUP_TYPE":
                        mapper[i] = (e, v) => e.GROUP_TYPE = v;
                        break;
                    case "GROUP_CATEGORY":
                        mapper[i] = (e, v) => e.GROUP_CATEGORY = v;
                        break;
                    case "SOURCE_SG":
                        mapper[i] = (e, v) => e.SOURCE_SG = v;
                        break;
                    case "STRICT_CRITERIA":
                        mapper[i] = (e, v) => e.STRICT_CRITERIA = v;
                        break;
                    case "MAX_NUMBER_STUD":
                        mapper[i] = (e, v) => e.MAX_NUMBER_STUD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "STRUCTURE":
                        mapper[i] = (e, v) => e.STRUCTURE = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CESSATION_DATE":
                        mapper[i] = (e, v) => e.CESSATION_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "HOUSE_HOMEGROUP":
                        mapper[i] = (e, v) => e.HOUSE_HOMEGROUP = v;
                        break;
                    case "SCOPE":
                        mapper[i] = (e, v) => e.SCOPE = v;
                        break;
                    case "FROM_CAMPUS":
                        mapper[i] = (e, v) => e.FROM_CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TO_CAMPUS":
                        mapper[i] = (e, v) => e.TO_CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CAND_FIRST_YR":
                        mapper[i] = (e, v) => e.CAND_FIRST_YR = v;
                        break;
                    case "CAND_LAST_YR":
                        mapper[i] = (e, v) => e.CAND_LAST_YR = v;
                        break;
                    case "FUT_FIRST_YR":
                        mapper[i] = (e, v) => e.FUT_FIRST_YR = v;
                        break;
                    case "FUT_LAST_YR":
                        mapper[i] = (e, v) => e.FUT_LAST_YR = v;
                        break;
                    case "CAND_FIRST_AGE":
                        mapper[i] = (e, v) => e.CAND_FIRST_AGE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CAND_LAST_AGE":
                        mapper[i] = (e, v) => e.CAND_LAST_AGE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_DATE":
                        mapper[i] = (e, v) => e.AGE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "FIRST_DOB":
                        mapper[i] = (e, v) => e.FIRST_DOB = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LAST_DOB":
                        mapper[i] = (e, v) => e.LAST_DOB = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "GENDERA":
                        mapper[i] = (e, v) => e.GENDERA = v;
                        break;
                    case "GENDERB":
                        mapper[i] = (e, v) => e.GENDERB = v;
                        break;
                    case "HOUSE":
                        mapper[i] = (e, v) => e.HOUSE = v;
                        break;
                    case "DAYONE":
                        mapper[i] = (e, v) => e.DAYONE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DO_FIRST_PERD":
                        mapper[i] = (e, v) => e.DO_FIRST_PERD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LASTDAY":
                        mapper[i] = (e, v) => e.LASTDAY = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LD_LAST_PERD":
                        mapper[i] = (e, v) => e.LD_LAST_PERD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DAYONE_AM_PM":
                        mapper[i] = (e, v) => e.DAYONE_AM_PM = v;
                        break;
                    case "LASTDAY_AM_PM":
                        mapper[i] = (e, v) => e.LASTDAY_AM_PM = v;
                        break;
                    case "ABS_TYPE":
                        mapper[i] = (e, v) => e.ABS_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PREV_ABS_TYPE":
                        mapper[i] = (e, v) => e.PREV_ABS_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FREQUENCY":
                        mapper[i] = (e, v) => e.FREQUENCY = v;
                        break;
                    case "DESTINATION":
                        mapper[i] = (e, v) => e.DESTINATION = v;
                        break;
                    case "VENUE_ADDRESS":
                        mapper[i] = (e, v) => e.VENUE_ADDRESS = v;
                        break;
                    case "EXC_GLCODE":
                        mapper[i] = (e, v) => e.EXC_GLCODE = v;
                        break;
                    case "FEEDBACK":
                        mapper[i] = (e, v) => e.FEEDBACK = v;
                        break;
                    case "SPECIAL_NEEDS":
                        mapper[i] = (e, v) => e.SPECIAL_NEEDS = v;
                        break;
                    case "EXC_PURPOSE":
                        mapper[i] = (e, v) => e.EXC_PURPOSE = v;
                        break;
                    case "EXC_SERVICE_PROVIDER":
                        mapper[i] = (e, v) => e.EXC_SERVICE_PROVIDER = v;
                        break;
                    case "TRANSPORT_METHOD":
                        mapper[i] = (e, v) => e.TRANSPORT_METHOD = v;
                        break;
                    case "EXC_TRANSPORT_PROVIDER":
                        mapper[i] = (e, v) => e.EXC_TRANSPORT_PROVIDER = v;
                        break;
                    case "FIXED_TRANS_COST":
                        mapper[i] = (e, v) => e.FIXED_TRANS_COST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PER_ST_TRANS_COST":
                        mapper[i] = (e, v) => e.PER_ST_TRANS_COST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "FIXED_VENUE_COST":
                        mapper[i] = (e, v) => e.FIXED_VENUE_COST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PER_ST_VENUE_COST":
                        mapper[i] = (e, v) => e.PER_ST_VENUE_COST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "OTHER_COSTS":
                        mapper[i] = (e, v) => e.OTHER_COSTS = v;
                        break;
                    case "EXC_AMOUNT":
                        mapper[i] = (e, v) => e.EXC_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "STAFF_MEMBERS":
                        mapper[i] = (e, v) => e.STAFF_MEMBERS = v;
                        break;
                    case "PARENT_MEMBERS":
                        mapper[i] = (e, v) => e.PARENT_MEMBERS = v;
                        break;
                    case "RESP_PERSON_TYPE":
                        mapper[i] = (e, v) => e.RESP_PERSON_TYPE = v;
                        break;
                    case "ADULT_RESPONSIBLE":
                        mapper[i] = (e, v) => e.ADULT_RESPONSIBLE = v;
                        break;
                    case "RESP_PARENT_GENDER":
                        mapper[i] = (e, v) => e.RESP_PARENT_GENDER = v;
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
