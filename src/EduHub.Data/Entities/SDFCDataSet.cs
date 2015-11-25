using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Sundry Debtor Fees Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SDFCDataSet : SetBase<SDFC>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SDFC"; } }

        internal SDFCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GLCODE = new Lazy<NullDictionary<string, IReadOnlyList<SDFC>>>(() => this.ToGroupedNullDictionary(i => i.GLCODE));
            Index_GST_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<SDFC>>>(() => this.ToGroupedNullDictionary(i => i.GST_TYPE));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<SDFC>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_SDFCKEY = new Lazy<Dictionary<string, SDFC>>(() => this.ToDictionary(i => i.SDFCKEY));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<SDFC>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SDFC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SDFC" /> fields for each CSV column header</returns>
        protected override Action<SDFC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SDFC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SDFCKEY":
                        mapper[i] = (e, v) => e.SDFCKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "SDGROUP":
                        mapper[i] = (e, v) => e.SDGROUP = v;
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
        /// Merges <see cref="SDFC" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SDFC" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SDFC" /> items to added or update the base <see cref="SDFC" /> items</param>
        /// <returns>A merged list of <see cref="SDFC" /> items</returns>
        protected override List<SDFC> ApplyDeltaItems(List<SDFC> Items, List<SDFC> DeltaItems)
        {
            Dictionary<string, int> Index_SDFCKEY = Items.ToIndexDictionary(i => i.SDFCKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SDFC deltaItem in DeltaItems)
            {
                int index;

                if (Index_SDFCKEY.TryGetValue(deltaItem.SDFCKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SDFCKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<SDFC>>> Index_GLCODE;
        private Lazy<NullDictionary<string, IReadOnlyList<SDFC>>> Index_GST_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<SDFC>>> Index_INITIATIVE;
        private Lazy<Dictionary<string, SDFC>> Index_SDFCKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SDFC>>> Index_SUBPROGRAM;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SDFC by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find SDFC</param>
        /// <returns>List of related SDFC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDFC> FindByGLCODE(string GLCODE)
        {
            return Index_GLCODE.Value[GLCODE];
        }

        /// <summary>
        /// Attempt to find SDFC by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find SDFC</param>
        /// <param name="Value">List of related SDFC entities</param>
        /// <returns>True if the list of related SDFC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLCODE(string GLCODE, out IReadOnlyList<SDFC> Value)
        {
            return Index_GLCODE.Value.TryGetValue(GLCODE, out Value);
        }

        /// <summary>
        /// Attempt to find SDFC by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find SDFC</param>
        /// <returns>List of related SDFC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDFC> TryFindByGLCODE(string GLCODE)
        {
            IReadOnlyList<SDFC> value;
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
        /// Find SDFC by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find SDFC</param>
        /// <returns>List of related SDFC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDFC> FindByGST_TYPE(string GST_TYPE)
        {
            return Index_GST_TYPE.Value[GST_TYPE];
        }

        /// <summary>
        /// Attempt to find SDFC by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find SDFC</param>
        /// <param name="Value">List of related SDFC entities</param>
        /// <returns>True if the list of related SDFC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGST_TYPE(string GST_TYPE, out IReadOnlyList<SDFC> Value)
        {
            return Index_GST_TYPE.Value.TryGetValue(GST_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find SDFC by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find SDFC</param>
        /// <returns>List of related SDFC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDFC> TryFindByGST_TYPE(string GST_TYPE)
        {
            IReadOnlyList<SDFC> value;
            if (Index_GST_TYPE.Value.TryGetValue(GST_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SDFC by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find SDFC</param>
        /// <returns>List of related SDFC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDFC> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find SDFC by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find SDFC</param>
        /// <param name="Value">List of related SDFC entities</param>
        /// <returns>True if the list of related SDFC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<SDFC> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find SDFC by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find SDFC</param>
        /// <returns>List of related SDFC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDFC> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<SDFC> value;
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
        /// Find SDFC by SDFCKEY field
        /// </summary>
        /// <param name="SDFCKEY">SDFCKEY value used to find SDFC</param>
        /// <returns>Related SDFC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SDFC FindBySDFCKEY(string SDFCKEY)
        {
            return Index_SDFCKEY.Value[SDFCKEY];
        }

        /// <summary>
        /// Attempt to find SDFC by SDFCKEY field
        /// </summary>
        /// <param name="SDFCKEY">SDFCKEY value used to find SDFC</param>
        /// <param name="Value">Related SDFC entity</param>
        /// <returns>True if the related SDFC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySDFCKEY(string SDFCKEY, out SDFC Value)
        {
            return Index_SDFCKEY.Value.TryGetValue(SDFCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SDFC by SDFCKEY field
        /// </summary>
        /// <param name="SDFCKEY">SDFCKEY value used to find SDFC</param>
        /// <returns>Related SDFC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SDFC TryFindBySDFCKEY(string SDFCKEY)
        {
            SDFC value;
            if (Index_SDFCKEY.Value.TryGetValue(SDFCKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SDFC by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find SDFC</param>
        /// <returns>List of related SDFC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDFC> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find SDFC by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find SDFC</param>
        /// <param name="Value">List of related SDFC entities</param>
        /// <returns>True if the list of related SDFC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<SDFC> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find SDFC by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find SDFC</param>
        /// <returns>List of related SDFC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDFC> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<SDFC> value;
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
