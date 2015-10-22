using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Faculties Data Set
    /// </summary>
    public sealed partial class KSFDataSet : SetBase<KSF>
    {
        private Lazy<Dictionary<string, KSF>> KSFKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_FACULTY01ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_FACULTY02ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_FACULTY03ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_FACULTY04ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SM>>> SM_FACULTYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SU>>> SU_FACULTYForeignIndex;

        internal KSFDataSet(EduHubContext Context)
            : base(Context)
        {
            KSFKEYIndex = new Lazy<Dictionary<string, KSF>>(() => this.ToDictionary(e => e.KSFKEY));

            SF_FACULTY01ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.FACULTY01 != null)
                          .GroupBy(e => e.FACULTY01)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            SF_FACULTY02ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.FACULTY02 != null)
                          .GroupBy(e => e.FACULTY02)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            SF_FACULTY03ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.FACULTY03 != null)
                          .GroupBy(e => e.FACULTY03)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            SF_FACULTY04ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.FACULTY04 != null)
                          .GroupBy(e => e.FACULTY04)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            SM_FACULTYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SM>>>(() =>
                    Context.SM
                          .Where(e => e.FACULTY != null)
                          .GroupBy(e => e.FACULTY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SM>)g.ToList()
                          .AsReadOnly()));

            SU_FACULTYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SU>>>(() =>
                    Context.SU
                          .Where(e => e.FACULTY != null)
                          .GroupBy(e => e.FACULTY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SU>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KSF"; } }

        /// <summary>
        /// Find KSF by KSFKEY key field
        /// </summary>
        /// <param name="Key">KSFKEY value used to find KSF</param>
        /// <returns>Related KSF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KSFKEY value didn't match any KSF entities</exception>
        public KSF FindByKSFKEY(string Key)
        {
            KSF result;
            if (KSFKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KSF by KSFKEY key field
        /// </summary>
        /// <param name="Key">KSFKEY value used to find KSF</param>
        /// <param name="Value">Related KSF entity</param>
        /// <returns>True if the KSF entity is found</returns>
        public bool TryFindByKSFKEY(string Key, out KSF Value)
        {
            return KSFKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KSF by KSFKEY key field
        /// </summary>
        /// <param name="Key">KSFKEY value used to find KSF</param>
        /// <returns>Related KSF entity, or null if not found</returns>
        public KSF TryFindByKSFKEY(string Key)
        {
            KSF result;
            if (KSFKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.FACULTY01]-&gt;[KSF.KSFKEY]
        /// </summary>
        /// <param name="KSFKEY">KSFKEY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFByFACULTY01(string KSFKEY)
        {
            IReadOnlyList<SF> result;
            if (SF_FACULTY01ForeignIndex.Value.TryGetValue(KSFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.FACULTY01]-&gt;[KSF.KSFKEY]
        /// </summary>
        /// <param name="KSFKEY">KSFKEY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFByFACULTY01(string KSFKEY, out IReadOnlyList<SF> Value)
        {
            return SF_FACULTY01ForeignIndex.Value.TryGetValue(KSFKEY, out Value);
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.FACULTY02]-&gt;[KSF.KSFKEY]
        /// </summary>
        /// <param name="KSFKEY">KSFKEY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFByFACULTY02(string KSFKEY)
        {
            IReadOnlyList<SF> result;
            if (SF_FACULTY02ForeignIndex.Value.TryGetValue(KSFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.FACULTY02]-&gt;[KSF.KSFKEY]
        /// </summary>
        /// <param name="KSFKEY">KSFKEY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFByFACULTY02(string KSFKEY, out IReadOnlyList<SF> Value)
        {
            return SF_FACULTY02ForeignIndex.Value.TryGetValue(KSFKEY, out Value);
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.FACULTY03]-&gt;[KSF.KSFKEY]
        /// </summary>
        /// <param name="KSFKEY">KSFKEY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFByFACULTY03(string KSFKEY)
        {
            IReadOnlyList<SF> result;
            if (SF_FACULTY03ForeignIndex.Value.TryGetValue(KSFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.FACULTY03]-&gt;[KSF.KSFKEY]
        /// </summary>
        /// <param name="KSFKEY">KSFKEY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFByFACULTY03(string KSFKEY, out IReadOnlyList<SF> Value)
        {
            return SF_FACULTY03ForeignIndex.Value.TryGetValue(KSFKEY, out Value);
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.FACULTY04]-&gt;[KSF.KSFKEY]
        /// </summary>
        /// <param name="KSFKEY">KSFKEY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFByFACULTY04(string KSFKEY)
        {
            IReadOnlyList<SF> result;
            if (SF_FACULTY04ForeignIndex.Value.TryGetValue(KSFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.FACULTY04]-&gt;[KSF.KSFKEY]
        /// </summary>
        /// <param name="KSFKEY">KSFKEY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFByFACULTY04(string KSFKEY, out IReadOnlyList<SF> Value)
        {
            return SF_FACULTY04ForeignIndex.Value.TryGetValue(KSFKEY, out Value);
        }

        /// <summary>
        /// Find all SM (Rooms) entities by [SM.FACULTY]-&gt;[KSF.KSFKEY]
        /// </summary>
        /// <param name="KSFKEY">KSFKEY value used to find SM entities</param>
        /// <returns>A list of related SM entities</returns>
        public IReadOnlyList<SM> FindSMByFACULTY(string KSFKEY)
        {
            IReadOnlyList<SM> result;
            if (SM_FACULTYForeignIndex.Value.TryGetValue(KSFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SM>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SM entities by [SM.FACULTY]-&gt;[KSF.KSFKEY]
        /// </summary>
        /// <param name="KSFKEY">KSFKEY value used to find SM entities</param>
        /// <param name="Value">A list of related SM entities</param>
        /// <returns>True if any SM entities are found</returns>
        public bool TryFindSMByFACULTY(string KSFKEY, out IReadOnlyList<SM> Value)
        {
            return SM_FACULTYForeignIndex.Value.TryGetValue(KSFKEY, out Value);
        }

        /// <summary>
        /// Find all SU (Subjects) entities by [SU.FACULTY]-&gt;[KSF.KSFKEY]
        /// </summary>
        /// <param name="KSFKEY">KSFKEY value used to find SU entities</param>
        /// <returns>A list of related SU entities</returns>
        public IReadOnlyList<SU> FindSUByFACULTY(string KSFKEY)
        {
            IReadOnlyList<SU> result;
            if (SU_FACULTYForeignIndex.Value.TryGetValue(KSFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SU>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SU entities by [SU.FACULTY]-&gt;[KSF.KSFKEY]
        /// </summary>
        /// <param name="KSFKEY">KSFKEY value used to find SU entities</param>
        /// <param name="Value">A list of related SU entities</param>
        /// <returns>True if any SU entities are found</returns>
        public bool TryFindSUByFACULTY(string KSFKEY, out IReadOnlyList<SU> Value)
        {
            return SU_FACULTYForeignIndex.Value.TryGetValue(KSFKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KSF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KSF" /> fields for each CSV column header</returns>
        protected override Action<KSF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KSF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KSFKEY":
                        mapper[i] = (e, v) => e.KSFKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "COORDINATOR":
                        mapper[i] = (e, v) => e.COORDINATOR = v;
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
