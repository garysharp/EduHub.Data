using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Fees Data Set
    /// </summary>
    public sealed partial class SADataSet : SetBase<SA>
    {
        private Lazy<Dictionary<string, SA>> SAKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<DFF>>> DFF_FEE_CODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<DR>>> DR_DRTABLEAForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SAB>>> SAB_FEE_CODE_1STForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SAB>>> SAB_FEE_CODE_2NDForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SAB>>> SAB_FEE_CODE_3RDForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SAB>>> SAB_FEE_CODE_4THForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SAB>>> SAB_FEE_CODE_KGForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SABT>>> SABT_FEE_CODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STSB>>> STSB_SPLIT_ITEMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SU>>> SU_FEE_CODEForeignIndex;

        internal SADataSet(EduHubContext Context)
            : base(Context)
        {
            SAKEYIndex = new Lazy<Dictionary<string, SA>>(() => this.ToDictionary(e => e.SAKEY));

            DFF_FEE_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DFF>>>(() =>
                    Context.DFF
                          .Where(e => e.FEE_CODE != null)
                          .GroupBy(e => e.FEE_CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DFF>)g.ToList()
                          .AsReadOnly()));

            DR_DRTABLEAForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DR>>>(() =>
                    Context.DR
                          .Where(e => e.DRTABLEA != null)
                          .GroupBy(e => e.DRTABLEA)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DR>)g.ToList()
                          .AsReadOnly()));

            SAB_FEE_CODE_1STForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SAB>>>(() =>
                    Context.SAB
                          .Where(e => e.FEE_CODE_1ST != null)
                          .GroupBy(e => e.FEE_CODE_1ST)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SAB>)g.ToList()
                          .AsReadOnly()));

            SAB_FEE_CODE_2NDForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SAB>>>(() =>
                    Context.SAB
                          .Where(e => e.FEE_CODE_2ND != null)
                          .GroupBy(e => e.FEE_CODE_2ND)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SAB>)g.ToList()
                          .AsReadOnly()));

            SAB_FEE_CODE_3RDForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SAB>>>(() =>
                    Context.SAB
                          .Where(e => e.FEE_CODE_3RD != null)
                          .GroupBy(e => e.FEE_CODE_3RD)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SAB>)g.ToList()
                          .AsReadOnly()));

            SAB_FEE_CODE_4THForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SAB>>>(() =>
                    Context.SAB
                          .Where(e => e.FEE_CODE_4TH != null)
                          .GroupBy(e => e.FEE_CODE_4TH)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SAB>)g.ToList()
                          .AsReadOnly()));

            SAB_FEE_CODE_KGForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SAB>>>(() =>
                    Context.SAB
                          .Where(e => e.FEE_CODE_KG != null)
                          .GroupBy(e => e.FEE_CODE_KG)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SAB>)g.ToList()
                          .AsReadOnly()));

            SABT_FEE_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SABT>>>(() =>
                    Context.SABT
                          .Where(e => e.FEE_CODE != null)
                          .GroupBy(e => e.FEE_CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SABT>)g.ToList()
                          .AsReadOnly()));

            STSB_SPLIT_ITEMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STSB>>>(() =>
                    Context.STSB
                          .Where(e => e.SPLIT_ITEM != null)
                          .GroupBy(e => e.SPLIT_ITEM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STSB>)g.ToList()
                          .AsReadOnly()));

            SU_FEE_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SU>>>(() =>
                    Context.SU
                          .Where(e => e.FEE_CODE != null)
                          .GroupBy(e => e.FEE_CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SU>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SA"; } }

        /// <summary>
        /// Find SA by SAKEY key field
        /// </summary>
        /// <param name="Key">SAKEY value used to find SA</param>
        /// <returns>Related SA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SAKEY value didn't match any SA entities</exception>
        public SA FindBySAKEY(string Key)
        {
            SA result;
            if (SAKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SA by SAKEY key field
        /// </summary>
        /// <param name="Key">SAKEY value used to find SA</param>
        /// <param name="Value">Related SA entity</param>
        /// <returns>True if the SA entity is found</returns>
        public bool TryFindBySAKEY(string Key, out SA Value)
        {
            return SAKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SA by SAKEY key field
        /// </summary>
        /// <param name="Key">SAKEY value used to find SA</param>
        /// <returns>Related SA entity, or null if not found</returns>
        public SA TryFindBySAKEY(string Key)
        {
            SA result;
            if (SAKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all DFF (Family Financial Transactions) entities by [DFF.FEE_CODE]-&gt;[SA.SAKEY]
        /// </summary>
        /// <param name="SAKEY">SAKEY value used to find DFF entities</param>
        /// <returns>A list of related DFF entities</returns>
        public IReadOnlyList<DFF> FindDFFByFEE_CODE(string SAKEY)
        {
            IReadOnlyList<DFF> result;
            if (DFF_FEE_CODEForeignIndex.Value.TryGetValue(SAKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<DFF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DFF entities by [DFF.FEE_CODE]-&gt;[SA.SAKEY]
        /// </summary>
        /// <param name="SAKEY">SAKEY value used to find DFF entities</param>
        /// <param name="Value">A list of related DFF entities</param>
        /// <returns>True if any DFF entities are found</returns>
        public bool TryFindDFFByFEE_CODE(string SAKEY, out IReadOnlyList<DFF> Value)
        {
            return DFF_FEE_CODEForeignIndex.Value.TryGetValue(SAKEY, out Value);
        }

        /// <summary>
        /// Find all DR (Accounts Receivable) entities by [DR.DRTABLEA]-&gt;[SA.SAKEY]
        /// </summary>
        /// <param name="SAKEY">SAKEY value used to find DR entities</param>
        /// <returns>A list of related DR entities</returns>
        public IReadOnlyList<DR> FindDRByDRTABLEA(string SAKEY)
        {
            IReadOnlyList<DR> result;
            if (DR_DRTABLEAForeignIndex.Value.TryGetValue(SAKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<DR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DR entities by [DR.DRTABLEA]-&gt;[SA.SAKEY]
        /// </summary>
        /// <param name="SAKEY">SAKEY value used to find DR entities</param>
        /// <param name="Value">A list of related DR entities</param>
        /// <returns>True if any DR entities are found</returns>
        public bool TryFindDRByDRTABLEA(string SAKEY, out IReadOnlyList<DR> Value)
        {
            return DR_DRTABLEAForeignIndex.Value.TryGetValue(SAKEY, out Value);
        }

        /// <summary>
        /// Find all SAB (Fees - Billing Templates) entities by [SAB.FEE_CODE_1ST]-&gt;[SA.SAKEY]
        /// </summary>
        /// <param name="SAKEY">SAKEY value used to find SAB entities</param>
        /// <returns>A list of related SAB entities</returns>
        public IReadOnlyList<SAB> FindSABByFEE_CODE_1ST(string SAKEY)
        {
            IReadOnlyList<SAB> result;
            if (SAB_FEE_CODE_1STForeignIndex.Value.TryGetValue(SAKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SAB>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SAB entities by [SAB.FEE_CODE_1ST]-&gt;[SA.SAKEY]
        /// </summary>
        /// <param name="SAKEY">SAKEY value used to find SAB entities</param>
        /// <param name="Value">A list of related SAB entities</param>
        /// <returns>True if any SAB entities are found</returns>
        public bool TryFindSABByFEE_CODE_1ST(string SAKEY, out IReadOnlyList<SAB> Value)
        {
            return SAB_FEE_CODE_1STForeignIndex.Value.TryGetValue(SAKEY, out Value);
        }

        /// <summary>
        /// Find all SAB (Fees - Billing Templates) entities by [SAB.FEE_CODE_2ND]-&gt;[SA.SAKEY]
        /// </summary>
        /// <param name="SAKEY">SAKEY value used to find SAB entities</param>
        /// <returns>A list of related SAB entities</returns>
        public IReadOnlyList<SAB> FindSABByFEE_CODE_2ND(string SAKEY)
        {
            IReadOnlyList<SAB> result;
            if (SAB_FEE_CODE_2NDForeignIndex.Value.TryGetValue(SAKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SAB>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SAB entities by [SAB.FEE_CODE_2ND]-&gt;[SA.SAKEY]
        /// </summary>
        /// <param name="SAKEY">SAKEY value used to find SAB entities</param>
        /// <param name="Value">A list of related SAB entities</param>
        /// <returns>True if any SAB entities are found</returns>
        public bool TryFindSABByFEE_CODE_2ND(string SAKEY, out IReadOnlyList<SAB> Value)
        {
            return SAB_FEE_CODE_2NDForeignIndex.Value.TryGetValue(SAKEY, out Value);
        }

        /// <summary>
        /// Find all SAB (Fees - Billing Templates) entities by [SAB.FEE_CODE_3RD]-&gt;[SA.SAKEY]
        /// </summary>
        /// <param name="SAKEY">SAKEY value used to find SAB entities</param>
        /// <returns>A list of related SAB entities</returns>
        public IReadOnlyList<SAB> FindSABByFEE_CODE_3RD(string SAKEY)
        {
            IReadOnlyList<SAB> result;
            if (SAB_FEE_CODE_3RDForeignIndex.Value.TryGetValue(SAKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SAB>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SAB entities by [SAB.FEE_CODE_3RD]-&gt;[SA.SAKEY]
        /// </summary>
        /// <param name="SAKEY">SAKEY value used to find SAB entities</param>
        /// <param name="Value">A list of related SAB entities</param>
        /// <returns>True if any SAB entities are found</returns>
        public bool TryFindSABByFEE_CODE_3RD(string SAKEY, out IReadOnlyList<SAB> Value)
        {
            return SAB_FEE_CODE_3RDForeignIndex.Value.TryGetValue(SAKEY, out Value);
        }

        /// <summary>
        /// Find all SAB (Fees - Billing Templates) entities by [SAB.FEE_CODE_4TH]-&gt;[SA.SAKEY]
        /// </summary>
        /// <param name="SAKEY">SAKEY value used to find SAB entities</param>
        /// <returns>A list of related SAB entities</returns>
        public IReadOnlyList<SAB> FindSABByFEE_CODE_4TH(string SAKEY)
        {
            IReadOnlyList<SAB> result;
            if (SAB_FEE_CODE_4THForeignIndex.Value.TryGetValue(SAKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SAB>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SAB entities by [SAB.FEE_CODE_4TH]-&gt;[SA.SAKEY]
        /// </summary>
        /// <param name="SAKEY">SAKEY value used to find SAB entities</param>
        /// <param name="Value">A list of related SAB entities</param>
        /// <returns>True if any SAB entities are found</returns>
        public bool TryFindSABByFEE_CODE_4TH(string SAKEY, out IReadOnlyList<SAB> Value)
        {
            return SAB_FEE_CODE_4THForeignIndex.Value.TryGetValue(SAKEY, out Value);
        }

        /// <summary>
        /// Find all SAB (Fees - Billing Templates) entities by [SAB.FEE_CODE_KG]-&gt;[SA.SAKEY]
        /// </summary>
        /// <param name="SAKEY">SAKEY value used to find SAB entities</param>
        /// <returns>A list of related SAB entities</returns>
        public IReadOnlyList<SAB> FindSABByFEE_CODE_KG(string SAKEY)
        {
            IReadOnlyList<SAB> result;
            if (SAB_FEE_CODE_KGForeignIndex.Value.TryGetValue(SAKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SAB>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SAB entities by [SAB.FEE_CODE_KG]-&gt;[SA.SAKEY]
        /// </summary>
        /// <param name="SAKEY">SAKEY value used to find SAB entities</param>
        /// <param name="Value">A list of related SAB entities</param>
        /// <returns>True if any SAB entities are found</returns>
        public bool TryFindSABByFEE_CODE_KG(string SAKEY, out IReadOnlyList<SAB> Value)
        {
            return SAB_FEE_CODE_KGForeignIndex.Value.TryGetValue(SAKEY, out Value);
        }

        /// <summary>
        /// Find all SABT (Billing Template Transactions) entities by [SABT.FEE_CODE]-&gt;[SA.SAKEY]
        /// </summary>
        /// <param name="SAKEY">SAKEY value used to find SABT entities</param>
        /// <returns>A list of related SABT entities</returns>
        public IReadOnlyList<SABT> FindSABTByFEE_CODE(string SAKEY)
        {
            IReadOnlyList<SABT> result;
            if (SABT_FEE_CODEForeignIndex.Value.TryGetValue(SAKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SABT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SABT entities by [SABT.FEE_CODE]-&gt;[SA.SAKEY]
        /// </summary>
        /// <param name="SAKEY">SAKEY value used to find SABT entities</param>
        /// <param name="Value">A list of related SABT entities</param>
        /// <returns>True if any SABT entities are found</returns>
        public bool TryFindSABTByFEE_CODE(string SAKEY, out IReadOnlyList<SABT> Value)
        {
            return SABT_FEE_CODEForeignIndex.Value.TryGetValue(SAKEY, out Value);
        }

        /// <summary>
        /// Find all STSB (Family Invoice Allocations) entities by [STSB.SPLIT_ITEM]-&gt;[SA.SAKEY]
        /// </summary>
        /// <param name="SAKEY">SAKEY value used to find STSB entities</param>
        /// <returns>A list of related STSB entities</returns>
        public IReadOnlyList<STSB> FindSTSBBySPLIT_ITEM(string SAKEY)
        {
            IReadOnlyList<STSB> result;
            if (STSB_SPLIT_ITEMForeignIndex.Value.TryGetValue(SAKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STSB>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STSB entities by [STSB.SPLIT_ITEM]-&gt;[SA.SAKEY]
        /// </summary>
        /// <param name="SAKEY">SAKEY value used to find STSB entities</param>
        /// <param name="Value">A list of related STSB entities</param>
        /// <returns>True if any STSB entities are found</returns>
        public bool TryFindSTSBBySPLIT_ITEM(string SAKEY, out IReadOnlyList<STSB> Value)
        {
            return STSB_SPLIT_ITEMForeignIndex.Value.TryGetValue(SAKEY, out Value);
        }

        /// <summary>
        /// Find all SU (Subjects) entities by [SU.FEE_CODE]-&gt;[SA.SAKEY]
        /// </summary>
        /// <param name="SAKEY">SAKEY value used to find SU entities</param>
        /// <returns>A list of related SU entities</returns>
        public IReadOnlyList<SU> FindSUByFEE_CODE(string SAKEY)
        {
            IReadOnlyList<SU> result;
            if (SU_FEE_CODEForeignIndex.Value.TryGetValue(SAKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SU>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SU entities by [SU.FEE_CODE]-&gt;[SA.SAKEY]
        /// </summary>
        /// <param name="SAKEY">SAKEY value used to find SU entities</param>
        /// <param name="Value">A list of related SU entities</param>
        /// <returns>True if any SU entities are found</returns>
        public bool TryFindSUByFEE_CODE(string SAKEY, out IReadOnlyList<SU> Value)
        {
            return SU_FEE_CODEForeignIndex.Value.TryGetValue(SAKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SA" /> fields for each CSV column header</returns>
        protected override Action<SA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SAKEY":
                        mapper[i] = (e, v) => e.SAKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "SAGROUP":
                        mapper[i] = (e, v) => e.SAGROUP = v;
                        break;
                    case "STATEMENT":
                        mapper[i] = (e, v) => e.STATEMENT = v;
                        break;
                    case "METHOD":
                        mapper[i] = (e, v) => e.METHOD = v;
                        break;
                    case "AMOUNT":
                        mapper[i] = (e, v) => e.AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS_AMOUNT":
                        mapper[i] = (e, v) => e.GROSS_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "FREQUENCY":
                        mapper[i] = (e, v) => e.FREQUENCY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "GST_TYPE":
                        mapper[i] = (e, v) => e.GST_TYPE = v;
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
                    case "VOLUNTARY":
                        mapper[i] = (e, v) => e.VOLUNTARY = v;
                        break;
                    case "SPLIT_BILLING":
                        mapper[i] = (e, v) => e.SPLIT_BILLING = v;
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
