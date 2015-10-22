using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Addresses Data Set
    /// </summary>
    public sealed partial class UMDataSet : SetBase<UM>
    {
        private Lazy<Dictionary<int, UM>> UMKEYIndex;

        private Lazy<Dictionary<int, IReadOnlyList<DF>>> DF_HOMEKEYForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<DF>>> DF_MAILKEYForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<DF>>> DF_BILLINGKEYForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<PE>>> PE_HOMEKEYForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<PE>>> PE_MAILKEYForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<PE>>> PE_LEAVEKEYForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<SAM>>> SAM_ADDRESSKEYForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<SAM>>> SAM_MAILKEYForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<SF>>> SF_HOMEKEYForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<SF>>> SF_MAILKEYForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<STTRIPS>>> STTRIPS_AM_PICKUP_ADDRESS_IDForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<STTRIPS>>> STTRIPS_PM_SETDOWN_ADDRESS_IDForeignIndex;

        internal UMDataSet(EduHubContext Context)
            : base(Context)
        {
            UMKEYIndex = new Lazy<Dictionary<int, UM>>(() => this.ToDictionary(e => e.UMKEY));

            DF_HOMEKEYForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<DF>>>(() =>
                    Context.DF
                          .Where(e => e.HOMEKEY != null)
                          .GroupBy(e => e.HOMEKEY.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DF>)g.ToList()
                          .AsReadOnly()));

            DF_MAILKEYForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<DF>>>(() =>
                    Context.DF
                          .Where(e => e.MAILKEY != null)
                          .GroupBy(e => e.MAILKEY.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DF>)g.ToList()
                          .AsReadOnly()));

            DF_BILLINGKEYForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<DF>>>(() =>
                    Context.DF
                          .Where(e => e.BILLINGKEY != null)
                          .GroupBy(e => e.BILLINGKEY.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DF>)g.ToList()
                          .AsReadOnly()));

            PE_HOMEKEYForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<PE>>>(() =>
                    Context.PE
                          .Where(e => e.HOMEKEY != null)
                          .GroupBy(e => e.HOMEKEY.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PE>)g.ToList()
                          .AsReadOnly()));

            PE_MAILKEYForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<PE>>>(() =>
                    Context.PE
                          .Where(e => e.MAILKEY != null)
                          .GroupBy(e => e.MAILKEY.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PE>)g.ToList()
                          .AsReadOnly()));

            PE_LEAVEKEYForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<PE>>>(() =>
                    Context.PE
                          .Where(e => e.LEAVEKEY != null)
                          .GroupBy(e => e.LEAVEKEY.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PE>)g.ToList()
                          .AsReadOnly()));

            SAM_ADDRESSKEYForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<SAM>>>(() =>
                    Context.SAM
                          .Where(e => e.ADDRESSKEY != null)
                          .GroupBy(e => e.ADDRESSKEY.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SAM>)g.ToList()
                          .AsReadOnly()));

            SAM_MAILKEYForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<SAM>>>(() =>
                    Context.SAM
                          .Where(e => e.MAILKEY != null)
                          .GroupBy(e => e.MAILKEY.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SAM>)g.ToList()
                          .AsReadOnly()));

            SF_HOMEKEYForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.HOMEKEY != null)
                          .GroupBy(e => e.HOMEKEY.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            SF_MAILKEYForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.MAILKEY != null)
                          .GroupBy(e => e.MAILKEY.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            STTRIPS_AM_PICKUP_ADDRESS_IDForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<STTRIPS>>>(() =>
                    Context.STTRIPS
                          .Where(e => e.AM_PICKUP_ADDRESS_ID != null)
                          .GroupBy(e => e.AM_PICKUP_ADDRESS_ID.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STTRIPS>)g.ToList()
                          .AsReadOnly()));

            STTRIPS_PM_SETDOWN_ADDRESS_IDForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<STTRIPS>>>(() =>
                    Context.STTRIPS
                          .Where(e => e.PM_SETDOWN_ADDRESS_ID != null)
                          .GroupBy(e => e.PM_SETDOWN_ADDRESS_ID.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STTRIPS>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "UM"; } }

        /// <summary>
        /// Find UM by UMKEY key field
        /// </summary>
        /// <param name="Key">UMKEY value used to find UM</param>
        /// <returns>Related UM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">UMKEY value didn't match any UM entities</exception>
        public UM FindByUMKEY(int Key)
        {
            UM result;
            if (UMKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find UM by UMKEY key field
        /// </summary>
        /// <param name="Key">UMKEY value used to find UM</param>
        /// <param name="Value">Related UM entity</param>
        /// <returns>True if the UM entity is found</returns>
        public bool TryFindByUMKEY(int Key, out UM Value)
        {
            return UMKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find UM by UMKEY key field
        /// </summary>
        /// <param name="Key">UMKEY value used to find UM</param>
        /// <returns>Related UM entity, or null if not found</returns>
        public UM TryFindByUMKEY(int Key)
        {
            UM result;
            if (UMKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all DF (Families) entities by [DF.HOMEKEY]-&gt;[UM.UMKEY]
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find DF entities</param>
        /// <returns>A list of related DF entities</returns>
        public IReadOnlyList<DF> FindDFByHOMEKEY(int UMKEY)
        {
            IReadOnlyList<DF> result;
            if (DF_HOMEKEYForeignIndex.Value.TryGetValue(UMKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<DF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DF entities by [DF.HOMEKEY]-&gt;[UM.UMKEY]
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find DF entities</param>
        /// <param name="Value">A list of related DF entities</param>
        /// <returns>True if any DF entities are found</returns>
        public bool TryFindDFByHOMEKEY(int UMKEY, out IReadOnlyList<DF> Value)
        {
            return DF_HOMEKEYForeignIndex.Value.TryGetValue(UMKEY, out Value);
        }

        /// <summary>
        /// Find all DF (Families) entities by [DF.MAILKEY]-&gt;[UM.UMKEY]
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find DF entities</param>
        /// <returns>A list of related DF entities</returns>
        public IReadOnlyList<DF> FindDFByMAILKEY(int UMKEY)
        {
            IReadOnlyList<DF> result;
            if (DF_MAILKEYForeignIndex.Value.TryGetValue(UMKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<DF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DF entities by [DF.MAILKEY]-&gt;[UM.UMKEY]
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find DF entities</param>
        /// <param name="Value">A list of related DF entities</param>
        /// <returns>True if any DF entities are found</returns>
        public bool TryFindDFByMAILKEY(int UMKEY, out IReadOnlyList<DF> Value)
        {
            return DF_MAILKEYForeignIndex.Value.TryGetValue(UMKEY, out Value);
        }

        /// <summary>
        /// Find all DF (Families) entities by [DF.BILLINGKEY]-&gt;[UM.UMKEY]
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find DF entities</param>
        /// <returns>A list of related DF entities</returns>
        public IReadOnlyList<DF> FindDFByBILLINGKEY(int UMKEY)
        {
            IReadOnlyList<DF> result;
            if (DF_BILLINGKEYForeignIndex.Value.TryGetValue(UMKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<DF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DF entities by [DF.BILLINGKEY]-&gt;[UM.UMKEY]
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find DF entities</param>
        /// <param name="Value">A list of related DF entities</param>
        /// <returns>True if any DF entities are found</returns>
        public bool TryFindDFByBILLINGKEY(int UMKEY, out IReadOnlyList<DF> Value)
        {
            return DF_BILLINGKEYForeignIndex.Value.TryGetValue(UMKEY, out Value);
        }

        /// <summary>
        /// Find all PE (Employees) entities by [PE.HOMEKEY]-&gt;[UM.UMKEY]
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find PE entities</param>
        /// <returns>A list of related PE entities</returns>
        public IReadOnlyList<PE> FindPEByHOMEKEY(int UMKEY)
        {
            IReadOnlyList<PE> result;
            if (PE_HOMEKEYForeignIndex.Value.TryGetValue(UMKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PE entities by [PE.HOMEKEY]-&gt;[UM.UMKEY]
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find PE entities</param>
        /// <param name="Value">A list of related PE entities</param>
        /// <returns>True if any PE entities are found</returns>
        public bool TryFindPEByHOMEKEY(int UMKEY, out IReadOnlyList<PE> Value)
        {
            return PE_HOMEKEYForeignIndex.Value.TryGetValue(UMKEY, out Value);
        }

        /// <summary>
        /// Find all PE (Employees) entities by [PE.MAILKEY]-&gt;[UM.UMKEY]
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find PE entities</param>
        /// <returns>A list of related PE entities</returns>
        public IReadOnlyList<PE> FindPEByMAILKEY(int UMKEY)
        {
            IReadOnlyList<PE> result;
            if (PE_MAILKEYForeignIndex.Value.TryGetValue(UMKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PE entities by [PE.MAILKEY]-&gt;[UM.UMKEY]
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find PE entities</param>
        /// <param name="Value">A list of related PE entities</param>
        /// <returns>True if any PE entities are found</returns>
        public bool TryFindPEByMAILKEY(int UMKEY, out IReadOnlyList<PE> Value)
        {
            return PE_MAILKEYForeignIndex.Value.TryGetValue(UMKEY, out Value);
        }

        /// <summary>
        /// Find all PE (Employees) entities by [PE.LEAVEKEY]-&gt;[UM.UMKEY]
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find PE entities</param>
        /// <returns>A list of related PE entities</returns>
        public IReadOnlyList<PE> FindPEByLEAVEKEY(int UMKEY)
        {
            IReadOnlyList<PE> result;
            if (PE_LEAVEKEYForeignIndex.Value.TryGetValue(UMKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PE entities by [PE.LEAVEKEY]-&gt;[UM.UMKEY]
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find PE entities</param>
        /// <param name="Value">A list of related PE entities</param>
        /// <returns>True if any PE entities are found</returns>
        public bool TryFindPEByLEAVEKEY(int UMKEY, out IReadOnlyList<PE> Value)
        {
            return PE_LEAVEKEYForeignIndex.Value.TryGetValue(UMKEY, out Value);
        }

        /// <summary>
        /// Find all SAM (School Association Members) entities by [SAM.ADDRESSKEY]-&gt;[UM.UMKEY]
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find SAM entities</param>
        /// <returns>A list of related SAM entities</returns>
        public IReadOnlyList<SAM> FindSAMByADDRESSKEY(int UMKEY)
        {
            IReadOnlyList<SAM> result;
            if (SAM_ADDRESSKEYForeignIndex.Value.TryGetValue(UMKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SAM>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SAM entities by [SAM.ADDRESSKEY]-&gt;[UM.UMKEY]
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find SAM entities</param>
        /// <param name="Value">A list of related SAM entities</param>
        /// <returns>True if any SAM entities are found</returns>
        public bool TryFindSAMByADDRESSKEY(int UMKEY, out IReadOnlyList<SAM> Value)
        {
            return SAM_ADDRESSKEYForeignIndex.Value.TryGetValue(UMKEY, out Value);
        }

        /// <summary>
        /// Find all SAM (School Association Members) entities by [SAM.MAILKEY]-&gt;[UM.UMKEY]
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find SAM entities</param>
        /// <returns>A list of related SAM entities</returns>
        public IReadOnlyList<SAM> FindSAMByMAILKEY(int UMKEY)
        {
            IReadOnlyList<SAM> result;
            if (SAM_MAILKEYForeignIndex.Value.TryGetValue(UMKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SAM>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SAM entities by [SAM.MAILKEY]-&gt;[UM.UMKEY]
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find SAM entities</param>
        /// <param name="Value">A list of related SAM entities</param>
        /// <returns>True if any SAM entities are found</returns>
        public bool TryFindSAMByMAILKEY(int UMKEY, out IReadOnlyList<SAM> Value)
        {
            return SAM_MAILKEYForeignIndex.Value.TryGetValue(UMKEY, out Value);
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.HOMEKEY]-&gt;[UM.UMKEY]
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFByHOMEKEY(int UMKEY)
        {
            IReadOnlyList<SF> result;
            if (SF_HOMEKEYForeignIndex.Value.TryGetValue(UMKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.HOMEKEY]-&gt;[UM.UMKEY]
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFByHOMEKEY(int UMKEY, out IReadOnlyList<SF> Value)
        {
            return SF_HOMEKEYForeignIndex.Value.TryGetValue(UMKEY, out Value);
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.MAILKEY]-&gt;[UM.UMKEY]
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFByMAILKEY(int UMKEY)
        {
            IReadOnlyList<SF> result;
            if (SF_MAILKEYForeignIndex.Value.TryGetValue(UMKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.MAILKEY]-&gt;[UM.UMKEY]
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFByMAILKEY(int UMKEY, out IReadOnlyList<SF> Value)
        {
            return SF_MAILKEYForeignIndex.Value.TryGetValue(UMKEY, out Value);
        }

        /// <summary>
        /// Find all STTRIPS (Student Trips) entities by [STTRIPS.AM_PICKUP_ADDRESS_ID]-&gt;[UM.UMKEY]
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find STTRIPS entities</param>
        /// <returns>A list of related STTRIPS entities</returns>
        public IReadOnlyList<STTRIPS> FindSTTRIPSByAM_PICKUP_ADDRESS_ID(int UMKEY)
        {
            IReadOnlyList<STTRIPS> result;
            if (STTRIPS_AM_PICKUP_ADDRESS_IDForeignIndex.Value.TryGetValue(UMKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STTRIPS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STTRIPS entities by [STTRIPS.AM_PICKUP_ADDRESS_ID]-&gt;[UM.UMKEY]
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find STTRIPS entities</param>
        /// <param name="Value">A list of related STTRIPS entities</param>
        /// <returns>True if any STTRIPS entities are found</returns>
        public bool TryFindSTTRIPSByAM_PICKUP_ADDRESS_ID(int UMKEY, out IReadOnlyList<STTRIPS> Value)
        {
            return STTRIPS_AM_PICKUP_ADDRESS_IDForeignIndex.Value.TryGetValue(UMKEY, out Value);
        }

        /// <summary>
        /// Find all STTRIPS (Student Trips) entities by [STTRIPS.PM_SETDOWN_ADDRESS_ID]-&gt;[UM.UMKEY]
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find STTRIPS entities</param>
        /// <returns>A list of related STTRIPS entities</returns>
        public IReadOnlyList<STTRIPS> FindSTTRIPSByPM_SETDOWN_ADDRESS_ID(int UMKEY)
        {
            IReadOnlyList<STTRIPS> result;
            if (STTRIPS_PM_SETDOWN_ADDRESS_IDForeignIndex.Value.TryGetValue(UMKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STTRIPS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STTRIPS entities by [STTRIPS.PM_SETDOWN_ADDRESS_ID]-&gt;[UM.UMKEY]
        /// </summary>
        /// <param name="UMKEY">UMKEY value used to find STTRIPS entities</param>
        /// <param name="Value">A list of related STTRIPS entities</param>
        /// <returns>True if any STTRIPS entities are found</returns>
        public bool TryFindSTTRIPSByPM_SETDOWN_ADDRESS_ID(int UMKEY, out IReadOnlyList<STTRIPS> Value)
        {
            return STTRIPS_PM_SETDOWN_ADDRESS_IDForeignIndex.Value.TryGetValue(UMKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="UM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="UM" /> fields for each CSV column header</returns>
        protected override Action<UM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<UM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "UMKEY":
                        mapper[i] = (e, v) => e.UMKEY = int.Parse(v);
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "ADDRESS03":
                        mapper[i] = (e, v) => e.ADDRESS03 = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "SILENT":
                        mapper[i] = (e, v) => e.SILENT = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "KAP_LINK":
                        mapper[i] = (e, v) => e.KAP_LINK = v;
                        break;
                    case "COUNTRY":
                        mapper[i] = (e, v) => e.COUNTRY = v;
                        break;
                    case "DPID":
                        mapper[i] = (e, v) => e.DPID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BARCODE":
                        mapper[i] = (e, v) => e.BARCODE = v;
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
