using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Australian Postcodes Data Set
    /// </summary>
    public sealed class KAP_DataSet : SetBase<KAP_Entity>
    {
        internal KAP_DataSet(EduHubContext Context)
            : base(Context)
        {
            KAPKEY_Index = new Lazy<Dictionary<string, KAP_Entity>>(() => this.ToDictionary(e => e.KAPKEY));
            PLACE_NAME_Index = new Lazy<Dictionary<string, KAP_Entity>>(() => this.ToDictionary(e => e.PLACE_NAME));
        }

        public override string SetName { get { return "KAP"; } }

        private Lazy<Dictionary<string, KAP_Entity>> KAPKEY_Index;
        private Lazy<Dictionary<string, KAP_Entity>> PLACE_NAME_Index;

        public KAP_Entity FindByKAPKEY(string Key)
        {
            KAP_Entity result;
            if (KAPKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByKAPKEY(string Key, out KAP_Entity Value)
        {
            return KAPKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public KAP_Entity TryFindByKAPKEY(string Key)
        {
            KAP_Entity result;
            if (KAPKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        public KAP_Entity FindByPLACE_NAME(string Key)
        {
            KAP_Entity result;
            if (PLACE_NAME_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByPLACE_NAME(string Key, out KAP_Entity Value)
        {
            return PLACE_NAME_Index.Value.TryGetValue(Key, out Value);
        }
        public KAP_Entity TryFindByPLACE_NAME(string Key)
        {
            KAP_Entity result;
            if (PLACE_NAME_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KAP_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KAP_Entity, string>[Headers.Count];

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
