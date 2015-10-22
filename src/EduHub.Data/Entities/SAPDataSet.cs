using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Association Positions Data Set
    /// </summary>
    public sealed partial class SAPDataSet : SetBase<SAP>
    {
        private Lazy<Dictionary<string, SAP>> SAPKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<SAM>>> SAM_ASSOC_POSNForeignIndex;

        internal SAPDataSet(EduHubContext Context)
            : base(Context)
        {
            SAPKEYIndex = new Lazy<Dictionary<string, SAP>>(() => this.ToDictionary(e => e.SAPKEY));

            SAM_ASSOC_POSNForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SAM>>>(() =>
                    Context.SAM
                          .Where(e => e.ASSOC_POSN != null)
                          .GroupBy(e => e.ASSOC_POSN)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SAM>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SAP"; } }

        /// <summary>
        /// Find SAP by SAPKEY key field
        /// </summary>
        /// <param name="Key">SAPKEY value used to find SAP</param>
        /// <returns>Related SAP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SAPKEY value didn't match any SAP entities</exception>
        public SAP FindBySAPKEY(string Key)
        {
            SAP result;
            if (SAPKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SAP by SAPKEY key field
        /// </summary>
        /// <param name="Key">SAPKEY value used to find SAP</param>
        /// <param name="Value">Related SAP entity</param>
        /// <returns>True if the SAP entity is found</returns>
        public bool TryFindBySAPKEY(string Key, out SAP Value)
        {
            return SAPKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SAP by SAPKEY key field
        /// </summary>
        /// <param name="Key">SAPKEY value used to find SAP</param>
        /// <returns>Related SAP entity, or null if not found</returns>
        public SAP TryFindBySAPKEY(string Key)
        {
            SAP result;
            if (SAPKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all SAM (School Association Members) entities by [SAM.ASSOC_POSN]-&gt;[SAP.SAPKEY]
        /// </summary>
        /// <param name="SAPKEY">SAPKEY value used to find SAM entities</param>
        /// <returns>A list of related SAM entities</returns>
        public IReadOnlyList<SAM> FindSAMByASSOC_POSN(string SAPKEY)
        {
            IReadOnlyList<SAM> result;
            if (SAM_ASSOC_POSNForeignIndex.Value.TryGetValue(SAPKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SAM>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SAM entities by [SAM.ASSOC_POSN]-&gt;[SAP.SAPKEY]
        /// </summary>
        /// <param name="SAPKEY">SAPKEY value used to find SAM entities</param>
        /// <param name="Value">A list of related SAM entities</param>
        /// <returns>True if any SAM entities are found</returns>
        public bool TryFindSAMByASSOC_POSN(string SAPKEY, out IReadOnlyList<SAM> Value)
        {
            return SAM_ASSOC_POSNForeignIndex.Value.TryGetValue(SAPKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SAP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SAP" /> fields for each CSV column header</returns>
        protected override Action<SAP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SAP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SAPKEY":
                        mapper[i] = (e, v) => e.SAPKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "SORT_CODE":
                        mapper[i] = (e, v) => e.SORT_CODE = v == null ? (short?)null : short.Parse(v);
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
