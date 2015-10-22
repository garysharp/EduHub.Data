using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Delivery Addresses Data Set
    /// </summary>
    public sealed partial class KADDataSet : SetBase<KAD>
    {
        private Lazy<Dictionary<string, KAD>> KADKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<CRF>>> CRF_DEL_CODEForeignIndex;

        internal KADDataSet(EduHubContext Context)
            : base(Context)
        {
            KADKEYIndex = new Lazy<Dictionary<string, KAD>>(() => this.ToDictionary(e => e.KADKEY));

            CRF_DEL_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<CRF>>>(() =>
                    Context.CRF
                          .Where(e => e.DEL_CODE != null)
                          .GroupBy(e => e.DEL_CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<CRF>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KAD"; } }

        /// <summary>
        /// Find KAD by KADKEY key field
        /// </summary>
        /// <param name="Key">KADKEY value used to find KAD</param>
        /// <returns>Related KAD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KADKEY value didn't match any KAD entities</exception>
        public KAD FindByKADKEY(string Key)
        {
            KAD result;
            if (KADKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KAD by KADKEY key field
        /// </summary>
        /// <param name="Key">KADKEY value used to find KAD</param>
        /// <param name="Value">Related KAD entity</param>
        /// <returns>True if the KAD entity is found</returns>
        public bool TryFindByKADKEY(string Key, out KAD Value)
        {
            return KADKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KAD by KADKEY key field
        /// </summary>
        /// <param name="Key">KADKEY value used to find KAD</param>
        /// <returns>Related KAD entity, or null if not found</returns>
        public KAD TryFindByKADKEY(string Key)
        {
            KAD result;
            if (KADKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all CRF (Creditor Financial Transaction) entities by [CRF.DEL_CODE]-&gt;[KAD.KADKEY]
        /// </summary>
        /// <param name="KADKEY">KADKEY value used to find CRF entities</param>
        /// <returns>A list of related CRF entities</returns>
        public IReadOnlyList<CRF> FindCRFByDEL_CODE(string KADKEY)
        {
            IReadOnlyList<CRF> result;
            if (CRF_DEL_CODEForeignIndex.Value.TryGetValue(KADKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<CRF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all CRF entities by [CRF.DEL_CODE]-&gt;[KAD.KADKEY]
        /// </summary>
        /// <param name="KADKEY">KADKEY value used to find CRF entities</param>
        /// <param name="Value">A list of related CRF entities</param>
        /// <returns>True if any CRF entities are found</returns>
        public bool TryFindCRFByDEL_CODE(string KADKEY, out IReadOnlyList<CRF> Value)
        {
            return CRF_DEL_CODEForeignIndex.Value.TryGetValue(KADKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KAD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KAD" /> fields for each CSV column header</returns>
        protected override Action<KAD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KAD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KADKEY":
                        mapper[i] = (e, v) => e.KADKEY = v;
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
