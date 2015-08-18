using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Rooms Data Set
    /// </summary>
    public sealed class SMDataSet : SetBase<SM>
    {
        private Lazy<Dictionary<string, SM>> ROOMIndex;

        internal SMDataSet(EduHubContext Context)
            : base(Context)
        {
            ROOMIndex = new Lazy<Dictionary<string, SM>>(() => this.ToDictionary(e => e.ROOM));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SM"; } }

        /// <summary>
        /// Find SM by ROOM key field
        /// </summary>
        /// <param name="Key">ROOM value used to find SM</param>
        /// <returns>Related SM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ROOM value didn't match any SM entities</exception>
        public SM FindByROOM(string Key)
        {
            SM result;
            if (ROOMIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SM by ROOM key field
        /// </summary>
        /// <param name="Key">ROOM value used to find SM</param>
        /// <param name="Value">Related SM entity</param>
        /// <returns>True if the SM Entity is found</returns>
        public bool TryFindByROOM(string Key, out SM Value)
        {
            return ROOMIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SM by ROOM key field
        /// </summary>
        /// <param name="Key">ROOM value used to find SM</param>
        /// <returns>Related SM entity, or null if not found</returns>
        public SM TryFindByROOM(string Key)
        {
            SM result;
            if (ROOMIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SM, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "SEATING":
                        mapper[i] = (e, v) => e.SEATING = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ROOM_TYPE":
                        mapper[i] = (e, v) => e.ROOM_TYPE = v;
                        break;
                    case "FACULTY":
                        mapper[i] = (e, v) => e.FACULTY = v;
                        break;
                    case "AREA_CODE":
                        mapper[i] = (e, v) => e.AREA_CODE = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "STAFF_CODE":
                        mapper[i] = (e, v) => e.STAFF_CODE = v;
                        break;
                    case "COMMENTA":
                        mapper[i] = (e, v) => e.COMMENTA = v;
                        break;
                    case "BOARD":
                        mapper[i] = (e, v) => e.BOARD = v;
                        break;
                    case "BLACKOUT":
                        mapper[i] = (e, v) => e.BLACKOUT = v;
                        break;
                    case "NORMAL_ALLOTMENT":
                        mapper[i] = (e, v) => e.NORMAL_ALLOTMENT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "GROUP_INDICATOR":
                        mapper[i] = (e, v) => e.GROUP_INDICATOR = v;
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
