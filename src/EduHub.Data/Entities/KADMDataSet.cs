using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Depreciation Methods Data Set
    /// </summary>
    public sealed class KADMDataSet : SetBase<KADM>
    {
        private Lazy<Dictionary<string, KADM>> KADMKEYIndex;

        internal KADMDataSet(EduHubContext Context)
            : base(Context)
        {
            KADMKEYIndex = new Lazy<Dictionary<string, KADM>>(() => this.ToDictionary(e => e.KADMKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KADM"; } }

        /// <summary>
        /// Find KADM by KADMKEY key field
        /// </summary>
        /// <param name="Key">KADMKEY value used to find KADM</param>
        /// <returns>Related KADM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KADMKEY value didn't match any KADM entities</exception>
        public KADM FindByKADMKEY(string Key)
        {
            KADM result;
            if (KADMKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KADM by KADMKEY key field
        /// </summary>
        /// <param name="Key">KADMKEY value used to find KADM</param>
        /// <param name="Value">Related KADM entity</param>
        /// <returns>True if the KADM entity is found</returns>
        public bool TryFindByKADMKEY(string Key, out KADM Value)
        {
            return KADMKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KADM by KADMKEY key field
        /// </summary>
        /// <param name="Key">KADMKEY value used to find KADM</param>
        /// <returns>Related KADM entity, or null if not found</returns>
        public KADM TryFindByKADMKEY(string Key)
        {
            KADM result;
            if (KADMKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KADM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KADM" /> fields for each CSV column header</returns>
        protected override Action<KADM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KADM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KADMKEY":
                        mapper[i] = (e, v) => e.KADMKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "DETAIL":
                        mapper[i] = (e, v) => e.DETAIL = v;
                        break;
                    case "DATE_BASED":
                        mapper[i] = (e, v) => e.DATE_BASED = v;
                        break;
                    case "TAX":
                        mapper[i] = (e, v) => e.TAX = v;
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
