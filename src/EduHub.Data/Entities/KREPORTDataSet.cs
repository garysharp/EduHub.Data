﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Reports for emailing Data Set
    /// </summary>
    public sealed partial class KREPORTDataSet : SetBase<KREPORT>
    {
        private Lazy<Dictionary<string, KREPORT>> KREPORTKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<SPEMAIL>>> SPEMAIL_REPORTForeignIndex;

        internal KREPORTDataSet(EduHubContext Context)
            : base(Context)
        {
            KREPORTKEYIndex = new Lazy<Dictionary<string, KREPORT>>(() => this.ToDictionary(e => e.KREPORTKEY));

            SPEMAIL_REPORTForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SPEMAIL>>>(() =>
                    Context.SPEMAIL
                          .Where(e => e.REPORT != null)
                          .GroupBy(e => e.REPORT)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SPEMAIL>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KREPORT"; } }

        /// <summary>
        /// Find KREPORT by KREPORTKEY key field
        /// </summary>
        /// <param name="Key">KREPORTKEY value used to find KREPORT</param>
        /// <returns>Related KREPORT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KREPORTKEY value didn't match any KREPORT entities</exception>
        public KREPORT FindByKREPORTKEY(string Key)
        {
            KREPORT result;
            if (KREPORTKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KREPORT by KREPORTKEY key field
        /// </summary>
        /// <param name="Key">KREPORTKEY value used to find KREPORT</param>
        /// <param name="Value">Related KREPORT entity</param>
        /// <returns>True if the KREPORT entity is found</returns>
        public bool TryFindByKREPORTKEY(string Key, out KREPORT Value)
        {
            return KREPORTKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KREPORT by KREPORTKEY key field
        /// </summary>
        /// <param name="Key">KREPORTKEY value used to find KREPORT</param>
        /// <returns>Related KREPORT entity, or null if not found</returns>
        public KREPORT TryFindByKREPORTKEY(string Key)
        {
            KREPORT result;
            if (KREPORTKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all SPEMAIL (Report email templates) entities by [SPEMAIL.REPORT]-&gt;[KREPORT.KREPORTKEY]
        /// </summary>
        /// <param name="KREPORTKEY">KREPORTKEY value used to find SPEMAIL entities</param>
        /// <returns>A list of related SPEMAIL entities</returns>
        public IReadOnlyList<SPEMAIL> FindSPEMAILByREPORT(string KREPORTKEY)
        {
            IReadOnlyList<SPEMAIL> result;
            if (SPEMAIL_REPORTForeignIndex.Value.TryGetValue(KREPORTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SPEMAIL>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SPEMAIL entities by [SPEMAIL.REPORT]-&gt;[KREPORT.KREPORTKEY]
        /// </summary>
        /// <param name="KREPORTKEY">KREPORTKEY value used to find SPEMAIL entities</param>
        /// <param name="Value">A list of related SPEMAIL entities</param>
        /// <returns>True if any SPEMAIL entities are found</returns>
        public bool TryFindSPEMAILByREPORT(string KREPORTKEY, out IReadOnlyList<SPEMAIL> Value)
        {
            return SPEMAIL_REPORTForeignIndex.Value.TryGetValue(KREPORTKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KREPORT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KREPORT" /> fields for each CSV column header</returns>
        protected override Action<KREPORT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KREPORT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KREPORTKEY":
                        mapper[i] = (e, v) => e.KREPORTKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ROLE_CODE":
                        mapper[i] = (e, v) => e.ROLE_CODE = v;
                        break;
                    case "REPORT_NAME":
                        mapper[i] = (e, v) => e.REPORT_NAME = v;
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
