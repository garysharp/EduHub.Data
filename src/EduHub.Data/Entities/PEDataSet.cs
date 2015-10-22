using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employees Data Set
    /// </summary>
    public sealed partial class PEDataSet : SetBase<PE>
    {
        private Lazy<Dictionary<string, PE>> PEKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<PEF>>> PEF_CODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PEFH>>> PEFH_CODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PELA>>> PELA_PEKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PELD>>> PELD_PEKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PEM>>> PEM_CODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PEPM>>> PEPM_CODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PEPS>>> PEPS_CODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PEPU>>> PEPU_CODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PEPUH>>> PEPUH_CODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PEPY>>> PEPY_CODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PESH>>> PESH_CODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PESP>>> PESP_CODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PETP>>> PETP_CODEForeignIndex;

        internal PEDataSet(EduHubContext Context)
            : base(Context)
        {
            PEKEYIndex = new Lazy<Dictionary<string, PE>>(() => this.ToDictionary(e => e.PEKEY));

            PEF_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PEF>>>(() =>
                    Context.PEF
                          .Where(e => e.CODE != null)
                          .GroupBy(e => e.CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEF>)g.ToList()
                          .AsReadOnly()));

            PEFH_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PEFH>>>(() =>
                    Context.PEFH
                          .Where(e => e.CODE != null)
                          .GroupBy(e => e.CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEFH>)g.ToList()
                          .AsReadOnly()));

            PELA_PEKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PELA>>>(() =>
                    Context.PELA
                          .Where(e => e.PEKEY != null)
                          .GroupBy(e => e.PEKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PELA>)g.ToList()
                          .AsReadOnly()));

            PELD_PEKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PELD>>>(() =>
                    Context.PELD
                          .Where(e => e.PEKEY != null)
                          .GroupBy(e => e.PEKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PELD>)g.ToList()
                          .AsReadOnly()));

            PEM_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PEM>>>(() =>
                    Context.PEM
                          .Where(e => e.CODE != null)
                          .GroupBy(e => e.CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEM>)g.ToList()
                          .AsReadOnly()));

            PEPM_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PEPM>>>(() =>
                    Context.PEPM
                          .Where(e => e.CODE != null)
                          .GroupBy(e => e.CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEPM>)g.ToList()
                          .AsReadOnly()));

            PEPS_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PEPS>>>(() =>
                    Context.PEPS
                          .Where(e => e.CODE != null)
                          .GroupBy(e => e.CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEPS>)g.ToList()
                          .AsReadOnly()));

            PEPU_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PEPU>>>(() =>
                    Context.PEPU
                          .Where(e => e.CODE != null)
                          .GroupBy(e => e.CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEPU>)g.ToList()
                          .AsReadOnly()));

            PEPUH_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PEPUH>>>(() =>
                    Context.PEPUH
                          .Where(e => e.CODE != null)
                          .GroupBy(e => e.CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEPUH>)g.ToList()
                          .AsReadOnly()));

            PEPY_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PEPY>>>(() =>
                    Context.PEPY
                          .Where(e => e.CODE != null)
                          .GroupBy(e => e.CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEPY>)g.ToList()
                          .AsReadOnly()));

            PESH_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PESH>>>(() =>
                    Context.PESH
                          .Where(e => e.CODE != null)
                          .GroupBy(e => e.CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PESH>)g.ToList()
                          .AsReadOnly()));

            PESP_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PESP>>>(() =>
                    Context.PESP
                          .Where(e => e.CODE != null)
                          .GroupBy(e => e.CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PESP>)g.ToList()
                          .AsReadOnly()));

            PETP_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PETP>>>(() =>
                    Context.PETP
                          .Where(e => e.CODE != null)
                          .GroupBy(e => e.CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PETP>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PE"; } }

        /// <summary>
        /// Find PE by PEKEY key field
        /// </summary>
        /// <param name="Key">PEKEY value used to find PE</param>
        /// <returns>Related PE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">PEKEY value didn't match any PE entities</exception>
        public PE FindByPEKEY(string Key)
        {
            PE result;
            if (PEKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find PE by PEKEY key field
        /// </summary>
        /// <param name="Key">PEKEY value used to find PE</param>
        /// <param name="Value">Related PE entity</param>
        /// <returns>True if the PE entity is found</returns>
        public bool TryFindByPEKEY(string Key, out PE Value)
        {
            return PEKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find PE by PEKEY key field
        /// </summary>
        /// <param name="Key">PEKEY value used to find PE</param>
        /// <returns>Related PE entity, or null if not found</returns>
        public PE TryFindByPEKEY(string Key)
        {
            PE result;
            if (PEKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all PEF (Payroll Transactions) entities by [PEF.CODE]-&gt;[PE.PEKEY]
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PEF entities</param>
        /// <returns>A list of related PEF entities</returns>
        public IReadOnlyList<PEF> FindPEFByCODE(string PEKEY)
        {
            IReadOnlyList<PEF> result;
            if (PEF_CODEForeignIndex.Value.TryGetValue(PEKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PEF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEF entities by [PEF.CODE]-&gt;[PE.PEKEY]
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PEF entities</param>
        /// <param name="Value">A list of related PEF entities</param>
        /// <returns>True if any PEF entities are found</returns>
        public bool TryFindPEFByCODE(string PEKEY, out IReadOnlyList<PEF> Value)
        {
            return PEF_CODEForeignIndex.Value.TryGetValue(PEKEY, out Value);
        }

        /// <summary>
        /// Find all PEFH (Payroll Transaction History) entities by [PEFH.CODE]-&gt;[PE.PEKEY]
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PEFH entities</param>
        /// <returns>A list of related PEFH entities</returns>
        public IReadOnlyList<PEFH> FindPEFHByCODE(string PEKEY)
        {
            IReadOnlyList<PEFH> result;
            if (PEFH_CODEForeignIndex.Value.TryGetValue(PEKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PEFH>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEFH entities by [PEFH.CODE]-&gt;[PE.PEKEY]
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PEFH entities</param>
        /// <param name="Value">A list of related PEFH entities</param>
        /// <returns>True if any PEFH entities are found</returns>
        public bool TryFindPEFHByCODE(string PEKEY, out IReadOnlyList<PEFH> Value)
        {
            return PEFH_CODEForeignIndex.Value.TryGetValue(PEKEY, out Value);
        }

        /// <summary>
        /// Find all PELA (Employee Leave Audit) entities by [PELA.PEKEY]-&gt;[PE.PEKEY]
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PELA entities</param>
        /// <returns>A list of related PELA entities</returns>
        public IReadOnlyList<PELA> FindPELAByPEKEY(string PEKEY)
        {
            IReadOnlyList<PELA> result;
            if (PELA_PEKEYForeignIndex.Value.TryGetValue(PEKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PELA>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PELA entities by [PELA.PEKEY]-&gt;[PE.PEKEY]
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PELA entities</param>
        /// <param name="Value">A list of related PELA entities</param>
        /// <returns>True if any PELA entities are found</returns>
        public bool TryFindPELAByPEKEY(string PEKEY, out IReadOnlyList<PELA> Value)
        {
            return PELA_PEKEYForeignIndex.Value.TryGetValue(PEKEY, out Value);
        }

        /// <summary>
        /// Find all PELD (Employee Leave Details) entities by [PELD.PEKEY]-&gt;[PE.PEKEY]
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PELD entities</param>
        /// <returns>A list of related PELD entities</returns>
        public IReadOnlyList<PELD> FindPELDByPEKEY(string PEKEY)
        {
            IReadOnlyList<PELD> result;
            if (PELD_PEKEYForeignIndex.Value.TryGetValue(PEKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PELD>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PELD entities by [PELD.PEKEY]-&gt;[PE.PEKEY]
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PELD entities</param>
        /// <param name="Value">A list of related PELD entities</param>
        /// <returns>True if any PELD entities are found</returns>
        public bool TryFindPELDByPEKEY(string PEKEY, out IReadOnlyList<PELD> Value)
        {
            return PELD_PEKEYForeignIndex.Value.TryGetValue(PEKEY, out Value);
        }

        /// <summary>
        /// Find all PEM (Pay Advice Slip Message) entities by [PEM.CODE]-&gt;[PE.PEKEY]
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PEM entities</param>
        /// <returns>A list of related PEM entities</returns>
        public IReadOnlyList<PEM> FindPEMByCODE(string PEKEY)
        {
            IReadOnlyList<PEM> result;
            if (PEM_CODEForeignIndex.Value.TryGetValue(PEKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PEM>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEM entities by [PEM.CODE]-&gt;[PE.PEKEY]
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PEM entities</param>
        /// <param name="Value">A list of related PEM entities</param>
        /// <returns>True if any PEM entities are found</returns>
        public bool TryFindPEMByCODE(string PEKEY, out IReadOnlyList<PEM> Value)
        {
            return PEM_CODEForeignIndex.Value.TryGetValue(PEKEY, out Value);
        }

        /// <summary>
        /// Find all PEPM (Pay Methods) entities by [PEPM.CODE]-&gt;[PE.PEKEY]
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PEPM entities</param>
        /// <returns>A list of related PEPM entities</returns>
        public IReadOnlyList<PEPM> FindPEPMByCODE(string PEKEY)
        {
            IReadOnlyList<PEPM> result;
            if (PEPM_CODEForeignIndex.Value.TryGetValue(PEKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PEPM>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEPM entities by [PEPM.CODE]-&gt;[PE.PEKEY]
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PEPM entities</param>
        /// <param name="Value">A list of related PEPM entities</param>
        /// <returns>True if any PEPM entities are found</returns>
        public bool TryFindPEPMByCODE(string PEKEY, out IReadOnlyList<PEPM> Value)
        {
            return PEPM_CODEForeignIndex.Value.TryGetValue(PEKEY, out Value);
        }

        /// <summary>
        /// Find all PEPS (Standard and Last Pays) entities by [PEPS.CODE]-&gt;[PE.PEKEY]
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PEPS entities</param>
        /// <returns>A list of related PEPS entities</returns>
        public IReadOnlyList<PEPS> FindPEPSByCODE(string PEKEY)
        {
            IReadOnlyList<PEPS> result;
            if (PEPS_CODEForeignIndex.Value.TryGetValue(PEKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PEPS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEPS entities by [PEPS.CODE]-&gt;[PE.PEKEY]
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PEPS entities</param>
        /// <param name="Value">A list of related PEPS entities</param>
        /// <returns>True if any PEPS entities are found</returns>
        public bool TryFindPEPSByCODE(string PEKEY, out IReadOnlyList<PEPS> Value)
        {
            return PEPS_CODEForeignIndex.Value.TryGetValue(PEKEY, out Value);
        }

        /// <summary>
        /// Find all PEPU (Super (SGL and Employee) YTD Transactions) entities by [PEPU.CODE]-&gt;[PE.PEKEY]
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PEPU entities</param>
        /// <returns>A list of related PEPU entities</returns>
        public IReadOnlyList<PEPU> FindPEPUByCODE(string PEKEY)
        {
            IReadOnlyList<PEPU> result;
            if (PEPU_CODEForeignIndex.Value.TryGetValue(PEKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PEPU>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEPU entities by [PEPU.CODE]-&gt;[PE.PEKEY]
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PEPU entities</param>
        /// <param name="Value">A list of related PEPU entities</param>
        /// <returns>True if any PEPU entities are found</returns>
        public bool TryFindPEPUByCODE(string PEKEY, out IReadOnlyList<PEPU> Value)
        {
            return PEPU_CODEForeignIndex.Value.TryGetValue(PEKEY, out Value);
        }

        /// <summary>
        /// Find all PEPUH (Super (SGL and Employee) History YTD Transactions) entities by [PEPUH.CODE]-&gt;[PE.PEKEY]
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PEPUH entities</param>
        /// <returns>A list of related PEPUH entities</returns>
        public IReadOnlyList<PEPUH> FindPEPUHByCODE(string PEKEY)
        {
            IReadOnlyList<PEPUH> result;
            if (PEPUH_CODEForeignIndex.Value.TryGetValue(PEKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PEPUH>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEPUH entities by [PEPUH.CODE]-&gt;[PE.PEKEY]
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PEPUH entities</param>
        /// <param name="Value">A list of related PEPUH entities</param>
        /// <returns>True if any PEPUH entities are found</returns>
        public bool TryFindPEPUHByCODE(string PEKEY, out IReadOnlyList<PEPUH> Value)
        {
            return PEPUH_CODEForeignIndex.Value.TryGetValue(PEKEY, out Value);
        }

        /// <summary>
        /// Find all PEPY (Employee History) entities by [PEPY.CODE]-&gt;[PE.PEKEY]
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PEPY entities</param>
        /// <returns>A list of related PEPY entities</returns>
        public IReadOnlyList<PEPY> FindPEPYByCODE(string PEKEY)
        {
            IReadOnlyList<PEPY> result;
            if (PEPY_CODEForeignIndex.Value.TryGetValue(PEKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PEPY>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEPY entities by [PEPY.CODE]-&gt;[PE.PEKEY]
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PEPY entities</param>
        /// <param name="Value">A list of related PEPY entities</param>
        /// <returns>True if any PEPY entities are found</returns>
        public bool TryFindPEPYByCODE(string PEKEY, out IReadOnlyList<PEPY> Value)
        {
            return PEPY_CODEForeignIndex.Value.TryGetValue(PEKEY, out Value);
        }

        /// <summary>
        /// Find all PESH (Employee Super LTD History) entities by [PESH.CODE]-&gt;[PE.PEKEY]
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PESH entities</param>
        /// <returns>A list of related PESH entities</returns>
        public IReadOnlyList<PESH> FindPESHByCODE(string PEKEY)
        {
            IReadOnlyList<PESH> result;
            if (PESH_CODEForeignIndex.Value.TryGetValue(PEKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PESH>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PESH entities by [PESH.CODE]-&gt;[PE.PEKEY]
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PESH entities</param>
        /// <param name="Value">A list of related PESH entities</param>
        /// <returns>True if any PESH entities are found</returns>
        public bool TryFindPESHByCODE(string PEKEY, out IReadOnlyList<PESH> Value)
        {
            return PESH_CODEForeignIndex.Value.TryGetValue(PEKEY, out Value);
        }

        /// <summary>
        /// Find all PESP (Employee Super Payment Transactions) entities by [PESP.CODE]-&gt;[PE.PEKEY]
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PESP entities</param>
        /// <returns>A list of related PESP entities</returns>
        public IReadOnlyList<PESP> FindPESPByCODE(string PEKEY)
        {
            IReadOnlyList<PESP> result;
            if (PESP_CODEForeignIndex.Value.TryGetValue(PEKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PESP>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PESP entities by [PESP.CODE]-&gt;[PE.PEKEY]
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PESP entities</param>
        /// <param name="Value">A list of related PESP entities</param>
        /// <returns>True if any PESP entities are found</returns>
        public bool TryFindPESPByCODE(string PEKEY, out IReadOnlyList<PESP> Value)
        {
            return PESP_CODEForeignIndex.Value.TryGetValue(PEKEY, out Value);
        }

        /// <summary>
        /// Find all PETP (Termination Payment) entities by [PETP.CODE]-&gt;[PE.PEKEY]
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PETP entities</param>
        /// <returns>A list of related PETP entities</returns>
        public IReadOnlyList<PETP> FindPETPByCODE(string PEKEY)
        {
            IReadOnlyList<PETP> result;
            if (PETP_CODEForeignIndex.Value.TryGetValue(PEKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PETP>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PETP entities by [PETP.CODE]-&gt;[PE.PEKEY]
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PETP entities</param>
        /// <param name="Value">A list of related PETP entities</param>
        /// <returns>True if any PETP entities are found</returns>
        public bool TryFindPETPByCODE(string PEKEY, out IReadOnlyList<PETP> Value)
        {
            return PETP_CODEForeignIndex.Value.TryGetValue(PEKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PE" /> fields for each CSV column header</returns>
        protected override Action<PE, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PEKEY":
                        mapper[i] = (e, v) => e.PEKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "SURNAME":
                        mapper[i] = (e, v) => e.SURNAME = v;
                        break;
                    case "FIRST_NAME":
                        mapper[i] = (e, v) => e.FIRST_NAME = v;
                        break;
                    case "SECOND_NAME":
                        mapper[i] = (e, v) => e.SECOND_NAME = v;
                        break;
                    case "PREF_NAME":
                        mapper[i] = (e, v) => e.PREF_NAME = v;
                        break;
                    case "PREVIOUS_NAME":
                        mapper[i] = (e, v) => e.PREVIOUS_NAME = v;
                        break;
                    case "BIRTHDATE":
                        mapper[i] = (e, v) => e.BIRTHDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "GENDER":
                        mapper[i] = (e, v) => e.GENDER = v;
                        break;
                    case "HOMEADD01":
                        mapper[i] = (e, v) => e.HOMEADD01 = v;
                        break;
                    case "HOMEADD02":
                        mapper[i] = (e, v) => e.HOMEADD02 = v;
                        break;
                    case "HOMESUBURB":
                        mapper[i] = (e, v) => e.HOMESUBURB = v;
                        break;
                    case "HOMESTATE":
                        mapper[i] = (e, v) => e.HOMESTATE = v;
                        break;
                    case "HOMEPOST":
                        mapper[i] = (e, v) => e.HOMEPOST = v;
                        break;
                    case "COUNTRY":
                        mapper[i] = (e, v) => e.COUNTRY = v;
                        break;
                    case "HOMEPHONE":
                        mapper[i] = (e, v) => e.HOMEPHONE = v;
                        break;
                    case "BUS_PHONE":
                        mapper[i] = (e, v) => e.BUS_PHONE = v;
                        break;
                    case "PHONE_EXT":
                        mapper[i] = (e, v) => e.PHONE_EXT = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "EMAIL":
                        mapper[i] = (e, v) => e.EMAIL = v;
                        break;
                    case "DRIVERS_LIC_NO":
                        mapper[i] = (e, v) => e.DRIVERS_LIC_NO = v;
                        break;
                    case "OWN_VEHICLE":
                        mapper[i] = (e, v) => e.OWN_VEHICLE = v;
                        break;
                    case "COMMENTS":
                        mapper[i] = (e, v) => e.COMMENTS = v;
                        break;
                    case "HOMEKEY":
                        mapper[i] = (e, v) => e.HOMEKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MAILKEY":
                        mapper[i] = (e, v) => e.MAILKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "LEAVEKEY":
                        mapper[i] = (e, v) => e.LEAVEKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PAYCODE":
                        mapper[i] = (e, v) => e.PAYCODE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TAXCODE":
                        mapper[i] = (e, v) => e.TAXCODE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DEPARTMENT":
                        mapper[i] = (e, v) => e.DEPARTMENT = v;
                        break;
                    case "PENUMBER":
                        mapper[i] = (e, v) => e.PENUMBER = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TAXFILENUM":
                        mapper[i] = (e, v) => e.TAXFILENUM = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EMPLOY_TYPE":
                        mapper[i] = (e, v) => e.EMPLOY_TYPE = v;
                        break;
                    case "NORMAL_HOURS":
                        mapper[i] = (e, v) => e.NORMAL_HOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "FTE_VALUE":
                        mapper[i] = (e, v) => e.FTE_VALUE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ANNUAL_SALARY":
                        mapper[i] = (e, v) => e.ANNUAL_SALARY = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "STD_HOURS":
                        mapper[i] = (e, v) => e.STD_HOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "UNION_NAME":
                        mapper[i] = (e, v) => e.UNION_NAME = v;
                        break;
                    case "LEAVE_GROUP":
                        mapper[i] = (e, v) => e.LEAVE_GROUP = v;
                        break;
                    case "PAY_TYPE":
                        mapper[i] = (e, v) => e.PAY_TYPE = v;
                        break;
                    case "HOURLY_RATE":
                        mapper[i] = (e, v) => e.HOURLY_RATE = v;
                        break;
                    case "SIX_SUPER_FUND":
                        mapper[i] = (e, v) => e.SIX_SUPER_FUND = v;
                        break;
                    case "SIX_MEMBER_NO":
                        mapper[i] = (e, v) => e.SIX_MEMBER_NO = v;
                        break;
                    case "SUPER_LEVY":
                        mapper[i] = (e, v) => e.SUPER_LEVY = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ZONE":
                        mapper[i] = (e, v) => e.ZONE = v;
                        break;
                    case "ZONE_CODE":
                        mapper[i] = (e, v) => e.ZONE_CODE = v;
                        break;
                    case "ZONE_ALLOW":
                        mapper[i] = (e, v) => e.ZONE_ALLOW = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NO_DEPEND":
                        mapper[i] = (e, v) => e.NO_DEPEND = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ALLOWANCES":
                        mapper[i] = (e, v) => e.ALLOWANCES = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "DEP_REBATE":
                        mapper[i] = (e, v) => e.DEP_REBATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "MEDICARE":
                        mapper[i] = (e, v) => e.MEDICARE = v;
                        break;
                    case "MEDICARE_Q9NOTQ12z":
                        mapper[i] = (e, v) => e.MEDICARE_Q9NOTQ12z = v;
                        break;
                    case "MEDICARE_Q09A":
                        mapper[i] = (e, v) => e.MEDICARE_Q09A = v;
                        break;
                    case "MEDICARE_Q10A":
                        mapper[i] = (e, v) => e.MEDICARE_Q10A = v;
                        break;
                    case "MEDICARE_Q11A":
                        mapper[i] = (e, v) => e.MEDICARE_Q11A = v;
                        break;
                    case "MEDICARE_Q12A":
                        mapper[i] = (e, v) => e.MEDICARE_Q12A = v;
                        break;
                    case "STARTDATE":
                        mapper[i] = (e, v) => e.STARTDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TERMDATE":
                        mapper[i] = (e, v) => e.TERMDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SALREVDATE":
                        mapper[i] = (e, v) => e.SALREVDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SUSPEND_DATE":
                        mapper[i] = (e, v) => e.SUSPEND_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LASTPAYPERD":
                        mapper[i] = (e, v) => e.LASTPAYPERD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "NEXTPAYPERD":
                        mapper[i] = (e, v) => e.NEXTPAYPERD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "LASTPAYDATE":
                        mapper[i] = (e, v) => e.LASTPAYDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LASTPAYRATE":
                        mapper[i] = (e, v) => e.LASTPAYRATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "LASTNORMITEM":
                        mapper[i] = (e, v) => e.LASTNORMITEM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LASTPAYGROSS":
                        mapper[i] = (e, v) => e.LASTPAYGROSS = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTPAYNETT":
                        mapper[i] = (e, v) => e.LASTPAYNETT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTPAYTAX":
                        mapper[i] = (e, v) => e.LASTPAYTAX = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS01":
                        mapper[i] = (e, v) => e.GROSS01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS02":
                        mapper[i] = (e, v) => e.GROSS02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS03":
                        mapper[i] = (e, v) => e.GROSS03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS04":
                        mapper[i] = (e, v) => e.GROSS04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS05":
                        mapper[i] = (e, v) => e.GROSS05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS06":
                        mapper[i] = (e, v) => e.GROSS06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS07":
                        mapper[i] = (e, v) => e.GROSS07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS08":
                        mapper[i] = (e, v) => e.GROSS08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS09":
                        mapper[i] = (e, v) => e.GROSS09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS10":
                        mapper[i] = (e, v) => e.GROSS10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS11":
                        mapper[i] = (e, v) => e.GROSS11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS12":
                        mapper[i] = (e, v) => e.GROSS12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NETT01":
                        mapper[i] = (e, v) => e.NETT01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NETT02":
                        mapper[i] = (e, v) => e.NETT02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NETT03":
                        mapper[i] = (e, v) => e.NETT03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NETT04":
                        mapper[i] = (e, v) => e.NETT04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NETT05":
                        mapper[i] = (e, v) => e.NETT05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NETT06":
                        mapper[i] = (e, v) => e.NETT06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NETT07":
                        mapper[i] = (e, v) => e.NETT07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NETT08":
                        mapper[i] = (e, v) => e.NETT08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NETT09":
                        mapper[i] = (e, v) => e.NETT09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NETT10":
                        mapper[i] = (e, v) => e.NETT10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NETT11":
                        mapper[i] = (e, v) => e.NETT11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NETT12":
                        mapper[i] = (e, v) => e.NETT12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TAX01":
                        mapper[i] = (e, v) => e.TAX01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TAX02":
                        mapper[i] = (e, v) => e.TAX02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TAX03":
                        mapper[i] = (e, v) => e.TAX03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TAX04":
                        mapper[i] = (e, v) => e.TAX04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TAX05":
                        mapper[i] = (e, v) => e.TAX05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TAX06":
                        mapper[i] = (e, v) => e.TAX06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TAX07":
                        mapper[i] = (e, v) => e.TAX07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TAX08":
                        mapper[i] = (e, v) => e.TAX08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TAX09":
                        mapper[i] = (e, v) => e.TAX09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TAX10":
                        mapper[i] = (e, v) => e.TAX10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TAX11":
                        mapper[i] = (e, v) => e.TAX11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TAX12":
                        mapper[i] = (e, v) => e.TAX12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PAYG_SUMMARY":
                        mapper[i] = (e, v) => e.PAYG_SUMMARY = v;
                        break;
                    case "YEAR_LEVEL":
                        mapper[i] = (e, v) => e.YEAR_LEVEL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "REPORTABLE_FB":
                        mapper[i] = (e, v) => e.REPORTABLE_FB = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "EMPLOYEE_PIC":
                        mapper[i] = (e, v) => e.EMPLOYEE_PIC = null; // eduHub is not encoding byte arrays
                        break;
                    case "VIT_REGISTRATION":
                        mapper[i] = (e, v) => e.VIT_REGISTRATION = v;
                        break;
                    case "VIT_EXPIRY":
                        mapper[i] = (e, v) => e.VIT_EXPIRY = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "WWCC_NUMBER":
                        mapper[i] = (e, v) => e.WWCC_NUMBER = v;
                        break;
                    case "WWCC_EXPIRY":
                        mapper[i] = (e, v) => e.WWCC_EXPIRY = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "WWCC_TYPE":
                        mapper[i] = (e, v) => e.WWCC_TYPE = v;
                        break;
                    case "ESUPER_IGNORE_THRESHOLD":
                        mapper[i] = (e, v) => e.ESUPER_IGNORE_THRESHOLD = v;
                        break;
                    case "ESUPER_FUND01":
                        mapper[i] = (e, v) => e.ESUPER_FUND01 = v;
                        break;
                    case "ESUPER_FUND02":
                        mapper[i] = (e, v) => e.ESUPER_FUND02 = v;
                        break;
                    case "ESUPER_FUND03":
                        mapper[i] = (e, v) => e.ESUPER_FUND03 = v;
                        break;
                    case "ESUPER_FUND04":
                        mapper[i] = (e, v) => e.ESUPER_FUND04 = v;
                        break;
                    case "ESUPER_FUND05":
                        mapper[i] = (e, v) => e.ESUPER_FUND05 = v;
                        break;
                    case "ESUPER_MEMBER01":
                        mapper[i] = (e, v) => e.ESUPER_MEMBER01 = v;
                        break;
                    case "ESUPER_MEMBER02":
                        mapper[i] = (e, v) => e.ESUPER_MEMBER02 = v;
                        break;
                    case "ESUPER_MEMBER03":
                        mapper[i] = (e, v) => e.ESUPER_MEMBER03 = v;
                        break;
                    case "ESUPER_MEMBER04":
                        mapper[i] = (e, v) => e.ESUPER_MEMBER04 = v;
                        break;
                    case "ESUPER_MEMBER05":
                        mapper[i] = (e, v) => e.ESUPER_MEMBER05 = v;
                        break;
                    case "ESUPER_PERCENT01":
                        mapper[i] = (e, v) => e.ESUPER_PERCENT01 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ESUPER_PERCENT02":
                        mapper[i] = (e, v) => e.ESUPER_PERCENT02 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ESUPER_PERCENT03":
                        mapper[i] = (e, v) => e.ESUPER_PERCENT03 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ESUPER_PERCENT04":
                        mapper[i] = (e, v) => e.ESUPER_PERCENT04 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ESUPER_PERCENT05":
                        mapper[i] = (e, v) => e.ESUPER_PERCENT05 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "LEAVE_HOURS":
                        mapper[i] = (e, v) => e.LEAVE_HOURS = v == null ? (double?)null : double.Parse(v);
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
