using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Steps or Pay Class Data Set
    /// </summary>
    public sealed partial class PSDataSet : SetBase<PS>
    {
        private Lazy<Dictionary<short, PS>> PSKEYIndex;

        private Lazy<Dictionary<short, IReadOnlyList<PEF>>> PEF_PAY_STEPForeignIndex;
        private Lazy<Dictionary<short, IReadOnlyList<PEFH>>> PEFH_PAY_STEPForeignIndex;
        private Lazy<Dictionary<short, IReadOnlyList<PEPS>>> PEPS_PAY_STEPForeignIndex;
        private Lazy<Dictionary<short, IReadOnlyList<PSF>>> PSF_PSKEYForeignIndex;

        internal PSDataSet(EduHubContext Context)
            : base(Context)
        {
            PSKEYIndex = new Lazy<Dictionary<short, PS>>(() => this.ToDictionary(e => e.PSKEY));

            PEF_PAY_STEPForeignIndex =
                new Lazy<Dictionary<short, IReadOnlyList<PEF>>>(() =>
                    Context.PEF
                          .Where(e => e.PAY_STEP != null)
                          .GroupBy(e => e.PAY_STEP.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEF>)g.ToList()
                          .AsReadOnly()));

            PEFH_PAY_STEPForeignIndex =
                new Lazy<Dictionary<short, IReadOnlyList<PEFH>>>(() =>
                    Context.PEFH
                          .Where(e => e.PAY_STEP != null)
                          .GroupBy(e => e.PAY_STEP.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEFH>)g.ToList()
                          .AsReadOnly()));

            PEPS_PAY_STEPForeignIndex =
                new Lazy<Dictionary<short, IReadOnlyList<PEPS>>>(() =>
                    Context.PEPS
                          .Where(e => e.PAY_STEP != null)
                          .GroupBy(e => e.PAY_STEP.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEPS>)g.ToList()
                          .AsReadOnly()));

            PSF_PSKEYForeignIndex =
                new Lazy<Dictionary<short, IReadOnlyList<PSF>>>(() =>
                    Context.PSF
                          .Where(e => e.PSKEY != null)
                          .GroupBy(e => e.PSKEY.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PSF>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PS"; } }

        /// <summary>
        /// Find PS by PSKEY key field
        /// </summary>
        /// <param name="Key">PSKEY value used to find PS</param>
        /// <returns>Related PS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">PSKEY value didn't match any PS entities</exception>
        public PS FindByPSKEY(short Key)
        {
            PS result;
            if (PSKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find PS by PSKEY key field
        /// </summary>
        /// <param name="Key">PSKEY value used to find PS</param>
        /// <param name="Value">Related PS entity</param>
        /// <returns>True if the PS entity is found</returns>
        public bool TryFindByPSKEY(short Key, out PS Value)
        {
            return PSKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find PS by PSKEY key field
        /// </summary>
        /// <param name="Key">PSKEY value used to find PS</param>
        /// <returns>Related PS entity, or null if not found</returns>
        public PS TryFindByPSKEY(short Key)
        {
            PS result;
            if (PSKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all PEF (Payroll Transactions) entities by [PEF.PAY_STEP]-&gt;[PS.PSKEY]
        /// </summary>
        /// <param name="PSKEY">PSKEY value used to find PEF entities</param>
        /// <returns>A list of related PEF entities</returns>
        public IReadOnlyList<PEF> FindPEFByPAY_STEP(short PSKEY)
        {
            IReadOnlyList<PEF> result;
            if (PEF_PAY_STEPForeignIndex.Value.TryGetValue(PSKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PEF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEF entities by [PEF.PAY_STEP]-&gt;[PS.PSKEY]
        /// </summary>
        /// <param name="PSKEY">PSKEY value used to find PEF entities</param>
        /// <param name="Value">A list of related PEF entities</param>
        /// <returns>True if any PEF entities are found</returns>
        public bool TryFindPEFByPAY_STEP(short PSKEY, out IReadOnlyList<PEF> Value)
        {
            return PEF_PAY_STEPForeignIndex.Value.TryGetValue(PSKEY, out Value);
        }

        /// <summary>
        /// Find all PEFH (Payroll Transaction History) entities by [PEFH.PAY_STEP]-&gt;[PS.PSKEY]
        /// </summary>
        /// <param name="PSKEY">PSKEY value used to find PEFH entities</param>
        /// <returns>A list of related PEFH entities</returns>
        public IReadOnlyList<PEFH> FindPEFHByPAY_STEP(short PSKEY)
        {
            IReadOnlyList<PEFH> result;
            if (PEFH_PAY_STEPForeignIndex.Value.TryGetValue(PSKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PEFH>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEFH entities by [PEFH.PAY_STEP]-&gt;[PS.PSKEY]
        /// </summary>
        /// <param name="PSKEY">PSKEY value used to find PEFH entities</param>
        /// <param name="Value">A list of related PEFH entities</param>
        /// <returns>True if any PEFH entities are found</returns>
        public bool TryFindPEFHByPAY_STEP(short PSKEY, out IReadOnlyList<PEFH> Value)
        {
            return PEFH_PAY_STEPForeignIndex.Value.TryGetValue(PSKEY, out Value);
        }

        /// <summary>
        /// Find all PEPS (Standard and Last Pays) entities by [PEPS.PAY_STEP]-&gt;[PS.PSKEY]
        /// </summary>
        /// <param name="PSKEY">PSKEY value used to find PEPS entities</param>
        /// <returns>A list of related PEPS entities</returns>
        public IReadOnlyList<PEPS> FindPEPSByPAY_STEP(short PSKEY)
        {
            IReadOnlyList<PEPS> result;
            if (PEPS_PAY_STEPForeignIndex.Value.TryGetValue(PSKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PEPS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEPS entities by [PEPS.PAY_STEP]-&gt;[PS.PSKEY]
        /// </summary>
        /// <param name="PSKEY">PSKEY value used to find PEPS entities</param>
        /// <param name="Value">A list of related PEPS entities</param>
        /// <returns>True if any PEPS entities are found</returns>
        public bool TryFindPEPSByPAY_STEP(short PSKEY, out IReadOnlyList<PEPS> Value)
        {
            return PEPS_PAY_STEPForeignIndex.Value.TryGetValue(PSKEY, out Value);
        }

        /// <summary>
        /// Find all PSF (Future Pay Steps or Pay Class) entities by [PSF.PSKEY]-&gt;[PS.PSKEY]
        /// </summary>
        /// <param name="PSKEY">PSKEY value used to find PSF entities</param>
        /// <returns>A list of related PSF entities</returns>
        public IReadOnlyList<PSF> FindPSFByPSKEY(short PSKEY)
        {
            IReadOnlyList<PSF> result;
            if (PSF_PSKEYForeignIndex.Value.TryGetValue(PSKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PSF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PSF entities by [PSF.PSKEY]-&gt;[PS.PSKEY]
        /// </summary>
        /// <param name="PSKEY">PSKEY value used to find PSF entities</param>
        /// <param name="Value">A list of related PSF entities</param>
        /// <returns>True if any PSF entities are found</returns>
        public bool TryFindPSFByPSKEY(short PSKEY, out IReadOnlyList<PSF> Value)
        {
            return PSF_PSKEYForeignIndex.Value.TryGetValue(PSKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PS" /> fields for each CSV column header</returns>
        protected override Action<PS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PSKEY":
                        mapper[i] = (e, v) => e.PSKEY = short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "PAY_TYPE":
                        mapper[i] = (e, v) => e.PAY_TYPE = v;
                        break;
                    case "EFFECTIVE_DATE":
                        mapper[i] = (e, v) => e.EFFECTIVE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ANNUAL_RATE":
                        mapper[i] = (e, v) => e.ANNUAL_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "MONTHLY_RATE":
                        mapper[i] = (e, v) => e.MONTHLY_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "FORTNIGHTLY_RATE":
                        mapper[i] = (e, v) => e.FORTNIGHTLY_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "WEEKLY_RATE":
                        mapper[i] = (e, v) => e.WEEKLY_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "HOURLY_RATE":
                        mapper[i] = (e, v) => e.HOURLY_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "STD_WEEKLY_HOURS":
                        mapper[i] = (e, v) => e.STD_WEEKLY_HOURS = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "STD_MONTHLY_HOURS":
                        mapper[i] = (e, v) => e.STD_MONTHLY_HOURS = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
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
