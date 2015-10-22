using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Items Data Set
    /// </summary>
    public sealed partial class PIDataSet : SetBase<PI>
    {
        private Lazy<Dictionary<short, PI>> PIKEYIndex;

        private Lazy<Dictionary<short, IReadOnlyList<PEF>>> PEF_PAYITEMForeignIndex;
        private Lazy<Dictionary<short, IReadOnlyList<PEFH>>> PEFH_PAYITEMForeignIndex;
        private Lazy<Dictionary<short, IReadOnlyList<PEPS>>> PEPS_PAYITEMForeignIndex;
        private Lazy<Dictionary<short, IReadOnlyList<PEPU>>> PEPU_PAYITEMForeignIndex;
        private Lazy<Dictionary<short, IReadOnlyList<PEPUH>>> PEPUH_PAYITEMForeignIndex;
        private Lazy<Dictionary<short, IReadOnlyList<PETP>>> PETP_PAYITEMForeignIndex;
        private Lazy<Dictionary<short, IReadOnlyList<PI>>> PI_BASEITEMForeignIndex;
        private Lazy<Dictionary<short, IReadOnlyList<PILI>>> PILI_PIKEYForeignIndex;

        internal PIDataSet(EduHubContext Context)
            : base(Context)
        {
            PIKEYIndex = new Lazy<Dictionary<short, PI>>(() => this.ToDictionary(e => e.PIKEY));

            PEF_PAYITEMForeignIndex =
                new Lazy<Dictionary<short, IReadOnlyList<PEF>>>(() =>
                    Context.PEF
                          .Where(e => e.PAYITEM != null)
                          .GroupBy(e => e.PAYITEM.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEF>)g.ToList()
                          .AsReadOnly()));

            PEFH_PAYITEMForeignIndex =
                new Lazy<Dictionary<short, IReadOnlyList<PEFH>>>(() =>
                    Context.PEFH
                          .Where(e => e.PAYITEM != null)
                          .GroupBy(e => e.PAYITEM.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEFH>)g.ToList()
                          .AsReadOnly()));

            PEPS_PAYITEMForeignIndex =
                new Lazy<Dictionary<short, IReadOnlyList<PEPS>>>(() =>
                    Context.PEPS
                          .Where(e => e.PAYITEM != null)
                          .GroupBy(e => e.PAYITEM.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEPS>)g.ToList()
                          .AsReadOnly()));

            PEPU_PAYITEMForeignIndex =
                new Lazy<Dictionary<short, IReadOnlyList<PEPU>>>(() =>
                    Context.PEPU
                          .Where(e => e.PAYITEM != null)
                          .GroupBy(e => e.PAYITEM.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEPU>)g.ToList()
                          .AsReadOnly()));

            PEPUH_PAYITEMForeignIndex =
                new Lazy<Dictionary<short, IReadOnlyList<PEPUH>>>(() =>
                    Context.PEPUH
                          .Where(e => e.PAYITEM != null)
                          .GroupBy(e => e.PAYITEM.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEPUH>)g.ToList()
                          .AsReadOnly()));

            PETP_PAYITEMForeignIndex =
                new Lazy<Dictionary<short, IReadOnlyList<PETP>>>(() =>
                    Context.PETP
                          .Where(e => e.PAYITEM != null)
                          .GroupBy(e => e.PAYITEM.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PETP>)g.ToList()
                          .AsReadOnly()));

            PI_BASEITEMForeignIndex =
                new Lazy<Dictionary<short, IReadOnlyList<PI>>>(() =>
                    Context.PI
                          .Where(e => e.BASEITEM != null)
                          .GroupBy(e => e.BASEITEM.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PI>)g.ToList()
                          .AsReadOnly()));

            PILI_PIKEYForeignIndex =
                new Lazy<Dictionary<short, IReadOnlyList<PILI>>>(() =>
                    Context.PILI
                          .Where(e => e.PIKEY != null)
                          .GroupBy(e => e.PIKEY.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PILI>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PI"; } }

        /// <summary>
        /// Find PI by PIKEY key field
        /// </summary>
        /// <param name="Key">PIKEY value used to find PI</param>
        /// <returns>Related PI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">PIKEY value didn't match any PI entities</exception>
        public PI FindByPIKEY(short Key)
        {
            PI result;
            if (PIKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find PI by PIKEY key field
        /// </summary>
        /// <param name="Key">PIKEY value used to find PI</param>
        /// <param name="Value">Related PI entity</param>
        /// <returns>True if the PI entity is found</returns>
        public bool TryFindByPIKEY(short Key, out PI Value)
        {
            return PIKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find PI by PIKEY key field
        /// </summary>
        /// <param name="Key">PIKEY value used to find PI</param>
        /// <returns>Related PI entity, or null if not found</returns>
        public PI TryFindByPIKEY(short Key)
        {
            PI result;
            if (PIKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all PEF (Payroll Transactions) entities by [PEF.PAYITEM]-&gt;[PI.PIKEY]
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PEF entities</param>
        /// <returns>A list of related PEF entities</returns>
        public IReadOnlyList<PEF> FindPEFByPAYITEM(short PIKEY)
        {
            IReadOnlyList<PEF> result;
            if (PEF_PAYITEMForeignIndex.Value.TryGetValue(PIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PEF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEF entities by [PEF.PAYITEM]-&gt;[PI.PIKEY]
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PEF entities</param>
        /// <param name="Value">A list of related PEF entities</param>
        /// <returns>True if any PEF entities are found</returns>
        public bool TryFindPEFByPAYITEM(short PIKEY, out IReadOnlyList<PEF> Value)
        {
            return PEF_PAYITEMForeignIndex.Value.TryGetValue(PIKEY, out Value);
        }

        /// <summary>
        /// Find all PEFH (Payroll Transaction History) entities by [PEFH.PAYITEM]-&gt;[PI.PIKEY]
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PEFH entities</param>
        /// <returns>A list of related PEFH entities</returns>
        public IReadOnlyList<PEFH> FindPEFHByPAYITEM(short PIKEY)
        {
            IReadOnlyList<PEFH> result;
            if (PEFH_PAYITEMForeignIndex.Value.TryGetValue(PIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PEFH>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEFH entities by [PEFH.PAYITEM]-&gt;[PI.PIKEY]
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PEFH entities</param>
        /// <param name="Value">A list of related PEFH entities</param>
        /// <returns>True if any PEFH entities are found</returns>
        public bool TryFindPEFHByPAYITEM(short PIKEY, out IReadOnlyList<PEFH> Value)
        {
            return PEFH_PAYITEMForeignIndex.Value.TryGetValue(PIKEY, out Value);
        }

        /// <summary>
        /// Find all PEPS (Standard and Last Pays) entities by [PEPS.PAYITEM]-&gt;[PI.PIKEY]
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PEPS entities</param>
        /// <returns>A list of related PEPS entities</returns>
        public IReadOnlyList<PEPS> FindPEPSByPAYITEM(short PIKEY)
        {
            IReadOnlyList<PEPS> result;
            if (PEPS_PAYITEMForeignIndex.Value.TryGetValue(PIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PEPS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEPS entities by [PEPS.PAYITEM]-&gt;[PI.PIKEY]
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PEPS entities</param>
        /// <param name="Value">A list of related PEPS entities</param>
        /// <returns>True if any PEPS entities are found</returns>
        public bool TryFindPEPSByPAYITEM(short PIKEY, out IReadOnlyList<PEPS> Value)
        {
            return PEPS_PAYITEMForeignIndex.Value.TryGetValue(PIKEY, out Value);
        }

        /// <summary>
        /// Find all PEPU (Super (SGL and Employee) YTD Transactions) entities by [PEPU.PAYITEM]-&gt;[PI.PIKEY]
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PEPU entities</param>
        /// <returns>A list of related PEPU entities</returns>
        public IReadOnlyList<PEPU> FindPEPUByPAYITEM(short PIKEY)
        {
            IReadOnlyList<PEPU> result;
            if (PEPU_PAYITEMForeignIndex.Value.TryGetValue(PIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PEPU>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEPU entities by [PEPU.PAYITEM]-&gt;[PI.PIKEY]
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PEPU entities</param>
        /// <param name="Value">A list of related PEPU entities</param>
        /// <returns>True if any PEPU entities are found</returns>
        public bool TryFindPEPUByPAYITEM(short PIKEY, out IReadOnlyList<PEPU> Value)
        {
            return PEPU_PAYITEMForeignIndex.Value.TryGetValue(PIKEY, out Value);
        }

        /// <summary>
        /// Find all PEPUH (Super (SGL and Employee) History YTD Transactions) entities by [PEPUH.PAYITEM]-&gt;[PI.PIKEY]
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PEPUH entities</param>
        /// <returns>A list of related PEPUH entities</returns>
        public IReadOnlyList<PEPUH> FindPEPUHByPAYITEM(short PIKEY)
        {
            IReadOnlyList<PEPUH> result;
            if (PEPUH_PAYITEMForeignIndex.Value.TryGetValue(PIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PEPUH>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEPUH entities by [PEPUH.PAYITEM]-&gt;[PI.PIKEY]
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PEPUH entities</param>
        /// <param name="Value">A list of related PEPUH entities</param>
        /// <returns>True if any PEPUH entities are found</returns>
        public bool TryFindPEPUHByPAYITEM(short PIKEY, out IReadOnlyList<PEPUH> Value)
        {
            return PEPUH_PAYITEMForeignIndex.Value.TryGetValue(PIKEY, out Value);
        }

        /// <summary>
        /// Find all PETP (Termination Payment) entities by [PETP.PAYITEM]-&gt;[PI.PIKEY]
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PETP entities</param>
        /// <returns>A list of related PETP entities</returns>
        public IReadOnlyList<PETP> FindPETPByPAYITEM(short PIKEY)
        {
            IReadOnlyList<PETP> result;
            if (PETP_PAYITEMForeignIndex.Value.TryGetValue(PIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PETP>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PETP entities by [PETP.PAYITEM]-&gt;[PI.PIKEY]
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PETP entities</param>
        /// <param name="Value">A list of related PETP entities</param>
        /// <returns>True if any PETP entities are found</returns>
        public bool TryFindPETPByPAYITEM(short PIKEY, out IReadOnlyList<PETP> Value)
        {
            return PETP_PAYITEMForeignIndex.Value.TryGetValue(PIKEY, out Value);
        }

        /// <summary>
        /// Find all PI (Pay Items) entities by [PI.BASEITEM]-&gt;[PI.PIKEY]
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PI entities</param>
        /// <returns>A list of related PI entities</returns>
        public IReadOnlyList<PI> FindPIByBASEITEM(short PIKEY)
        {
            IReadOnlyList<PI> result;
            if (PI_BASEITEMForeignIndex.Value.TryGetValue(PIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PI entities by [PI.BASEITEM]-&gt;[PI.PIKEY]
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PI entities</param>
        /// <param name="Value">A list of related PI entities</param>
        /// <returns>True if any PI entities are found</returns>
        public bool TryFindPIByBASEITEM(short PIKEY, out IReadOnlyList<PI> Value)
        {
            return PI_BASEITEMForeignIndex.Value.TryGetValue(PIKEY, out Value);
        }

        /// <summary>
        /// Find all PILI (Pay Item Leave Items) entities by [PILI.PIKEY]-&gt;[PI.PIKEY]
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PILI entities</param>
        /// <returns>A list of related PILI entities</returns>
        public IReadOnlyList<PILI> FindPILIByPIKEY(short PIKEY)
        {
            IReadOnlyList<PILI> result;
            if (PILI_PIKEYForeignIndex.Value.TryGetValue(PIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PILI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PILI entities by [PILI.PIKEY]-&gt;[PI.PIKEY]
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PILI entities</param>
        /// <param name="Value">A list of related PILI entities</param>
        /// <returns>True if any PILI entities are found</returns>
        public bool TryFindPILIByPIKEY(short PIKEY, out IReadOnlyList<PILI> Value)
        {
            return PILI_PIKEYForeignIndex.Value.TryGetValue(PIKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PI" /> fields for each CSV column header</returns>
        protected override Action<PI, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PIKEY":
                        mapper[i] = (e, v) => e.PIKEY = short.Parse(v);
                        break;
                    case "PAYCODE":
                        mapper[i] = (e, v) => e.PAYCODE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "TRANSTYPE":
                        mapper[i] = (e, v) => e.TRANSTYPE = v;
                        break;
                    case "TAXABLE":
                        mapper[i] = (e, v) => e.TAXABLE = v;
                        break;
                    case "UNIT":
                        mapper[i] = (e, v) => e.UNIT = v;
                        break;
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
                        break;
                    case "PAYG_BOX":
                        mapper[i] = (e, v) => e.PAYG_BOX = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TAXRATE":
                        mapper[i] = (e, v) => e.TAXRATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TAXFREE":
                        mapper[i] = (e, v) => e.TAXFREE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BASEITEM":
                        mapper[i] = (e, v) => e.BASEITEM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "BASELOAD":
                        mapper[i] = (e, v) => e.BASELOAD = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "BASETYPE":
                        mapper[i] = (e, v) => e.BASETYPE = v;
                        break;
                    case "AWARD":
                        mapper[i] = (e, v) => e.AWARD = v;
                        break;
                    case "ACCRUED":
                        mapper[i] = (e, v) => e.ACCRUED = v;
                        break;
                    case "ACCRUE_ITEM01":
                        mapper[i] = (e, v) => e.ACCRUE_ITEM01 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ACCRUE_ITEM02":
                        mapper[i] = (e, v) => e.ACCRUE_ITEM02 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ACCRUE_ITEM03":
                        mapper[i] = (e, v) => e.ACCRUE_ITEM03 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ACCRUE_ITEM04":
                        mapper[i] = (e, v) => e.ACCRUE_ITEM04 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ACCRUE_RATEA01":
                        mapper[i] = (e, v) => e.ACCRUE_RATEA01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ACCRUE_RATEA02":
                        mapper[i] = (e, v) => e.ACCRUE_RATEA02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ACCRUE_RATEA03":
                        mapper[i] = (e, v) => e.ACCRUE_RATEA03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ACCRUE_RATEA04":
                        mapper[i] = (e, v) => e.ACCRUE_RATEA04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ACCRUE_RATEB01":
                        mapper[i] = (e, v) => e.ACCRUE_RATEB01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ACCRUE_RATEB02":
                        mapper[i] = (e, v) => e.ACCRUE_RATEB02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ACCRUE_RATEB03":
                        mapper[i] = (e, v) => e.ACCRUE_RATEB03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ACCRUE_RATEB04":
                        mapper[i] = (e, v) => e.ACCRUE_RATEB04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AUTOCALC":
                        mapper[i] = (e, v) => e.AUTOCALC = v;
                        break;
                    case "DHOURS":
                        mapper[i] = (e, v) => e.DHOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "DRATE":
                        mapper[i] = (e, v) => e.DRATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "DPAY_YEAR":
                        mapper[i] = (e, v) => e.DPAY_YEAR = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DPAY_QTY":
                        mapper[i] = (e, v) => e.DPAY_QTY = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "DVALUE":
                        mapper[i] = (e, v) => e.DVALUE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_LEVY":
                        mapper[i] = (e, v) => e.SUPER_LEVY = v;
                        break;
                    case "PERS_SUPER":
                        mapper[i] = (e, v) => e.PERS_SUPER = v;
                        break;
                    case "PERS_SUPER_RATE":
                        mapper[i] = (e, v) => e.PERS_SUPER_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "AFFECTS_LEAVE":
                        mapper[i] = (e, v) => e.AFFECTS_LEAVE = v;
                        break;
                    case "LEAVE_CODE":
                        mapper[i] = (e, v) => e.LEAVE_CODE = v;
                        break;
                    case "PERCENT_AFFECT":
                        mapper[i] = (e, v) => e.PERCENT_AFFECT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "CLR_GLCODE":
                        mapper[i] = (e, v) => e.CLR_GLCODE = v;
                        break;
                    case "SHORT_DESC":
                        mapper[i] = (e, v) => e.SHORT_DESC = v;
                        break;
                    case "LEAVELOAD_ITEM":
                        mapper[i] = (e, v) => e.LEAVELOAD_ITEM = v;
                        break;
                    case "LEAVE_BASEITEM":
                        mapper[i] = (e, v) => e.LEAVE_BASEITEM = v;
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
                    case "NORMAL_SPLIT":
                        mapper[i] = (e, v) => e.NORMAL_SPLIT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "LPA_SPLIT":
                        mapper[i] = (e, v) => e.LPA_SPLIT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ANNUALISED_LOADING":
                        mapper[i] = (e, v) => e.ANNUALISED_LOADING = v == null ? (double?)null : double.Parse(v);
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
