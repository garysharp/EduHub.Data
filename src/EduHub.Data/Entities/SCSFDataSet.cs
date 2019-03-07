using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// CSF Strands Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCSFDataSet : EduHubDataSet<SCSF>
    {
        /// <inheritdoc />
        public override string Name { get { return "SCSF"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SCSFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SCSFKEY = new Lazy<Dictionary<string, SCSF>>(() => this.ToDictionary(i => i.SCSFKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCSF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCSF" /> fields for each CSV column header</returns>
        internal override Action<SCSF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCSF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCSFKEY":
                        mapper[i] = (e, v) => e.SCSFKEY = v;
                        break;
                    case "KLA":
                        mapper[i] = (e, v) => e.KLA = v;
                        break;
                    case "STRAND":
                        mapper[i] = (e, v) => e.STRAND = v;
                        break;
                    case "SUB_STRAND":
                        mapper[i] = (e, v) => e.SUB_STRAND = v;
                        break;
                    case "ENABLED":
                        mapper[i] = (e, v) => e.ENABLED = v;
                        break;
                    case "DEET_REQUIRED":
                        mapper[i] = (e, v) => e.DEET_REQUIRED = v;
                        break;
                    case "LOW_LEVEL":
                        mapper[i] = (e, v) => e.LOW_LEVEL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "HIGH_LEVEL":
                        mapper[i] = (e, v) => e.HIGH_LEVEL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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

        /// <summary>
        /// Merges <see cref="SCSF" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SCSF" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SCSF" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SCSF}"/> of entities</returns>
        internal override IEnumerable<SCSF> ApplyDeltaEntities(IEnumerable<SCSF> Entities, List<SCSF> DeltaEntities)
        {
            HashSet<string> Index_SCSFKEY = new HashSet<string>(DeltaEntities.Select(i => i.SCSFKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SCSFKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SCSFKEY.Remove(entity.SCSFKEY);
                            
                            if (entity.SCSFKEY.CompareTo(deltaClusteredKey) <= 0)
                            {
                                if (!overwritten)
                                {
                                    yield return entity;
                                }
                            }
                            else
                            {
                                yieldEntity = !overwritten;
                                break;
                            }
                        }
                        
                        yield return deltaIterator.Current;
                        if (yieldEntity)
                        {
                            yield return entityIterator.Current;
                        }
                    }

                    while (entityIterator.MoveNext())
                    {
                        yield return entityIterator.Current;
                    }
                }
            }
        }

        #region Index Fields

        private Lazy<Dictionary<string, SCSF>> Index_SCSFKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCSF by SCSFKEY field
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSF</param>
        /// <returns>Related SCSF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCSF FindBySCSFKEY(string SCSFKEY)
        {
            return Index_SCSFKEY.Value[SCSFKEY];
        }

        /// <summary>
        /// Attempt to find SCSF by SCSFKEY field
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSF</param>
        /// <param name="Value">Related SCSF entity</param>
        /// <returns>True if the related SCSF entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCSFKEY(string SCSFKEY, out SCSF Value)
        {
            return Index_SCSFKEY.Value.TryGetValue(SCSFKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SCSF by SCSFKEY field
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSF</param>
        /// <returns>Related SCSF entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCSF TryFindBySCSFKEY(string SCSFKEY)
        {
            SCSF value;
            if (Index_SCSFKEY.Value.TryGetValue(SCSFKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region SQL Integration

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SCSF table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCSF]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCSF](
        [SCSFKEY] varchar(5) NOT NULL,
        [KLA] varchar(40) NULL,
        [STRAND] varchar(40) NULL,
        [SUB_STRAND] varchar(40) NULL,
        [ENABLED] varchar(1) NULL,
        [DEET_REQUIRED] varchar(1) NULL,
        [LOW_LEVEL] smallint NULL,
        [HIGH_LEVEL] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SCSF_Index_SCSFKEY] PRIMARY KEY CLUSTERED (
            [SCSFKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SCSFDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SCSFDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SCSF"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SCSF"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SCSF> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_SCSFKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_SCSFKEY.Add(entity.SCSFKEY);
            }

            builder.AppendLine("DELETE [dbo].[SCSF] WHERE");


            // Index_SCSFKEY
            builder.Append("[SCSFKEY] IN (");
            for (int index = 0; index < Index_SCSFKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SCSFKEY
                var parameterSCSFKEY = $"@p{parameterIndex++}";
                builder.Append(parameterSCSFKEY);
                command.Parameters.Add(parameterSCSFKEY, SqlDbType.VarChar, 5).Value = Index_SCSFKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCSF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCSF data set</returns>
        public override EduHubDataSetDataReader<SCSF> GetDataSetDataReader()
        {
            return new SCSFDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCSF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCSF data set</returns>
        public override EduHubDataSetDataReader<SCSF> GetDataSetDataReader(List<SCSF> Entities)
        {
            return new SCSFDataReader(new EduHubDataSetLoadedReader<SCSF>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCSFDataReader : EduHubDataSetDataReader<SCSF>
        {
            public SCSFDataReader(IEduHubDataSetReader<SCSF> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 11; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SCSFKEY
                        return Current.SCSFKEY;
                    case 1: // KLA
                        return Current.KLA;
                    case 2: // STRAND
                        return Current.STRAND;
                    case 3: // SUB_STRAND
                        return Current.SUB_STRAND;
                    case 4: // ENABLED
                        return Current.ENABLED;
                    case 5: // DEET_REQUIRED
                        return Current.DEET_REQUIRED;
                    case 6: // LOW_LEVEL
                        return Current.LOW_LEVEL;
                    case 7: // HIGH_LEVEL
                        return Current.HIGH_LEVEL;
                    case 8: // LW_DATE
                        return Current.LW_DATE;
                    case 9: // LW_TIME
                        return Current.LW_TIME;
                    case 10: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // KLA
                        return Current.KLA == null;
                    case 2: // STRAND
                        return Current.STRAND == null;
                    case 3: // SUB_STRAND
                        return Current.SUB_STRAND == null;
                    case 4: // ENABLED
                        return Current.ENABLED == null;
                    case 5: // DEET_REQUIRED
                        return Current.DEET_REQUIRED == null;
                    case 6: // LOW_LEVEL
                        return Current.LOW_LEVEL == null;
                    case 7: // HIGH_LEVEL
                        return Current.HIGH_LEVEL == null;
                    case 8: // LW_DATE
                        return Current.LW_DATE == null;
                    case 9: // LW_TIME
                        return Current.LW_TIME == null;
                    case 10: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SCSFKEY
                        return "SCSFKEY";
                    case 1: // KLA
                        return "KLA";
                    case 2: // STRAND
                        return "STRAND";
                    case 3: // SUB_STRAND
                        return "SUB_STRAND";
                    case 4: // ENABLED
                        return "ENABLED";
                    case 5: // DEET_REQUIRED
                        return "DEET_REQUIRED";
                    case 6: // LOW_LEVEL
                        return "LOW_LEVEL";
                    case 7: // HIGH_LEVEL
                        return "HIGH_LEVEL";
                    case 8: // LW_DATE
                        return "LW_DATE";
                    case 9: // LW_TIME
                        return "LW_TIME";
                    case 10: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SCSFKEY":
                        return 0;
                    case "KLA":
                        return 1;
                    case "STRAND":
                        return 2;
                    case "SUB_STRAND":
                        return 3;
                    case "ENABLED":
                        return 4;
                    case "DEET_REQUIRED":
                        return 5;
                    case "LOW_LEVEL":
                        return 6;
                    case "HIGH_LEVEL":
                        return 7;
                    case "LW_DATE":
                        return 8;
                    case "LW_TIME":
                        return 9;
                    case "LW_USER":
                        return 10;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
