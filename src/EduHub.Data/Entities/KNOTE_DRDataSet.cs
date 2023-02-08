#if !EduHubScoped
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
    /// Debtor Notes Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KNOTE_DRDataSet : EduHubDataSet<KNOTE_DR>
    {
        /// <inheritdoc />
        public override string Name { get { return "KNOTE_DR"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KNOTE_DRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<KNOTE_DR>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_TID = new Lazy<Dictionary<int, KNOTE_DR>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KNOTE_DR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KNOTE_DR" /> fields for each CSV column header</returns>
        internal override Action<KNOTE_DR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KNOTE_DR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "NOTE_DATE":
                        mapper[i] = (e, v) => e.NOTE_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "NOTE_MEMO":
                        mapper[i] = (e, v) => e.NOTE_MEMO = v;
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
        /// Merges <see cref="KNOTE_DR" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KNOTE_DR" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KNOTE_DR" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KNOTE_DR}"/> of entities</returns>
        internal override IEnumerable<KNOTE_DR> ApplyDeltaEntities(IEnumerable<KNOTE_DR> Entities, List<KNOTE_DR> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.CODE;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.CODE.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<KNOTE_DR>>> Index_CODE;
        private Lazy<Dictionary<int, KNOTE_DR>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KNOTE_DR by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find KNOTE_DR</param>
        /// <returns>List of related KNOTE_DR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KNOTE_DR> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find KNOTE_DR by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find KNOTE_DR</param>
        /// <param name="Value">List of related KNOTE_DR entities</param>
        /// <returns>True if the list of related KNOTE_DR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<KNOTE_DR> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find KNOTE_DR by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find KNOTE_DR</param>
        /// <returns>List of related KNOTE_DR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KNOTE_DR> TryFindByCODE(string CODE)
        {
            IReadOnlyList<KNOTE_DR> value;
            if (Index_CODE.Value.TryGetValue(CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KNOTE_DR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KNOTE_DR</param>
        /// <returns>Related KNOTE_DR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KNOTE_DR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find KNOTE_DR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KNOTE_DR</param>
        /// <param name="Value">Related KNOTE_DR entity</param>
        /// <returns>True if the related KNOTE_DR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out KNOTE_DR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find KNOTE_DR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KNOTE_DR</param>
        /// <returns>Related KNOTE_DR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KNOTE_DR TryFindByTID(int TID)
        {
            KNOTE_DR value;
            if (Index_TID.Value.TryGetValue(TID, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KNOTE_DR table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KNOTE_DR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KNOTE_DR](
        [TID] int IDENTITY NOT NULL,
        [CODE] varchar(10) NOT NULL,
        [NOTE_DATE] datetime NULL,
        [NOTE_MEMO] varchar(MAX) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KNOTE_DR_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [KNOTE_DR_Index_CODE] ON [dbo].[KNOTE_DR]
    (
            [CODE] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KNOTE_DR]') AND name = N'KNOTE_DR_Index_TID')
    ALTER INDEX [KNOTE_DR_Index_TID] ON [dbo].[KNOTE_DR] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KNOTE_DR]') AND name = N'KNOTE_DR_Index_TID')
    ALTER INDEX [KNOTE_DR_Index_TID] ON [dbo].[KNOTE_DR] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KNOTE_DR"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KNOTE_DR"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KNOTE_DR> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[KNOTE_DR] WHERE");


            // Index_TID
            builder.Append("[TID] IN (");
            for (int index = 0; index < Index_TID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // TID
                var parameterTID = $"@p{parameterIndex++}";
                builder.Append(parameterTID);
                command.Parameters.Add(parameterTID, SqlDbType.Int).Value = Index_TID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KNOTE_DR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KNOTE_DR data set</returns>
        public override EduHubDataSetDataReader<KNOTE_DR> GetDataSetDataReader()
        {
            return new KNOTE_DRDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KNOTE_DR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KNOTE_DR data set</returns>
        public override EduHubDataSetDataReader<KNOTE_DR> GetDataSetDataReader(List<KNOTE_DR> Entities)
        {
            return new KNOTE_DRDataReader(new EduHubDataSetLoadedReader<KNOTE_DR>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KNOTE_DRDataReader : EduHubDataSetDataReader<KNOTE_DR>
        {
            public KNOTE_DRDataReader(IEduHubDataSetReader<KNOTE_DR> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 7; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // CODE
                        return Current.CODE;
                    case 2: // NOTE_DATE
                        return Current.NOTE_DATE;
                    case 3: // NOTE_MEMO
                        return Current.NOTE_MEMO;
                    case 4: // LW_DATE
                        return Current.LW_DATE;
                    case 5: // LW_TIME
                        return Current.LW_TIME;
                    case 6: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // NOTE_DATE
                        return Current.NOTE_DATE == null;
                    case 3: // NOTE_MEMO
                        return Current.NOTE_MEMO == null;
                    case 4: // LW_DATE
                        return Current.LW_DATE == null;
                    case 5: // LW_TIME
                        return Current.LW_TIME == null;
                    case 6: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // TID
                        return "TID";
                    case 1: // CODE
                        return "CODE";
                    case 2: // NOTE_DATE
                        return "NOTE_DATE";
                    case 3: // NOTE_MEMO
                        return "NOTE_MEMO";
                    case 4: // LW_DATE
                        return "LW_DATE";
                    case 5: // LW_TIME
                        return "LW_TIME";
                    case 6: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "TID":
                        return 0;
                    case "CODE":
                        return 1;
                    case "NOTE_DATE":
                        return 2;
                    case "NOTE_MEMO":
                        return 3;
                    case "LW_DATE":
                        return 4;
                    case "LW_TIME":
                        return 5;
                    case "LW_USER":
                        return 6;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
#endif
