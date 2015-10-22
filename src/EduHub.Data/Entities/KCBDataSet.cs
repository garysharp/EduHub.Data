using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Behaviour Classifications Data Set
    /// </summary>
    public sealed partial class KCBDataSet : SetBase<KCB>
    {
        private Lazy<Dictionary<string, KCB>> KCBKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<SID>>> SID_INCIDENT_TYPEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STMB>>> STMB_B_CODEForeignIndex;

        internal KCBDataSet(EduHubContext Context)
            : base(Context)
        {
            KCBKEYIndex = new Lazy<Dictionary<string, KCB>>(() => this.ToDictionary(e => e.KCBKEY));

            SID_INCIDENT_TYPEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SID>>>(() =>
                    Context.SID
                          .Where(e => e.INCIDENT_TYPE != null)
                          .GroupBy(e => e.INCIDENT_TYPE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SID>)g.ToList()
                          .AsReadOnly()));

            STMB_B_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STMB>>>(() =>
                    Context.STMB
                          .Where(e => e.B_CODE != null)
                          .GroupBy(e => e.B_CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STMB>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCB"; } }

        /// <summary>
        /// Find KCB by KCBKEY key field
        /// </summary>
        /// <param name="Key">KCBKEY value used to find KCB</param>
        /// <returns>Related KCB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KCBKEY value didn't match any KCB entities</exception>
        public KCB FindByKCBKEY(string Key)
        {
            KCB result;
            if (KCBKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KCB by KCBKEY key field
        /// </summary>
        /// <param name="Key">KCBKEY value used to find KCB</param>
        /// <param name="Value">Related KCB entity</param>
        /// <returns>True if the KCB entity is found</returns>
        public bool TryFindByKCBKEY(string Key, out KCB Value)
        {
            return KCBKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KCB by KCBKEY key field
        /// </summary>
        /// <param name="Key">KCBKEY value used to find KCB</param>
        /// <returns>Related KCB entity, or null if not found</returns>
        public KCB TryFindByKCBKEY(string Key)
        {
            KCB result;
            if (KCBKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all SID (Disciplinary Incidents) entities by [SID.INCIDENT_TYPE]-&gt;[KCB.KCBKEY]
        /// </summary>
        /// <param name="KCBKEY">KCBKEY value used to find SID entities</param>
        /// <returns>A list of related SID entities</returns>
        public IReadOnlyList<SID> FindSIDByINCIDENT_TYPE(string KCBKEY)
        {
            IReadOnlyList<SID> result;
            if (SID_INCIDENT_TYPEForeignIndex.Value.TryGetValue(KCBKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SID>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SID entities by [SID.INCIDENT_TYPE]-&gt;[KCB.KCBKEY]
        /// </summary>
        /// <param name="KCBKEY">KCBKEY value used to find SID entities</param>
        /// <param name="Value">A list of related SID entities</param>
        /// <returns>True if any SID entities are found</returns>
        public bool TryFindSIDByINCIDENT_TYPE(string KCBKEY, out IReadOnlyList<SID> Value)
        {
            return SID_INCIDENT_TYPEForeignIndex.Value.TryGetValue(KCBKEY, out Value);
        }

        /// <summary>
        /// Find all STMB (Student Merit Behaviour Details) entities by [STMB.B_CODE]-&gt;[KCB.KCBKEY]
        /// </summary>
        /// <param name="KCBKEY">KCBKEY value used to find STMB entities</param>
        /// <returns>A list of related STMB entities</returns>
        public IReadOnlyList<STMB> FindSTMBByB_CODE(string KCBKEY)
        {
            IReadOnlyList<STMB> result;
            if (STMB_B_CODEForeignIndex.Value.TryGetValue(KCBKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STMB>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STMB entities by [STMB.B_CODE]-&gt;[KCB.KCBKEY]
        /// </summary>
        /// <param name="KCBKEY">KCBKEY value used to find STMB entities</param>
        /// <param name="Value">A list of related STMB entities</param>
        /// <returns>True if any STMB entities are found</returns>
        public bool TryFindSTMBByB_CODE(string KCBKEY, out IReadOnlyList<STMB> Value)
        {
            return STMB_B_CODEForeignIndex.Value.TryGetValue(KCBKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCB" /> fields for each CSV column header</returns>
        protected override Action<KCB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCBKEY":
                        mapper[i] = (e, v) => e.KCBKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "POS_NEG":
                        mapper[i] = (e, v) => e.POS_NEG = v;
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
