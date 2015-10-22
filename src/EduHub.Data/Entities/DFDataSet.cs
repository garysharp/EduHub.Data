using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Families Data Set
    /// </summary>
    public sealed partial class DFDataSet : SetBase<DF>
    {
        private Lazy<Dictionary<string, DF>> DFKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<DFB>>> DFB_FAM_CODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<DFF>>> DFF_CODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<DFHI>>> DFHI_FKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<DFVT>>> DFVT_FAMILYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ST>>> ST_FAMILYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ST>>> ST_FAMBForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ST>>> ST_FAMCForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STSB>>> STSB_FAMILYForeignIndex;

        internal DFDataSet(EduHubContext Context)
            : base(Context)
        {
            DFKEYIndex = new Lazy<Dictionary<string, DF>>(() => this.ToDictionary(e => e.DFKEY));

            DFB_FAM_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DFB>>>(() =>
                    Context.DFB
                          .Where(e => e.FAM_CODE != null)
                          .GroupBy(e => e.FAM_CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DFB>)g.ToList()
                          .AsReadOnly()));

            DFF_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DFF>>>(() =>
                    Context.DFF
                          .Where(e => e.CODE != null)
                          .GroupBy(e => e.CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DFF>)g.ToList()
                          .AsReadOnly()));

            DFHI_FKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DFHI>>>(() =>
                    Context.DFHI
                          .Where(e => e.FKEY != null)
                          .GroupBy(e => e.FKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DFHI>)g.ToList()
                          .AsReadOnly()));

            DFVT_FAMILYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DFVT>>>(() =>
                    Context.DFVT
                          .Where(e => e.FAMILY != null)
                          .GroupBy(e => e.FAMILY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DFVT>)g.ToList()
                          .AsReadOnly()));

            ST_FAMILYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ST>>>(() =>
                    Context.ST
                          .Where(e => e.FAMILY != null)
                          .GroupBy(e => e.FAMILY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ST>)g.ToList()
                          .AsReadOnly()));

            ST_FAMBForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ST>>>(() =>
                    Context.ST
                          .Where(e => e.FAMB != null)
                          .GroupBy(e => e.FAMB)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ST>)g.ToList()
                          .AsReadOnly()));

            ST_FAMCForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ST>>>(() =>
                    Context.ST
                          .Where(e => e.FAMC != null)
                          .GroupBy(e => e.FAMC)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ST>)g.ToList()
                          .AsReadOnly()));

            STSB_FAMILYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STSB>>>(() =>
                    Context.STSB
                          .Where(e => e.FAMILY != null)
                          .GroupBy(e => e.FAMILY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STSB>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "DF"; } }

        /// <summary>
        /// Find DF by DFKEY key field
        /// </summary>
        /// <param name="Key">DFKEY value used to find DF</param>
        /// <returns>Related DF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">DFKEY value didn't match any DF entities</exception>
        public DF FindByDFKEY(string Key)
        {
            DF result;
            if (DFKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find DF by DFKEY key field
        /// </summary>
        /// <param name="Key">DFKEY value used to find DF</param>
        /// <param name="Value">Related DF entity</param>
        /// <returns>True if the DF entity is found</returns>
        public bool TryFindByDFKEY(string Key, out DF Value)
        {
            return DFKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find DF by DFKEY key field
        /// </summary>
        /// <param name="Key">DFKEY value used to find DF</param>
        /// <returns>Related DF entity, or null if not found</returns>
        public DF TryFindByDFKEY(string Key)
        {
            DF result;
            if (DFKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all DFB (BPAY Receipts) entities by [DFB.FAM_CODE]-&gt;[DF.DFKEY]
        /// </summary>
        /// <param name="DFKEY">DFKEY value used to find DFB entities</param>
        /// <returns>A list of related DFB entities</returns>
        public IReadOnlyList<DFB> FindDFBByFAM_CODE(string DFKEY)
        {
            IReadOnlyList<DFB> result;
            if (DFB_FAM_CODEForeignIndex.Value.TryGetValue(DFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<DFB>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DFB entities by [DFB.FAM_CODE]-&gt;[DF.DFKEY]
        /// </summary>
        /// <param name="DFKEY">DFKEY value used to find DFB entities</param>
        /// <param name="Value">A list of related DFB entities</param>
        /// <returns>True if any DFB entities are found</returns>
        public bool TryFindDFBByFAM_CODE(string DFKEY, out IReadOnlyList<DFB> Value)
        {
            return DFB_FAM_CODEForeignIndex.Value.TryGetValue(DFKEY, out Value);
        }

        /// <summary>
        /// Find all DFF (Family Financial Transactions) entities by [DFF.CODE]-&gt;[DF.DFKEY]
        /// </summary>
        /// <param name="DFKEY">DFKEY value used to find DFF entities</param>
        /// <returns>A list of related DFF entities</returns>
        public IReadOnlyList<DFF> FindDFFByCODE(string DFKEY)
        {
            IReadOnlyList<DFF> result;
            if (DFF_CODEForeignIndex.Value.TryGetValue(DFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<DFF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DFF entities by [DFF.CODE]-&gt;[DF.DFKEY]
        /// </summary>
        /// <param name="DFKEY">DFKEY value used to find DFF entities</param>
        /// <param name="Value">A list of related DFF entities</param>
        /// <returns>True if any DFF entities are found</returns>
        public bool TryFindDFFByCODE(string DFKEY, out IReadOnlyList<DFF> Value)
        {
            return DFF_CODEForeignIndex.Value.TryGetValue(DFKEY, out Value);
        }

        /// <summary>
        /// Find all DFHI (Family History) entities by [DFHI.FKEY]-&gt;[DF.DFKEY]
        /// </summary>
        /// <param name="DFKEY">DFKEY value used to find DFHI entities</param>
        /// <returns>A list of related DFHI entities</returns>
        public IReadOnlyList<DFHI> FindDFHIByFKEY(string DFKEY)
        {
            IReadOnlyList<DFHI> result;
            if (DFHI_FKEYForeignIndex.Value.TryGetValue(DFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<DFHI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DFHI entities by [DFHI.FKEY]-&gt;[DF.DFKEY]
        /// </summary>
        /// <param name="DFKEY">DFKEY value used to find DFHI entities</param>
        /// <param name="Value">A list of related DFHI entities</param>
        /// <returns>True if any DFHI entities are found</returns>
        public bool TryFindDFHIByFKEY(string DFKEY, out IReadOnlyList<DFHI> Value)
        {
            return DFHI_FKEYForeignIndex.Value.TryGetValue(DFKEY, out Value);
        }

        /// <summary>
        /// Find all DFVT (Family Voluntary Transactions) entities by [DFVT.FAMILY]-&gt;[DF.DFKEY]
        /// </summary>
        /// <param name="DFKEY">DFKEY value used to find DFVT entities</param>
        /// <returns>A list of related DFVT entities</returns>
        public IReadOnlyList<DFVT> FindDFVTByFAMILY(string DFKEY)
        {
            IReadOnlyList<DFVT> result;
            if (DFVT_FAMILYForeignIndex.Value.TryGetValue(DFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<DFVT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DFVT entities by [DFVT.FAMILY]-&gt;[DF.DFKEY]
        /// </summary>
        /// <param name="DFKEY">DFKEY value used to find DFVT entities</param>
        /// <param name="Value">A list of related DFVT entities</param>
        /// <returns>True if any DFVT entities are found</returns>
        public bool TryFindDFVTByFAMILY(string DFKEY, out IReadOnlyList<DFVT> Value)
        {
            return DFVT_FAMILYForeignIndex.Value.TryGetValue(DFKEY, out Value);
        }

        /// <summary>
        /// Find all ST (Students) entities by [ST.FAMILY]-&gt;[DF.DFKEY]
        /// </summary>
        /// <param name="DFKEY">DFKEY value used to find ST entities</param>
        /// <returns>A list of related ST entities</returns>
        public IReadOnlyList<ST> FindSTByFAMILY(string DFKEY)
        {
            IReadOnlyList<ST> result;
            if (ST_FAMILYForeignIndex.Value.TryGetValue(DFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<ST>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ST entities by [ST.FAMILY]-&gt;[DF.DFKEY]
        /// </summary>
        /// <param name="DFKEY">DFKEY value used to find ST entities</param>
        /// <param name="Value">A list of related ST entities</param>
        /// <returns>True if any ST entities are found</returns>
        public bool TryFindSTByFAMILY(string DFKEY, out IReadOnlyList<ST> Value)
        {
            return ST_FAMILYForeignIndex.Value.TryGetValue(DFKEY, out Value);
        }

        /// <summary>
        /// Find all ST (Students) entities by [ST.FAMB]-&gt;[DF.DFKEY]
        /// </summary>
        /// <param name="DFKEY">DFKEY value used to find ST entities</param>
        /// <returns>A list of related ST entities</returns>
        public IReadOnlyList<ST> FindSTByFAMB(string DFKEY)
        {
            IReadOnlyList<ST> result;
            if (ST_FAMBForeignIndex.Value.TryGetValue(DFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<ST>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ST entities by [ST.FAMB]-&gt;[DF.DFKEY]
        /// </summary>
        /// <param name="DFKEY">DFKEY value used to find ST entities</param>
        /// <param name="Value">A list of related ST entities</param>
        /// <returns>True if any ST entities are found</returns>
        public bool TryFindSTByFAMB(string DFKEY, out IReadOnlyList<ST> Value)
        {
            return ST_FAMBForeignIndex.Value.TryGetValue(DFKEY, out Value);
        }

        /// <summary>
        /// Find all ST (Students) entities by [ST.FAMC]-&gt;[DF.DFKEY]
        /// </summary>
        /// <param name="DFKEY">DFKEY value used to find ST entities</param>
        /// <returns>A list of related ST entities</returns>
        public IReadOnlyList<ST> FindSTByFAMC(string DFKEY)
        {
            IReadOnlyList<ST> result;
            if (ST_FAMCForeignIndex.Value.TryGetValue(DFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<ST>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ST entities by [ST.FAMC]-&gt;[DF.DFKEY]
        /// </summary>
        /// <param name="DFKEY">DFKEY value used to find ST entities</param>
        /// <param name="Value">A list of related ST entities</param>
        /// <returns>True if any ST entities are found</returns>
        public bool TryFindSTByFAMC(string DFKEY, out IReadOnlyList<ST> Value)
        {
            return ST_FAMCForeignIndex.Value.TryGetValue(DFKEY, out Value);
        }

        /// <summary>
        /// Find all STSB (Family Invoice Allocations) entities by [STSB.FAMILY]-&gt;[DF.DFKEY]
        /// </summary>
        /// <param name="DFKEY">DFKEY value used to find STSB entities</param>
        /// <returns>A list of related STSB entities</returns>
        public IReadOnlyList<STSB> FindSTSBByFAMILY(string DFKEY)
        {
            IReadOnlyList<STSB> result;
            if (STSB_FAMILYForeignIndex.Value.TryGetValue(DFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STSB>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STSB entities by [STSB.FAMILY]-&gt;[DF.DFKEY]
        /// </summary>
        /// <param name="DFKEY">DFKEY value used to find STSB entities</param>
        /// <param name="Value">A list of related STSB entities</param>
        /// <returns>True if any STSB entities are found</returns>
        public bool TryFindSTSBByFAMILY(string DFKEY, out IReadOnlyList<STSB> Value)
        {
            return STSB_FAMILYForeignIndex.Value.TryGetValue(DFKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="DF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="DF" /> fields for each CSV column header</returns>
        protected override Action<DF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<DF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "DFKEY":
                        mapper[i] = (e, v) => e.DFKEY = v;
                        break;
                    case "NAME_A":
                        mapper[i] = (e, v) => e.NAME_A = v;
                        break;
                    case "SURNAME_A":
                        mapper[i] = (e, v) => e.SURNAME_A = v;
                        break;
                    case "TITLE_A":
                        mapper[i] = (e, v) => e.TITLE_A = v;
                        break;
                    case "WORK_CONT_A":
                        mapper[i] = (e, v) => e.WORK_CONT_A = v;
                        break;
                    case "OCCUPATION_A":
                        mapper[i] = (e, v) => e.OCCUPATION_A = v;
                        break;
                    case "EMPLOYER_A":
                        mapper[i] = (e, v) => e.EMPLOYER_A = v;
                        break;
                    case "NATIVE_LANG_A":
                        mapper[i] = (e, v) => e.NATIVE_LANG_A = v;
                        break;
                    case "OTHER_LANG_A":
                        mapper[i] = (e, v) => e.OTHER_LANG_A = v;
                        break;
                    case "INTERPRETER_A":
                        mapper[i] = (e, v) => e.INTERPRETER_A = v;
                        break;
                    case "BIRTH_COUNTRY_A":
                        mapper[i] = (e, v) => e.BIRTH_COUNTRY_A = v;
                        break;
                    case "BH_AT_HOME_A":
                        mapper[i] = (e, v) => e.BH_AT_HOME_A = v;
                        break;
                    case "BH_CONTACT_A":
                        mapper[i] = (e, v) => e.BH_CONTACT_A = v;
                        break;
                    case "AH_AT_HOME_A":
                        mapper[i] = (e, v) => e.AH_AT_HOME_A = v;
                        break;
                    case "AH_CONTACT_A":
                        mapper[i] = (e, v) => e.AH_CONTACT_A = v;
                        break;
                    case "E_MAIL_A":
                        mapper[i] = (e, v) => e.E_MAIL_A = v;
                        break;
                    case "PREF_MAIL_MECH_A":
                        mapper[i] = (e, v) => e.PREF_MAIL_MECH_A = v;
                        break;
                    case "FAX_A":
                        mapper[i] = (e, v) => e.FAX_A = v;
                        break;
                    case "GENDER_A":
                        mapper[i] = (e, v) => e.GENDER_A = v;
                        break;
                    case "SCH_ED_A":
                        mapper[i] = (e, v) => e.SCH_ED_A = v;
                        break;
                    case "NON_SCH_ED_A":
                        mapper[i] = (e, v) => e.NON_SCH_ED_A = v;
                        break;
                    case "OCCUP_STATUS_A":
                        mapper[i] = (e, v) => e.OCCUP_STATUS_A = v;
                        break;
                    case "LOTE_HOME_CODE_A":
                        mapper[i] = (e, v) => e.LOTE_HOME_CODE_A = v;
                        break;
                    case "MOBILE_A":
                        mapper[i] = (e, v) => e.MOBILE_A = v;
                        break;
                    case "SMS_NOTIFY_A":
                        mapper[i] = (e, v) => e.SMS_NOTIFY_A = v;
                        break;
                    case "E_MAIL_NOTIFY_A":
                        mapper[i] = (e, v) => e.E_MAIL_NOTIFY_A = v;
                        break;
                    case "NAME_B":
                        mapper[i] = (e, v) => e.NAME_B = v;
                        break;
                    case "SURNAME_B":
                        mapper[i] = (e, v) => e.SURNAME_B = v;
                        break;
                    case "TITLE_B":
                        mapper[i] = (e, v) => e.TITLE_B = v;
                        break;
                    case "WORK_CONT_B":
                        mapper[i] = (e, v) => e.WORK_CONT_B = v;
                        break;
                    case "OCCUPATION_B":
                        mapper[i] = (e, v) => e.OCCUPATION_B = v;
                        break;
                    case "EMPLOYER_B":
                        mapper[i] = (e, v) => e.EMPLOYER_B = v;
                        break;
                    case "NATIVE_LANG_B":
                        mapper[i] = (e, v) => e.NATIVE_LANG_B = v;
                        break;
                    case "OTHER_LANG_B":
                        mapper[i] = (e, v) => e.OTHER_LANG_B = v;
                        break;
                    case "INTERPRETER_B":
                        mapper[i] = (e, v) => e.INTERPRETER_B = v;
                        break;
                    case "BIRTH_COUNTRY_B":
                        mapper[i] = (e, v) => e.BIRTH_COUNTRY_B = v;
                        break;
                    case "BH_AT_HOME_B":
                        mapper[i] = (e, v) => e.BH_AT_HOME_B = v;
                        break;
                    case "BH_CONTACT_B":
                        mapper[i] = (e, v) => e.BH_CONTACT_B = v;
                        break;
                    case "AH_AT_HOME_B":
                        mapper[i] = (e, v) => e.AH_AT_HOME_B = v;
                        break;
                    case "AH_CONTACT_B":
                        mapper[i] = (e, v) => e.AH_CONTACT_B = v;
                        break;
                    case "E_MAIL_B":
                        mapper[i] = (e, v) => e.E_MAIL_B = v;
                        break;
                    case "PREF_MAIL_MECH_B":
                        mapper[i] = (e, v) => e.PREF_MAIL_MECH_B = v;
                        break;
                    case "FAX_B":
                        mapper[i] = (e, v) => e.FAX_B = v;
                        break;
                    case "GENDER_B":
                        mapper[i] = (e, v) => e.GENDER_B = v;
                        break;
                    case "SCH_ED_B":
                        mapper[i] = (e, v) => e.SCH_ED_B = v;
                        break;
                    case "NON_SCH_ED_B":
                        mapper[i] = (e, v) => e.NON_SCH_ED_B = v;
                        break;
                    case "OCCUP_STATUS_B":
                        mapper[i] = (e, v) => e.OCCUP_STATUS_B = v;
                        break;
                    case "LOTE_HOME_CODE_B":
                        mapper[i] = (e, v) => e.LOTE_HOME_CODE_B = v;
                        break;
                    case "MOBILE_B":
                        mapper[i] = (e, v) => e.MOBILE_B = v;
                        break;
                    case "SMS_NOTIFY_B":
                        mapper[i] = (e, v) => e.SMS_NOTIFY_B = v;
                        break;
                    case "E_MAIL_NOTIFY_B":
                        mapper[i] = (e, v) => e.E_MAIL_NOTIFY_B = v;
                        break;
                    case "PREF_NOTICE_LANG":
                        mapper[i] = (e, v) => e.PREF_NOTICE_LANG = v;
                        break;
                    case "GROUP_AVAILABILITY":
                        mapper[i] = (e, v) => e.GROUP_AVAILABILITY = v;
                        break;
                    case "OCCUP_STATUS_GRP":
                        mapper[i] = (e, v) => e.OCCUP_STATUS_GRP = v;
                        break;
                    case "HOMETITLE":
                        mapper[i] = (e, v) => e.HOMETITLE = v;
                        break;
                    case "HOMEKEY":
                        mapper[i] = (e, v) => e.HOMEKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MAILTITLE":
                        mapper[i] = (e, v) => e.MAILTITLE = v;
                        break;
                    case "MAILKEY":
                        mapper[i] = (e, v) => e.MAILKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BILLINGTITLE":
                        mapper[i] = (e, v) => e.BILLINGTITLE = v;
                        break;
                    case "BILLINGKEY":
                        mapper[i] = (e, v) => e.BILLINGKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BILLING_MEMO":
                        mapper[i] = (e, v) => e.BILLING_MEMO = v;
                        break;
                    case "ACCTYPE":
                        mapper[i] = (e, v) => e.ACCTYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGED01":
                        mapper[i] = (e, v) => e.AGED01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED02":
                        mapper[i] = (e, v) => e.AGED02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED03":
                        mapper[i] = (e, v) => e.AGED03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED04":
                        mapper[i] = (e, v) => e.AGED04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED05":
                        mapper[i] = (e, v) => e.AGED05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ALLOCAMT":
                        mapper[i] = (e, v) => e.ALLOCAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CHARGES":
                        mapper[i] = (e, v) => e.CHARGES = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTREC":
                        mapper[i] = (e, v) => e.LASTREC = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTRECDATE":
                        mapper[i] = (e, v) => e.LASTRECDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "OPBAL":
                        mapper[i] = (e, v) => e.OPBAL = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "OPBAL_YEAR":
                        mapper[i] = (e, v) => e.OPBAL_YEAR = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PRICELEVEL":
                        mapper[i] = (e, v) => e.PRICELEVEL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "BPAY_SEQUENCE":
                        mapper[i] = (e, v) => e.BPAY_SEQUENCE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BPAY_REFERENCE":
                        mapper[i] = (e, v) => e.BPAY_REFERENCE = v;
                        break;
                    case "NO_STUDENTS":
                        mapper[i] = (e, v) => e.NO_STUDENTS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NO_ASSOC_STUDENTS":
                        mapper[i] = (e, v) => e.NO_ASSOC_STUDENTS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CREDIT_LIMIT":
                        mapper[i] = (e, v) => e.CREDIT_LIMIT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BILL_GROUP":
                        mapper[i] = (e, v) => e.BILL_GROUP = v;
                        break;
                    case "DOCTOR":
                        mapper[i] = (e, v) => e.DOCTOR = v;
                        break;
                    case "EMERG_NAME01":
                        mapper[i] = (e, v) => e.EMERG_NAME01 = v;
                        break;
                    case "EMERG_NAME02":
                        mapper[i] = (e, v) => e.EMERG_NAME02 = v;
                        break;
                    case "EMERG_NAME03":
                        mapper[i] = (e, v) => e.EMERG_NAME03 = v;
                        break;
                    case "EMERG_NAME04":
                        mapper[i] = (e, v) => e.EMERG_NAME04 = v;
                        break;
                    case "EMERG_RELATION01":
                        mapper[i] = (e, v) => e.EMERG_RELATION01 = v;
                        break;
                    case "EMERG_RELATION02":
                        mapper[i] = (e, v) => e.EMERG_RELATION02 = v;
                        break;
                    case "EMERG_RELATION03":
                        mapper[i] = (e, v) => e.EMERG_RELATION03 = v;
                        break;
                    case "EMERG_RELATION04":
                        mapper[i] = (e, v) => e.EMERG_RELATION04 = v;
                        break;
                    case "EMERG_LANG01":
                        mapper[i] = (e, v) => e.EMERG_LANG01 = v;
                        break;
                    case "EMERG_LANG02":
                        mapper[i] = (e, v) => e.EMERG_LANG02 = v;
                        break;
                    case "EMERG_LANG03":
                        mapper[i] = (e, v) => e.EMERG_LANG03 = v;
                        break;
                    case "EMERG_LANG04":
                        mapper[i] = (e, v) => e.EMERG_LANG04 = v;
                        break;
                    case "EMERG_CONTACT01":
                        mapper[i] = (e, v) => e.EMERG_CONTACT01 = v;
                        break;
                    case "EMERG_CONTACT02":
                        mapper[i] = (e, v) => e.EMERG_CONTACT02 = v;
                        break;
                    case "EMERG_CONTACT03":
                        mapper[i] = (e, v) => e.EMERG_CONTACT03 = v;
                        break;
                    case "EMERG_CONTACT04":
                        mapper[i] = (e, v) => e.EMERG_CONTACT04 = v;
                        break;
                    case "ACC_DECLARATION":
                        mapper[i] = (e, v) => e.ACC_DECLARATION = v;
                        break;
                    case "AMBULANCE_SUBSCRIBER":
                        mapper[i] = (e, v) => e.AMBULANCE_SUBSCRIBER = v;
                        break;
                    case "MEDICARE_NO":
                        mapper[i] = (e, v) => e.MEDICARE_NO = v;
                        break;
                    case "HOME_LANG":
                        mapper[i] = (e, v) => e.HOME_LANG = v;
                        break;
                    case "DRAWER":
                        mapper[i] = (e, v) => e.DRAWER = v;
                        break;
                    case "BSB":
                        mapper[i] = (e, v) => e.BSB = v;
                        break;
                    case "TAX_INVOICE":
                        mapper[i] = (e, v) => e.TAX_INVOICE = v;
                        break;
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
                        break;
                    case "BILLING_EMAIL":
                        mapper[i] = (e, v) => e.BILLING_EMAIL = v;
                        break;
                    case "PREF_EMAIL":
                        mapper[i] = (e, v) => e.PREF_EMAIL = v;
                        break;
                    case "CASES_KEY":
                        mapper[i] = (e, v) => e.CASES_KEY = v;
                        break;
                    case "EMA_APPLY_DATE":
                        mapper[i] = (e, v) => e.EMA_APPLY_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "EMA_APPLY":
                        mapper[i] = (e, v) => e.EMA_APPLY = v;
                        break;
                    case "DSS_SURNAME":
                        mapper[i] = (e, v) => e.DSS_SURNAME = v;
                        break;
                    case "DSS_FIRST_NAME":
                        mapper[i] = (e, v) => e.DSS_FIRST_NAME = v;
                        break;
                    case "SSN_ELIG_CODE":
                        mapper[i] = (e, v) => e.SSN_ELIG_CODE = v;
                        break;
                    case "SSN":
                        mapper[i] = (e, v) => e.SSN = v;
                        break;
                    case "EMA_TOTAL1P":
                        mapper[i] = (e, v) => e.EMA_TOTAL1P = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "EMA_STAT1P":
                        mapper[i] = (e, v) => e.EMA_STAT1P = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "EMA_TOTAL2P":
                        mapper[i] = (e, v) => e.EMA_TOTAL2P = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "EMA_STAT2P":
                        mapper[i] = (e, v) => e.EMA_STAT2P = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "EMA_CLAIM_VN":
                        mapper[i] = (e, v) => e.EMA_CLAIM_VN = v;
                        break;
                    case "EMA_SEND":
                        mapper[i] = (e, v) => e.EMA_SEND = v;
                        break;
                    case "EMA_CLAIM_PD":
                        mapper[i] = (e, v) => e.EMA_CLAIM_PD = v;
                        break;
                    case "CASES_EMA_ID":
                        mapper[i] = (e, v) => e.CASES_EMA_ID = v;
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
