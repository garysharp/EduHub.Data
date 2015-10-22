using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Australian Postcodes Data Set
    /// </summary>
    public sealed partial class KAPDataSet : SetBase<KAP>
    {
        private Lazy<Dictionary<string, KAP>> KAPKEYIndex;
        private Lazy<Dictionary<string, KAP>> PLACE_NAMEIndex;


        internal KAPDataSet(EduHubContext Context)
            : base(Context)
        {
            KAPKEYIndex = new Lazy<Dictionary<string, KAP>>(() => this.ToDictionary(e => e.KAPKEY));
            PLACE_NAMEIndex = new Lazy<Dictionary<string, KAP>>(() => this.ToDictionary(e => e.PLACE_NAME));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KAP"; } }

        /// <summary>
        /// Find KAP by KAPKEY key field
        /// </summary>
        /// <param name="Key">KAPKEY value used to find KAP</param>
        /// <returns>Related KAP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KAPKEY value didn't match any KAP entities</exception>
        public KAP FindByKAPKEY(string Key)
        {
            KAP result;
            if (KAPKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KAP by KAPKEY key field
        /// </summary>
        /// <param name="Key">KAPKEY value used to find KAP</param>
        /// <param name="Value">Related KAP entity</param>
        /// <returns>True if the KAP entity is found</returns>
        public bool TryFindByKAPKEY(string Key, out KAP Value)
        {
            return KAPKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KAP by KAPKEY key field
        /// </summary>
        /// <param name="Key">KAPKEY value used to find KAP</param>
        /// <returns>Related KAP entity, or null if not found</returns>
        public KAP TryFindByKAPKEY(string Key)
        {
            KAP result;
            if (KAPKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KAP by PLACE_NAME key field
        /// </summary>
        /// <param name="Key">PLACE_NAME value used to find KAP</param>
        /// <returns>Related KAP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">PLACE_NAME value didn't match any KAP entities</exception>
        public KAP FindByPLACE_NAME(string Key)
        {
            KAP result;
            if (PLACE_NAMEIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KAP by PLACE_NAME key field
        /// </summary>
        /// <param name="Key">PLACE_NAME value used to find KAP</param>
        /// <param name="Value">Related KAP entity</param>
        /// <returns>True if the KAP entity is found</returns>
        public bool TryFindByPLACE_NAME(string Key, out KAP Value)
        {
            return PLACE_NAMEIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KAP by PLACE_NAME key field
        /// </summary>
        /// <param name="Key">PLACE_NAME value used to find KAP</param>
        /// <returns>Related KAP entity, or null if not found</returns>
        public KAP TryFindByPLACE_NAME(string Key)
        {
            KAP result;
            if (PLACE_NAMEIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KAP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KAP" /> fields for each CSV column header</returns>
        protected override Action<KAP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KAP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KAPKEY":
                        mapper[i] = (e, v) => e.KAPKEY = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "PLACE_NAME":
                        mapper[i] = (e, v) => e.PLACE_NAME = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "DISCRIMINATOR":
                        mapper[i] = (e, v) => e.DISCRIMINATOR = v;
                        break;
                    case "STREET_ADD":
                        mapper[i] = (e, v) => e.STREET_ADD = v;
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
