using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Languages Data Set
    /// </summary>
    public sealed partial class KGLDataSet : SetBase<KGL>
    {
        private Lazy<Dictionary<string, KGL>> KGLKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<DF>>> DF_NATIVE_LANG_AForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<DF>>> DF_OTHER_LANG_AForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<DF>>> DF_LOTE_HOME_CODE_AForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<DF>>> DF_NATIVE_LANG_BForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<DF>>> DF_OTHER_LANG_BForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<DF>>> DF_LOTE_HOME_CODE_BForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<DF>>> DF_PREF_NOTICE_LANGForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<DF>>> DF_EMERG_LANG01ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<DF>>> DF_EMERG_LANG02ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<DF>>> DF_EMERG_LANG03ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<DF>>> DF_EMERG_LANG04ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<DF>>> DF_HOME_LANGForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<OSCS>>> OSCS_HOME_LANGForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_LANG01ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_LANG02ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_EMERG_LANG01ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_EMERG_LANG02ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SPU>>> SPU_HOME_LANGUAGEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ST>>> ST_HOME_LANGForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ST>>> ST_EMERG_LANG01ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ST>>> ST_EMERG_LANG02ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ST>>> ST_LANGUAGE_PREVIOUS_SCHOOLINGForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ST>>> ST_LOTE_HOME_CODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STRE>>> STRE_ST_HOME_LANGForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STRE>>> STRE_ST_LOTE_HOME_CODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STRE>>> STRE_DF_LOTE_HOME_CODE_AForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STRE>>> STRE_DF_LOTE_HOME_CODE_BForeignIndex;

        internal KGLDataSet(EduHubContext Context)
            : base(Context)
        {
            KGLKEYIndex = new Lazy<Dictionary<string, KGL>>(() => this.ToDictionary(e => e.KGLKEY));

            DF_NATIVE_LANG_AForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DF>>>(() =>
                    Context.DF
                          .Where(e => e.NATIVE_LANG_A != null)
                          .GroupBy(e => e.NATIVE_LANG_A)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DF>)g.ToList()
                          .AsReadOnly()));

            DF_OTHER_LANG_AForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DF>>>(() =>
                    Context.DF
                          .Where(e => e.OTHER_LANG_A != null)
                          .GroupBy(e => e.OTHER_LANG_A)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DF>)g.ToList()
                          .AsReadOnly()));

            DF_LOTE_HOME_CODE_AForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DF>>>(() =>
                    Context.DF
                          .Where(e => e.LOTE_HOME_CODE_A != null)
                          .GroupBy(e => e.LOTE_HOME_CODE_A)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DF>)g.ToList()
                          .AsReadOnly()));

            DF_NATIVE_LANG_BForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DF>>>(() =>
                    Context.DF
                          .Where(e => e.NATIVE_LANG_B != null)
                          .GroupBy(e => e.NATIVE_LANG_B)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DF>)g.ToList()
                          .AsReadOnly()));

            DF_OTHER_LANG_BForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DF>>>(() =>
                    Context.DF
                          .Where(e => e.OTHER_LANG_B != null)
                          .GroupBy(e => e.OTHER_LANG_B)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DF>)g.ToList()
                          .AsReadOnly()));

            DF_LOTE_HOME_CODE_BForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DF>>>(() =>
                    Context.DF
                          .Where(e => e.LOTE_HOME_CODE_B != null)
                          .GroupBy(e => e.LOTE_HOME_CODE_B)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DF>)g.ToList()
                          .AsReadOnly()));

            DF_PREF_NOTICE_LANGForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DF>>>(() =>
                    Context.DF
                          .Where(e => e.PREF_NOTICE_LANG != null)
                          .GroupBy(e => e.PREF_NOTICE_LANG)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DF>)g.ToList()
                          .AsReadOnly()));

            DF_EMERG_LANG01ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DF>>>(() =>
                    Context.DF
                          .Where(e => e.EMERG_LANG01 != null)
                          .GroupBy(e => e.EMERG_LANG01)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DF>)g.ToList()
                          .AsReadOnly()));

            DF_EMERG_LANG02ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DF>>>(() =>
                    Context.DF
                          .Where(e => e.EMERG_LANG02 != null)
                          .GroupBy(e => e.EMERG_LANG02)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DF>)g.ToList()
                          .AsReadOnly()));

            DF_EMERG_LANG03ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DF>>>(() =>
                    Context.DF
                          .Where(e => e.EMERG_LANG03 != null)
                          .GroupBy(e => e.EMERG_LANG03)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DF>)g.ToList()
                          .AsReadOnly()));

            DF_EMERG_LANG04ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DF>>>(() =>
                    Context.DF
                          .Where(e => e.EMERG_LANG04 != null)
                          .GroupBy(e => e.EMERG_LANG04)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DF>)g.ToList()
                          .AsReadOnly()));

            DF_HOME_LANGForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DF>>>(() =>
                    Context.DF
                          .Where(e => e.HOME_LANG != null)
                          .GroupBy(e => e.HOME_LANG)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DF>)g.ToList()
                          .AsReadOnly()));

            OSCS_HOME_LANGForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<OSCS>>>(() =>
                    Context.OSCS
                          .Where(e => e.HOME_LANG != null)
                          .GroupBy(e => e.HOME_LANG)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<OSCS>)g.ToList()
                          .AsReadOnly()));

            SF_LANG01ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.LANG01 != null)
                          .GroupBy(e => e.LANG01)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            SF_LANG02ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.LANG02 != null)
                          .GroupBy(e => e.LANG02)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            SF_EMERG_LANG01ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.EMERG_LANG01 != null)
                          .GroupBy(e => e.EMERG_LANG01)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            SF_EMERG_LANG02ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.EMERG_LANG02 != null)
                          .GroupBy(e => e.EMERG_LANG02)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            SPU_HOME_LANGUAGEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SPU>>>(() =>
                    Context.SPU
                          .Where(e => e.HOME_LANGUAGE != null)
                          .GroupBy(e => e.HOME_LANGUAGE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SPU>)g.ToList()
                          .AsReadOnly()));

            ST_HOME_LANGForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ST>>>(() =>
                    Context.ST
                          .Where(e => e.HOME_LANG != null)
                          .GroupBy(e => e.HOME_LANG)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ST>)g.ToList()
                          .AsReadOnly()));

            ST_EMERG_LANG01ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ST>>>(() =>
                    Context.ST
                          .Where(e => e.EMERG_LANG01 != null)
                          .GroupBy(e => e.EMERG_LANG01)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ST>)g.ToList()
                          .AsReadOnly()));

            ST_EMERG_LANG02ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ST>>>(() =>
                    Context.ST
                          .Where(e => e.EMERG_LANG02 != null)
                          .GroupBy(e => e.EMERG_LANG02)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ST>)g.ToList()
                          .AsReadOnly()));

            ST_LANGUAGE_PREVIOUS_SCHOOLINGForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ST>>>(() =>
                    Context.ST
                          .Where(e => e.LANGUAGE_PREVIOUS_SCHOOLING != null)
                          .GroupBy(e => e.LANGUAGE_PREVIOUS_SCHOOLING)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ST>)g.ToList()
                          .AsReadOnly()));

            ST_LOTE_HOME_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ST>>>(() =>
                    Context.ST
                          .Where(e => e.LOTE_HOME_CODE != null)
                          .GroupBy(e => e.LOTE_HOME_CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ST>)g.ToList()
                          .AsReadOnly()));

            STRE_ST_HOME_LANGForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STRE>>>(() =>
                    Context.STRE
                          .Where(e => e.ST_HOME_LANG != null)
                          .GroupBy(e => e.ST_HOME_LANG)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STRE>)g.ToList()
                          .AsReadOnly()));

            STRE_ST_LOTE_HOME_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STRE>>>(() =>
                    Context.STRE
                          .Where(e => e.ST_LOTE_HOME_CODE != null)
                          .GroupBy(e => e.ST_LOTE_HOME_CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STRE>)g.ToList()
                          .AsReadOnly()));

            STRE_DF_LOTE_HOME_CODE_AForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STRE>>>(() =>
                    Context.STRE
                          .Where(e => e.DF_LOTE_HOME_CODE_A != null)
                          .GroupBy(e => e.DF_LOTE_HOME_CODE_A)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STRE>)g.ToList()
                          .AsReadOnly()));

            STRE_DF_LOTE_HOME_CODE_BForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STRE>>>(() =>
                    Context.STRE
                          .Where(e => e.DF_LOTE_HOME_CODE_B != null)
                          .GroupBy(e => e.DF_LOTE_HOME_CODE_B)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STRE>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGL"; } }

        /// <summary>
        /// Find KGL by KGLKEY key field
        /// </summary>
        /// <param name="Key">KGLKEY value used to find KGL</param>
        /// <returns>Related KGL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KGLKEY value didn't match any KGL entities</exception>
        public KGL FindByKGLKEY(string Key)
        {
            KGL result;
            if (KGLKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KGL by KGLKEY key field
        /// </summary>
        /// <param name="Key">KGLKEY value used to find KGL</param>
        /// <param name="Value">Related KGL entity</param>
        /// <returns>True if the KGL entity is found</returns>
        public bool TryFindByKGLKEY(string Key, out KGL Value)
        {
            return KGLKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KGL by KGLKEY key field
        /// </summary>
        /// <param name="Key">KGLKEY value used to find KGL</param>
        /// <returns>Related KGL entity, or null if not found</returns>
        public KGL TryFindByKGLKEY(string Key)
        {
            KGL result;
            if (KGLKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all DF (Families) entities by [DF.NATIVE_LANG_A]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find DF entities</param>
        /// <returns>A list of related DF entities</returns>
        public IReadOnlyList<DF> FindDFByNATIVE_LANG_A(string KGLKEY)
        {
            IReadOnlyList<DF> result;
            if (DF_NATIVE_LANG_AForeignIndex.Value.TryGetValue(KGLKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<DF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DF entities by [DF.NATIVE_LANG_A]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find DF entities</param>
        /// <param name="Value">A list of related DF entities</param>
        /// <returns>True if any DF entities are found</returns>
        public bool TryFindDFByNATIVE_LANG_A(string KGLKEY, out IReadOnlyList<DF> Value)
        {
            return DF_NATIVE_LANG_AForeignIndex.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Find all DF (Families) entities by [DF.OTHER_LANG_A]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find DF entities</param>
        /// <returns>A list of related DF entities</returns>
        public IReadOnlyList<DF> FindDFByOTHER_LANG_A(string KGLKEY)
        {
            IReadOnlyList<DF> result;
            if (DF_OTHER_LANG_AForeignIndex.Value.TryGetValue(KGLKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<DF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DF entities by [DF.OTHER_LANG_A]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find DF entities</param>
        /// <param name="Value">A list of related DF entities</param>
        /// <returns>True if any DF entities are found</returns>
        public bool TryFindDFByOTHER_LANG_A(string KGLKEY, out IReadOnlyList<DF> Value)
        {
            return DF_OTHER_LANG_AForeignIndex.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Find all DF (Families) entities by [DF.LOTE_HOME_CODE_A]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find DF entities</param>
        /// <returns>A list of related DF entities</returns>
        public IReadOnlyList<DF> FindDFByLOTE_HOME_CODE_A(string KGLKEY)
        {
            IReadOnlyList<DF> result;
            if (DF_LOTE_HOME_CODE_AForeignIndex.Value.TryGetValue(KGLKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<DF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DF entities by [DF.LOTE_HOME_CODE_A]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find DF entities</param>
        /// <param name="Value">A list of related DF entities</param>
        /// <returns>True if any DF entities are found</returns>
        public bool TryFindDFByLOTE_HOME_CODE_A(string KGLKEY, out IReadOnlyList<DF> Value)
        {
            return DF_LOTE_HOME_CODE_AForeignIndex.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Find all DF (Families) entities by [DF.NATIVE_LANG_B]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find DF entities</param>
        /// <returns>A list of related DF entities</returns>
        public IReadOnlyList<DF> FindDFByNATIVE_LANG_B(string KGLKEY)
        {
            IReadOnlyList<DF> result;
            if (DF_NATIVE_LANG_BForeignIndex.Value.TryGetValue(KGLKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<DF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DF entities by [DF.NATIVE_LANG_B]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find DF entities</param>
        /// <param name="Value">A list of related DF entities</param>
        /// <returns>True if any DF entities are found</returns>
        public bool TryFindDFByNATIVE_LANG_B(string KGLKEY, out IReadOnlyList<DF> Value)
        {
            return DF_NATIVE_LANG_BForeignIndex.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Find all DF (Families) entities by [DF.OTHER_LANG_B]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find DF entities</param>
        /// <returns>A list of related DF entities</returns>
        public IReadOnlyList<DF> FindDFByOTHER_LANG_B(string KGLKEY)
        {
            IReadOnlyList<DF> result;
            if (DF_OTHER_LANG_BForeignIndex.Value.TryGetValue(KGLKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<DF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DF entities by [DF.OTHER_LANG_B]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find DF entities</param>
        /// <param name="Value">A list of related DF entities</param>
        /// <returns>True if any DF entities are found</returns>
        public bool TryFindDFByOTHER_LANG_B(string KGLKEY, out IReadOnlyList<DF> Value)
        {
            return DF_OTHER_LANG_BForeignIndex.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Find all DF (Families) entities by [DF.LOTE_HOME_CODE_B]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find DF entities</param>
        /// <returns>A list of related DF entities</returns>
        public IReadOnlyList<DF> FindDFByLOTE_HOME_CODE_B(string KGLKEY)
        {
            IReadOnlyList<DF> result;
            if (DF_LOTE_HOME_CODE_BForeignIndex.Value.TryGetValue(KGLKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<DF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DF entities by [DF.LOTE_HOME_CODE_B]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find DF entities</param>
        /// <param name="Value">A list of related DF entities</param>
        /// <returns>True if any DF entities are found</returns>
        public bool TryFindDFByLOTE_HOME_CODE_B(string KGLKEY, out IReadOnlyList<DF> Value)
        {
            return DF_LOTE_HOME_CODE_BForeignIndex.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Find all DF (Families) entities by [DF.PREF_NOTICE_LANG]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find DF entities</param>
        /// <returns>A list of related DF entities</returns>
        public IReadOnlyList<DF> FindDFByPREF_NOTICE_LANG(string KGLKEY)
        {
            IReadOnlyList<DF> result;
            if (DF_PREF_NOTICE_LANGForeignIndex.Value.TryGetValue(KGLKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<DF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DF entities by [DF.PREF_NOTICE_LANG]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find DF entities</param>
        /// <param name="Value">A list of related DF entities</param>
        /// <returns>True if any DF entities are found</returns>
        public bool TryFindDFByPREF_NOTICE_LANG(string KGLKEY, out IReadOnlyList<DF> Value)
        {
            return DF_PREF_NOTICE_LANGForeignIndex.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Find all DF (Families) entities by [DF.EMERG_LANG01]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find DF entities</param>
        /// <returns>A list of related DF entities</returns>
        public IReadOnlyList<DF> FindDFByEMERG_LANG01(string KGLKEY)
        {
            IReadOnlyList<DF> result;
            if (DF_EMERG_LANG01ForeignIndex.Value.TryGetValue(KGLKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<DF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DF entities by [DF.EMERG_LANG01]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find DF entities</param>
        /// <param name="Value">A list of related DF entities</param>
        /// <returns>True if any DF entities are found</returns>
        public bool TryFindDFByEMERG_LANG01(string KGLKEY, out IReadOnlyList<DF> Value)
        {
            return DF_EMERG_LANG01ForeignIndex.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Find all DF (Families) entities by [DF.EMERG_LANG02]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find DF entities</param>
        /// <returns>A list of related DF entities</returns>
        public IReadOnlyList<DF> FindDFByEMERG_LANG02(string KGLKEY)
        {
            IReadOnlyList<DF> result;
            if (DF_EMERG_LANG02ForeignIndex.Value.TryGetValue(KGLKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<DF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DF entities by [DF.EMERG_LANG02]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find DF entities</param>
        /// <param name="Value">A list of related DF entities</param>
        /// <returns>True if any DF entities are found</returns>
        public bool TryFindDFByEMERG_LANG02(string KGLKEY, out IReadOnlyList<DF> Value)
        {
            return DF_EMERG_LANG02ForeignIndex.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Find all DF (Families) entities by [DF.EMERG_LANG03]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find DF entities</param>
        /// <returns>A list of related DF entities</returns>
        public IReadOnlyList<DF> FindDFByEMERG_LANG03(string KGLKEY)
        {
            IReadOnlyList<DF> result;
            if (DF_EMERG_LANG03ForeignIndex.Value.TryGetValue(KGLKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<DF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DF entities by [DF.EMERG_LANG03]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find DF entities</param>
        /// <param name="Value">A list of related DF entities</param>
        /// <returns>True if any DF entities are found</returns>
        public bool TryFindDFByEMERG_LANG03(string KGLKEY, out IReadOnlyList<DF> Value)
        {
            return DF_EMERG_LANG03ForeignIndex.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Find all DF (Families) entities by [DF.EMERG_LANG04]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find DF entities</param>
        /// <returns>A list of related DF entities</returns>
        public IReadOnlyList<DF> FindDFByEMERG_LANG04(string KGLKEY)
        {
            IReadOnlyList<DF> result;
            if (DF_EMERG_LANG04ForeignIndex.Value.TryGetValue(KGLKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<DF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DF entities by [DF.EMERG_LANG04]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find DF entities</param>
        /// <param name="Value">A list of related DF entities</param>
        /// <returns>True if any DF entities are found</returns>
        public bool TryFindDFByEMERG_LANG04(string KGLKEY, out IReadOnlyList<DF> Value)
        {
            return DF_EMERG_LANG04ForeignIndex.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Find all DF (Families) entities by [DF.HOME_LANG]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find DF entities</param>
        /// <returns>A list of related DF entities</returns>
        public IReadOnlyList<DF> FindDFByHOME_LANG(string KGLKEY)
        {
            IReadOnlyList<DF> result;
            if (DF_HOME_LANGForeignIndex.Value.TryGetValue(KGLKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<DF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DF entities by [DF.HOME_LANG]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find DF entities</param>
        /// <param name="Value">A list of related DF entities</param>
        /// <returns>True if any DF entities are found</returns>
        public bool TryFindDFByHOME_LANG(string KGLKEY, out IReadOnlyList<DF> Value)
        {
            return DF_HOME_LANGForeignIndex.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Find all OSCS (CASES Past Students) entities by [OSCS.HOME_LANG]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find OSCS entities</param>
        /// <returns>A list of related OSCS entities</returns>
        public IReadOnlyList<OSCS> FindOSCSByHOME_LANG(string KGLKEY)
        {
            IReadOnlyList<OSCS> result;
            if (OSCS_HOME_LANGForeignIndex.Value.TryGetValue(KGLKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<OSCS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all OSCS entities by [OSCS.HOME_LANG]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find OSCS entities</param>
        /// <param name="Value">A list of related OSCS entities</param>
        /// <returns>True if any OSCS entities are found</returns>
        public bool TryFindOSCSByHOME_LANG(string KGLKEY, out IReadOnlyList<OSCS> Value)
        {
            return OSCS_HOME_LANGForeignIndex.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.LANG01]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFByLANG01(string KGLKEY)
        {
            IReadOnlyList<SF> result;
            if (SF_LANG01ForeignIndex.Value.TryGetValue(KGLKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.LANG01]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFByLANG01(string KGLKEY, out IReadOnlyList<SF> Value)
        {
            return SF_LANG01ForeignIndex.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.LANG02]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFByLANG02(string KGLKEY)
        {
            IReadOnlyList<SF> result;
            if (SF_LANG02ForeignIndex.Value.TryGetValue(KGLKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.LANG02]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFByLANG02(string KGLKEY, out IReadOnlyList<SF> Value)
        {
            return SF_LANG02ForeignIndex.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.EMERG_LANG01]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFByEMERG_LANG01(string KGLKEY)
        {
            IReadOnlyList<SF> result;
            if (SF_EMERG_LANG01ForeignIndex.Value.TryGetValue(KGLKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.EMERG_LANG01]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFByEMERG_LANG01(string KGLKEY, out IReadOnlyList<SF> Value)
        {
            return SF_EMERG_LANG01ForeignIndex.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.EMERG_LANG02]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFByEMERG_LANG02(string KGLKEY)
        {
            IReadOnlyList<SF> result;
            if (SF_EMERG_LANG02ForeignIndex.Value.TryGetValue(KGLKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.EMERG_LANG02]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFByEMERG_LANG02(string KGLKEY, out IReadOnlyList<SF> Value)
        {
            return SF_EMERG_LANG02ForeignIndex.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Find all SPU (Publications) entities by [SPU.HOME_LANGUAGE]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find SPU entities</param>
        /// <returns>A list of related SPU entities</returns>
        public IReadOnlyList<SPU> FindSPUByHOME_LANGUAGE(string KGLKEY)
        {
            IReadOnlyList<SPU> result;
            if (SPU_HOME_LANGUAGEForeignIndex.Value.TryGetValue(KGLKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SPU>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SPU entities by [SPU.HOME_LANGUAGE]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find SPU entities</param>
        /// <param name="Value">A list of related SPU entities</param>
        /// <returns>True if any SPU entities are found</returns>
        public bool TryFindSPUByHOME_LANGUAGE(string KGLKEY, out IReadOnlyList<SPU> Value)
        {
            return SPU_HOME_LANGUAGEForeignIndex.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Find all ST (Students) entities by [ST.HOME_LANG]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find ST entities</param>
        /// <returns>A list of related ST entities</returns>
        public IReadOnlyList<ST> FindSTByHOME_LANG(string KGLKEY)
        {
            IReadOnlyList<ST> result;
            if (ST_HOME_LANGForeignIndex.Value.TryGetValue(KGLKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<ST>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ST entities by [ST.HOME_LANG]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find ST entities</param>
        /// <param name="Value">A list of related ST entities</param>
        /// <returns>True if any ST entities are found</returns>
        public bool TryFindSTByHOME_LANG(string KGLKEY, out IReadOnlyList<ST> Value)
        {
            return ST_HOME_LANGForeignIndex.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Find all ST (Students) entities by [ST.EMERG_LANG01]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find ST entities</param>
        /// <returns>A list of related ST entities</returns>
        public IReadOnlyList<ST> FindSTByEMERG_LANG01(string KGLKEY)
        {
            IReadOnlyList<ST> result;
            if (ST_EMERG_LANG01ForeignIndex.Value.TryGetValue(KGLKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<ST>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ST entities by [ST.EMERG_LANG01]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find ST entities</param>
        /// <param name="Value">A list of related ST entities</param>
        /// <returns>True if any ST entities are found</returns>
        public bool TryFindSTByEMERG_LANG01(string KGLKEY, out IReadOnlyList<ST> Value)
        {
            return ST_EMERG_LANG01ForeignIndex.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Find all ST (Students) entities by [ST.EMERG_LANG02]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find ST entities</param>
        /// <returns>A list of related ST entities</returns>
        public IReadOnlyList<ST> FindSTByEMERG_LANG02(string KGLKEY)
        {
            IReadOnlyList<ST> result;
            if (ST_EMERG_LANG02ForeignIndex.Value.TryGetValue(KGLKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<ST>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ST entities by [ST.EMERG_LANG02]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find ST entities</param>
        /// <param name="Value">A list of related ST entities</param>
        /// <returns>True if any ST entities are found</returns>
        public bool TryFindSTByEMERG_LANG02(string KGLKEY, out IReadOnlyList<ST> Value)
        {
            return ST_EMERG_LANG02ForeignIndex.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Find all ST (Students) entities by [ST.LANGUAGE_PREVIOUS_SCHOOLING]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find ST entities</param>
        /// <returns>A list of related ST entities</returns>
        public IReadOnlyList<ST> FindSTByLANGUAGE_PREVIOUS_SCHOOLING(string KGLKEY)
        {
            IReadOnlyList<ST> result;
            if (ST_LANGUAGE_PREVIOUS_SCHOOLINGForeignIndex.Value.TryGetValue(KGLKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<ST>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ST entities by [ST.LANGUAGE_PREVIOUS_SCHOOLING]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find ST entities</param>
        /// <param name="Value">A list of related ST entities</param>
        /// <returns>True if any ST entities are found</returns>
        public bool TryFindSTByLANGUAGE_PREVIOUS_SCHOOLING(string KGLKEY, out IReadOnlyList<ST> Value)
        {
            return ST_LANGUAGE_PREVIOUS_SCHOOLINGForeignIndex.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Find all ST (Students) entities by [ST.LOTE_HOME_CODE]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find ST entities</param>
        /// <returns>A list of related ST entities</returns>
        public IReadOnlyList<ST> FindSTByLOTE_HOME_CODE(string KGLKEY)
        {
            IReadOnlyList<ST> result;
            if (ST_LOTE_HOME_CODEForeignIndex.Value.TryGetValue(KGLKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<ST>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ST entities by [ST.LOTE_HOME_CODE]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find ST entities</param>
        /// <param name="Value">A list of related ST entities</param>
        /// <returns>True if any ST entities are found</returns>
        public bool TryFindSTByLOTE_HOME_CODE(string KGLKEY, out IReadOnlyList<ST> Value)
        {
            return ST_LOTE_HOME_CODEForeignIndex.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Find all STRE (Student Re-Enrolment) entities by [STRE.ST_HOME_LANG]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find STRE entities</param>
        /// <returns>A list of related STRE entities</returns>
        public IReadOnlyList<STRE> FindSTREByST_HOME_LANG(string KGLKEY)
        {
            IReadOnlyList<STRE> result;
            if (STRE_ST_HOME_LANGForeignIndex.Value.TryGetValue(KGLKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STRE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STRE entities by [STRE.ST_HOME_LANG]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find STRE entities</param>
        /// <param name="Value">A list of related STRE entities</param>
        /// <returns>True if any STRE entities are found</returns>
        public bool TryFindSTREByST_HOME_LANG(string KGLKEY, out IReadOnlyList<STRE> Value)
        {
            return STRE_ST_HOME_LANGForeignIndex.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Find all STRE (Student Re-Enrolment) entities by [STRE.ST_LOTE_HOME_CODE]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find STRE entities</param>
        /// <returns>A list of related STRE entities</returns>
        public IReadOnlyList<STRE> FindSTREByST_LOTE_HOME_CODE(string KGLKEY)
        {
            IReadOnlyList<STRE> result;
            if (STRE_ST_LOTE_HOME_CODEForeignIndex.Value.TryGetValue(KGLKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STRE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STRE entities by [STRE.ST_LOTE_HOME_CODE]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find STRE entities</param>
        /// <param name="Value">A list of related STRE entities</param>
        /// <returns>True if any STRE entities are found</returns>
        public bool TryFindSTREByST_LOTE_HOME_CODE(string KGLKEY, out IReadOnlyList<STRE> Value)
        {
            return STRE_ST_LOTE_HOME_CODEForeignIndex.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Find all STRE (Student Re-Enrolment) entities by [STRE.DF_LOTE_HOME_CODE_A]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find STRE entities</param>
        /// <returns>A list of related STRE entities</returns>
        public IReadOnlyList<STRE> FindSTREByDF_LOTE_HOME_CODE_A(string KGLKEY)
        {
            IReadOnlyList<STRE> result;
            if (STRE_DF_LOTE_HOME_CODE_AForeignIndex.Value.TryGetValue(KGLKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STRE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STRE entities by [STRE.DF_LOTE_HOME_CODE_A]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find STRE entities</param>
        /// <param name="Value">A list of related STRE entities</param>
        /// <returns>True if any STRE entities are found</returns>
        public bool TryFindSTREByDF_LOTE_HOME_CODE_A(string KGLKEY, out IReadOnlyList<STRE> Value)
        {
            return STRE_DF_LOTE_HOME_CODE_AForeignIndex.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Find all STRE (Student Re-Enrolment) entities by [STRE.DF_LOTE_HOME_CODE_B]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find STRE entities</param>
        /// <returns>A list of related STRE entities</returns>
        public IReadOnlyList<STRE> FindSTREByDF_LOTE_HOME_CODE_B(string KGLKEY)
        {
            IReadOnlyList<STRE> result;
            if (STRE_DF_LOTE_HOME_CODE_BForeignIndex.Value.TryGetValue(KGLKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STRE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STRE entities by [STRE.DF_LOTE_HOME_CODE_B]-&gt;[KGL.KGLKEY]
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find STRE entities</param>
        /// <param name="Value">A list of related STRE entities</param>
        /// <returns>True if any STRE entities are found</returns>
        public bool TryFindSTREByDF_LOTE_HOME_CODE_B(string KGLKEY, out IReadOnlyList<STRE> Value)
        {
            return STRE_DF_LOTE_HOME_CODE_BForeignIndex.Value.TryGetValue(KGLKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGL" /> fields for each CSV column header</returns>
        protected override Action<KGL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGLKEY":
                        mapper[i] = (e, v) => e.KGLKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "NOTICES_AVAILABLE":
                        mapper[i] = (e, v) => e.NOTICES_AVAILABLE = v;
                        break;
                    case "ASCL":
                        mapper[i] = (e, v) => e.ASCL = v;
                        break;
                    case "CASESKEY":
                        mapper[i] = (e, v) => e.CASESKEY = v;
                        break;
                    case "CASES_CASES21_CONV":
                        mapper[i] = (e, v) => e.CASES_CASES21_CONV = v;
                        break;
                    case "OBSOLETE":
                        mapper[i] = (e, v) => e.OBSOLETE = v;
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
