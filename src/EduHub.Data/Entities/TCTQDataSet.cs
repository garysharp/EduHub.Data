using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Class Information Data Set
    /// </summary>
    public sealed partial class TCTQDataSet : SetBase<TCTQ>
    {
        private Lazy<Dictionary<short, TCTQ>> COMPOSITEIndex;


        internal TCTQDataSet(EduHubContext Context)
            : base(Context)
        {
            COMPOSITEIndex = new Lazy<Dictionary<short, TCTQ>>(() => this.ToDictionary(e => e.COMPOSITE));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TCTQ"; } }

        /// <summary>
        /// Find TCTQ by COMPOSITE key field
        /// </summary>
        /// <param name="Key">COMPOSITE value used to find TCTQ</param>
        /// <returns>Related TCTQ entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">COMPOSITE value didn't match any TCTQ entities</exception>
        public TCTQ FindByCOMPOSITE(short Key)
        {
            TCTQ result;
            if (COMPOSITEIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find TCTQ by COMPOSITE key field
        /// </summary>
        /// <param name="Key">COMPOSITE value used to find TCTQ</param>
        /// <param name="Value">Related TCTQ entity</param>
        /// <returns>True if the TCTQ entity is found</returns>
        public bool TryFindByCOMPOSITE(short Key, out TCTQ Value)
        {
            return COMPOSITEIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find TCTQ by COMPOSITE key field
        /// </summary>
        /// <param name="Key">COMPOSITE value used to find TCTQ</param>
        /// <returns>Related TCTQ entity, or null if not found</returns>
        public TCTQ TryFindByCOMPOSITE(short Key)
        {
            TCTQ result;
            if (COMPOSITEIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TCTQ" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TCTQ" /> fields for each CSV column header</returns>
        protected override Action<TCTQ, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TCTQ, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TCTQKEY":
                        mapper[i] = (e, v) => e.TCTQKEY = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "QKEY":
                        mapper[i] = (e, v) => e.QKEY = v;
                        break;
                    case "SUBJ":
                        mapper[i] = (e, v) => e.SUBJ = v;
                        break;
                    case "CLASS":
                        mapper[i] = (e, v) => e.CLASS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "IDENT":
                        mapper[i] = (e, v) => e.IDENT = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CLASS_SIZE":
                        mapper[i] = (e, v) => e.CLASS_SIZE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "T1TEACH":
                        mapper[i] = (e, v) => e.T1TEACH = v;
                        break;
                    case "T2TEACH":
                        mapper[i] = (e, v) => e.T2TEACH = v;
                        break;
                    case "R1ROOM":
                        mapper[i] = (e, v) => e.R1ROOM = v;
                        break;
                    case "R2ROOM":
                        mapper[i] = (e, v) => e.R2ROOM = v;
                        break;
                    case "RESOURCES01":
                        mapper[i] = (e, v) => e.RESOURCES01 = v;
                        break;
                    case "RESOURCES02":
                        mapper[i] = (e, v) => e.RESOURCES02 = v;
                        break;
                    case "RESOURCES03":
                        mapper[i] = (e, v) => e.RESOURCES03 = v;
                        break;
                    case "RESOURCES04":
                        mapper[i] = (e, v) => e.RESOURCES04 = v;
                        break;
                    case "RESOURCES05":
                        mapper[i] = (e, v) => e.RESOURCES05 = v;
                        break;
                    case "RESOURCES06":
                        mapper[i] = (e, v) => e.RESOURCES06 = v;
                        break;
                    case "RESOURCES07":
                        mapper[i] = (e, v) => e.RESOURCES07 = v;
                        break;
                    case "RESOURCES08":
                        mapper[i] = (e, v) => e.RESOURCES08 = v;
                        break;
                    case "RESOURCES09":
                        mapper[i] = (e, v) => e.RESOURCES09 = v;
                        break;
                    case "EXTRA_TEACH":
                        mapper[i] = (e, v) => e.EXTRA_TEACH = v;
                        break;
                    case "EXTRA_ROOM":
                        mapper[i] = (e, v) => e.EXTRA_ROOM = v;
                        break;
                    case "QROW":
                        mapper[i] = (e, v) => e.QROW = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "QCOL":
                        mapper[i] = (e, v) => e.QCOL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "COMPOSITE":
                        mapper[i] = (e, v) => e.COMPOSITE = short.Parse(v);
                        break;
                    case "GKEY":
                        mapper[i] = (e, v) => e.GKEY = v;
                        break;
                    case "GROW":
                        mapper[i] = (e, v) => e.GROW = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "GCOL":
                        mapper[i] = (e, v) => e.GCOL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "GCOLOUR":
                        mapper[i] = (e, v) => e.GCOLOUR = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "OCCUR":
                        mapper[i] = (e, v) => e.OCCUR = v == null ? (short?)null : short.Parse(v);
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
