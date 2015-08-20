using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Contacts Data Set
    /// </summary>
    public sealed class KPCDataSet : SetBase<KPC>
    {
        private Lazy<Dictionary<string, KPC>> KPCKEYIndex;

        internal KPCDataSet(EduHubContext Context)
            : base(Context)
        {
            KPCKEYIndex = new Lazy<Dictionary<string, KPC>>(() => this.ToDictionary(e => e.KPCKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KPC"; } }

        /// <summary>
        /// Find KPC by KPCKEY key field
        /// </summary>
        /// <param name="Key">KPCKEY value used to find KPC</param>
        /// <returns>Related KPC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KPCKEY value didn't match any KPC entities</exception>
        public KPC FindByKPCKEY(string Key)
        {
            KPC result;
            if (KPCKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KPC by KPCKEY key field
        /// </summary>
        /// <param name="Key">KPCKEY value used to find KPC</param>
        /// <param name="Value">Related KPC entity</param>
        /// <returns>True if the KPC entity is found</returns>
        public bool TryFindByKPCKEY(string Key, out KPC Value)
        {
            return KPCKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KPC by KPCKEY key field
        /// </summary>
        /// <param name="Key">KPCKEY value used to find KPC</param>
        /// <returns>Related KPC entity, or null if not found</returns>
        public KPC TryFindByKPCKEY(string Key)
        {
            KPC result;
            if (KPCKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KPC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KPC" /> fields for each CSV column header</returns>
        protected override Action<KPC, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KPC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KPCKEY":
                        mapper[i] = (e, v) => e.KPCKEY = v;
                        break;
                    case "SURNAME":
                        mapper[i] = (e, v) => e.SURNAME = v;
                        break;
                    case "FIRST_NAME":
                        mapper[i] = (e, v) => e.FIRST_NAME = v;
                        break;
                    case "SECOND_NAME":
                        mapper[i] = (e, v) => e.SECOND_NAME = v;
                        break;
                    case "GENDER":
                        mapper[i] = (e, v) => e.GENDER = v;
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
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POST":
                        mapper[i] = (e, v) => e.POST = v;
                        break;
                    case "BUS_PHONE":
                        mapper[i] = (e, v) => e.BUS_PHONE = v;
                        break;
                    case "HOME_PHONE":
                        mapper[i] = (e, v) => e.HOME_PHONE = v;
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "EMAIL":
                        mapper[i] = (e, v) => e.EMAIL = v;
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
