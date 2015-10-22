using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Cost Centres Data Set
    /// </summary>
    public sealed partial class PCDataSet : SetBase<PC>
    {
        private Lazy<Dictionary<string, PC>> PCKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<PEF>>> PEF_TRCENTREForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PEFH>>> PEFH_TRCENTREForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PEPS>>> PEPS_TRCENTREForeignIndex;

        internal PCDataSet(EduHubContext Context)
            : base(Context)
        {
            PCKEYIndex = new Lazy<Dictionary<string, PC>>(() => this.ToDictionary(e => e.PCKEY));

            PEF_TRCENTREForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PEF>>>(() =>
                    Context.PEF
                          .Where(e => e.TRCENTRE != null)
                          .GroupBy(e => e.TRCENTRE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEF>)g.ToList()
                          .AsReadOnly()));

            PEFH_TRCENTREForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PEFH>>>(() =>
                    Context.PEFH
                          .Where(e => e.TRCENTRE != null)
                          .GroupBy(e => e.TRCENTRE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEFH>)g.ToList()
                          .AsReadOnly()));

            PEPS_TRCENTREForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PEPS>>>(() =>
                    Context.PEPS
                          .Where(e => e.TRCENTRE != null)
                          .GroupBy(e => e.TRCENTRE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEPS>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PC"; } }

        /// <summary>
        /// Find PC by PCKEY key field
        /// </summary>
        /// <param name="Key">PCKEY value used to find PC</param>
        /// <returns>Related PC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">PCKEY value didn't match any PC entities</exception>
        public PC FindByPCKEY(string Key)
        {
            PC result;
            if (PCKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find PC by PCKEY key field
        /// </summary>
        /// <param name="Key">PCKEY value used to find PC</param>
        /// <param name="Value">Related PC entity</param>
        /// <returns>True if the PC entity is found</returns>
        public bool TryFindByPCKEY(string Key, out PC Value)
        {
            return PCKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find PC by PCKEY key field
        /// </summary>
        /// <param name="Key">PCKEY value used to find PC</param>
        /// <returns>Related PC entity, or null if not found</returns>
        public PC TryFindByPCKEY(string Key)
        {
            PC result;
            if (PCKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all PEF (Payroll Transactions) entities by [PEF.TRCENTRE]-&gt;[PC.PCKEY]
        /// </summary>
        /// <param name="PCKEY">PCKEY value used to find PEF entities</param>
        /// <returns>A list of related PEF entities</returns>
        public IReadOnlyList<PEF> FindPEFByTRCENTRE(string PCKEY)
        {
            IReadOnlyList<PEF> result;
            if (PEF_TRCENTREForeignIndex.Value.TryGetValue(PCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PEF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEF entities by [PEF.TRCENTRE]-&gt;[PC.PCKEY]
        /// </summary>
        /// <param name="PCKEY">PCKEY value used to find PEF entities</param>
        /// <param name="Value">A list of related PEF entities</param>
        /// <returns>True if any PEF entities are found</returns>
        public bool TryFindPEFByTRCENTRE(string PCKEY, out IReadOnlyList<PEF> Value)
        {
            return PEF_TRCENTREForeignIndex.Value.TryGetValue(PCKEY, out Value);
        }

        /// <summary>
        /// Find all PEFH (Payroll Transaction History) entities by [PEFH.TRCENTRE]-&gt;[PC.PCKEY]
        /// </summary>
        /// <param name="PCKEY">PCKEY value used to find PEFH entities</param>
        /// <returns>A list of related PEFH entities</returns>
        public IReadOnlyList<PEFH> FindPEFHByTRCENTRE(string PCKEY)
        {
            IReadOnlyList<PEFH> result;
            if (PEFH_TRCENTREForeignIndex.Value.TryGetValue(PCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PEFH>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEFH entities by [PEFH.TRCENTRE]-&gt;[PC.PCKEY]
        /// </summary>
        /// <param name="PCKEY">PCKEY value used to find PEFH entities</param>
        /// <param name="Value">A list of related PEFH entities</param>
        /// <returns>True if any PEFH entities are found</returns>
        public bool TryFindPEFHByTRCENTRE(string PCKEY, out IReadOnlyList<PEFH> Value)
        {
            return PEFH_TRCENTREForeignIndex.Value.TryGetValue(PCKEY, out Value);
        }

        /// <summary>
        /// Find all PEPS (Standard and Last Pays) entities by [PEPS.TRCENTRE]-&gt;[PC.PCKEY]
        /// </summary>
        /// <param name="PCKEY">PCKEY value used to find PEPS entities</param>
        /// <returns>A list of related PEPS entities</returns>
        public IReadOnlyList<PEPS> FindPEPSByTRCENTRE(string PCKEY)
        {
            IReadOnlyList<PEPS> result;
            if (PEPS_TRCENTREForeignIndex.Value.TryGetValue(PCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PEPS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEPS entities by [PEPS.TRCENTRE]-&gt;[PC.PCKEY]
        /// </summary>
        /// <param name="PCKEY">PCKEY value used to find PEPS entities</param>
        /// <param name="Value">A list of related PEPS entities</param>
        /// <returns>True if any PEPS entities are found</returns>
        public bool TryFindPEPSByTRCENTRE(string PCKEY, out IReadOnlyList<PEPS> Value)
        {
            return PEPS_TRCENTREForeignIndex.Value.TryGetValue(PCKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PC" /> fields for each CSV column header</returns>
        protected override Action<PC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PCKEY":
                        mapper[i] = (e, v) => e.PCKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "SUBPROGRAM":
                        mapper[i] = (e, v) => e.SUBPROGRAM = v;
                        break;
                    case "GLPROGRAM":
                        mapper[i] = (e, v) => e.GLPROGRAM = v;
                        break;
                    case "INITIATIVE":
                        mapper[i] = (e, v) => e.INITIATIVE = v;
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
