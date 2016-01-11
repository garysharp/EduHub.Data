using System;
using System.Data;
using System.Data.SqlClient;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Import or Update Errors Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KERRORDataSet : EduHubDataSet<KERROR>
    {
        /// <inheritdoc />
        public override string Name { get { return "KERROR"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return false; } }

        internal KERRORDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KERROR_ID = new Lazy<Dictionary<int, KERROR>>(() => this.ToDictionary(i => i.KERROR_ID));
            Index_SPOUTKEY = new Lazy<NullDictionary<string, IReadOnlyList<KERROR>>>(() => this.ToGroupedNullDictionary(i => i.SPOUTKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KERROR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KERROR" /> fields for each CSV column header</returns>
        internal override Action<KERROR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KERROR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KERROR_ID":
                        mapper[i] = (e, v) => e.KERROR_ID = int.Parse(v);
                        break;
                    case "SOURCE":
                        mapper[i] = (e, v) => e.SOURCE = v;
                        break;
                    case "TEXT01":
                        mapper[i] = (e, v) => e.TEXT01 = v;
                        break;
                    case "TEXT02":
                        mapper[i] = (e, v) => e.TEXT02 = v;
                        break;
                    case "TEXT03":
                        mapper[i] = (e, v) => e.TEXT03 = v;
                        break;
                    case "TEXT04":
                        mapper[i] = (e, v) => e.TEXT04 = v;
                        break;
                    case "TEXT05":
                        mapper[i] = (e, v) => e.TEXT05 = v;
                        break;
                    case "TEXT06":
                        mapper[i] = (e, v) => e.TEXT06 = v;
                        break;
                    case "TEXT07":
                        mapper[i] = (e, v) => e.TEXT07 = v;
                        break;
                    case "TEXT08":
                        mapper[i] = (e, v) => e.TEXT08 = v;
                        break;
                    case "TEXT09":
                        mapper[i] = (e, v) => e.TEXT09 = v;
                        break;
                    case "VALIDATION":
                        mapper[i] = (e, v) => e.VALIDATION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PROCESSED":
                        mapper[i] = (e, v) => e.PROCESSED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "ERROR_TEXT":
                        mapper[i] = (e, v) => e.ERROR_TEXT = v;
                        break;
                    case "SPOUTKEY":
                        mapper[i] = (e, v) => e.SPOUTKEY = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="KERROR" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KERROR" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KERROR" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KERROR}"/> of entities</returns>
        internal override IEnumerable<KERROR> ApplyDeltaEntities(IEnumerable<KERROR> Entities, List<KERROR> DeltaEntities)
        {
            HashSet<int> Index_KERROR_ID = new HashSet<int>(DeltaEntities.Select(i => i.KERROR_ID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KERROR_ID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KERROR_ID.Remove(entity.KERROR_ID);
                            
                            if (entity.KERROR_ID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, KERROR>> Index_KERROR_ID;
        private Lazy<NullDictionary<string, IReadOnlyList<KERROR>>> Index_SPOUTKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KERROR by KERROR_ID field
        /// </summary>
        /// <param name="KERROR_ID">KERROR_ID value used to find KERROR</param>
        /// <returns>Related KERROR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KERROR FindByKERROR_ID(int KERROR_ID)
        {
            return Index_KERROR_ID.Value[KERROR_ID];
        }

        /// <summary>
        /// Attempt to find KERROR by KERROR_ID field
        /// </summary>
        /// <param name="KERROR_ID">KERROR_ID value used to find KERROR</param>
        /// <param name="Value">Related KERROR entity</param>
        /// <returns>True if the related KERROR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKERROR_ID(int KERROR_ID, out KERROR Value)
        {
            return Index_KERROR_ID.Value.TryGetValue(KERROR_ID, out Value);
        }

        /// <summary>
        /// Attempt to find KERROR by KERROR_ID field
        /// </summary>
        /// <param name="KERROR_ID">KERROR_ID value used to find KERROR</param>
        /// <returns>Related KERROR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KERROR TryFindByKERROR_ID(int KERROR_ID)
        {
            KERROR value;
            if (Index_KERROR_ID.Value.TryGetValue(KERROR_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KERROR by SPOUTKEY field
        /// </summary>
        /// <param name="SPOUTKEY">SPOUTKEY value used to find KERROR</param>
        /// <returns>List of related KERROR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KERROR> FindBySPOUTKEY(string SPOUTKEY)
        {
            return Index_SPOUTKEY.Value[SPOUTKEY];
        }

        /// <summary>
        /// Attempt to find KERROR by SPOUTKEY field
        /// </summary>
        /// <param name="SPOUTKEY">SPOUTKEY value used to find KERROR</param>
        /// <param name="Value">List of related KERROR entities</param>
        /// <returns>True if the list of related KERROR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySPOUTKEY(string SPOUTKEY, out IReadOnlyList<KERROR> Value)
        {
            return Index_SPOUTKEY.Value.TryGetValue(SPOUTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KERROR by SPOUTKEY field
        /// </summary>
        /// <param name="SPOUTKEY">SPOUTKEY value used to find KERROR</param>
        /// <returns>List of related KERROR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KERROR> TryFindBySPOUTKEY(string SPOUTKEY)
        {
            IReadOnlyList<KERROR> value;
            if (Index_SPOUTKEY.Value.TryGetValue(SPOUTKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KERROR table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KERROR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KERROR](
        [KERROR_ID] int IDENTITY NOT NULL,
        [SOURCE] varchar(10) NULL,
        [TEXT01] varchar(30) NULL,
        [TEXT02] varchar(30) NULL,
        [TEXT03] varchar(30) NULL,
        [TEXT04] varchar(30) NULL,
        [TEXT05] varchar(30) NULL,
        [TEXT06] varchar(30) NULL,
        [TEXT07] varchar(30) NULL,
        [TEXT08] varchar(30) NULL,
        [TEXT09] varchar(30) NULL,
        [VALIDATION] smallint NULL,
        [PROCESSED] datetime NULL,
        [STATUS] varchar(3) NULL,
        [ERROR_TEXT] text NULL,
        [SPOUTKEY] varchar(100) NULL,
        CONSTRAINT [KERROR_Index_KERROR_ID] PRIMARY KEY CLUSTERED (
            [KERROR_ID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KERROR_Index_SPOUTKEY] ON [dbo].[KERROR]
    (
            [SPOUTKEY] ASC
    );
END");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which disables all non-clustered table indexes.
        /// Typically called before <see cref="SqlBulkCopy"/> to improve performance.
        /// <see cref="GetSqlRebuildIndexesCommand(SqlConnection)"/> should be called to rebuild and enable indexes after performance sensitive work is completed.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will disable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KERROR]') AND name = N'Index_SPOUTKEY')
    ALTER INDEX [Index_SPOUTKEY] ON [dbo].[KERROR] DISABLE;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which rebuilds and enables all non-clustered table indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will rebuild and enable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KERROR]') AND name = N'Index_SPOUTKEY')
    ALTER INDEX [Index_SPOUTKEY] ON [dbo].[KERROR] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KERROR"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KERROR"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KERROR> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_KERROR_ID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_KERROR_ID.Add(entity.KERROR_ID);
            }

            builder.AppendLine("DELETE [dbo].[KERROR] WHERE");


            // Index_KERROR_ID
            builder.Append("[KERROR_ID] IN (");
            for (int index = 0; index < Index_KERROR_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KERROR_ID
                var parameterKERROR_ID = $"@p{parameterIndex++}";
                builder.Append(parameterKERROR_ID);
                command.Parameters.Add(parameterKERROR_ID, SqlDbType.Int).Value = Index_KERROR_ID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KERROR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KERROR data set</returns>
        public override EduHubDataSetDataReader<KERROR> GetDataSetDataReader()
        {
            return new KERRORDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KERROR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KERROR data set</returns>
        public override EduHubDataSetDataReader<KERROR> GetDataSetDataReader(List<KERROR> Entities)
        {
            return new KERRORDataReader(new EduHubDataSetLoadedReader<KERROR>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KERRORDataReader : EduHubDataSetDataReader<KERROR>
        {
            public KERRORDataReader(IEduHubDataSetReader<KERROR> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 16; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KERROR_ID
                        return Current.KERROR_ID;
                    case 1: // SOURCE
                        return Current.SOURCE;
                    case 2: // TEXT01
                        return Current.TEXT01;
                    case 3: // TEXT02
                        return Current.TEXT02;
                    case 4: // TEXT03
                        return Current.TEXT03;
                    case 5: // TEXT04
                        return Current.TEXT04;
                    case 6: // TEXT05
                        return Current.TEXT05;
                    case 7: // TEXT06
                        return Current.TEXT06;
                    case 8: // TEXT07
                        return Current.TEXT07;
                    case 9: // TEXT08
                        return Current.TEXT08;
                    case 10: // TEXT09
                        return Current.TEXT09;
                    case 11: // VALIDATION
                        return Current.VALIDATION;
                    case 12: // PROCESSED
                        return Current.PROCESSED;
                    case 13: // STATUS
                        return Current.STATUS;
                    case 14: // ERROR_TEXT
                        return Current.ERROR_TEXT;
                    case 15: // SPOUTKEY
                        return Current.SPOUTKEY;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // SOURCE
                        return Current.SOURCE == null;
                    case 2: // TEXT01
                        return Current.TEXT01 == null;
                    case 3: // TEXT02
                        return Current.TEXT02 == null;
                    case 4: // TEXT03
                        return Current.TEXT03 == null;
                    case 5: // TEXT04
                        return Current.TEXT04 == null;
                    case 6: // TEXT05
                        return Current.TEXT05 == null;
                    case 7: // TEXT06
                        return Current.TEXT06 == null;
                    case 8: // TEXT07
                        return Current.TEXT07 == null;
                    case 9: // TEXT08
                        return Current.TEXT08 == null;
                    case 10: // TEXT09
                        return Current.TEXT09 == null;
                    case 11: // VALIDATION
                        return Current.VALIDATION == null;
                    case 12: // PROCESSED
                        return Current.PROCESSED == null;
                    case 13: // STATUS
                        return Current.STATUS == null;
                    case 14: // ERROR_TEXT
                        return Current.ERROR_TEXT == null;
                    case 15: // SPOUTKEY
                        return Current.SPOUTKEY == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KERROR_ID
                        return "KERROR_ID";
                    case 1: // SOURCE
                        return "SOURCE";
                    case 2: // TEXT01
                        return "TEXT01";
                    case 3: // TEXT02
                        return "TEXT02";
                    case 4: // TEXT03
                        return "TEXT03";
                    case 5: // TEXT04
                        return "TEXT04";
                    case 6: // TEXT05
                        return "TEXT05";
                    case 7: // TEXT06
                        return "TEXT06";
                    case 8: // TEXT07
                        return "TEXT07";
                    case 9: // TEXT08
                        return "TEXT08";
                    case 10: // TEXT09
                        return "TEXT09";
                    case 11: // VALIDATION
                        return "VALIDATION";
                    case 12: // PROCESSED
                        return "PROCESSED";
                    case 13: // STATUS
                        return "STATUS";
                    case 14: // ERROR_TEXT
                        return "ERROR_TEXT";
                    case 15: // SPOUTKEY
                        return "SPOUTKEY";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KERROR_ID":
                        return 0;
                    case "SOURCE":
                        return 1;
                    case "TEXT01":
                        return 2;
                    case "TEXT02":
                        return 3;
                    case "TEXT03":
                        return 4;
                    case "TEXT04":
                        return 5;
                    case "TEXT05":
                        return 6;
                    case "TEXT06":
                        return 7;
                    case "TEXT07":
                        return 8;
                    case "TEXT08":
                        return 9;
                    case "TEXT09":
                        return 10;
                    case "VALIDATION":
                        return 11;
                    case "PROCESSED":
                        return 12;
                    case "STATUS":
                        return 13;
                    case "ERROR_TEXT":
                        return 14;
                    case "SPOUTKEY":
                        return 15;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
