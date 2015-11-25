using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Fees - Billing Templates Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SABDataSet : SetBase<SAB>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SAB"; } }

        internal SABDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_FEE_CODE_1ST = new Lazy<NullDictionary<string, IReadOnlyList<SAB>>>(() => this.ToGroupedNullDictionary(i => i.FEE_CODE_1ST));
            Index_FEE_CODE_2ND = new Lazy<NullDictionary<string, IReadOnlyList<SAB>>>(() => this.ToGroupedNullDictionary(i => i.FEE_CODE_2ND));
            Index_FEE_CODE_3RD = new Lazy<NullDictionary<string, IReadOnlyList<SAB>>>(() => this.ToGroupedNullDictionary(i => i.FEE_CODE_3RD));
            Index_FEE_CODE_4TH = new Lazy<NullDictionary<string, IReadOnlyList<SAB>>>(() => this.ToGroupedNullDictionary(i => i.FEE_CODE_4TH));
            Index_FEE_CODE_KG = new Lazy<NullDictionary<string, IReadOnlyList<SAB>>>(() => this.ToGroupedNullDictionary(i => i.FEE_CODE_KG));
            Index_SABKEY = new Lazy<Dictionary<string, SAB>>(() => this.ToDictionary(i => i.SABKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SAB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SAB" /> fields for each CSV column header</returns>
        protected override Action<SAB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SAB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SABKEY":
                        mapper[i] = (e, v) => e.SABKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "BILL_TYPE":
                        mapper[i] = (e, v) => e.BILL_TYPE = v;
                        break;
                    case "FROM_CLASS":
                        mapper[i] = (e, v) => e.FROM_CLASS = v;
                        break;
                    case "TO_CLASS":
                        mapper[i] = (e, v) => e.TO_CLASS = v;
                        break;
                    case "FROM_YEAR":
                        mapper[i] = (e, v) => e.FROM_YEAR = v;
                        break;
                    case "TO_YEAR":
                        mapper[i] = (e, v) => e.TO_YEAR = v;
                        break;
                    case "RES_STATUS":
                        mapper[i] = (e, v) => e.RES_STATUS = v;
                        break;
                    case "FEE_CODE_1ST":
                        mapper[i] = (e, v) => e.FEE_CODE_1ST = v;
                        break;
                    case "FEE_CODE_2ND":
                        mapper[i] = (e, v) => e.FEE_CODE_2ND = v;
                        break;
                    case "FEE_CODE_3RD":
                        mapper[i] = (e, v) => e.FEE_CODE_3RD = v;
                        break;
                    case "FEE_CODE_4TH":
                        mapper[i] = (e, v) => e.FEE_CODE_4TH = v;
                        break;
                    case "FEE_CODE_KG":
                        mapper[i] = (e, v) => e.FEE_CODE_KG = v;
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
        /// Merges <see cref="SAB" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SAB" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SAB" /> items to added or update the base <see cref="SAB" /> items</param>
        /// <returns>A merged list of <see cref="SAB" /> items</returns>
        protected override List<SAB> ApplyDeltaItems(List<SAB> Items, List<SAB> DeltaItems)
        {
            Dictionary<string, int> Index_SABKEY = Items.ToIndexDictionary(i => i.SABKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SAB deltaItem in DeltaItems)
            {
                int index;

                if (Index_SABKEY.TryGetValue(deltaItem.SABKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SABKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<SAB>>> Index_FEE_CODE_1ST;
        private Lazy<NullDictionary<string, IReadOnlyList<SAB>>> Index_FEE_CODE_2ND;
        private Lazy<NullDictionary<string, IReadOnlyList<SAB>>> Index_FEE_CODE_3RD;
        private Lazy<NullDictionary<string, IReadOnlyList<SAB>>> Index_FEE_CODE_4TH;
        private Lazy<NullDictionary<string, IReadOnlyList<SAB>>> Index_FEE_CODE_KG;
        private Lazy<Dictionary<string, SAB>> Index_SABKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SAB by FEE_CODE_1ST field
        /// </summary>
        /// <param name="FEE_CODE_1ST">FEE_CODE_1ST value used to find SAB</param>
        /// <returns>List of related SAB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> FindByFEE_CODE_1ST(string FEE_CODE_1ST)
        {
            return Index_FEE_CODE_1ST.Value[FEE_CODE_1ST];
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_1ST field
        /// </summary>
        /// <param name="FEE_CODE_1ST">FEE_CODE_1ST value used to find SAB</param>
        /// <param name="Value">List of related SAB entities</param>
        /// <returns>True if the list of related SAB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFEE_CODE_1ST(string FEE_CODE_1ST, out IReadOnlyList<SAB> Value)
        {
            return Index_FEE_CODE_1ST.Value.TryGetValue(FEE_CODE_1ST, out Value);
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_1ST field
        /// </summary>
        /// <param name="FEE_CODE_1ST">FEE_CODE_1ST value used to find SAB</param>
        /// <returns>List of related SAB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> TryFindByFEE_CODE_1ST(string FEE_CODE_1ST)
        {
            IReadOnlyList<SAB> value;
            if (Index_FEE_CODE_1ST.Value.TryGetValue(FEE_CODE_1ST, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAB by FEE_CODE_2ND field
        /// </summary>
        /// <param name="FEE_CODE_2ND">FEE_CODE_2ND value used to find SAB</param>
        /// <returns>List of related SAB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> FindByFEE_CODE_2ND(string FEE_CODE_2ND)
        {
            return Index_FEE_CODE_2ND.Value[FEE_CODE_2ND];
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_2ND field
        /// </summary>
        /// <param name="FEE_CODE_2ND">FEE_CODE_2ND value used to find SAB</param>
        /// <param name="Value">List of related SAB entities</param>
        /// <returns>True if the list of related SAB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFEE_CODE_2ND(string FEE_CODE_2ND, out IReadOnlyList<SAB> Value)
        {
            return Index_FEE_CODE_2ND.Value.TryGetValue(FEE_CODE_2ND, out Value);
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_2ND field
        /// </summary>
        /// <param name="FEE_CODE_2ND">FEE_CODE_2ND value used to find SAB</param>
        /// <returns>List of related SAB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> TryFindByFEE_CODE_2ND(string FEE_CODE_2ND)
        {
            IReadOnlyList<SAB> value;
            if (Index_FEE_CODE_2ND.Value.TryGetValue(FEE_CODE_2ND, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAB by FEE_CODE_3RD field
        /// </summary>
        /// <param name="FEE_CODE_3RD">FEE_CODE_3RD value used to find SAB</param>
        /// <returns>List of related SAB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> FindByFEE_CODE_3RD(string FEE_CODE_3RD)
        {
            return Index_FEE_CODE_3RD.Value[FEE_CODE_3RD];
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_3RD field
        /// </summary>
        /// <param name="FEE_CODE_3RD">FEE_CODE_3RD value used to find SAB</param>
        /// <param name="Value">List of related SAB entities</param>
        /// <returns>True if the list of related SAB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFEE_CODE_3RD(string FEE_CODE_3RD, out IReadOnlyList<SAB> Value)
        {
            return Index_FEE_CODE_3RD.Value.TryGetValue(FEE_CODE_3RD, out Value);
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_3RD field
        /// </summary>
        /// <param name="FEE_CODE_3RD">FEE_CODE_3RD value used to find SAB</param>
        /// <returns>List of related SAB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> TryFindByFEE_CODE_3RD(string FEE_CODE_3RD)
        {
            IReadOnlyList<SAB> value;
            if (Index_FEE_CODE_3RD.Value.TryGetValue(FEE_CODE_3RD, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAB by FEE_CODE_4TH field
        /// </summary>
        /// <param name="FEE_CODE_4TH">FEE_CODE_4TH value used to find SAB</param>
        /// <returns>List of related SAB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> FindByFEE_CODE_4TH(string FEE_CODE_4TH)
        {
            return Index_FEE_CODE_4TH.Value[FEE_CODE_4TH];
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_4TH field
        /// </summary>
        /// <param name="FEE_CODE_4TH">FEE_CODE_4TH value used to find SAB</param>
        /// <param name="Value">List of related SAB entities</param>
        /// <returns>True if the list of related SAB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFEE_CODE_4TH(string FEE_CODE_4TH, out IReadOnlyList<SAB> Value)
        {
            return Index_FEE_CODE_4TH.Value.TryGetValue(FEE_CODE_4TH, out Value);
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_4TH field
        /// </summary>
        /// <param name="FEE_CODE_4TH">FEE_CODE_4TH value used to find SAB</param>
        /// <returns>List of related SAB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> TryFindByFEE_CODE_4TH(string FEE_CODE_4TH)
        {
            IReadOnlyList<SAB> value;
            if (Index_FEE_CODE_4TH.Value.TryGetValue(FEE_CODE_4TH, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAB by FEE_CODE_KG field
        /// </summary>
        /// <param name="FEE_CODE_KG">FEE_CODE_KG value used to find SAB</param>
        /// <returns>List of related SAB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> FindByFEE_CODE_KG(string FEE_CODE_KG)
        {
            return Index_FEE_CODE_KG.Value[FEE_CODE_KG];
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_KG field
        /// </summary>
        /// <param name="FEE_CODE_KG">FEE_CODE_KG value used to find SAB</param>
        /// <param name="Value">List of related SAB entities</param>
        /// <returns>True if the list of related SAB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFEE_CODE_KG(string FEE_CODE_KG, out IReadOnlyList<SAB> Value)
        {
            return Index_FEE_CODE_KG.Value.TryGetValue(FEE_CODE_KG, out Value);
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_KG field
        /// </summary>
        /// <param name="FEE_CODE_KG">FEE_CODE_KG value used to find SAB</param>
        /// <returns>List of related SAB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> TryFindByFEE_CODE_KG(string FEE_CODE_KG)
        {
            IReadOnlyList<SAB> value;
            if (Index_FEE_CODE_KG.Value.TryGetValue(FEE_CODE_KG, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAB by SABKEY field
        /// </summary>
        /// <param name="SABKEY">SABKEY value used to find SAB</param>
        /// <returns>Related SAB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAB FindBySABKEY(string SABKEY)
        {
            return Index_SABKEY.Value[SABKEY];
        }

        /// <summary>
        /// Attempt to find SAB by SABKEY field
        /// </summary>
        /// <param name="SABKEY">SABKEY value used to find SAB</param>
        /// <param name="Value">Related SAB entity</param>
        /// <returns>True if the related SAB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySABKEY(string SABKEY, out SAB Value)
        {
            return Index_SABKEY.Value.TryGetValue(SABKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SAB by SABKEY field
        /// </summary>
        /// <param name="SABKEY">SABKEY value used to find SAB</param>
        /// <returns>Related SAB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAB TryFindBySABKEY(string SABKEY)
        {
            SAB value;
            if (Index_SABKEY.Value.TryGetValue(SABKEY, out value))
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
