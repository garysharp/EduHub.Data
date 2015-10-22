using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Groups Data Set
    /// </summary>
    public sealed partial class KGCDataSet : SetBase<KGC>
    {
        private Lazy<Dictionary<string, KGC>> KGCKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<KGC>>> KGC_NEXT_HGForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<KGCHI>>> KGCHI_KGCKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SGHG>>> SGHG_KGCLINKForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SS>>> SS_FROM_HOMEGROUPForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SS>>> SS_TO_HOMEGROUPForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SSHG>>> SSHG_HOMEGROUPForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SSHG>>> SSHG_TEACHING_HGForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ST>>> ST_HOME_GROUPForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ST>>> ST_NEXT_HGForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ST_TFR>>> ST_TFR_HOME_GROUP_NEWForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STRE>>> STRE_ST_HOME_GROUPForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TE>>> TE_START_FORMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TE>>> TE_END_FORMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TXHG>>> TXHG_HOME_GROUPForeignIndex;

        internal KGCDataSet(EduHubContext Context)
            : base(Context)
        {
            KGCKEYIndex = new Lazy<Dictionary<string, KGC>>(() => this.ToDictionary(e => e.KGCKEY));

            KGC_NEXT_HGForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<KGC>>>(() =>
                    Context.KGC
                          .Where(e => e.NEXT_HG != null)
                          .GroupBy(e => e.NEXT_HG)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<KGC>)g.ToList()
                          .AsReadOnly()));

            KGCHI_KGCKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<KGCHI>>>(() =>
                    Context.KGCHI
                          .Where(e => e.KGCKEY != null)
                          .GroupBy(e => e.KGCKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<KGCHI>)g.ToList()
                          .AsReadOnly()));

            SGHG_KGCLINKForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SGHG>>>(() =>
                    Context.SGHG
                          .Where(e => e.KGCLINK != null)
                          .GroupBy(e => e.KGCLINK)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SGHG>)g.ToList()
                          .AsReadOnly()));

            SS_FROM_HOMEGROUPForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SS>>>(() =>
                    Context.SS
                          .Where(e => e.FROM_HOMEGROUP != null)
                          .GroupBy(e => e.FROM_HOMEGROUP)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SS>)g.ToList()
                          .AsReadOnly()));

            SS_TO_HOMEGROUPForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SS>>>(() =>
                    Context.SS
                          .Where(e => e.TO_HOMEGROUP != null)
                          .GroupBy(e => e.TO_HOMEGROUP)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SS>)g.ToList()
                          .AsReadOnly()));

            SSHG_HOMEGROUPForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SSHG>>>(() =>
                    Context.SSHG
                          .Where(e => e.HOMEGROUP != null)
                          .GroupBy(e => e.HOMEGROUP)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SSHG>)g.ToList()
                          .AsReadOnly()));

            SSHG_TEACHING_HGForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SSHG>>>(() =>
                    Context.SSHG
                          .Where(e => e.TEACHING_HG != null)
                          .GroupBy(e => e.TEACHING_HG)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SSHG>)g.ToList()
                          .AsReadOnly()));

            ST_HOME_GROUPForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ST>>>(() =>
                    Context.ST
                          .Where(e => e.HOME_GROUP != null)
                          .GroupBy(e => e.HOME_GROUP)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ST>)g.ToList()
                          .AsReadOnly()));

            ST_NEXT_HGForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ST>>>(() =>
                    Context.ST
                          .Where(e => e.NEXT_HG != null)
                          .GroupBy(e => e.NEXT_HG)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ST>)g.ToList()
                          .AsReadOnly()));

            ST_TFR_HOME_GROUP_NEWForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ST_TFR>>>(() =>
                    Context.ST_TFR
                          .Where(e => e.HOME_GROUP_NEW != null)
                          .GroupBy(e => e.HOME_GROUP_NEW)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ST_TFR>)g.ToList()
                          .AsReadOnly()));

            STRE_ST_HOME_GROUPForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STRE>>>(() =>
                    Context.STRE
                          .Where(e => e.ST_HOME_GROUP != null)
                          .GroupBy(e => e.ST_HOME_GROUP)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STRE>)g.ToList()
                          .AsReadOnly()));

            TE_START_FORMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TE>>>(() =>
                    Context.TE
                          .Where(e => e.START_FORM != null)
                          .GroupBy(e => e.START_FORM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TE>)g.ToList()
                          .AsReadOnly()));

            TE_END_FORMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TE>>>(() =>
                    Context.TE
                          .Where(e => e.END_FORM != null)
                          .GroupBy(e => e.END_FORM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TE>)g.ToList()
                          .AsReadOnly()));

            TXHG_HOME_GROUPForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TXHG>>>(() =>
                    Context.TXHG
                          .Where(e => e.HOME_GROUP != null)
                          .GroupBy(e => e.HOME_GROUP)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TXHG>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGC"; } }

        /// <summary>
        /// Find KGC by KGCKEY key field
        /// </summary>
        /// <param name="Key">KGCKEY value used to find KGC</param>
        /// <returns>Related KGC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KGCKEY value didn't match any KGC entities</exception>
        public KGC FindByKGCKEY(string Key)
        {
            KGC result;
            if (KGCKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KGC by KGCKEY key field
        /// </summary>
        /// <param name="Key">KGCKEY value used to find KGC</param>
        /// <param name="Value">Related KGC entity</param>
        /// <returns>True if the KGC entity is found</returns>
        public bool TryFindByKGCKEY(string Key, out KGC Value)
        {
            return KGCKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KGC by KGCKEY key field
        /// </summary>
        /// <param name="Key">KGCKEY value used to find KGC</param>
        /// <returns>Related KGC entity, or null if not found</returns>
        public KGC TryFindByKGCKEY(string Key)
        {
            KGC result;
            if (KGCKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all KGC (Home Groups) entities by [KGC.NEXT_HG]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find KGC entities</param>
        /// <returns>A list of related KGC entities</returns>
        public IReadOnlyList<KGC> FindKGCByNEXT_HG(string KGCKEY)
        {
            IReadOnlyList<KGC> result;
            if (KGC_NEXT_HGForeignIndex.Value.TryGetValue(KGCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<KGC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all KGC entities by [KGC.NEXT_HG]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find KGC entities</param>
        /// <param name="Value">A list of related KGC entities</param>
        /// <returns>True if any KGC entities are found</returns>
        public bool TryFindKGCByNEXT_HG(string KGCKEY, out IReadOnlyList<KGC> Value)
        {
            return KGC_NEXT_HGForeignIndex.Value.TryGetValue(KGCKEY, out Value);
        }

        /// <summary>
        /// Find all KGCHI (Home Group History) entities by [KGCHI.KGCKEY]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find KGCHI entities</param>
        /// <returns>A list of related KGCHI entities</returns>
        public IReadOnlyList<KGCHI> FindKGCHIByKGCKEY(string KGCKEY)
        {
            IReadOnlyList<KGCHI> result;
            if (KGCHI_KGCKEYForeignIndex.Value.TryGetValue(KGCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<KGCHI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all KGCHI entities by [KGCHI.KGCKEY]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find KGCHI entities</param>
        /// <param name="Value">A list of related KGCHI entities</param>
        /// <returns>True if any KGCHI entities are found</returns>
        public bool TryFindKGCHIByKGCKEY(string KGCKEY, out IReadOnlyList<KGCHI> Value)
        {
            return KGCHI_KGCKEYForeignIndex.Value.TryGetValue(KGCKEY, out Value);
        }

        /// <summary>
        /// Find all SGHG (Home Group Eligibility Criteria) entities by [SGHG.KGCLINK]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find SGHG entities</param>
        /// <returns>A list of related SGHG entities</returns>
        public IReadOnlyList<SGHG> FindSGHGByKGCLINK(string KGCKEY)
        {
            IReadOnlyList<SGHG> result;
            if (SGHG_KGCLINKForeignIndex.Value.TryGetValue(KGCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SGHG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SGHG entities by [SGHG.KGCLINK]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find SGHG entities</param>
        /// <param name="Value">A list of related SGHG entities</param>
        /// <returns>True if any SGHG entities are found</returns>
        public bool TryFindSGHGByKGCLINK(string KGCKEY, out IReadOnlyList<SGHG> Value)
        {
            return SGHG_KGCLINKForeignIndex.Value.TryGetValue(KGCKEY, out Value);
        }

        /// <summary>
        /// Find all SS (Specialist Subjects) entities by [SS.FROM_HOMEGROUP]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find SS entities</param>
        /// <returns>A list of related SS entities</returns>
        public IReadOnlyList<SS> FindSSByFROM_HOMEGROUP(string KGCKEY)
        {
            IReadOnlyList<SS> result;
            if (SS_FROM_HOMEGROUPForeignIndex.Value.TryGetValue(KGCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SS entities by [SS.FROM_HOMEGROUP]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find SS entities</param>
        /// <param name="Value">A list of related SS entities</param>
        /// <returns>True if any SS entities are found</returns>
        public bool TryFindSSByFROM_HOMEGROUP(string KGCKEY, out IReadOnlyList<SS> Value)
        {
            return SS_FROM_HOMEGROUPForeignIndex.Value.TryGetValue(KGCKEY, out Value);
        }

        /// <summary>
        /// Find all SS (Specialist Subjects) entities by [SS.TO_HOMEGROUP]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find SS entities</param>
        /// <returns>A list of related SS entities</returns>
        public IReadOnlyList<SS> FindSSByTO_HOMEGROUP(string KGCKEY)
        {
            IReadOnlyList<SS> result;
            if (SS_TO_HOMEGROUPForeignIndex.Value.TryGetValue(KGCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SS entities by [SS.TO_HOMEGROUP]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find SS entities</param>
        /// <param name="Value">A list of related SS entities</param>
        /// <returns>True if any SS entities are found</returns>
        public bool TryFindSSByTO_HOMEGROUP(string KGCKEY, out IReadOnlyList<SS> Value)
        {
            return SS_TO_HOMEGROUPForeignIndex.Value.TryGetValue(KGCKEY, out Value);
        }

        /// <summary>
        /// Find all SSHG (Specialist Subjects per Home Group) entities by [SSHG.HOMEGROUP]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find SSHG entities</param>
        /// <returns>A list of related SSHG entities</returns>
        public IReadOnlyList<SSHG> FindSSHGByHOMEGROUP(string KGCKEY)
        {
            IReadOnlyList<SSHG> result;
            if (SSHG_HOMEGROUPForeignIndex.Value.TryGetValue(KGCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SSHG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SSHG entities by [SSHG.HOMEGROUP]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find SSHG entities</param>
        /// <param name="Value">A list of related SSHG entities</param>
        /// <returns>True if any SSHG entities are found</returns>
        public bool TryFindSSHGByHOMEGROUP(string KGCKEY, out IReadOnlyList<SSHG> Value)
        {
            return SSHG_HOMEGROUPForeignIndex.Value.TryGetValue(KGCKEY, out Value);
        }

        /// <summary>
        /// Find all SSHG (Specialist Subjects per Home Group) entities by [SSHG.TEACHING_HG]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find SSHG entities</param>
        /// <returns>A list of related SSHG entities</returns>
        public IReadOnlyList<SSHG> FindSSHGByTEACHING_HG(string KGCKEY)
        {
            IReadOnlyList<SSHG> result;
            if (SSHG_TEACHING_HGForeignIndex.Value.TryGetValue(KGCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SSHG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SSHG entities by [SSHG.TEACHING_HG]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find SSHG entities</param>
        /// <param name="Value">A list of related SSHG entities</param>
        /// <returns>True if any SSHG entities are found</returns>
        public bool TryFindSSHGByTEACHING_HG(string KGCKEY, out IReadOnlyList<SSHG> Value)
        {
            return SSHG_TEACHING_HGForeignIndex.Value.TryGetValue(KGCKEY, out Value);
        }

        /// <summary>
        /// Find all ST (Students) entities by [ST.HOME_GROUP]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find ST entities</param>
        /// <returns>A list of related ST entities</returns>
        public IReadOnlyList<ST> FindSTByHOME_GROUP(string KGCKEY)
        {
            IReadOnlyList<ST> result;
            if (ST_HOME_GROUPForeignIndex.Value.TryGetValue(KGCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<ST>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ST entities by [ST.HOME_GROUP]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find ST entities</param>
        /// <param name="Value">A list of related ST entities</param>
        /// <returns>True if any ST entities are found</returns>
        public bool TryFindSTByHOME_GROUP(string KGCKEY, out IReadOnlyList<ST> Value)
        {
            return ST_HOME_GROUPForeignIndex.Value.TryGetValue(KGCKEY, out Value);
        }

        /// <summary>
        /// Find all ST (Students) entities by [ST.NEXT_HG]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find ST entities</param>
        /// <returns>A list of related ST entities</returns>
        public IReadOnlyList<ST> FindSTByNEXT_HG(string KGCKEY)
        {
            IReadOnlyList<ST> result;
            if (ST_NEXT_HGForeignIndex.Value.TryGetValue(KGCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<ST>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ST entities by [ST.NEXT_HG]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find ST entities</param>
        /// <param name="Value">A list of related ST entities</param>
        /// <returns>True if any ST entities are found</returns>
        public bool TryFindSTByNEXT_HG(string KGCKEY, out IReadOnlyList<ST> Value)
        {
            return ST_NEXT_HGForeignIndex.Value.TryGetValue(KGCKEY, out Value);
        }

        /// <summary>
        /// Find all ST_TFR (ST Transfer) entities by [ST_TFR.HOME_GROUP_NEW]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find ST_TFR entities</param>
        /// <returns>A list of related ST_TFR entities</returns>
        public IReadOnlyList<ST_TFR> FindST_TFRByHOME_GROUP_NEW(string KGCKEY)
        {
            IReadOnlyList<ST_TFR> result;
            if (ST_TFR_HOME_GROUP_NEWForeignIndex.Value.TryGetValue(KGCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<ST_TFR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ST_TFR entities by [ST_TFR.HOME_GROUP_NEW]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find ST_TFR entities</param>
        /// <param name="Value">A list of related ST_TFR entities</param>
        /// <returns>True if any ST_TFR entities are found</returns>
        public bool TryFindST_TFRByHOME_GROUP_NEW(string KGCKEY, out IReadOnlyList<ST_TFR> Value)
        {
            return ST_TFR_HOME_GROUP_NEWForeignIndex.Value.TryGetValue(KGCKEY, out Value);
        }

        /// <summary>
        /// Find all STRE (Student Re-Enrolment) entities by [STRE.ST_HOME_GROUP]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find STRE entities</param>
        /// <returns>A list of related STRE entities</returns>
        public IReadOnlyList<STRE> FindSTREByST_HOME_GROUP(string KGCKEY)
        {
            IReadOnlyList<STRE> result;
            if (STRE_ST_HOME_GROUPForeignIndex.Value.TryGetValue(KGCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STRE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STRE entities by [STRE.ST_HOME_GROUP]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find STRE entities</param>
        /// <param name="Value">A list of related STRE entities</param>
        /// <returns>True if any STRE entities are found</returns>
        public bool TryFindSTREByST_HOME_GROUP(string KGCKEY, out IReadOnlyList<STRE> Value)
        {
            return STRE_ST_HOME_GROUPForeignIndex.Value.TryGetValue(KGCKEY, out Value);
        }

        /// <summary>
        /// Find all TE (Calendar Events) entities by [TE.START_FORM]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find TE entities</param>
        /// <returns>A list of related TE entities</returns>
        public IReadOnlyList<TE> FindTEBySTART_FORM(string KGCKEY)
        {
            IReadOnlyList<TE> result;
            if (TE_START_FORMForeignIndex.Value.TryGetValue(KGCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TE entities by [TE.START_FORM]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find TE entities</param>
        /// <param name="Value">A list of related TE entities</param>
        /// <returns>True if any TE entities are found</returns>
        public bool TryFindTEBySTART_FORM(string KGCKEY, out IReadOnlyList<TE> Value)
        {
            return TE_START_FORMForeignIndex.Value.TryGetValue(KGCKEY, out Value);
        }

        /// <summary>
        /// Find all TE (Calendar Events) entities by [TE.END_FORM]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find TE entities</param>
        /// <returns>A list of related TE entities</returns>
        public IReadOnlyList<TE> FindTEByEND_FORM(string KGCKEY)
        {
            IReadOnlyList<TE> result;
            if (TE_END_FORMForeignIndex.Value.TryGetValue(KGCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TE entities by [TE.END_FORM]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find TE entities</param>
        /// <param name="Value">A list of related TE entities</param>
        /// <returns>True if any TE entities are found</returns>
        public bool TryFindTEByEND_FORM(string KGCKEY, out IReadOnlyList<TE> Value)
        {
            return TE_END_FORMForeignIndex.Value.TryGetValue(KGCKEY, out Value);
        }

        /// <summary>
        /// Find all TXHG (Home Group Daily Attendance Records) entities by [TXHG.HOME_GROUP]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find TXHG entities</param>
        /// <returns>A list of related TXHG entities</returns>
        public IReadOnlyList<TXHG> FindTXHGByHOME_GROUP(string KGCKEY)
        {
            IReadOnlyList<TXHG> result;
            if (TXHG_HOME_GROUPForeignIndex.Value.TryGetValue(KGCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TXHG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TXHG entities by [TXHG.HOME_GROUP]-&gt;[KGC.KGCKEY]
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find TXHG entities</param>
        /// <param name="Value">A list of related TXHG entities</param>
        /// <returns>True if any TXHG entities are found</returns>
        public bool TryFindTXHGByHOME_GROUP(string KGCKEY, out IReadOnlyList<TXHG> Value)
        {
            return TXHG_HOME_GROUPForeignIndex.Value.TryGetValue(KGCKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGC" /> fields for each CSV column header</returns>
        protected override Action<KGC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGCKEY":
                        mapper[i] = (e, v) => e.KGCKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TEACHER":
                        mapper[i] = (e, v) => e.TEACHER = v;
                        break;
                    case "TEACHER_B":
                        mapper[i] = (e, v) => e.TEACHER_B = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "HG_SIZE":
                        mapper[i] = (e, v) => e.HG_SIZE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MALES":
                        mapper[i] = (e, v) => e.MALES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FEMALES":
                        mapper[i] = (e, v) => e.FEMALES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MIN_AC_YR":
                        mapper[i] = (e, v) => e.MIN_AC_YR = v;
                        break;
                    case "MAX_AC_YR":
                        mapper[i] = (e, v) => e.MAX_AC_YR = v;
                        break;
                    case "NEXT_HG":
                        mapper[i] = (e, v) => e.NEXT_HG = v;
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
