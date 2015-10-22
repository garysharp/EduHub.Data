using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Departments Data Set
    /// </summary>
    public sealed partial class PDDataSet : SetBase<PD>
    {
        private Lazy<Dictionary<string, PD>> PDKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<PE>>> PE_DEPARTMENTForeignIndex;

        internal PDDataSet(EduHubContext Context)
            : base(Context)
        {
            PDKEYIndex = new Lazy<Dictionary<string, PD>>(() => this.ToDictionary(e => e.PDKEY));

            PE_DEPARTMENTForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PE>>>(() =>
                    Context.PE
                          .Where(e => e.DEPARTMENT != null)
                          .GroupBy(e => e.DEPARTMENT)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PE>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PD"; } }

        /// <summary>
        /// Find PD by PDKEY key field
        /// </summary>
        /// <param name="Key">PDKEY value used to find PD</param>
        /// <returns>Related PD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">PDKEY value didn't match any PD entities</exception>
        public PD FindByPDKEY(string Key)
        {
            PD result;
            if (PDKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find PD by PDKEY key field
        /// </summary>
        /// <param name="Key">PDKEY value used to find PD</param>
        /// <param name="Value">Related PD entity</param>
        /// <returns>True if the PD entity is found</returns>
        public bool TryFindByPDKEY(string Key, out PD Value)
        {
            return PDKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find PD by PDKEY key field
        /// </summary>
        /// <param name="Key">PDKEY value used to find PD</param>
        /// <returns>Related PD entity, or null if not found</returns>
        public PD TryFindByPDKEY(string Key)
        {
            PD result;
            if (PDKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all PE (Employees) entities by [PE.DEPARTMENT]-&gt;[PD.PDKEY]
        /// </summary>
        /// <param name="PDKEY">PDKEY value used to find PE entities</param>
        /// <returns>A list of related PE entities</returns>
        public IReadOnlyList<PE> FindPEByDEPARTMENT(string PDKEY)
        {
            IReadOnlyList<PE> result;
            if (PE_DEPARTMENTForeignIndex.Value.TryGetValue(PDKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PE entities by [PE.DEPARTMENT]-&gt;[PD.PDKEY]
        /// </summary>
        /// <param name="PDKEY">PDKEY value used to find PE entities</param>
        /// <param name="Value">A list of related PE entities</param>
        /// <returns>True if any PE entities are found</returns>
        public bool TryFindPEByDEPARTMENT(string PDKEY, out IReadOnlyList<PE> Value)
        {
            return PE_DEPARTMENTForeignIndex.Value.TryGetValue(PDKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PD" /> fields for each CSV column header</returns>
        protected override Action<PD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PDKEY":
                        mapper[i] = (e, v) => e.PDKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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
    }
}
