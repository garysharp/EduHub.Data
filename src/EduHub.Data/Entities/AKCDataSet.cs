using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Categories Data Set
    /// </summary>
    public sealed class AKCDataSet : SetBase<AKC>
    {
        private Lazy<Dictionary<string, AKC>> CATEGORYIndex;

        internal AKCDataSet(EduHubContext Context)
            : base(Context)
        {
            CATEGORYIndex = new Lazy<Dictionary<string, AKC>>(() => this.ToDictionary(e => e.CATEGORY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "AKC"; } }

        /// <summary>
        /// Find AKC by CATEGORY key field
        /// </summary>
        /// <param name="Key">CATEGORY value used to find AKC</param>
        /// <returns>Related AKC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">CATEGORY value didn't match any AKC entities</exception>
        public AKC FindByCATEGORY(string Key)
        {
            AKC result;
            if (CATEGORYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find AKC by CATEGORY key field
        /// </summary>
        /// <param name="Key">CATEGORY value used to find AKC</param>
        /// <param name="Value">Related AKC entity</param>
        /// <returns>True if the AKC entity is found</returns>
        public bool TryFindByCATEGORY(string Key, out AKC Value)
        {
            return CATEGORYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find AKC by CATEGORY key field
        /// </summary>
        /// <param name="Key">CATEGORY value used to find AKC</param>
        /// <returns>Related AKC entity, or null if not found</returns>
        public AKC TryFindByCATEGORY(string Key)
        {
            AKC result;
            if (CATEGORYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AKC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AKC" /> fields for each CSV column header</returns>
        protected override Action<AKC, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<AKC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "GLCODE_ASS":
                        mapper[i] = (e, v) => e.GLCODE_ASS = v;
                        break;
                    case "GLCODE_PRV":
                        mapper[i] = (e, v) => e.GLCODE_PRV = v;
                        break;
                    case "GLCODE_EXP":
                        mapper[i] = (e, v) => e.GLCODE_EXP = v;
                        break;
                    case "GL_REVALS_BS":
                        mapper[i] = (e, v) => e.GL_REVALS_BS = v;
                        break;
                    case "GL_REVALS_PL":
                        mapper[i] = (e, v) => e.GL_REVALS_PL = v;
                        break;
                    case "GL_REVALS_ASS":
                        mapper[i] = (e, v) => e.GL_REVALS_ASS = v;
                        break;
                    case "GL_DISP_PROF":
                        mapper[i] = (e, v) => e.GL_DISP_PROF = v;
                        break;
                    case "GL_DISP_PROC":
                        mapper[i] = (e, v) => e.GL_DISP_PROC = v;
                        break;
                    case "APTE_GLCODE":
                        mapper[i] = (e, v) => e.APTE_GLCODE = v;
                        break;
                    case "PTE_USE_RATE":
                        mapper[i] = (e, v) => e.PTE_USE_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "DEPN_AMETHOD":
                        mapper[i] = (e, v) => e.DEPN_AMETHOD = v;
                        break;
                    case "DEPN_TMETHOD":
                        mapper[i] = (e, v) => e.DEPN_TMETHOD = v;
                        break;
                    case "DEPN_ARATE":
                        mapper[i] = (e, v) => e.DEPN_ARATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "APTE_USE_RATE":
                        mapper[i] = (e, v) => e.APTE_USE_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "DEPN_TRATE":
                        mapper[i] = (e, v) => e.DEPN_TRATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TPTE_USE_RATE":
                        mapper[i] = (e, v) => e.TPTE_USE_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "EXPECTED_LIFE":
                        mapper[i] = (e, v) => e.EXPECTED_LIFE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SEND_TO_FLAG":
                        mapper[i] = (e, v) => e.SEND_TO_FLAG = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "MAP_CATEGORY":
                        mapper[i] = (e, v) => e.MAP_CATEGORY = v;
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
