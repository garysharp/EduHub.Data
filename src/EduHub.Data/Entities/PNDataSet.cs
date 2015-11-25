using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Payroll Groups Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PNDataSet : SetBase<PN>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PN"; } }

        internal PNDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_DD_GLCODE = new Lazy<NullDictionary<string, IReadOnlyList<PN>>>(() => this.ToGroupedNullDictionary(i => i.DD_GLCODE));
            Index_GLBANK = new Lazy<NullDictionary<string, IReadOnlyList<PN>>>(() => this.ToGroupedNullDictionary(i => i.GLBANK));
            Index_GLCODE = new Lazy<NullDictionary<string, IReadOnlyList<PN>>>(() => this.ToGroupedNullDictionary(i => i.GLCODE));
            Index_GLTAX = new Lazy<NullDictionary<string, IReadOnlyList<PN>>>(() => this.ToGroupedNullDictionary(i => i.GLTAX));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<PN>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_PNKEY = new Lazy<Dictionary<short, PN>>(() => this.ToDictionary(i => i.PNKEY));
            Index_PPDKEY = new Lazy<NullDictionary<string, IReadOnlyList<PN>>>(() => this.ToGroupedNullDictionary(i => i.PPDKEY));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<PN>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PN" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PN" /> fields for each CSV column header</returns>
        protected override Action<PN, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PN, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PNKEY":
                        mapper[i] = (e, v) => e.PNKEY = short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "TRANSTYPE":
                        mapper[i] = (e, v) => e.TRANSTYPE = v;
                        break;
                    case "FIRSTDATE":
                        mapper[i] = (e, v) => e.FIRSTDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "NEXTDATE":
                        mapper[i] = (e, v) => e.NEXTDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "NO_PAYS":
                        mapper[i] = (e, v) => e.NO_PAYS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ROUNDOFF":
                        mapper[i] = (e, v) => e.ROUNDOFF = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PPDKEY":
                        mapper[i] = (e, v) => e.PPDKEY = v;
                        break;
                    case "PAY_TYPE":
                        mapper[i] = (e, v) => e.PAY_TYPE = v;
                        break;
                    case "ACN":
                        mapper[i] = (e, v) => e.ACN = v;
                        break;
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
                        break;
                    case "DD_GLCODE":
                        mapper[i] = (e, v) => e.DD_GLCODE = v;
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "GLBANK":
                        mapper[i] = (e, v) => e.GLBANK = v;
                        break;
                    case "GLTAX":
                        mapper[i] = (e, v) => e.GLTAX = v;
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

        /// <summary>
        /// Merges <see cref="PN" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PN" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PN" /> items to added or update the base <see cref="PN" /> items</param>
        /// <returns>A merged list of <see cref="PN" /> items</returns>
        protected override List<PN> ApplyDeltaItems(List<PN> Items, List<PN> DeltaItems)
        {
            Dictionary<short, int> Index_PNKEY = Items.ToIndexDictionary(i => i.PNKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PN deltaItem in DeltaItems)
            {
                int index;

                if (Index_PNKEY.TryGetValue(deltaItem.PNKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.PNKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<PN>>> Index_DD_GLCODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PN>>> Index_GLBANK;
        private Lazy<NullDictionary<string, IReadOnlyList<PN>>> Index_GLCODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PN>>> Index_GLTAX;
        private Lazy<NullDictionary<string, IReadOnlyList<PN>>> Index_INITIATIVE;
        private Lazy<Dictionary<short, PN>> Index_PNKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<PN>>> Index_PPDKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<PN>>> Index_SUBPROGRAM;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PN by DD_GLCODE field
        /// </summary>
        /// <param name="DD_GLCODE">DD_GLCODE value used to find PN</param>
        /// <returns>List of related PN entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> FindByDD_GLCODE(string DD_GLCODE)
        {
            return Index_DD_GLCODE.Value[DD_GLCODE];
        }

        /// <summary>
        /// Attempt to find PN by DD_GLCODE field
        /// </summary>
        /// <param name="DD_GLCODE">DD_GLCODE value used to find PN</param>
        /// <param name="Value">List of related PN entities</param>
        /// <returns>True if the list of related PN entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDD_GLCODE(string DD_GLCODE, out IReadOnlyList<PN> Value)
        {
            return Index_DD_GLCODE.Value.TryGetValue(DD_GLCODE, out Value);
        }

        /// <summary>
        /// Attempt to find PN by DD_GLCODE field
        /// </summary>
        /// <param name="DD_GLCODE">DD_GLCODE value used to find PN</param>
        /// <returns>List of related PN entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> TryFindByDD_GLCODE(string DD_GLCODE)
        {
            IReadOnlyList<PN> value;
            if (Index_DD_GLCODE.Value.TryGetValue(DD_GLCODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PN by GLBANK field
        /// </summary>
        /// <param name="GLBANK">GLBANK value used to find PN</param>
        /// <returns>List of related PN entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> FindByGLBANK(string GLBANK)
        {
            return Index_GLBANK.Value[GLBANK];
        }

        /// <summary>
        /// Attempt to find PN by GLBANK field
        /// </summary>
        /// <param name="GLBANK">GLBANK value used to find PN</param>
        /// <param name="Value">List of related PN entities</param>
        /// <returns>True if the list of related PN entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLBANK(string GLBANK, out IReadOnlyList<PN> Value)
        {
            return Index_GLBANK.Value.TryGetValue(GLBANK, out Value);
        }

        /// <summary>
        /// Attempt to find PN by GLBANK field
        /// </summary>
        /// <param name="GLBANK">GLBANK value used to find PN</param>
        /// <returns>List of related PN entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> TryFindByGLBANK(string GLBANK)
        {
            IReadOnlyList<PN> value;
            if (Index_GLBANK.Value.TryGetValue(GLBANK, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PN by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PN</param>
        /// <returns>List of related PN entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> FindByGLCODE(string GLCODE)
        {
            return Index_GLCODE.Value[GLCODE];
        }

        /// <summary>
        /// Attempt to find PN by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PN</param>
        /// <param name="Value">List of related PN entities</param>
        /// <returns>True if the list of related PN entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLCODE(string GLCODE, out IReadOnlyList<PN> Value)
        {
            return Index_GLCODE.Value.TryGetValue(GLCODE, out Value);
        }

        /// <summary>
        /// Attempt to find PN by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PN</param>
        /// <returns>List of related PN entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> TryFindByGLCODE(string GLCODE)
        {
            IReadOnlyList<PN> value;
            if (Index_GLCODE.Value.TryGetValue(GLCODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PN by GLTAX field
        /// </summary>
        /// <param name="GLTAX">GLTAX value used to find PN</param>
        /// <returns>List of related PN entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> FindByGLTAX(string GLTAX)
        {
            return Index_GLTAX.Value[GLTAX];
        }

        /// <summary>
        /// Attempt to find PN by GLTAX field
        /// </summary>
        /// <param name="GLTAX">GLTAX value used to find PN</param>
        /// <param name="Value">List of related PN entities</param>
        /// <returns>True if the list of related PN entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLTAX(string GLTAX, out IReadOnlyList<PN> Value)
        {
            return Index_GLTAX.Value.TryGetValue(GLTAX, out Value);
        }

        /// <summary>
        /// Attempt to find PN by GLTAX field
        /// </summary>
        /// <param name="GLTAX">GLTAX value used to find PN</param>
        /// <returns>List of related PN entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> TryFindByGLTAX(string GLTAX)
        {
            IReadOnlyList<PN> value;
            if (Index_GLTAX.Value.TryGetValue(GLTAX, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PN by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PN</param>
        /// <returns>List of related PN entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find PN by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PN</param>
        /// <param name="Value">List of related PN entities</param>
        /// <returns>True if the list of related PN entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<PN> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find PN by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PN</param>
        /// <returns>List of related PN entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<PN> value;
            if (Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PN by PNKEY field
        /// </summary>
        /// <param name="PNKEY">PNKEY value used to find PN</param>
        /// <returns>Related PN entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PN FindByPNKEY(short PNKEY)
        {
            return Index_PNKEY.Value[PNKEY];
        }

        /// <summary>
        /// Attempt to find PN by PNKEY field
        /// </summary>
        /// <param name="PNKEY">PNKEY value used to find PN</param>
        /// <param name="Value">Related PN entity</param>
        /// <returns>True if the related PN entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPNKEY(short PNKEY, out PN Value)
        {
            return Index_PNKEY.Value.TryGetValue(PNKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PN by PNKEY field
        /// </summary>
        /// <param name="PNKEY">PNKEY value used to find PN</param>
        /// <returns>Related PN entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PN TryFindByPNKEY(short PNKEY)
        {
            PN value;
            if (Index_PNKEY.Value.TryGetValue(PNKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PN by PPDKEY field
        /// </summary>
        /// <param name="PPDKEY">PPDKEY value used to find PN</param>
        /// <returns>List of related PN entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> FindByPPDKEY(string PPDKEY)
        {
            return Index_PPDKEY.Value[PPDKEY];
        }

        /// <summary>
        /// Attempt to find PN by PPDKEY field
        /// </summary>
        /// <param name="PPDKEY">PPDKEY value used to find PN</param>
        /// <param name="Value">List of related PN entities</param>
        /// <returns>True if the list of related PN entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPPDKEY(string PPDKEY, out IReadOnlyList<PN> Value)
        {
            return Index_PPDKEY.Value.TryGetValue(PPDKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PN by PPDKEY field
        /// </summary>
        /// <param name="PPDKEY">PPDKEY value used to find PN</param>
        /// <returns>List of related PN entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> TryFindByPPDKEY(string PPDKEY)
        {
            IReadOnlyList<PN> value;
            if (Index_PPDKEY.Value.TryGetValue(PPDKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PN by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PN</param>
        /// <returns>List of related PN entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find PN by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PN</param>
        /// <param name="Value">List of related PN entities</param>
        /// <returns>True if the list of related PN entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<PN> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find PN by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PN</param>
        /// <returns>List of related PN entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<PN> value;
            if (Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out value))
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
