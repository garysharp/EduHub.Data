using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accidents Data Set
    /// </summary>
    public sealed class SADDataSet : SetBase<SAD>
    {
        private Lazy<Dictionary<int, SAD>> SADKEYIndex;

        internal SADDataSet(EduHubContext Context)
            : base(Context)
        {
            SADKEYIndex = new Lazy<Dictionary<int, SAD>>(() => this.ToDictionary(e => e.SADKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SAD"; } }

        /// <summary>
        /// Find SAD by SADKEY key field
        /// </summary>
        /// <param name="Key">SADKEY value used to find SAD</param>
        /// <returns>Related SAD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SADKEY value didn't match any SAD entities</exception>
        public SAD FindBySADKEY(int Key)
        {
            SAD result;
            if (SADKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SAD by SADKEY key field
        /// </summary>
        /// <param name="Key">SADKEY value used to find SAD</param>
        /// <param name="Value">Related SAD entity</param>
        /// <returns>True if the SAD entity is found</returns>
        public bool TryFindBySADKEY(int Key, out SAD Value)
        {
            return SADKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SAD by SADKEY key field
        /// </summary>
        /// <param name="Key">SADKEY value used to find SAD</param>
        /// <returns>Related SAD entity, or null if not found</returns>
        public SAD TryFindBySADKEY(int Key)
        {
            SAD result;
            if (SADKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SAD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SAD" /> fields for each CSV column header</returns>
        protected override Action<SAD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SAD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SADKEY":
                        mapper[i] = (e, v) => e.SADKEY = int.Parse(v);
                        break;
                    case "DETAIL_OUTLINE":
                        mapper[i] = (e, v) => e.DETAIL_OUTLINE = v;
                        break;
                    case "ACCIDENT_DATE":
                        mapper[i] = (e, v) => e.ACCIDENT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ACCIDENT_TIME":
                        mapper[i] = (e, v) => e.ACCIDENT_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "GENERAL_ACTIVITY":
                        mapper[i] = (e, v) => e.GENERAL_ACTIVITY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DETAILED_ACTIVITY":
                        mapper[i] = (e, v) => e.DETAILED_ACTIVITY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OTHER_ACTIVITY_INFO":
                        mapper[i] = (e, v) => e.OTHER_ACTIVITY_INFO = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OTHER_DESC_INFO":
                        mapper[i] = (e, v) => e.OTHER_DESC_INFO = v;
                        break;
                    case "ACCIDENT_SITE":
                        mapper[i] = (e, v) => e.ACCIDENT_SITE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EXTERNAL_ADDRESS":
                        mapper[i] = (e, v) => e.EXTERNAL_ADDRESS = v;
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "AREA_DUTY_TEACHER":
                        mapper[i] = (e, v) => e.AREA_DUTY_TEACHER = v;
                        break;
                    case "DUTY_TEACHER_FULL_NAME":
                        mapper[i] = (e, v) => e.DUTY_TEACHER_FULL_NAME = v;
                        break;
                    case "TEACHERS_ON_DUTY":
                        mapper[i] = (e, v) => e.TEACHERS_ON_DUTY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CREATION_DATE":
                        mapper[i] = (e, v) => e.CREATION_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "MAILED":
                        mapper[i] = (e, v) => e.MAILED = v;
                        break;
                    case "FIRST_INJURED_PARTY":
                        mapper[i] = (e, v) => e.FIRST_INJURED_PARTY = v;
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
