using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Standard and Last Pays Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PEPSDataSet : SetBase<PEPS>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PEPS"; } }

        internal PEPSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<PEPS>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_TID = new Lazy<Dictionary<int, PEPS>>(() => this.ToDictionary(i => i.TID));
            Index_PAYITEM = new Lazy<NullDictionary<short?, IReadOnlyList<PEPS>>>(() => this.ToGroupedNullDictionary(i => i.PAYITEM));
            Index_PAY_STEP = new Lazy<NullDictionary<short?, IReadOnlyList<PEPS>>>(() => this.ToGroupedNullDictionary(i => i.PAY_STEP));
            Index_SUPER_FUND = new Lazy<NullDictionary<string, IReadOnlyList<PEPS>>>(() => this.ToGroupedNullDictionary(i => i.SUPER_FUND));
            Index_TRCENTRE = new Lazy<NullDictionary<string, IReadOnlyList<PEPS>>>(() => this.ToGroupedNullDictionary(i => i.TRCENTRE));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<PEPS>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<PEPS>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PEPS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PEPS" /> fields for each CSV column header</returns>
        protected override Action<PEPS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PEPS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "PAYITEM":
                        mapper[i] = (e, v) => e.PAYITEM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TRCOST":
                        mapper[i] = (e, v) => e.TRCOST = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TRQTY":
                        mapper[i] = (e, v) => e.TRQTY = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TRAMT":
                        mapper[i] = (e, v) => e.TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRDET":
                        mapper[i] = (e, v) => e.TRDET = v;
                        break;
                    case "FLAG":
                        mapper[i] = (e, v) => e.FLAG = v;
                        break;
                    case "TRPAYSPAN":
                        mapper[i] = (e, v) => e.TRPAYSPAN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TRTAXSPAN":
                        mapper[i] = (e, v) => e.TRTAXSPAN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TRDATE":
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TIMESHEET_NO":
                        mapper[i] = (e, v) => e.TIMESHEET_NO = v;
                        break;
                    case "PAY_STEP":
                        mapper[i] = (e, v) => e.PAY_STEP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SUPER_FUND":
                        mapper[i] = (e, v) => e.SUPER_FUND = v;
                        break;
                    case "SUPER_MEMBER":
                        mapper[i] = (e, v) => e.SUPER_MEMBER = v;
                        break;
                    case "SUPER_PERCENT":
                        mapper[i] = (e, v) => e.SUPER_PERCENT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TRCENTRE":
                        mapper[i] = (e, v) => e.TRCENTRE = v;
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
                    case "SPLIT_PERCENT":
                        mapper[i] = (e, v) => e.SPLIT_PERCENT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ALTER_TRQTY":
                        mapper[i] = (e, v) => e.ALTER_TRQTY = v == null ? (double?)null : double.Parse(v);
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

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<PEPS>>> Index_CODE;
        private Lazy<Dictionary<int, PEPS>> Index_TID;
        private Lazy<NullDictionary<short?, IReadOnlyList<PEPS>>> Index_PAYITEM;
        private Lazy<NullDictionary<short?, IReadOnlyList<PEPS>>> Index_PAY_STEP;
        private Lazy<NullDictionary<string, IReadOnlyList<PEPS>>> Index_SUPER_FUND;
        private Lazy<NullDictionary<string, IReadOnlyList<PEPS>>> Index_TRCENTRE;
        private Lazy<NullDictionary<string, IReadOnlyList<PEPS>>> Index_SUBPROGRAM;
        private Lazy<NullDictionary<string, IReadOnlyList<PEPS>>> Index_INITIATIVE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PEPS by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPS</param>
        /// <returns>List of related PEPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find PEPS by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPS</param>
        /// <param name="Value">List of related PEPS entities</param>
        /// <returns>True if the list of related PEPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<PEPS> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PEPS by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPS</param>
        /// <returns>List of related PEPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> TryFindByCODE(string CODE)
        {
            IReadOnlyList<PEPS> value;
            if (Index_CODE.Value.TryGetValue(CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PEPS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPS</param>
        /// <returns>Related PEPS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEPS FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PEPS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPS</param>
        /// <param name="Value">Related PEPS entity</param>
        /// <returns>True if the related PEPS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PEPS Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PEPS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPS</param>
        /// <returns>Related PEPS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEPS TryFindByTID(int TID)
        {
            PEPS value;
            if (Index_TID.Value.TryGetValue(TID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PEPS by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PEPS</param>
        /// <returns>List of related PEPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> FindByPAYITEM(short? PAYITEM)
        {
            return Index_PAYITEM.Value[PAYITEM];
        }

        /// <summary>
        /// Attempt to find PEPS by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PEPS</param>
        /// <param name="Value">List of related PEPS entities</param>
        /// <returns>True if the list of related PEPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPAYITEM(short? PAYITEM, out IReadOnlyList<PEPS> Value)
        {
            return Index_PAYITEM.Value.TryGetValue(PAYITEM, out Value);
        }

        /// <summary>
        /// Attempt to find PEPS by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PEPS</param>
        /// <returns>List of related PEPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> TryFindByPAYITEM(short? PAYITEM)
        {
            IReadOnlyList<PEPS> value;
            if (Index_PAYITEM.Value.TryGetValue(PAYITEM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PEPS by PAY_STEP field
        /// </summary>
        /// <param name="PAY_STEP">PAY_STEP value used to find PEPS</param>
        /// <returns>List of related PEPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> FindByPAY_STEP(short? PAY_STEP)
        {
            return Index_PAY_STEP.Value[PAY_STEP];
        }

        /// <summary>
        /// Attempt to find PEPS by PAY_STEP field
        /// </summary>
        /// <param name="PAY_STEP">PAY_STEP value used to find PEPS</param>
        /// <param name="Value">List of related PEPS entities</param>
        /// <returns>True if the list of related PEPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPAY_STEP(short? PAY_STEP, out IReadOnlyList<PEPS> Value)
        {
            return Index_PAY_STEP.Value.TryGetValue(PAY_STEP, out Value);
        }

        /// <summary>
        /// Attempt to find PEPS by PAY_STEP field
        /// </summary>
        /// <param name="PAY_STEP">PAY_STEP value used to find PEPS</param>
        /// <returns>List of related PEPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> TryFindByPAY_STEP(short? PAY_STEP)
        {
            IReadOnlyList<PEPS> value;
            if (Index_PAY_STEP.Value.TryGetValue(PAY_STEP, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PEPS by SUPER_FUND field
        /// </summary>
        /// <param name="SUPER_FUND">SUPER_FUND value used to find PEPS</param>
        /// <returns>List of related PEPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> FindBySUPER_FUND(string SUPER_FUND)
        {
            return Index_SUPER_FUND.Value[SUPER_FUND];
        }

        /// <summary>
        /// Attempt to find PEPS by SUPER_FUND field
        /// </summary>
        /// <param name="SUPER_FUND">SUPER_FUND value used to find PEPS</param>
        /// <param name="Value">List of related PEPS entities</param>
        /// <returns>True if the list of related PEPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUPER_FUND(string SUPER_FUND, out IReadOnlyList<PEPS> Value)
        {
            return Index_SUPER_FUND.Value.TryGetValue(SUPER_FUND, out Value);
        }

        /// <summary>
        /// Attempt to find PEPS by SUPER_FUND field
        /// </summary>
        /// <param name="SUPER_FUND">SUPER_FUND value used to find PEPS</param>
        /// <returns>List of related PEPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> TryFindBySUPER_FUND(string SUPER_FUND)
        {
            IReadOnlyList<PEPS> value;
            if (Index_SUPER_FUND.Value.TryGetValue(SUPER_FUND, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PEPS by TRCENTRE field
        /// </summary>
        /// <param name="TRCENTRE">TRCENTRE value used to find PEPS</param>
        /// <returns>List of related PEPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> FindByTRCENTRE(string TRCENTRE)
        {
            return Index_TRCENTRE.Value[TRCENTRE];
        }

        /// <summary>
        /// Attempt to find PEPS by TRCENTRE field
        /// </summary>
        /// <param name="TRCENTRE">TRCENTRE value used to find PEPS</param>
        /// <param name="Value">List of related PEPS entities</param>
        /// <returns>True if the list of related PEPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTRCENTRE(string TRCENTRE, out IReadOnlyList<PEPS> Value)
        {
            return Index_TRCENTRE.Value.TryGetValue(TRCENTRE, out Value);
        }

        /// <summary>
        /// Attempt to find PEPS by TRCENTRE field
        /// </summary>
        /// <param name="TRCENTRE">TRCENTRE value used to find PEPS</param>
        /// <returns>List of related PEPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> TryFindByTRCENTRE(string TRCENTRE)
        {
            IReadOnlyList<PEPS> value;
            if (Index_TRCENTRE.Value.TryGetValue(TRCENTRE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PEPS by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEPS</param>
        /// <returns>List of related PEPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find PEPS by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEPS</param>
        /// <param name="Value">List of related PEPS entities</param>
        /// <returns>True if the list of related PEPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<PEPS> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find PEPS by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEPS</param>
        /// <returns>List of related PEPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<PEPS> value;
            if (Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PEPS by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEPS</param>
        /// <returns>List of related PEPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find PEPS by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEPS</param>
        /// <param name="Value">List of related PEPS entities</param>
        /// <returns>True if the list of related PEPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<PEPS> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find PEPS by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEPS</param>
        /// <returns>List of related PEPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPS> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<PEPS> value;
            if (Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        #endregion

    }
}
